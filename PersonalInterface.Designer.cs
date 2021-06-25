
namespace RestaurantOtomasyonV1
{
    partial class PersonalInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInterface));
            this.lpanel = new System.Windows.Forms.Panel();
            this.maximize_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.minimize_button = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rpanel = new System.Windows.Forms.Panel();
            this.masa_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.desk_stat_timer = new System.Windows.Forms.Timer(this.components);
            this.lpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lpanel
            // 
            this.lpanel.Controls.Add(this.maximize_button);
            this.lpanel.Controls.Add(this.label2);
            this.lpanel.Controls.Add(this.minimize_button);
            this.lpanel.Controls.Add(this.CancelButton);
            this.lpanel.Controls.Add(this.label1);
            this.lpanel.Controls.Add(this.pictureBox1);
            this.lpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lpanel.Location = new System.Drawing.Point(0, 0);
            this.lpanel.Name = "lpanel";
            this.lpanel.Size = new System.Drawing.Size(264, 720);
            this.lpanel.TabIndex = 0;
            this.lpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            // 
            // maximize_button
            // 
            this.maximize_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.maximize_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximize_button.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_button.ForeColor = System.Drawing.Color.White;
            this.maximize_button.Location = new System.Drawing.Point(78, 12);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(27, 30);
            this.maximize_button.TabIndex = 5;
            this.maximize_button.TabStop = false;
            this.maximize_button.Text = "□";
            this.maximize_button.UseVisualStyleBackColor = false;
            this.maximize_button.Click += new System.EventHandler(this.maximize_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kebab-Co";
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.SeaGreen;
            this.minimize_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_button.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.Color.White;
            this.minimize_button.Location = new System.Drawing.Point(45, 12);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(27, 30);
            this.minimize_button.TabIndex = 6;
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
            this.CancelButton.TabIndex = 7;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masalar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantOtomasyonV1.Resource1.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rpanel
            // 
            this.rpanel.BackColor = System.Drawing.Color.White;
            this.rpanel.Controls.Add(this.masa_panel);
            this.rpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpanel.Location = new System.Drawing.Point(264, 0);
            this.rpanel.Name = "rpanel";
            this.rpanel.Size = new System.Drawing.Size(1016, 720);
            this.rpanel.TabIndex = 1;
            this.rpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            // 
            // masa_panel
            // 
            this.masa_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masa_panel.Location = new System.Drawing.Point(0, 0);
            this.masa_panel.Name = "masa_panel";
            this.masa_panel.Size = new System.Drawing.Size(1016, 720);
            this.masa_panel.TabIndex = 0;
            this.masa_panel.Visible = false;
            this.masa_panel.VisibleChanged += new System.EventHandler(this.masa_panel_VisibleChanged);
            // 
            // desk_stat_timer
            // 
            this.desk_stat_timer.Interval = 9999;
            this.desk_stat_timer.Tick += new System.EventHandler(this.desk_stat_timer_Tick);
            // 
            // PersonalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.rpanel);
            this.Controls.Add(this.lpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalInterface";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminInterface_MouseDown);
            this.lpanel.ResumeLayout(false);
            this.lpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lpanel;
        private System.Windows.Forms.Panel rpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel masa_panel;
        private System.Windows.Forms.Timer desk_stat_timer;
        private System.Windows.Forms.Button maximize_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button CancelButton;
    }
}