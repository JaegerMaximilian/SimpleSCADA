namespace SimpleSCADA_DesktopViewer
{
    partial class UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            cbox_usersExisting = new ComboBox();
            button4 = new Button();
            btn_Delete = new Button();
            btn_Save = new Button();
            cbox_premission = new ComboBox();
            txtb_initalPassword = new TextBox();
            txtb_lastName = new TextBox();
            txtb_firstName = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            Logo = new Label();
            pic_fhlogo = new PictureBox();
            btn_Load = new Button();
            Rezeptbearbeitung = new Label();
            btn_Abort = new Button();
            label6 = new Label();
            btn_CloseWindow = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            SuspendLayout();
            // 
            // cbox_usersExisting
            // 
            cbox_usersExisting.AllowDrop = true;
            cbox_usersExisting.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_usersExisting.FormattingEnabled = true;
            cbox_usersExisting.Location = new Point(232, 88);
            cbox_usersExisting.Name = "cbox_usersExisting";
            cbox_usersExisting.Size = new Size(310, 28);
            cbox_usersExisting.TabIndex = 62;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Lime;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(880, -107);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(44, 49);
            button4.TabIndex = 78;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(0, 46, 119);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.ForeColor = SystemColors.ButtonHighlight;
            btn_Delete.Location = new Point(439, 389);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(150, 30);
            btn_Delete.TabIndex = 76;
            btn_Delete.Text = "Löschen";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(0, 46, 119);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.ForeColor = SystemColors.ButtonHighlight;
            btn_Save.ImageAlign = ContentAlignment.BottomLeft;
            btn_Save.Location = new Point(266, 389);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 30);
            btn_Save.TabIndex = 75;
            btn_Save.Text = "Speichern";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // cbox_premission
            // 
            cbox_premission.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_premission.FormattingEnabled = true;
            cbox_premission.Location = new Point(382, 331);
            cbox_premission.Name = "cbox_premission";
            cbox_premission.Size = new Size(300, 28);
            cbox_premission.TabIndex = 74;
            // 
            // txtb_initalPassword
            // 
            txtb_initalPassword.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_initalPassword.Location = new Point(382, 285);
            txtb_initalPassword.Name = "txtb_initalPassword";
            txtb_initalPassword.Size = new Size(300, 27);
            txtb_initalPassword.TabIndex = 73;
            // 
            // txtb_lastName
            // 
            txtb_lastName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_lastName.Location = new Point(382, 236);
            txtb_lastName.Name = "txtb_lastName";
            txtb_lastName.Size = new Size(300, 27);
            txtb_lastName.TabIndex = 72;
            // 
            // txtb_firstName
            // 
            txtb_firstName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtb_firstName.Location = new Point(382, 188);
            txtb_firstName.Name = "txtb_firstName";
            txtb_firstName.Size = new Size(300, 27);
            txtb_firstName.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(226, 288);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 69;
            label7.Text = "Initiales Passwort:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(226, 334);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 67;
            label5.Text = "Rechte:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(226, 239);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 66;
            label3.Text = "Nachname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(226, 191);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 65;
            label1.Text = "Vorname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(450, -73);
            label2.Name = "label2";
            label2.Size = new Size(272, 38);
            label2.TabIndex = 61;
            label2.Text = "Auftragsbearbeitung";
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.BackColor = Color.FromArgb(0, 46, 119);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(pic_fhlogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 439);
            panel1.TabIndex = 60;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Logo.ForeColor = Color.White;
            Logo.Location = new Point(14, 112);
            Logo.Name = "Logo";
            Logo.Size = new Size(175, 37);
            Logo.TabIndex = 8;
            Logo.Text = "Simple Scada";
            // 
            // pic_fhlogo
            // 
            pic_fhlogo.Image = (Image)resources.GetObject("pic_fhlogo.Image");
            pic_fhlogo.Location = new Point(14, 16);
            pic_fhlogo.Margin = new Padding(3, 4, 3, 4);
            pic_fhlogo.Name = "pic_fhlogo";
            pic_fhlogo.Size = new Size(177, 92);
            pic_fhlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fhlogo.TabIndex = 2;
            pic_fhlogo.TabStop = false;
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.FromArgb(0, 46, 119);
            btn_Load.FlatStyle = FlatStyle.Flat;
            btn_Load.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Load.ForeColor = SystemColors.ButtonHighlight;
            btn_Load.Location = new Point(560, 88);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(100, 30);
            btn_Load.TabIndex = 64;
            btn_Load.Text = "Laden";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // Rezeptbearbeitung
            // 
            Rezeptbearbeitung.AutoSize = true;
            Rezeptbearbeitung.Font = new Font("Nirmala UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Rezeptbearbeitung.ForeColor = Color.Black;
            Rezeptbearbeitung.Location = new Point(213, 35);
            Rezeptbearbeitung.Name = "Rezeptbearbeitung";
            Rezeptbearbeitung.Size = new Size(258, 40);
            Rezeptbearbeitung.TabIndex = 80;
            Rezeptbearbeitung.Text = "Benutzer Manager:";
            // 
            // btn_Abort
            // 
            btn_Abort.BackColor = Color.FromArgb(0, 46, 119);
            btn_Abort.FlatStyle = FlatStyle.Flat;
            btn_Abort.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Abort.ForeColor = SystemColors.ButtonHighlight;
            btn_Abort.Location = new Point(614, 389);
            btn_Abort.Name = "btn_Abort";
            btn_Abort.Size = new Size(150, 30);
            btn_Abort.TabIndex = 81;
            btn_Abort.Text = "Abrechen";
            btn_Abort.UseVisualStyleBackColor = false;
            btn_Abort.Click += btn_Abort_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(226, 132);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 82;
            label6.Text = "Benutzerdaten";
            // 
            // btn_CloseWindow
            // 
            btn_CloseWindow.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseWindow.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseWindow.FlatAppearance.BorderSize = 0;
            btn_CloseWindow.FlatStyle = FlatStyle.Flat;
            btn_CloseWindow.ForeColor = Color.Lime;
            btn_CloseWindow.Image = (Image)resources.GetObject("btn_CloseWindow.Image");
            btn_CloseWindow.Location = new Point(768, 0);
            btn_CloseWindow.Margin = new Padding(3, 4, 3, 4);
            btn_CloseWindow.Name = "btn_CloseWindow";
            btn_CloseWindow.Size = new Size(44, 49);
            btn_CloseWindow.TabIndex = 83;
            btn_CloseWindow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CloseWindow.UseMnemonic = false;
            btn_CloseWindow.UseVisualStyleBackColor = true;
            btn_CloseWindow.Click += btn_CloseWindow_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(821, 439);
            Controls.Add(btn_CloseWindow);
            Controls.Add(label6);
            Controls.Add(btn_Abort);
            Controls.Add(Rezeptbearbeitung);
            Controls.Add(button4);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Save);
            Controls.Add(cbox_premission);
            Controls.Add(txtb_initalPassword);
            Controls.Add(txtb_lastName);
            Controls.Add(txtb_firstName);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbox_usersExisting);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_Load);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button btn_Delete;
        private Button btn_Save;
        private ComboBox cbox_premission;
        private TextBox txtb_initalPassword;
        private TextBox txtb_lastName;
        private TextBox txtb_firstName;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label4;
        private ComboBox cbNeuerbenuter;
        private Label label2;
        private Panel panel1;
        private Label Logo;
        private PictureBox pic_fhlogo;
        private Button butLadenBM;
        private Label Rezeptbearbeitung;
        private Button btn_Abort;
        private Label label6;
        private Button button6;
        private Button btn_Load;
        private Button btn_CloseWindow;
        public ComboBox cbox_usersExisting;
    }
}