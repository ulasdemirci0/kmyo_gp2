using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonV1
{
    public partial class LoginInterface : Form
    {
        public LoginInterface()
        {
            InitializeComponent();
        }
        Login login = new Login();
        #region Control Buttons
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal; this.Size = new Size(668, 434); }
            else
            { this.WindowState = FormWindowState.Maximized; }
        }
        #endregion
        #region No Border - Move
        // No Border - Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AdminInterface_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            if (login.personel_login(textBox3.Text))
                this.Hide();
            else
                MessageBox.Show("Parola hatalı!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login.admin_login(textBox1.Text, textBox2.Text))
                this.Hide();
            else
                MessageBox.Show("Kullanıcı adı veya parola hatalı!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            admin_panel.Visible = true;
            personel_panel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            admin_panel.Visible = false;
            personel_panel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
            admin_panel.Visible = false;
            personel_panel.Visible = false;
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            if (setup.is_FirstTime())
            {
                setup.install();
            }
        }
    }
}
