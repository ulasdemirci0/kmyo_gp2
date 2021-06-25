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
using Microsoft.VisualBasic;
namespace RestaurantOtomasyonV1
{
    public partial class customerInterface : Form
    {
        public customerInterface()
        {
            InitializeComponent();
        }
        #region Variables
        Customer_Actions _customer = new Customer_Actions();
        public int masa_id;
        string clickedCategoryName = null;
        #endregion
        #region Functions
        private void load_datagrid()
        {
            string soldItems = _customer.customers_load_sold_urun_names_and_counts(masa_id);
            if (soldItems != null)
            {
                string[] soldSplit = soldItems.Split('}')[1].Split('{');
                foreach (var item in soldSplit)
                {
                    if (item.Length > 0)
                    {
                        dataGridView1.Rows.Add(item.Split('%')[0], item.Split('%')[1], Convert.ToDouble(item.Split('%')[1]) * _customer.urun_find_price(item.Split('%')[0]));
                    }
                }
            }
        }
        private void load_category_items_to_control(string category = null, Control control = null)
        {
            if (control != null)
            {
                if (category != null && _customer.urun_is_any_urun_has_this_category(category))
                {
                    if (control.Name.ToLower().Contains("panel"))
                        control.Controls.Clear();
                    else if (control.Name.ToLower().Contains("list"))
                    {
                        ListBox listbox = (ListBox)control;
                        listbox.Items.Clear();
                    }

                    foreach (var item in _customer.urun_load_uruns_from_category(category))
                    {
                        string itemName = item.Split('{')[0];
                        Button MenuItem = new Button();
                        MenuItem.Height = 50;
                        MenuItem.Name = "btn_urun_" + itemName;
                        MenuItem.Width = 50;
                        MenuItem.AutoSizeMode = AutoSizeMode.GrowOnly;
                        MenuItem.BackColor = Color.FromArgb(255, 49, 75);
                        MenuItem.ForeColor = Color.White;
                        MenuItem.FlatStyle = FlatStyle.Popup;
                        MenuItem.AutoSize = true;
                        MenuItem.Font = new Font(Font.FontFamily, 12, FontStyle.Regular);
                        MenuItem.Text = itemName;
                        MenuItem.Click += MenuItem_Click;
                        if (control.Name.ToLower().Contains("anel"))
                        {
                            control.Controls.Add(MenuItem);
                        }
                        else if (control.Name.ToLower().Contains("list"))
                        {
                            ListBox listbox = (ListBox)control;
                            listbox.Items.Add(itemName + ", " + _customer.urun_find_price(itemName) + ", " + _customer.urun_find_category_from_urun(itemName));
                        }
                    }
                }
                else
                {
                    if (control.Name.ToLower().Contains("panel"))
                        control.Controls.Clear();
                    else if (control.Name.ToLower().Contains("list"))
                    {
                        ListBox listbox = (ListBox)control;
                        listbox.Items.Clear();
                    }
                }

            }
        }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
            string[] urun = _customer.urun_get(btn.Text).Split('{');
            int value = Convert.ToInt32(Interaction.InputBox("Adet giriniz", "Kebab-Co - Adisyon", "1"));
            if (value > 0)
            {
                dataGridView1.Rows.Add(urun[0], value, urun[2]);
                _customer.customer_sell_item(masa_id, urun[0], value);
            }
        }
        private void load_categories()
        {
            category_list.Items.Clear();
            comboBox1.Items.Clear();
            categoryPanel.MaximumSize = new Size(rPanel.Size.Width - 20, rPanel.Size.Height / 2);
            categoryPanel.Controls.Clear();

            foreach (var item in _customer.category_getall())
            {
                category_list.Items.Add(item);
                comboBox1.Items.Add(item);

                Button CategoryItem = new Button();
                CategoryItem.Height = 60;
                CategoryItem.Width = 100;
                CategoryItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                CategoryItem.BackColor = Color.FromArgb(255, 49, 75);
                CategoryItem.ForeColor = Color.White;
                CategoryItem.FlatStyle = FlatStyle.Popup;
                CategoryItem.AutoSize = true;
                CategoryItem.Font = new Font(Font.FontFamily, 12, FontStyle.Regular);
                CategoryItem.Text = item;
                categoryPanel.Controls.Add(CategoryItem);
                CategoryItem.Click += CategoryItem_Click;
            }
        }
        private void CategoryItem_Click(object sender, EventArgs e)
        {
            Control _this = (Control)sender;
            if (_this.Text != clickedCategoryName)
            {
                load_category_items_to_control(_this.Text, urunPanel);
                load_category_items_to_control(_this.Text, urun_list);
                clickedCategoryName = _this.Text;
            }
            else
            {
                urunPanel.Controls.Clear();
                urun_list.Items.Clear();
                clickedCategoryName = null;
            }

        }
        private void is_reserved_block(int masaid, Control ctrl)
        {
            if (_customer.customer_desk_statuses(masaid) == "reserved")
            {
                ctrl.Enabled = false;
            }
            else
            {

                ctrl.Enabled = true;
            }
        }
        private void load_urun()
        {
            urun_list.Items.Clear();
            foreach (var item in _customer.urun_get_all_names())
            {
                urun_list.Items.Add(item + ", " + _customer.urun_find_price(item) + ", " + _customer.urun_find_category_from_urun(item));
            }
        }

