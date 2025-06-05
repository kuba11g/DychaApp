using DychaApp.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DychaApp.Panels
{
    public partial class MyWalletPanel : Form
    {
        // Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font defaultFont;
        public MyWalletPanel()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Montserrat;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Montserrat.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Montserrat.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            defaultFont = new Font(fonts.Families[0], 16.0F);
        }

        private void MyWalletPanel_Load(object sender, EventArgs e)
        {
            label_Title.Font = new Font(fonts.Families[0], 30.0F, FontStyle.Bold);
            label_Subtitle.Font = new Font(fonts.Families[0], 11.25F, FontStyle.Bold);

            button_Logout.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Calculator.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);
            button_MyWallet.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Bold);
            button_MainSite.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);

            button_Show.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Summary.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_AccountValue.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Value.Font = new Font(fonts.Families[0], 15.0F, FontStyle.Regular);
            label_Profit.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_Money.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);

            dataGridView_MyWallet.Font = new Font(fonts.Families[0], 12.0F, FontStyle.Regular);
        }

        #region UpperBar
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
            }
        }
        private void panel_TitleBar_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(140, 140, 140), 2))
                e.Graphics.DrawRectangle(p, new Rectangle(1, 1, panel_TitleBar.ClientSize.Width - 2, panel_TitleBar.ClientSize.Height - 2));
        }

        #endregion UpperBar

        private void button_Calculator_Click(object sender, EventArgs e)
        {
            CalculatorPanel calculatorPanel = new CalculatorPanel();
            this.Hide();
            calculatorPanel.Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            WelcomePanel welcomePanel = new WelcomePanel();
            this.Hide();
            welcomePanel.Show();
        }

        private void button_MainSite_Click(object sender, EventArgs e)
        {
            MainPanel mainPanel = new MainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private async void button_Show_Click(object sender, EventArgs e)
        {
            dataGridView_MyWallet.Rows.Clear();

            await Task.Run(async () =>
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                List<Tuple<string, double, double>> addToWallet = new List<Tuple<string, double, double>>();
                List<double> stockData = new List<double>();
                double totalValue = 0, totalProfit = 0;

                for (int i = 0; i < DatabaseConnection.GetWalletCounter(Properties.Settings.Default.ID); i++)
                {
                    StockConnection stockConnection = new StockConnection();
                    addToWallet = DatabaseConnection.ShowWallet(i);
                    stockData = await stockConnection.GetData(addToWallet[0].Item1);

                    double profit = stockData[0] * addToWallet[0].Item2 - addToWallet[0].Item3 * addToWallet[0].Item2;
                    double percentageProfit = Math.Round((profit / (addToWallet[0].Item3 * addToWallet[0].Item2)) * 100, 2);
                    totalValue += stockData[0] * addToWallet[0].Item2;
                    totalProfit += profit;

                    string[] row = new string[6] { addToWallet[0].Item1, Convert.ToString(addToWallet[0].Item2), Convert.ToString(stockData[0]) + " $", Convert.ToString(addToWallet[0].Item3) + " $", profit.ToString("0.000") + " $", Convert.ToString(percentageProfit) + "%" };

                    dataGridView_MyWallet.Invoke((MethodInvoker)delegate
                    {
                        dataGridView_MyWallet.Rows.Add(row);
                        int rowIndex = dataGridView_MyWallet.Rows.Count - 1;

                        if (percentageProfit > 0)
                            dataGridView_MyWallet.Rows[rowIndex].Cells[5].Style.ForeColor = Color.LimeGreen;
                        else if (percentageProfit < 0)
                            dataGridView_MyWallet.Rows[rowIndex].Cells[5].Style.ForeColor = Color.Red;
                    });
                }

                dataGridView_MyWallet.Invoke((MethodInvoker)delegate
                {
                    label_Value.Text = totalValue.ToString("0.00") + " $";
                    label_Money.Text = totalProfit.ToString("0.00") + " $";
                });
            });
        }
    }
}
