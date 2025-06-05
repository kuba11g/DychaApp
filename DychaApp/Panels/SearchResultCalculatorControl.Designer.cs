namespace DychaApp.Panels
{
    partial class SearchResultCalculatorControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Symbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_Name.Location = new System.Drawing.Point(3, 15);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(100, 13);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "NVIDIA Corporation";
            this.label_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Name_MouseDown);
            this.label_Name.MouseEnter += new System.EventHandler(this.label_Name_MouseEnter);
            this.label_Name.MouseLeave += new System.EventHandler(this.label_Name_MouseLeave);
            // 
            // label_Symbol
            // 
            this.label_Symbol.AutoSize = true;
            this.label_Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Symbol.ForeColor = System.Drawing.Color.Red;
            this.label_Symbol.Location = new System.Drawing.Point(3, 2);
            this.label_Symbol.Name = "label_Symbol";
            this.label_Symbol.Size = new System.Drawing.Size(41, 13);
            this.label_Symbol.TabIndex = 2;
            this.label_Symbol.Text = "NVDA";
            this.label_Symbol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Symbol_MouseDown);
            this.label_Symbol.MouseEnter += new System.EventHandler(this.label_Symbol_MouseEnter);
            this.label_Symbol.MouseLeave += new System.EventHandler(this.label_Symbol_MouseLeave);
            // 
            // SearchResultCalculatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Symbol);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchResultCalculatorControl";
            this.Size = new System.Drawing.Size(222, 30);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchResultCalculatorControl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.SearchResultCalculatorControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SearchResultCalculatorControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Symbol;
    }
}
