namespace DychaApp.Panels
{
    partial class CalculatorPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_sublogo = new System.Windows.Forms.PictureBox();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_MainSite = new System.Windows.Forms.Button();
            this.button_MyWallet = new System.Windows.Forms.Button();
            this.button_Calculator = new System.Windows.Forms.Button();
            this.textBox_Volume = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_BuyPanel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser_StockMarket = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.label_CurrentPrice = new System.Windows.Forms.Label();
            this.label_Symbol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_MoneyBackPercentage = new System.Windows.Forms.Label();
            this.label_MoneyBackPercentageSum = new System.Windows.Forms.Label();
            this.label_MoneyBackRisk = new System.Windows.Forms.Label();
            this.label_MoneyBackRiskText = new System.Windows.Forms.Label();
            this.label_MoneyBack = new System.Windows.Forms.Label();
            this.label_MoneyBackSum = new System.Windows.Forms.Label();
            this.flowLayoutPanel_SearchResult = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_SearchBar = new System.Windows.Forms.TextBox();
            this.panel_SearchBar = new System.Windows.Forms.Panel();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.timer_ChangePrice = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label_High = new System.Windows.Forms.Label();
            this.label_HighTitle = new System.Windows.Forms.Label();
            this.label_Open = new System.Windows.Forms.Label();
            this.label_OpenTitle = new System.Windows.Forms.Label();
            this.label_Low = new System.Windows.Forms.Label();
            this.label_LowTitle = new System.Windows.Forms.Label();
            this.textBox_Days = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_BuyDaysPanel = new System.Windows.Forms.Label();
            this.button_Check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sublogo)).BeginInit();
            this.panel_SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1080, 4);
            this.label2.TabIndex = 56;
            this.label2.Text = "label2";
            // 
            // pictureBox_sublogo
            // 
            this.pictureBox_sublogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_sublogo.Image")));
            this.pictureBox_sublogo.Location = new System.Drawing.Point(184, 23);
            this.pictureBox_sublogo.Name = "pictureBox_sublogo";
            this.pictureBox_sublogo.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_sublogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sublogo.TabIndex = 57;
            this.pictureBox_sublogo.TabStop = false;
            // 
            // button_Minimize
            // 
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.button_Minimize.Location = new System.Drawing.Point(1037, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(22, 22);
            this.button_Minimize.TabIndex = 52;
            this.button_Minimize.Text = "-";
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // label_Subtitle
            // 
            this.label_Subtitle.AutoSize = true;
            this.label_Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label_Subtitle.Location = new System.Drawing.Point(36, 69);
            this.label_Subtitle.Name = "label_Subtitle";
            this.label_Subtitle.Size = new System.Drawing.Size(170, 18);
            this.label_Subtitle.TabIndex = 54;
            this.label_Subtitle.Text = "Bo każda dycha się liczy";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(28, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(160, 46);
            this.label_Title.TabIndex = 49;
            this.label_Title.Text = "DYCHA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 4);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // panel_TitleBar
            // 
            this.panel_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel_TitleBar.Location = new System.Drawing.Point(-3, -2);
            this.panel_TitleBar.Name = "panel_TitleBar";
            this.panel_TitleBar.Size = new System.Drawing.Size(1042, 25);
            this.panel_TitleBar.TabIndex = 50;
            this.panel_TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_TitleBar_Paint);
            this.panel_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TitleBar_MouseDown);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.button_Close.Location = new System.Drawing.Point(1058, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(22, 22);
            this.button_Close.TabIndex = 51;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.Red;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.Location = new System.Drawing.Point(929, 44);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(130, 35);
            this.button_Logout.TabIndex = 48;
            this.button_Logout.Text = "Wyloguj";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_MainSite
            // 
            this.button_MainSite.FlatAppearance.BorderSize = 0;
            this.button_MainSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MainSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_MainSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_MainSite.Location = new System.Drawing.Point(516, 44);
            this.button_MainSite.Name = "button_MainSite";
            this.button_MainSite.Size = new System.Drawing.Size(142, 35);
            this.button_MainSite.TabIndex = 63;
            this.button_MainSite.Text = "Strona główna";
            this.button_MainSite.UseVisualStyleBackColor = true;
            this.button_MainSite.Click += new System.EventHandler(this.button_MainSite_Click);
            // 
            // button_MyWallet
            // 
            this.button_MyWallet.FlatAppearance.BorderSize = 0;
            this.button_MyWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_MyWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_MyWallet.Location = new System.Drawing.Point(661, 44);
            this.button_MyWallet.Name = "button_MyWallet";
            this.button_MyWallet.Size = new System.Drawing.Size(105, 35);
            this.button_MyWallet.TabIndex = 62;
            this.button_MyWallet.Text = "Portfel";
            this.button_MyWallet.UseVisualStyleBackColor = true;
            this.button_MyWallet.Click += new System.EventHandler(this.button_MyWallet_Click);
            // 
            // button_Calculator
            // 
            this.button_Calculator.FlatAppearance.BorderSize = 0;
            this.button_Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Calculator.ForeColor = System.Drawing.Color.Red;
            this.button_Calculator.Location = new System.Drawing.Point(769, 44);
            this.button_Calculator.Name = "button_Calculator";
            this.button_Calculator.Size = new System.Drawing.Size(157, 35);
            this.button_Calculator.TabIndex = 61;
            this.button_Calculator.Text = "Kalkulator";
            this.button_Calculator.UseVisualStyleBackColor = true;
            // 
            // textBox_Volume
            // 
            this.textBox_Volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_Volume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox_Volume.Location = new System.Drawing.Point(581, 154);
            this.textBox_Volume.Name = "textBox_Volume";
            this.textBox_Volume.Size = new System.Drawing.Size(454, 19);
            this.textBox_Volume.TabIndex = 66;
            this.textBox_Volume.Text = "Wpisz kwotę...";
            this.textBox_Volume.Click += new System.EventHandler(this.textBox_Volume_Click);
            this.textBox_Volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Volume_KeyPress);
            this.textBox_Volume.Leave += new System.EventHandler(this.textBox_Volume_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Location = new System.Drawing.Point(574, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 30);
            this.panel1.TabIndex = 67;
            // 
            // label_BuyPanel
            // 
            this.label_BuyPanel.AutoSize = true;
            this.label_BuyPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BuyPanel.Location = new System.Drawing.Point(569, 113);
            this.label_BuyPanel.Name = "label_BuyPanel";
            this.label_BuyPanel.Size = new System.Drawing.Size(459, 25);
            this.label_BuyPanel.TabIndex = 78;
            this.label_BuyPanel.Text = "Wprowadź kwotę jaką planujesz zainwestować";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(540, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 664);
            this.label3.TabIndex = 70;
            this.label3.Text = "label3";
            // 
            // webBrowser_StockMarket
            // 
            this.webBrowser_StockMarket.AllowWebBrowserDrop = false;
            this.webBrowser_StockMarket.Location = new System.Drawing.Point(24, 207);
            this.webBrowser_StockMarket.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_StockMarket.Name = "webBrowser_StockMarket";
            this.webBrowser_StockMarket.ScriptErrorsSuppressed = true;
            this.webBrowser_StockMarket.ScrollBarsEnabled = false;
            this.webBrowser_StockMarket.Size = new System.Drawing.Size(493, 535);
            this.webBrowser_StockMarket.TabIndex = 68;
            this.webBrowser_StockMarket.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser_StockMarket.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_StockMarket_DocumentCompleted);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 539);
            this.label4.TabIndex = 71;
            // 
            // label_CurrentPrice
            // 
            this.label_CurrentPrice.AutoSize = true;
            this.label_CurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_CurrentPrice.Location = new System.Drawing.Point(140, 119);
            this.label_CurrentPrice.Name = "label_CurrentPrice";
            this.label_CurrentPrice.Size = new System.Drawing.Size(29, 39);
            this.label_CurrentPrice.TabIndex = 69;
            this.label_CurrentPrice.Text = "-";
            // 
            // label_Symbol
            // 
            this.label_Symbol.AutoSize = true;
            this.label_Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Symbol.Location = new System.Drawing.Point(20, 119);
            this.label_Symbol.Name = "label_Symbol";
            this.label_Symbol.Size = new System.Drawing.Size(115, 39);
            this.label_Symbol.TabIndex = 65;
            this.label_Symbol.Text = "SYMB";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(574, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 135);
            this.label6.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(574, 606);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(468, 135);
            this.label7.TabIndex = 81;
            // 
            // label_MoneyBackPercentage
            // 
            this.label_MoneyBackPercentage.AutoSize = true;
            this.label_MoneyBackPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBackPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBackPercentage.Location = new System.Drawing.Point(674, 286);
            this.label_MoneyBackPercentage.Name = "label_MoneyBackPercentage";
            this.label_MoneyBackPercentage.Size = new System.Drawing.Size(252, 25);
            this.label_MoneyBackPercentage.TabIndex = 82;
            this.label_MoneyBackPercentage.Text = "Przewidywany zwrot w %";
            // 
            // label_MoneyBackPercentageSum
            // 
            this.label_MoneyBackPercentageSum.AutoSize = true;
            this.label_MoneyBackPercentageSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBackPercentageSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBackPercentageSum.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_MoneyBackPercentageSum.Location = new System.Drawing.Point(748, 337);
            this.label_MoneyBackPercentageSum.Name = "label_MoneyBackPercentageSum";
            this.label_MoneyBackPercentageSum.Size = new System.Drawing.Size(19, 25);
            this.label_MoneyBackPercentageSum.TabIndex = 83;
            this.label_MoneyBackPercentageSum.Text = "-";
            this.label_MoneyBackPercentageSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MoneyBackRisk
            // 
            this.label_MoneyBackRisk.AutoSize = true;
            this.label_MoneyBackRisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBackRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBackRisk.Location = new System.Drawing.Point(691, 453);
            this.label_MoneyBackRisk.Name = "label_MoneyBackRisk";
            this.label_MoneyBackRisk.Size = new System.Drawing.Size(219, 25);
            this.label_MoneyBackRisk.TabIndex = 84;
            this.label_MoneyBackRisk.Text = "Przewidywane ryzyko";
            // 
            // label_MoneyBackRiskText
            // 
            this.label_MoneyBackRiskText.AutoSize = true;
            this.label_MoneyBackRiskText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBackRiskText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBackRiskText.Location = new System.Drawing.Point(701, 506);
            this.label_MoneyBackRiskText.Name = "label_MoneyBackRiskText";
            this.label_MoneyBackRiskText.Size = new System.Drawing.Size(19, 25);
            this.label_MoneyBackRiskText.TabIndex = 85;
            this.label_MoneyBackRiskText.Text = "-";
            // 
            // label_MoneyBack
            // 
            this.label_MoneyBack.AutoSize = true;
            this.label_MoneyBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBack.Location = new System.Drawing.Point(699, 622);
            this.label_MoneyBack.Name = "label_MoneyBack";
            this.label_MoneyBack.Size = new System.Drawing.Size(206, 25);
            this.label_MoneyBack.TabIndex = 86;
            this.label_MoneyBack.Text = "Przewidywany zwrot";
            // 
            // label_MoneyBackSum
            // 
            this.label_MoneyBackSum.AutoSize = true;
            this.label_MoneyBackSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label_MoneyBackSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MoneyBackSum.ForeColor = System.Drawing.Color.Red;
            this.label_MoneyBackSum.Location = new System.Drawing.Point(748, 674);
            this.label_MoneyBackSum.Name = "label_MoneyBackSum";
            this.label_MoneyBackSum.Size = new System.Drawing.Size(19, 25);
            this.label_MoneyBackSum.TabIndex = 87;
            this.label_MoneyBackSum.Text = "-";
            this.label_MoneyBackSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_SearchResult
            // 
            this.flowLayoutPanel_SearchResult.Location = new System.Drawing.Point(273, 78);
            this.flowLayoutPanel_SearchResult.Name = "flowLayoutPanel_SearchResult";
            this.flowLayoutPanel_SearchResult.Size = new System.Drawing.Size(222, 10);
            this.flowLayoutPanel_SearchResult.TabIndex = 90;
            // 
            // textBox_SearchBar
            // 
            this.textBox_SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox_SearchBar.Location = new System.Drawing.Point(312, 53);
            this.textBox_SearchBar.Name = "textBox_SearchBar";
            this.textBox_SearchBar.Size = new System.Drawing.Size(182, 19);
            this.textBox_SearchBar.TabIndex = 88;
            this.textBox_SearchBar.Text = "Wyszukaj...";
            this.textBox_SearchBar.Click += new System.EventHandler(this.textBox_SearchBar_Click);
            this.textBox_SearchBar.TextChanged += new System.EventHandler(this.textBox_SearchBar_TextChanged);
            this.textBox_SearchBar.Leave += new System.EventHandler(this.textBox_SearchBar_Leave);
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel_SearchBar.Controls.Add(this.pictureBox_Search);
            this.panel_SearchBar.Location = new System.Drawing.Point(273, 48);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(222, 30);
            this.panel_SearchBar.TabIndex = 89;
            // 
            // pictureBox_Search
            // 
            this.pictureBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Search.Image")));
            this.pictureBox_Search.Location = new System.Drawing.Point(3, 5);
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Search.TabIndex = 47;
            this.pictureBox_Search.TabStop = false;
            // 
            // timer_ChangePrice
            // 
            this.timer_ChangePrice.Enabled = true;
            this.timer_ChangePrice.Interval = 30000;
            this.timer_ChangePrice.Tick += new System.EventHandler(this.timer_ChangePrice_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(574, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 135);
            this.label5.TabIndex = 79;
            // 
            // label_High
            // 
            this.label_High.AutoSize = true;
            this.label_High.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_High.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_High.Location = new System.Drawing.Point(99, 169);
            this.label_High.Name = "label_High";
            this.label_High.Size = new System.Drawing.Size(19, 25);
            this.label_High.TabIndex = 92;
            this.label_High.Text = "-";
            // 
            // label_HighTitle
            // 
            this.label_HighTitle.AutoSize = true;
            this.label_HighTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_HighTitle.Location = new System.Drawing.Point(43, 169);
            this.label_HighTitle.Name = "label_HighTitle";
            this.label_HighTitle.Size = new System.Drawing.Size(62, 25);
            this.label_HighTitle.TabIndex = 91;
            this.label_HighTitle.Text = "High:";
            // 
            // label_Open
            // 
            this.label_Open.AutoSize = true;
            this.label_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_Open.Location = new System.Drawing.Point(417, 169);
            this.label_Open.Name = "label_Open";
            this.label_Open.Size = new System.Drawing.Size(19, 25);
            this.label_Open.TabIndex = 96;
            this.label_Open.Text = "-";
            // 
            // label_OpenTitle
            // 
            this.label_OpenTitle.AutoSize = true;
            this.label_OpenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_OpenTitle.Location = new System.Drawing.Point(353, 169);
            this.label_OpenTitle.Name = "label_OpenTitle";
            this.label_OpenTitle.Size = new System.Drawing.Size(70, 25);
            this.label_OpenTitle.TabIndex = 95;
            this.label_OpenTitle.Text = "Open:";
            // 
            // label_Low
            // 
            this.label_Low.AutoSize = true;
            this.label_Low.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Low.ForeColor = System.Drawing.Color.Red;
            this.label_Low.Location = new System.Drawing.Point(254, 169);
            this.label_Low.Name = "label_Low";
            this.label_Low.Size = new System.Drawing.Size(19, 25);
            this.label_Low.TabIndex = 94;
            this.label_Low.Text = "-";
            // 
            // label_LowTitle
            // 
            this.label_LowTitle.AutoSize = true;
            this.label_LowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_LowTitle.Location = new System.Drawing.Point(203, 169);
            this.label_LowTitle.Name = "label_LowTitle";
            this.label_LowTitle.Size = new System.Drawing.Size(57, 25);
            this.label_LowTitle.TabIndex = 93;
            this.label_LowTitle.Text = "Low:";
            // 
            // textBox_Days
            // 
            this.textBox_Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_Days.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox_Days.Location = new System.Drawing.Point(581, 227);
            this.textBox_Days.Name = "textBox_Days";
            this.textBox_Days.Size = new System.Drawing.Size(454, 19);
            this.textBox_Days.TabIndex = 97;
            this.textBox_Days.Text = "Wpisz liczbę dni...";
            this.textBox_Days.Click += new System.EventHandler(this.textBox_Days_Click);
            this.textBox_Days.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Days_KeyPress);
            this.textBox_Days.Leave += new System.EventHandler(this.textBox_Days_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Location = new System.Drawing.Point(574, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 30);
            this.panel2.TabIndex = 98;
            // 
            // label_BuyDaysPanel
            // 
            this.label_BuyDaysPanel.AutoSize = true;
            this.label_BuyDaysPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BuyDaysPanel.Location = new System.Drawing.Point(569, 186);
            this.label_BuyDaysPanel.Name = "label_BuyDaysPanel";
            this.label_BuyDaysPanel.Size = new System.Drawing.Size(391, 25);
            this.label_BuyDaysPanel.TabIndex = 99;
            this.label_BuyDaysPanel.Text = "Wprowadź ile dni planujesz inwestować";
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.Red;
            this.button_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(389, 119);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(130, 35);
            this.button_Check.TabIndex = 100;
            this.button_Check.Text = "Sprawdź";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // CalculatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1080, 768);
            this.Controls.Add(this.textBox_Days);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_BuyDaysPanel);
            this.Controls.Add(this.flowLayoutPanel_SearchResult);
            this.Controls.Add(this.textBox_SearchBar);
            this.Controls.Add(this.panel_SearchBar);
            this.Controls.Add(this.label_MoneyBackSum);
            this.Controls.Add(this.label_MoneyBack);
            this.Controls.Add(this.label_MoneyBackRiskText);
            this.Controls.Add(this.label_MoneyBackRisk);
            this.Controls.Add(this.label_MoneyBackPercentageSum);
            this.Controls.Add(this.label_MoneyBackPercentage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Volume);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_BuyPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webBrowser_StockMarket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_MainSite);
            this.Controls.Add(this.button_MyWallet);
            this.Controls.Add(this.button_Calculator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_sublogo);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.label_High);
            this.Controls.Add(this.label_HighTitle);
            this.Controls.Add(this.label_Open);
            this.Controls.Add(this.label_OpenTitle);
            this.Controls.Add(this.label_Low);
            this.Controls.Add(this.label_LowTitle);
            this.Controls.Add(this.label_CurrentPrice);
            this.Controls.Add(this.label_Symbol);
            this.Controls.Add(this.button_Check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorPanel";
            this.Text = "CalculatorPanel";
            this.Load += new System.EventHandler(this.CalculatorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sublogo)).EndInit();
            this.panel_SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_sublogo;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_MainSite;
        private System.Windows.Forms.Button button_MyWallet;
        private System.Windows.Forms.Button button_Calculator;
        private System.Windows.Forms.TextBox textBox_Volume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_BuyPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser_StockMarket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_CurrentPrice;
        private System.Windows.Forms.Label label_Symbol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_MoneyBackPercentage;
        private System.Windows.Forms.Label label_MoneyBackPercentageSum;
        private System.Windows.Forms.Label label_MoneyBackRisk;
        private System.Windows.Forms.Label label_MoneyBackRiskText;
        private System.Windows.Forms.Label label_MoneyBack;
        private System.Windows.Forms.Label label_MoneyBackSum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SearchResult;
        private System.Windows.Forms.TextBox textBox_SearchBar;
        private System.Windows.Forms.Panel panel_SearchBar;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.Timer timer_ChangePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_High;
        private System.Windows.Forms.Label label_HighTitle;
        private System.Windows.Forms.Label label_Open;
        private System.Windows.Forms.Label label_OpenTitle;
        private System.Windows.Forms.Label label_Low;
        private System.Windows.Forms.Label label_LowTitle;
        private System.Windows.Forms.TextBox textBox_Days;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_BuyDaysPanel;
        private System.Windows.Forms.Button button_Check;
    }
}