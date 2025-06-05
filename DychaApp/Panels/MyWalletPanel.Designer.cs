namespace DychaApp.Panels
{
    partial class MyWalletPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyWalletPanel));
            this.button_MainSite = new System.Windows.Forms.Button();
            this.button_MyWallet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_sublogo = new System.Windows.Forms.PictureBox();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Calculator = new System.Windows.Forms.Button();
            this.label_Subtitle = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_TitleBar = new System.Windows.Forms.Panel();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.dataGridView_MyWallet = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Summary = new System.Windows.Forms.Label();
            this.label_AccountValue = new System.Windows.Forms.Label();
            this.label_Value = new System.Windows.Forms.Label();
            this.label_Profit = new System.Windows.Forms.Label();
            this.label_Money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sublogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyWallet)).BeginInit();
            this.SuspendLayout();
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
            this.button_MainSite.TabIndex = 59;
            this.button_MainSite.Text = "Strona główna";
            this.button_MainSite.UseVisualStyleBackColor = true;
            this.button_MainSite.Click += new System.EventHandler(this.button_MainSite_Click);
            // 
            // button_MyWallet
            // 
            this.button_MyWallet.FlatAppearance.BorderSize = 0;
            this.button_MyWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_MyWallet.ForeColor = System.Drawing.Color.Red;
            this.button_MyWallet.Location = new System.Drawing.Point(661, 44);
            this.button_MyWallet.Name = "button_MyWallet";
            this.button_MyWallet.Size = new System.Drawing.Size(105, 35);
            this.button_MyWallet.TabIndex = 58;
            this.button_MyWallet.Text = "Portfel";
            this.button_MyWallet.UseVisualStyleBackColor = true;
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
            // button_Calculator
            // 
            this.button_Calculator.FlatAppearance.BorderSize = 0;
            this.button_Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Calculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_Calculator.Location = new System.Drawing.Point(769, 44);
            this.button_Calculator.Name = "button_Calculator";
            this.button_Calculator.Size = new System.Drawing.Size(157, 35);
            this.button_Calculator.TabIndex = 55;
            this.button_Calculator.Text = "Kalkulator";
            this.button_Calculator.UseVisualStyleBackColor = true;
            this.button_Calculator.Click += new System.EventHandler(this.button_Calculator_Click);
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
            // dataGridView_MyWallet
            // 
            this.dataGridView_MyWallet.AllowUserToAddRows = false;
            this.dataGridView_MyWallet.AllowUserToDeleteRows = false;
            this.dataGridView_MyWallet.AllowUserToResizeColumns = false;
            this.dataGridView_MyWallet.AllowUserToResizeRows = false;
            this.dataGridView_MyWallet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView_MyWallet.ColumnHeadersHeight = 45;
            this.dataGridView_MyWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_MyWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Volume,
            this.MarketValue,
            this.OpeningPrice,
            this.Profit,
            this.ProfitPercentage});
            this.dataGridView_MyWallet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridView_MyWallet.Location = new System.Drawing.Point(0, 103);
            this.dataGridView_MyWallet.Name = "dataGridView_MyWallet";
            this.dataGridView_MyWallet.ReadOnly = true;
            this.dataGridView_MyWallet.RowHeadersVisible = false;
            this.dataGridView_MyWallet.RowHeadersWidth = 4;
            this.dataGridView_MyWallet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_MyWallet.Size = new System.Drawing.Size(1080, 570);
            this.dataGridView_MyWallet.TabIndex = 60;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Pozycja";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Symbol.Width = 140;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Wolumen";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Volume.Width = 159;
            // 
            // MarketValue
            // 
            this.MarketValue.HeaderText = "Wartość rynkowa";
            this.MarketValue.Name = "MarketValue";
            this.MarketValue.ReadOnly = true;
            this.MarketValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MarketValue.Width = 229;
            // 
            // OpeningPrice
            // 
            this.OpeningPrice.HeaderText = "Cena otwarcia";
            this.OpeningPrice.Name = "OpeningPrice";
            this.OpeningPrice.ReadOnly = true;
            this.OpeningPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OpeningPrice.Width = 205;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Zysk netto";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Profit.Width = 174;
            // 
            // ProfitPercentage
            // 
            this.ProfitPercentage.HeaderText = "Zysk netto %";
            this.ProfitPercentage.Name = "ProfitPercentage";
            this.ProfitPercentage.ReadOnly = true;
            this.ProfitPercentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfitPercentage.Width = 170;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, 673);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1080, 4);
            this.label3.TabIndex = 61;
            this.label3.Text = "label3";
            // 
            // button_Show
            // 
            this.button_Show.BackColor = System.Drawing.Color.Red;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Show.ForeColor = System.Drawing.Color.White;
            this.button_Show.Location = new System.Drawing.Point(273, 44);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(222, 35);
            this.button_Show.TabIndex = 62;
            this.button_Show.Text = "Wyświetl";
            this.button_Show.UseVisualStyleBackColor = false;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(21)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(301, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 91);
            this.label4.TabIndex = 63;
            this.label4.Text = "label4";
            // 
            // label_Summary
            // 
            this.label_Summary.AutoSize = true;
            this.label_Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Summary.Location = new System.Drawing.Point(22, 702);
            this.label_Summary.Name = "label_Summary";
            this.label_Summary.Size = new System.Drawing.Size(254, 39);
            this.label_Summary.TabIndex = 64;
            this.label_Summary.Text = "Podsumowanie";
            // 
            // label_AccountValue
            // 
            this.label_AccountValue.AutoSize = true;
            this.label_AccountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AccountValue.Location = new System.Drawing.Point(323, 692);
            this.label_AccountValue.Name = "label_AccountValue";
            this.label_AccountValue.Size = new System.Drawing.Size(128, 24);
            this.label_AccountValue.TabIndex = 65;
            this.label_AccountValue.Text = "Wartość konta";
            // 
            // label_Value
            // 
            this.label_Value.AutoSize = true;
            this.label_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Value.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_Value.Location = new System.Drawing.Point(323, 722);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(37, 25);
            this.label_Value.TabIndex = 66;
            this.label_Value.Text = "- $";
            this.label_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Profit
            // 
            this.label_Profit.AutoSize = true;
            this.label_Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Profit.Location = new System.Drawing.Point(701, 702);
            this.label_Profit.Name = "label_Profit";
            this.label_Profit.Size = new System.Drawing.Size(92, 39);
            this.label_Profit.TabIndex = 67;
            this.label_Profit.Text = "Zysk";
            // 
            // label_Money
            // 
            this.label_Money.AutoSize = true;
            this.label_Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Money.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_Money.Location = new System.Drawing.Point(794, 702);
            this.label_Money.Name = "label_Money";
            this.label_Money.Size = new System.Drawing.Size(57, 39);
            this.label_Money.TabIndex = 68;
            this.label_Money.Text = "- $";
            // 
            // MyWalletPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1080, 768);
            this.Controls.Add(this.label_Money);
            this.Controls.Add(this.label_Profit);
            this.Controls.Add(this.label_Value);
            this.Controls.Add(this.label_AccountValue);
            this.Controls.Add(this.label_Summary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_MyWallet);
            this.Controls.Add(this.button_MainSite);
            this.Controls.Add(this.button_MyWallet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_sublogo);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Calculator);
            this.Controls.Add(this.label_Subtitle);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_TitleBar);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyWalletPanel";
            this.Text = "MyWalletPanel";
            this.Load += new System.EventHandler(this.MyWalletPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sublogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_MainSite;
        private System.Windows.Forms.Button button_MyWallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_sublogo;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Calculator;
        private System.Windows.Forms.Label label_Subtitle;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_TitleBar;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.DataGridView dataGridView_MyWallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Summary;
        private System.Windows.Forms.Label label_AccountValue;
        private System.Windows.Forms.Label label_Value;
        private System.Windows.Forms.Label label_Profit;
        private System.Windows.Forms.Label label_Money;
    }
}