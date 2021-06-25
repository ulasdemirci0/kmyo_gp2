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
    public partial class PersonalInterface : Form
    {
        public PersonalInterface()
        {
            InitializeComponent();
        }
        #region Declarations
        settings_Session settings = new settings_Session();
        Customer_Actions _customer = new Customer_Actions();
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
        #region Functions 
        private void toggle_Visibility(Control c)
        {
            if (c.Visible)
                c.Visible = false;
            else
                c.Visible = true;
        }
        #endregion
        #region Navigation Bar
        private void label1_Click(object sender, EventArgs e)
        {
            toggle_Visibility(masa_panel);
        }
        #endregion
        #region Masa Creations
        private void masa_panel_VisibleChanged(object sender, EventArgs e)
        {
            if (masa_panel.Visible == true)
            {
                #region Create dynamic Masa
                masa_panel.Controls.Clear();
                for (int i = 1; i <= settings.desk_count; i++)
                {
                    Button btn = new Button();
                    btn.Height = 100;
                    btn.Name = "btn_masa_" + i;
                    btn.Width = 100;

                    btn.ForeColor = Color.White;
                    btn.AutoSizeMode = AutoSizeMode.GrowOnly;
                    btn.AutoSize = true;
                    btn.Font = new Font(Font.FontFamily, 15, FontStyle.Bold);
                    btn.Text = "Masa " + i;
                    btn.Image = Resource1.dining_table_open;
                    masa_panel.Controls.Add(btn);
                    btn.Click += Btn_Click;





                }

                desk_stat_timer.Start();
                for (int i = 1; i <= settings.desk_count; i++)
                {
                    string status = _customer.customer_desk_statuses(i);
                    Button btn = masa_panel.Controls.Find("btn_masa_" + i, true).FirstOrDefault() as Button;
                    switch (status)
                    {
                        default:
                            btn.Image = null;
                            break;
                        case "closed":
                            btn.Image = Resource1.dining_table_closed;
                            break;
                        case "reserved":
                            btn.Image = Resource1.dining_table_reserved;
                            break;
                        case "open":
                            btn.Image = Resource1.dining_table_open;
                            break;
                    }
                }
                #endregion
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            customerInterface customer = new customerInterface();
            customer.masa_id = Convert.ToInt32(btn.Name.Remove(0, 9));
            customer.Show();
        }

        private void desk_stat_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= settings.desk_count; i++)
            {
                string status = _customer.customer_desk_statuses(i);
                Button btn = masa_panel.Controls.Find("btn_masa_" + i, true).FirstOrDefault() as Button;
                switch (status)
                {
                    default:
                        btn.Image = null;
                        break;
                    case "closed":
                        btn.Image = Resource1.dining_table_closed;
                        break;
                    case "reserved":
                        btn.Image = Resource1.dining_table_reserved;
                        break;
                    case "open":
                        btn.Image = Resource1.dining_table_open;
                        break;
                }
            }
        }
        #endregion
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
            { this.WindowState = FormWindowState.Normal; this.Size = new Size(1280, 720); }
            else
            { this.WindowState = FormWindowState.Maximized;}
        }
        #endregion
    }
}
