using DychaApp.Resources;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DychaApp.Panels
{
    public partial class LoginPanel: Form
    {
        // Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font defaultFont;
        public LoginPanel()
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

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            label_Title.Font = new Font(fonts.Families[0], 30.0F, FontStyle.Bold);
            label_Subtitle.Font = new Font(fonts.Families[0], 11.25F, FontStyle.Bold);
            button_Register.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Login.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);

            label_Logowanie.Font = new Font(fonts.Families[0], 24.0F, FontStyle.Regular);
            label_ZalogujSie.Font = new Font(fonts.Families[0], 11.0F, FontStyle.Regular);

            textBox_Login.Font = new Font(fonts.Families[0], 12.0F, FontStyle.Regular);
            textBox_Password.Font = new Font(fonts.Families[0], 12.0F, FontStyle.Regular);
            button_LoginForm.Font = new Font(fonts.Families[0], 16.0F, FontStyle.Regular);
            label_ZapomnialesHasla.Font = new Font(fonts.Families[0], 9.0F, FontStyle.Regular);
            button_RegisterForm.Font = new Font(fonts.Families[0], 12.0F, FontStyle.Regular);
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

        private async void button_LoginForm_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = await Task.Run(() => DatabaseConnection.Login(textBox_Login.Text, textBox_Password.Text));

            if (loginSuccessful)
            {
                MessageBox.Show("Zalogowano pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPanel mainPanel = new MainPanel();
                this.Hide();
                mainPanel.Show();
            }
            else if (textBox_Login.Text == "" || textBox_Password.Text == "" || textBox_Login.Text == "Nazwa użytkownika" || textBox_Password.Text == "Hasło")
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Niepoprawne dane logowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            this.Hide();
            registerPanel.Show();
        }

        private void button_RegisterForm_Click(object sender, EventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            this.Hide();
            registerPanel.Show();
        }

        private void textBox_Login_Enter(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Nazwa użytkownika")
            {
                textBox_Login.Text = "";
                textBox_Login.ForeColor = Color.Black;
            }
        }

        private void textBox_Login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Login.Text))
            {
                textBox_Login.Text = "Nazwa użytkownika";
                textBox_Login.ForeColor = Color.Gray;
            }
        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Hasło")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Password.Text))
            {
                textBox_Password.Text = "Hasło";
                textBox_Password.ForeColor = Color.Gray;
                textBox_Password.UseSystemPasswordChar = false;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != "Hasło")
                textBox_Password.UseSystemPasswordChar = true;
            else
                textBox_Password.UseSystemPasswordChar = false;
        }
    }
}
