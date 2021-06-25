
namespace RestaurantOtomasyonV1
{
    partial class customerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerInterface));
            this.lPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.rPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_urun_remove = new System.Windows.Forms.Button();
            this.btn_urun_edit = new System.Windows.Forms.Button();
            this.btn_urun_add = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urun_list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_category_remove = new System.Windows.Forms.Button();
            this.btn_category_rename = new System.Windows.Forms.Button();
            this.btn_category_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_list = new System.Windows.Forms.ListBox();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.urunPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.rPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPanel
            // 
            this.lPanel.AutoSize = true;
            this.lPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lPanel.Controls.Add(this.button1);
            this.lPanel.Controls.Add(this.lbl_total_price);
            this.lPanel.Controls.Add(this.label1);
            this.lPanel.Controls.Add(this.dataGridView1);
            this.lPanel.Controls.Add(this.CancelButton);
            this.lPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lPanel.Location = new System.Drawing.Point(0, 0);
            this.lPanel.Name = "lPanel";
            this.lPanel.Size = new System.Drawing.Size(303, 876);
            this.lPanel.TabIndex = 0;
            this.lPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adisyon\'dan Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.Location = new System.Drawing.Point(172, 747);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(27, 19);
            this.lbl_total_price.TabIndex = 9;
            this.lbl_total_price.Text = "0₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toplam Fiyat:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantity,
            this.price});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 653);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // name
            // 
            this.name.HeaderText = "Ürün";
            this.name.Name = "name";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Adet";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "Fiyat";
            this.price.Name = "price";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(0, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(27, 30);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // rPanel
            // 
            this.rPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rPanel.Controls.Add(this.groupBox3);
            this.rPanel.Controls.Add(this.groupBox1);
            this.rPanel.Controls.Add(this.categoryPanel);
            this.rPanel.Controls.Add(this.groupBox2);
            this.rPanel.Controls.Add(this.urunPanel);
            this.rPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPanel.Location = new System.Drawing.Point(303, 0);
            this.rPanel.Name = "rPanel";
            this.rPanel.Size = new System.Drawing.Size(1150, 876);
            this.rPanel.TabIndex = 1;
            this.rPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_urun_remove);
            this.groupBox3.Controls.Add(this.btn_urun_edit);
            this.groupBox3.Controls.Add(this.btn_urun_add);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.urun_list);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(705, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 416);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Ekle / Düzenle / Sil";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 25);
            this.comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kategori:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 25);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fiyat:";
            // 
            // btn_urun_remove
            // 
            this.btn_urun_remove.Location = new System.Drawing.Point(214, 323);
            this.btn_urun_remove.Name = "btn_urun_remove";
            this.btn_urun_remove.Size = new System.Drawing.Size(186, 30);
            this.btn_urun_remove.TabIndex = 6;
            this.btn_urun_remove.Text = "Ürün Sil";
            this.btn_urun_remove.UseVisualStyleBackColor = true;
            this.btn_urun_remove.Click += new System.EventHandler(this.btn_urun_remove_Click);
            // 
            // btn_urun_edit
            // 
            this.btn_urun_edit.Location = new System.Drawing.Point(214, 275);
            this.btn_urun_edit.Name = "btn_urun_edit";
            this.btn_urun_edit.Size = new System.Drawing.Size(186, 30);
            this.btn_urun_edit.TabIndex = 7;
            this.btn_urun_edit.Text = "Ürün Düzenle";
            this.btn_urun_edit.UseVisualStyleBackColor = true;
            this.btn_urun_edit.Click += new System.EventHandler(this.btn_urun_edit_Click);
            // 
            // btn_urun_add
            // 
            this.btn_urun_add.Location = new System.Drawing.Point(214, 225);
            this.btn_urun_add.Name = "btn_urun_add";
            this.btn_urun_add.Size = new System.Drawing.Size(186, 30);
            this.btn_urun_add.TabIndex = 8;
            this.btn_urun_add.Text = "Yeni Ürün Ekle";
            this.btn_urun_add.UseVisualStyleBackColor = true;
            this.btn_urun_add.Click += new System.EventHandler(this.btn_urun_add_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 25);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Adı:";
            // 
            // urun_list
            // 
            this.urun_list.FormattingEnabled = true;
            this.urun_list.ItemHeight = 17;
            this.urun_list.Location = new System.Drawing.Point(6, 26);
            this.urun_list.Name = "urun_list";
            this.urun_list.Size = new System.Drawing.Size(183, 327);
            this.urun_list.TabIndex = 1;
            this.urun_list.TabStop = false;
            this.urun_list.SelectedValueChanged += new System.EventHandler(this.urun_list_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(87, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sol taraftan ürün ekleyeceğiniz kategoriyi seçiniz.";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_category_remove);
            this.groupBox1.Controls.Add(this.btn_category_rename);
            this.groupBox1.Controls.Add(this.btn_category_add);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.category_list);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(705, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 311);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekle / Düzenle / Sil";
            // 
            // btn_category_remove
            // 
            this.btn_category_remove.Location = new System.Drawing.Point(225, 251);
            this.btn_category_remove.Name = "btn_category_remove";
            this.btn_category_remove.Size = new System.Drawing.Size(186, 30);
            this.btn_category_remove.TabIndex = 3;
            this.btn_category_remove.Text = "Seçili Kategoriyi Sil";
            this.btn_category_remove.UseVisualStyleBackColor = true;
            this.btn_category_remove.Click += new System.EventHandler(this.btn_category_remove_Click);
            // 
            // btn_category_rename
            // 
            this.btn_category_rename.Location = new System.Drawing.Point(225, 203);
            this.btn_category_rename.Name = "btn_category_rename";
            this.btn_category_rename.Size = new System.Drawing.Size(186, 30);
            this.btn_category_rename.TabIndex = 3;
            this.btn_category_rename.Text = "Kategori Adı Değiştir";
            this.btn_category_rename.UseVisualStyleBackColor = true;
            this.btn_category_rename.Click += new System.EventHandler(this.btn_category_rename_Click);
            // 
            // btn_category_add
            // 
            this.btn_category_add.Location = new System.Drawing.Point(225, 153);
            this.btn_category_add.Name = "btn_category_add";
            this.btn_category_add.Size = new System.Drawing.Size(186, 30);
            this.btn_category_add.TabIndex = 3;
            this.btn_category_add.Text = "Yeni Kategori Ekle";
            this.btn_category_add.UseVisualStyleBackColor = true;
            this.btn_category_add.Click += new System.EventHandler(this.btn_category_add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Adı";
            // 
            // category_list
            // 
            this.category_list.FormattingEnabled = true;
            this.category_list.ItemHeight = 17;
            this.category_list.Location = new System.Drawing.Point(6, 39);
            this.category_list.Name = "category_list";
            this.category_list.Size = new System.Drawing.Size(183, 242);
            this.category_list.TabIndex = 0;
            this.category_list.SelectedValueChanged += new System.EventHandler(this.category_list_SelectedValueChanged);
            // 
            // categoryPanel
            // 
            this.categoryPanel.AutoScroll = true;
            this.categoryPanel.AutoSize = true;
            this.categoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryPanel.Location = new System.Drawing.Point(18, 12);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(659, 196);
            this.categoryPanel.TabIndex = 4;
            this.categoryPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.categoryPanel_ControlAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(18, 772);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adisyon";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 31);
            this.button4.TabIndex = 0;
            this.button4.Text = "Rezerve";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "Hesap Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // urunPanel
            // 
            this.urunPanel.AutoScroll = true;
            this.urunPanel.AutoSize = true;
            this.urunPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunPanel.Location = new System.Drawing.Point(18, 214);
            this.urunPanel.Name = "urunPanel";
            this.urunPanel.Size = new System.Drawing.Size(659, 536);
            this.urunPanel.TabIndex = 0;
            // 
            // customerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1453, 876);
            this.ControlBox = false;
            this.Controls.Add(this.rPanel);
            this.Controls.Add(this.lPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customerInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerInterface";
            this.Load += new System.EventHandler(this.customerInterface_Load);
            this.lPanel.ResumeLayout(false);
            this.lPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.rPanel.ResumeLayout(false);
            this.rPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lPanel;
        private System.Windows.Forms.Panel rPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel urunPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox category_list;
        private System.Windows.Forms.Button btn_category_remove;
        private System.Windows.Forms.Button btn_category_rename;
        private System.Windows.Forms.Button btn_category_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox urun_list;
        private System.Windows.Forms.Button btn_urun_remove;
        private System.Windows.Forms.Button btn_urun_edit;
        private System.Windows.Forms.Button btn_urun_add;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}