
namespace RestaurantOtomasyonV1
{
    partial class AdminInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.lPanel = new System.Windows.Forms.Panel();
            this.maximize_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_personal = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personel_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_current_username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_current_permission = new System.Windows.Forms.Label();
            this.lbl_current_session_time = new System.Windows.Forms.Label();
            this.personelPanel = new System.Windows.Forms.Panel();
            this.masaPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.desk_stat_timer = new System.Windows.Forms.Timer(this.components);
            this.lPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.personelPanel.SuspendLayout();
            this.masaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPanel
            // 
            this.lPanel.AutoSize = true;
            this.lPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lPanel.Controls.Add(this.maximize_button);
            this.lPanel.Controls.Add(this.minimize_button);
            this.lPanel.Controls.Add(this.CancelButton);
            this.lPanel.Controls.Add(this.label8);
            this.lPanel.Controls.Add(this.lbl_personal);
            this.lPanel.Controls.Add(this.title);
            this.lPanel.Controls.Add(this.logo);
            this.lPanel.Controls.Add(this.pictureBox1);
            this.lPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lPanel.Location = new System.Drawing.Point(0, 0);
            this.lPanel.Name = "lPanel";
            this.lPanel.Size = new System.Drawing.Size(331, 720);
            this.lPanel.TabIndex = 0;
            this.lPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            // 
            // maximize_button
            // 
            this.maximize_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.maximize_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximize_button.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_button.ForeColor = System.Drawing.Color.White;
            this.maximize_button.Location = new System.Drawing.Point(45, 12);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(27, 30);
            this.maximize_button.TabIndex = 4;
            this.maximize_button.TabStop = false;
            this.maximize_button.Text = "□";
            this.maximize_button.UseVisualStyleBackColor = false;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.SeaGreen;
            this.minimize_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_button.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.Color.White;
            this.minimize_button.Location = new System.Drawing.Point(78, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(27, 30);
            this.minimize_button.TabIndex = 4;
            this.minimize_button.TabStop = false;
            this.minimize_button.Text = "_";
            this.minimize_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(12, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(27, 30);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Masa İşlemleri";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // lbl_personal
            // 
            this.lbl_personal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_personal.AutoSize = true;
            this.lbl_personal.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personal.ForeColor = System.Drawing.Color.White;
            this.lbl_personal.Location = new System.Drawing.Point(60, 338);
            this.lbl_personal.Name = "lbl_personal";
            this.lbl_personal.Size = new System.Drawing.Size(165, 25);
            this.lbl_personal.TabIndex = 3;
            this.lbl_personal.Text = "Personel İşlemleri";
            this.lbl_personal.Click += new System.EventHandler(this.label2_Click);
            this.lbl_personal.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.lbl_personal.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(57, 213);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(164, 45);
            this.title.TabIndex = 1;
            this.title.Text = "Kebab-Co";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.Home_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(65, 49);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(204, 150);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.personel_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(813, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle / Düzenle";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(153, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Yönetici olarak ayarlansın mı?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_TextUpdate);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // personel_btn
            // 
            this.personel_btn.AutoSize = true;
            this.personel_btn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personel_btn.Location = new System.Drawing.Point(18, 188);
            this.personel_btn.Name = "personel_btn";
            this.personel_btn.Size = new System.Drawing.Size(339, 29);
            this.personel_btn.TabIndex = 2;
            this.personel_btn.Text = "Kaydet";
            this.personel_btn.UseVisualStyleBackColor = true;
            this.personel_btn.Click += new System.EventHandler(this.personel_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Adı:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Şifre giriniz";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(340, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 641);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Sil";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(22, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 508);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kayıt Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(436, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Aynı isme sahip birden fazla kullanıcı eklemeniz durumunda hesaplar karışabilir. " +
    "Bu konuda sorumluluk size aittir.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbl_current_username);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbl_current_permission);
            this.groupBox3.Controls.Add(this.lbl_current_session_time);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(813, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 199);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Geçerli Kullanıcı Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Geçerli Kullanıcı Giriş:";
            // 
            // lbl_current_username
            // 
            this.lbl_current_username.AutoSize = true;
            this.lbl_current_username.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_username.Location = new System.Drawing.Point(211, 65);
            this.lbl_current_username.Name = "lbl_current_username";
            this.lbl_current_username.Size = new System.Drawing.Size(87, 20);
            this.lbl_current_username.TabIndex = 2;
            this.lbl_current_username.Text = "Placeholder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Geçerli Kullanıcı Yetkisi:";
            // 
            // lbl_current_permission
            // 
            this.lbl_current_permission.AutoSize = true;
            this.lbl_current_permission.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_permission.Location = new System.Drawing.Point(211, 98);
            this.lbl_current_permission.Name = "lbl_current_permission";
            this.lbl_current_permission.Size = new System.Drawing.Size(87, 20);
            this.lbl_current_permission.TabIndex = 2;
            this.lbl_current_permission.Text = "Placeholder";
            // 
            // lbl_current_session_time
            // 
            this.lbl_current_session_time.AutoSize = true;
            this.lbl_current_session_time.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_session_time.Location = new System.Drawing.Point(211, 132);
            this.lbl_current_session_time.Name = "lbl_current_session_time";
            this.lbl_current_session_time.Size = new System.Drawing.Size(87, 20);
            this.lbl_current_session_time.TabIndex = 2;
            this.lbl_current_session_time.Text = "Placeholder";
            // 
            // personelPanel
            // 
            this.personelPanel.AutoSize = true;
            this.personelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personelPanel.Controls.Add(this.label4);
            this.personelPanel.Controls.Add(this.groupBox3);
            this.personelPanel.Controls.Add(this.groupBox2);
            this.personelPanel.Controls.Add(this.groupBox1);
            this.personelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelPanel.Location = new System.Drawing.Point(0, 0);
            this.personelPanel.Name = "personelPanel";
            this.personelPanel.Size = new System.Drawing.Size(1280, 695);
            this.personelPanel.TabIndex = 1;
            this.personelPanel.Visible = false;
            this.personelPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            // 
            // masaPanel
            // 
            this.masaPanel.Controls.Add(this.flowLayoutPanel1);
            this.masaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masaPanel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaPanel.Location = new System.Drawing.Point(0, 0);
            this.masaPanel.Name = "masaPanel";
            this.masaPanel.Size = new System.Drawing.Size(1280, 720);
            this.masaPanel.TabIndex = 2;
            this.masaPanel.Visible = false;
            this.masaPanel.VisibleChanged += new System.EventHandler(this.masaPanel_VisibleChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(362, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(890, 393);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // desk_stat_timer
            // 
            this.desk_stat_timer.Interval = 9999;
            this.desk_stat_timer.Tick += new System.EventHandler(this.desk_stat_timer_Tick);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.lPanel);
            this.Controls.Add(this.personelPanel);
            this.Controls.Add(this.masaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            this.lPanel.ResumeLayout(false);
            this.lPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.personelPanel.ResumeLayout(false);
            this.personelPanel.PerformLayout();
            this.masaPanel.ResumeLayout(false);
            this.masaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lPanel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_personal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button personel_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_current_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_current_permission;
        private System.Windows.Forms.Label lbl_current_session_time;
        private System.Windows.Forms.Panel personelPanel;
        private System.Windows.Forms.Panel masaPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button maximize_button;
        private System.Windows.Forms.Timer desk_stat_timer;
    }
}