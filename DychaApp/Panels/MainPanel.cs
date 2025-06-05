using DychaApp.Resources;
using DychaApp.Resources.Class;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DychaApp.Panels
{
    public partial class MainPanel: Form
    {
        // Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font defaultFont;
        private bool IsChanged = false;
        public MainPanel()
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

        private void MainPanel_Load(object sender, EventArgs e)
        {
            label_Title.Font = new Font(fonts.Families[0], 30.0F, FontStyle.Bold);
            label_Subtitle.Font = new Font(fonts.Families[0], 11.25F, FontStyle.Bold);
            
            button_Logout.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Calculator.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);
            button_MyWallet.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);
            button_MainSite.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Bold);

            label_Symbol.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_CurrentPrice.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_SymbolBuy.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            label_CurrentPriceBuy.Font = new Font(fonts.Families[0], 22.0F, FontStyle.Regular);
            textBox_SearchBar.Font = new Font(fonts.Families[0], 10.0F, FontStyle.Regular);

            label_High.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Low.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_Open.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_HighTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_LowTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            label_OpenTitle.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);

            label_BuyPanel.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Bold);
            label_Volume.Font = new Font(fonts.Families[0], 16.0F, FontStyle.Regular);
            textBox_Volume.Font = new Font(fonts.Families[0], 10.0F, FontStyle.Regular);
            button_Buy.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);

            textBox_SearchBar.ShortcutsEnabled = false;
            textBox_Volume.ShortcutsEnabled = false;
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
            this.label_SymbolBuy.Text = myText;
            this.flowLayoutPanel_SearchResult.Height = 0;
            textBox_SearchBar.Text = "Wyszukaj...";

            StockConnection stockConnection = new StockConnection();
            await stockConnection.SetData(myText, label_CurrentPrice, label_High, label_Low, label_Open);
            label_CurrentPriceBuy.Text = label_CurrentPrice.Text;

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

                SearchResultControl searchResultControl = new SearchResultControl(this);
                searchResultControl.Details(stockSymbolLoader);
                flowLayoutPanel_SearchResult.Controls.Add(searchResultControl);

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
            if (textBox_Volume.Text == "Wpisz liczbę...")
                textBox_Volume.Text = "";
        }

        private void textBox_Volume_Leave(object sender, EventArgs e)
        {
            if (textBox_Volume.Text == "")
                textBox_Volume.Text = "Wpisz liczbę...";
        }

        private void button_MyWallet_Click(object sender, EventArgs e)
        {
            MyWalletPanel myWalletPanel = new MyWalletPanel();
            this.Hide();
            myWalletPanel.Show();
        }

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

        private void webBrowser_StockMarket_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            /*if (webBrowser_StockMarket.Document != null && webBrowser_StockMarket.Document.Body != null)
            {
                webBrowser_StockMarket.Document.Body.Style = "overflow: hidden;";
                webBrowser_StockMarket.Document.Body.Style = "margin-top:-215px;";
            }*/
        }

        private async void timer_ChangePrice_Tick(object sender, EventArgs e)
        {
            if (IsChanged == true)
            {
                StockConnection stockConnection = new StockConnection();
                await stockConnection.SetData(label_Symbol.Text, label_CurrentPrice, label_High, label_Low, label_Open);
                label_CurrentPriceBuy.Text = label_CurrentPrice.Text;
            }
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

        private void button_Buy_Click(object sender, EventArgs e)
        {
            if (label_CurrentPrice.Text == "-")
                MessageBox.Show("Nie można kupić akcji, ponieważ nie zostały wybrane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textBox_Volume.Text == "Wpisz liczbę..." || textBox_Volume.Text == "")
                MessageBox.Show("Wpisz ile chcesz kupić akcji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Convert.ToDouble(textBox_Volume.Text) > 0)
                {
                    string currentPrice = label_CurrentPrice.Text;
                    currentPrice = currentPrice.Remove(currentPrice.Length - 2);

                    DatabaseConnection.AddToWallet(label_Symbol.Text, Convert.ToDouble(textBox_Volume.Text), Convert.ToDouble(currentPrice));
                    MessageBox.Show("Zakupiono akcje!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Wpisz liczbę większą od 0!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
