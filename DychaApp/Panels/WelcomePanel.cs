using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace DychaApp.Panels
{
    public partial class WelcomePanel: Form
    {
        // Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font defaultFont;
        public WelcomePanel()
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

        private void WelcomePanel_Load(object sender, EventArgs e)
        {
            label_Title.Font = new Font(fonts.Families[0], 30.0F, FontStyle.Bold);
            label_Subtitle.Font = new Font(fonts.Families[0], 11.25F, FontStyle.Bold);
            button_Register.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);
            button_Login.Font = new Font(fonts.Families[0], 13.0F, FontStyle.Regular);

            label_Description1.Font = new Font(fonts.Families[0], 24.0F, FontStyle.Bold);
            label_Description2.Font = new Font(fonts.Families[0], 24.0F, FontStyle.Bold);
            label_DescPanel1.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);
            label_DescPanel2.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);
            label_DescPanel3.Font = new Font(fonts.Families[0], 20.0F, FontStyle.Regular);
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

        private void button_Login_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.Show();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();
            this.Hide();
            registerPanel.Show();
        }
    }
}
