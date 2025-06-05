using DychaApp.Resources.Class;
using DychaApp.Resources;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DychaApp.Panels
{
    public partial class CalculatorPanel : Form
    {
        // Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font defaultFont;
        private bool IsChanged = false;
        public CalculatorPanel()
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

        private void CalculatorPanel_Load(object sender, EventArgs e)
        {
            label_Title.Font = new Font(fonts.Families[0], 30.0F, FontStyle.Bold);
            label_Subtitle.Font = new Font(fonts.Families[0], 11.25F, FontStyle.Bold);

            button_Logout.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Calculator.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Bold);
            button_MyWallet.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);
            button_MainSite.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);

            label_Symbol.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_CurrentPrice.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            textBox_SearchBar.Font = new Font(fonts.Families[0], 10.0F, FontStyle.Regular);
            label_High.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Low.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Open.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_HighTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_LowTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_OpenTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Check.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);

            label_BuyPanel.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Bold);
            textBox_Volume.Font = new Font(fonts.Families[0], 10.0F, FontStyle.Regular);
            label_BuyDaysPanel.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Bold);
            textBox_Days.Font = new Font(fonts.Families[0], 10.0F, FontStyle.Regular);
            label_MoneyBackPercentage.Font = new Font(fonts.Families[0], 15.0F, FontStyle.Regular);
            label_MoneyBackPercentageSum.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);
            label_MoneyBackRisk.Font = new Font(fonts.Families[0], 15.0F, FontStyle.Regular);
            label_MoneyBackRiskText.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);
            label_MoneyBack.Font = new Font(fonts.Families[0], 15.0F, FontStyle.Regular);
            label_MoneyBackSum.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);

            textBox_SearchBar.ShortcutsEnabled = false;
            textBox_Volume.ShortcutsEnabled = false;
            textBox_Days.ShortcutsEnabled = false;
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

        public async void SetTextForLabel(string myText)
        {
            this.label_Symbol.Text = myText;
            this.flowLayoutPanel_SearchResult.Height = 0;
            textBox_SearchBar.Text = "Wyszukaj...";

            StockConnection stockConnection = new StockConnection();
            await stockConnection.SetData(myText, label_CurrentPrice, label_High, label_Low, label_Open);

            IsChanged = true;
            this.webBrowser_StockMarket.Navigate($"https://www.google.com/finance/quote/{myText}:NASDAQ");
        }

        private void LoadDetails()
        {
            int count = 0;
            foreach (StockSymbolLoader stockSymbolLoader in StockSymbolLoader.list)
            {
                if (count >= 10)
                    break;

                SearchResultCalculatorControl searchResultCalculatorControl = new SearchResultCalculatorControl(this);
                searchResultCalculatorControl.Details(stockSymbolLoader);
                flowLayoutPanel_SearchResult.Controls.Add(searchResultCalculatorControl);

                count++;
            }
        }

        private async void textBox_SearchBar_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SearchBar.Text.Length >= 1)
            {
                flowLayoutPanel_SearchResult.Controls.Clear();
                StockSymbolLoader stockSymbolLoader = new StockSymbolLoader();
                await stockSymbolLoader.Search(textBox_SearchBar.Text);
                LoadDetails();

                flowLayoutPanel_SearchResult.Height = flowLayoutPanel_SearchResult.Controls.Count * 30;
            }
            else
                flowLayoutPanel_SearchResult.Height = 0;
        }

        private void textBox_SearchBar_Click(object sender, EventArgs e)
        {
            if (textBox_SearchBar.Text == "Wyszukaj...")
                textBox_SearchBar.Text = "";
        }

        private void textBox_SearchBar_Leave(object sender, EventArgs e)
        {
            if (textBox_SearchBar.Text == "")
                textBox_SearchBar.Text = "Wyszukaj...";
        }

        private void textBox_Volume_Click(object sender, EventArgs e)
        {
            if (textBox_Volume.Text == "Wpisz kwotę...")
                textBox_Volume.Text = "";
        }

        private void textBox_Volume_Leave(object sender, EventArgs e)
        {
            if (textBox_Volume.Text == "")
                textBox_Volume.Text = "Wpisz kwotę...";
        }

        private void textBox_Days_Click(object sender, EventArgs e)
        {
            if (textBox_Days.Text == "Wpisz liczbę dni...")
                textBox_Days.Text = "";
        }

        private void textBox_Days_Leave(object sender, EventArgs e)
        {
            if (textBox_Days.Text == "")
                textBox_Days.Text = "Wpisz liczbę dni...";
        }

        private void button_MyWallet_Click(object sender, EventArgs e)
        {
            MyWalletPanel myWalletPanel = new MyWalletPanel();
            this.Hide();
            myWalletPanel.Show();
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

        
        private void textBox_Volume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_Days_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void webBrowser_StockMarket_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /*if (webBrowser_StockMarket.Document != null && webBrowser_StockMarket.Document.Body != null)
            {
                webBrowser_StockMarket.Document.Body.Style = "overflow: hidden;";
                webBrowser_StockMarket.Document.Body.Style = "margin-top:-205px;";
            }*/
        }

        private async void timer_ChangePrice_Tick(object sender, EventArgs e)
        {
            if (IsChanged == true)
            {
                StockConnection stockConnection = new StockConnection();
                await stockConnection.SetData(label_Symbol.Text, label_CurrentPrice, label_High, label_Low, label_Open);
            }
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (label_CurrentPrice.Text == "-")
                MessageBox.Show("Proszę wybrać akcje.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(textBox_Volume.Text) || textBox_Volume.Text == "Wpisz kwotę...")
                MessageBox.Show("Proszę wprowadzić kwotę inwestycji.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(textBox_Days.Text) || textBox_Days.Text == "Wpisz liczbę dni...")
                MessageBox.Show("Proszę wprowadzić liczbę dni.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                decimal calculatedRisk = CalculateExpectedReturn(
                    Convert.ToDecimal(textBox_Volume.Text),
                    Convert.ToDecimal(label_CurrentPrice.Text.TrimEnd(' ', '$')),
                    Convert.ToDecimal(label_High.Text.TrimEnd(' ', '$')),
                    Convert.ToDecimal(label_Low.Text.TrimEnd(' ', '$')),
                    Convert.ToDecimal(label_Open.Text.TrimEnd(' ', '$')),
                    Convert.ToInt32(textBox_Days.Text)
                );
                decimal riskPercentage = Math.Round((calculatedRisk / Convert.ToDecimal(textBox_Volume.Text)) * 100, 2);

                label_MoneyBackSum.Text = calculatedRisk.ToString("0.00") + " $";
                label_MoneyBackPercentageSum.Text = riskPercentage.ToString("0.00") + " %";

                if (riskPercentage < 10)
                {
                    label_MoneyBackRiskText.Text = "Niskie ryzyko";
                    label_MoneyBackRiskText.ForeColor = Color.LimeGreen;
                    label_MoneyBackPercentageSum.ForeColor = Color.LimeGreen;
                }
                else if (riskPercentage >= 10 && riskPercentage <= 20)
                {
                    label_MoneyBackRiskText.Text = "Średnie ryzyko";
                    label_MoneyBackRiskText.ForeColor = Color.Orange;
                    label_MoneyBackPercentageSum.ForeColor = Color.Orange;
                }
                else
                {
                    label_MoneyBackRiskText.Text = "Wysokie ryzyko";
                    label_MoneyBackRiskText.ForeColor = Color.Red;
                    label_MoneyBackPercentageSum.ForeColor = Color.Red;
                }
            }
        }

        public static decimal CalculateExpectedReturn(decimal investmentAmount, decimal currentPrice, decimal highPrice, decimal lowPrice, decimal openingPrice, int investmentPeriodDays)
        {
            decimal dailyPriceChange = (highPrice - lowPrice) / 2;
            decimal estimatedFuturePrice = currentPrice + (dailyPriceChange * investmentPeriodDays);
            decimal expectedReturn = (estimatedFuturePrice - currentPrice) / currentPrice * investmentAmount;

            return Math.Round(expectedReturn, 2);
        }
    }
}
