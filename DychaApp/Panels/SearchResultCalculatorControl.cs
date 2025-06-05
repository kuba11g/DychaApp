using DychaApp.Resources.Class;
using System.Windows.Forms;

namespace DychaApp.Panels
{
    public partial class SearchResultCalculatorControl : UserControl
    {
        private CalculatorPanel _calculatorPanel;
        public SearchResultCalculatorControl()
        {
            InitializeComponent();
        }

        public SearchResultCalculatorControl(CalculatorPanel calculatorPanel) : this()
        {
            _calculatorPanel = calculatorPanel;
        }

        public void Details(StockSymbolLoader stockSymbolLoader)
        {
            label_Symbol.Text = stockSymbolLoader.Symbol;
            label_Name.Text = stockSymbolLoader.Name;
        }

        private async void SearchResultCalculatorControl_MouseEnter(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
        }

        private async void SearchResultCalculatorControl_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(217, 217, 217);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(77, 77, 77);
        }

        private void SearchResultCalculatorControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (_calculatorPanel != null)
            {
                _calculatorPanel.SetTextForLabel(label_Symbol.Text);
            }
        }

        private async void label_Symbol_MouseEnter(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
        }

        private async void label_Symbol_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(217, 217, 217);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(77, 77, 77);
        }

        private void label_Symbol_MouseDown(object sender, MouseEventArgs e)
        {
            if (_calculatorPanel != null)
            {
                _calculatorPanel.SetTextForLabel(label_Symbol.Text);
            }
        }

        private async void label_Name_MouseEnter(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
        }

        private async void label_Name_MouseLeave(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(217, 217, 217);
            label_Symbol.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0);
            label_Name.ForeColor = System.Drawing.Color.FromArgb(77, 77, 77);
        }

        private void label_Name_MouseDown(object sender, MouseEventArgs e)
        {
            if (_calculatorPanel != null)
            {
                _calculatorPanel.SetTextForLabel(label_Symbol.Text);
            }
        }
    }
}
