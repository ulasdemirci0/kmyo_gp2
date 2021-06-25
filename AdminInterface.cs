using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Resources;
using RestaurantOtomasyonV1.Properties;

namespace RestaurantOtomasyonV1
{
    public partial class AdminInterface : Form
    {
        #region __Construct
        public AdminInterface()
        {
            InitializeComponent();
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
        #region Declarations
        user_actions user_Actions = new user_actions();
        settings_Session settings = new settings_Session();
        Customer_Actions _customer = new Customer_Actions();
        #endregion
        #region Load Event
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            if (textBox2.Text != "Şifre giriniz")
            {
                textBox2.UseSystemPasswordChar = true;
            }

            #region ComboBox and Listbox
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            foreach (var item in user_Actions.get_all_usernames())
            {
                comboBox1.Items.Add(item.Value);
                listBox1.Items.Add(item.Value);
            }
            #endregion

            settings_Session settings = new settings_Session();
            lbl_current_username.Text = settings.current_username;
            if (settings.isAdmin)
                lbl_current_permission.Text = "Admin";
            else
                lbl_current_permission.Text = "Personel";

            lbl_current_session_time.Text = settings.current_session.ToString();

        }
        #endregion
        #region Visibility - Hover Effects
        private void label2_Click(object sender, EventArgs e)
        {
            right_layout_control();
            personelPanel.Visible = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            lbl_personal.Font = new Font(lbl_personal.Font.Name, lbl_personal.Font.Size, FontStyle.Underline, lbl_personal.Font.Unit);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            lbl_personal.Font = new Font(lbl_personal.Font.Name, lbl_personal.Font.Size, FontStyle.Bold, lbl_personal.Font.Unit);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            if (textBox2.Text == "Şifre giriniz")
            {
                textBox2.Text = "";
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            right_layout_control();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            right_layout_control();
            masaPanel.Visible = true;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.Font = new Font(lbl_personal.Font.Name, lbl_personal.Font.Size, FontStyle.Underline, lbl_personal.Font.Unit);
        }
        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(lbl_personal.Font.Name, lbl_personal.Font.Size, FontStyle.Bold, lbl_personal.Font.Unit);
        }
        #endregion
        #region Personel Create / Update / Delete
        private void personel_btn_Click(object sender, EventArgs e)
        {
            if (user_Actions.is_user_exist(comboBox1.Text))
            {
                user_Actions.update_password(comboBox1.Text, textBox2.Text);
                #region ComboBox and Listbox
                comboBox1.Items.Clear();
                listBox1.Items.Clear();
                foreach (var item in user_Actions.get_all_usernames())
                {
                    comboBox1.Items.Add(item.Value);
                    listBox1.Items.Add(item.Value);
                }
                #endregion
            }
            else
            {
                user_Actions.create_user(comboBox1.Text, textBox2.Text, checkBox1.Checked);
                #region ComboBox and Listbox
                comboBox1.Items.Clear();
                listBox1.Items.Clear();
                foreach (var item in user_Actions.get_all_usernames())
                {
                    comboBox1.Items.Add(item.Value);
                    listBox1.Items.Add(item.Value);
                }
                #endregion
            }
            comboBox1.Text = "";
            textBox2.Text = "Şifre giriniz";
            textBox2.UseSystemPasswordChar = false;
        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(comboBox1.Text) && user_Actions.is_admin(comboBox1.Text))
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Length > 0)
            {
                user_Actions.delete_user(listBox1.SelectedItem.ToString());
                #region ComboBox and Listbox
                comboBox1.Items.Clear();
                listBox1.Items.Clear();
                foreach (var item in user_Actions.get_all_usernames())
                {
                    comboBox1.Items.Add(item.Value);
                    listBox1.Items.Add(item.Value);
                }
                #endregion
            }
        }
        #endregion
        #region Layout Visibility Control
        private void right_layout_control(Control obj = null, bool show = false)
        {
            if (!show)
            {
                if (obj != null)
                    obj.Visible = false;
                else
                {
                    masaPanel.Visible = false;
                    personelPanel.Visible = false;
                }
            }
            else
            {
                if (obj != null)
                    obj.Visible = true;
                else
                {
                    masaPanel.Visible = true;
                    personelPanel.Visible = true;
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
            { this.WindowState = FormWindowState.Maximized; right_layout_control(); right_layout_control(null, true); }
        }
        #endregion
        #region Masa İşlemleri
        private void masaPanel_VisibleChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.MaximumSize = new Size(masaPanel.Size.Width - 400, masaPanel.Size.Height / 2);
            if (masaPanel.Visible == true)
            {
                #region Create dynamic Masa
                flowLayoutPanel1.Controls.Clear();
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
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;





                }

                desk_stat_timer.Start();
                for (int i = 1; i <= settings.desk_count; i++)
                {
                    string status = _customer.customer_desk_statuses(i);
                    Button btn = masaPanel.Controls.Find("btn_masa_" + i, true).FirstOrDefault() as Button;
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
            else
            {

                desk_stat_timer.Stop();
            }
        }
        #region Masa Click Event
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            customerInterface customer = new customerInterface();
            customer.masa_id = Convert.ToInt32(btn.Name.Remove(0, 9));
            customer.Show();

        }

        #endregion

        #endregion


        // Every 9.99 sec
        private void desk_stat_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= settings.desk_count; i++)
            {
                string status = _customer.customer_desk_statuses(i);
                Button btn = masaPanel.Controls.Find("btn_masa_" + i, true).FirstOrDefault() as Button;
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
    }
}