        private void is_not_admin()
        {
            settings_Session set = new settings_Session();
            if (set.isAdmin == false)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;

                this.Width = 996;
                this.Height = 773;
            }
        }
        #endregion
        #region Form Load
        // Form Load
        private void customerInterface_Load(object sender, EventArgs e)
        {
            is_not_admin();
            settings_Session set = new settings_Session();
            load_datagrid();
            load_categories();
            if (_customer.customer_desk_statuses(masa_id) == "reserved")
                button4.Text = "Rezerve İptal";
            else
                button4.Text = "Rezerve Et";

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

        private void Move_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Control Button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        #endregion
        #region Button Click
        private void btn_category_add_Click(object sender, EventArgs e)
        {
            _customer.category_create(textBox1.Text);
            load_categories();
        }
        private void btn_category_remove_Click(object sender, EventArgs e)
        {
            if (category_list.SelectedItem.ToString() != null)
            {
                _customer.category_remove(category_list.SelectedItem.ToString());
                load_categories();
            }
        }
        private void btn_category_rename_Click(object sender, EventArgs e)
        {
            if (category_list.SelectedItem != null)
            {
                _customer.category_rename(category_list.SelectedItem.ToString(), textBox1.Text);
                load_categories();
            }
            textBox1.Text = "";
        }
        private void btn_urun_add_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && comboBox1.Text.Length > 0 && textBox3.TextLength > 0)
            {
                _customer.urun_create(textBox2.Text, comboBox1.Text, textBox3.Text);
                load_category_items_to_control(comboBox1.Text, urunPanel);
                load_category_items_to_control(comboBox1.Text, urun_list);
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
            }
            else
                MessageBox.Show("Boş alan bırakmamalısınız!", "Boş değer girildi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btn_urun_edit_Click(object sender, EventArgs e)
        {
            if (urun_list.SelectedItem != null)
            {
                if (textBox2.TextLength > 0 && comboBox1.Text.Length > 0 && textBox3.TextLength > 0)
                {
                    _customer.urun_update(urun_list.SelectedItem.ToString().Split(',')[0], textBox2.Text, comboBox1.Text, textBox3.Text);
                    load_category_items_to_control(comboBox1.Text, urunPanel);
                    load_category_items_to_control(comboBox1.Text, urun_list);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                }
                else MessageBox.Show("Boş alan bırakmamalısınız!", "Boş değer girildi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Düzenleme yapılacak kayıtı sol taraftaki listeden seçiniz.", "Boş değer girildi", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
        private void btn_urun_remove_Click(object sender, EventArgs e)
        {
            if (urun_list.SelectedItem != null)
            {
                string selectedItemCategory = urun_list.SelectedItem.ToString().Split(',')[2];
                _customer.urun_remove(urun_list.SelectedItem.ToString().Split(',')[0]);
                load_category_items_to_control(selectedItemCategory, urun_list);
                load_category_items_to_control(selectedItemCategory, urunPanel);
            }

            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _customer.customer_refund_item(masa_id, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

            }
        }
        #endregion
        #region List Selection Changed
        private void category_list_SelectedValueChanged(object sender, EventArgs e)
        {
            if (category_list.SelectedItem != null)
                textBox1.Text = category_list.SelectedItem.ToString();
            else
                textBox1.Text = "";
        }
        private void urun_list_SelectedValueChanged(object sender, EventArgs e)
        {
            if (urun_list.SelectedItem != null)
            {
                string[] item = _customer.urun_get(urun_list.SelectedItem.ToString().Split(',')[0]).Split('{');

                if (item.Length > 0)
                {
                    textBox2.Text = item[0];
                    comboBox1.Text = item[1];
                    textBox3.Text = item[2];
                }
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
            }
        }
        #endregion
        #region DataGrid Row Add/Remove
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double fiyat_x_adet = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                fiyat_x_adet += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
            }
            lbl_total_price.Text = fiyat_x_adet.ToString() + "₺";


        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double fiyat_x_adet = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                fiyat_x_adet += Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value);
            }
            lbl_total_price.Text = fiyat_x_adet.ToString() + "₺";
        }
        #endregion
        #region Reservation
        private void button4_Click(object sender, EventArgs e)
        {
            if (_customer.customer_desk_statuses(masa_id) == "reserved")
            {
                if (MessageBox.Show("Rezerve işlemi iptal edilsin mi?.\nRezerve işlemi 10 saniye içerisinde listelerde güncellenir.", "Rezerve UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _customer.customer_desk_reserve(masa_id, "unset");
                    load_categories();
                    button4.Text = "Rezerve Et";
                    dataGridView1.Rows.Clear();
                }
            }
            else
            {
                if (MessageBox.Show("Masayı rezerve olarak ayarlarsanız adisyon sıfırlanacaktır.\nRezerve işlemi 10 saniye içerisinde listelerde güncellenir.", "Rezerve UYARI!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    _customer.customer_desk_reserve(masa_id, "set");
                    load_categories();
                    button4.Text = "Rezerve İptal";
                }
            }
        }

        private void categoryPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            is_reserved_block(masa_id, e.Control);
        }
        #endregion
        #region Hesap Kapat
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesap kapat işlemi hesabı doğrudan hiç var olmamış gibi siler. \nEmin misiniz?", "HESAP SİLME İŞLEMİ!!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    _customer.customer_refund_item(masa_id, item.Cells[0].Value.ToString(), Convert.ToInt32(item.Cells[1].Value));
                }
                dataGridView1.Rows.Clear();

            }
        }
        #endregion
    }
}
