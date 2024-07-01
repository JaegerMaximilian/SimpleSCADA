namespace SimpleSCADA_DesktopViewer.Views
{
    partial class PasswordChangeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeView));
            btn_CloseRecipe = new Button();
            label2 = new Label();
            tbcodestärke = new TextBox();
            btn_Abort = new Button();
            btn_SaveChanges = new Button();
            pBar_strength = new ProgressBar();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            txtbVerificationNewPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtbNewPassword = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtbCurrentPassword = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            Logo = new Label();
            pic_fhlogo = new PictureBox();
            btn_Close = new Button();
            cbPasswordView = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            SuspendLayout();
            // 
            // btn_CloseRecipe
            // 
            btn_CloseRecipe.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseRecipe.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseRecipe.Image = (Image)resources.GetObject("btn_CloseRecipe.Image");
            btn_CloseRecipe.Location = new Point(1035, -172);
            btn_CloseRecipe.Margin = new Padding(3, 5, 3, 5);
            btn_CloseRecipe.Name = "btn_CloseRecipe";
            btn_CloseRecipe.Size = new Size(57, 79);
            btn_CloseRecipe.TabIndex = 59;
            btn_CloseRecipe.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(102, -75);
            label2.Name = "label2";
            label2.Size = new Size(244, 38);
            label2.TabIndex = 44;
            label2.Text = "Passwort Manager";
            // 
            // tbcodestärke
            // 
            tbcodestärke.Enabled = false;
            tbcodestärke.Location = new Point(776, 195);
            tbcodestärke.Margin = new Padding(3, 4, 3, 4);
            tbcodestärke.Name = "tbcodestärke";
            tbcodestärke.Size = new Size(100, 27);
            tbcodestärke.TabIndex = 75;
            // 
            // btn_Abort
            // 
            btn_Abort.BackColor = Color.FromArgb(0, 46, 119);
            btn_Abort.FlatStyle = FlatStyle.Flat;
            btn_Abort.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Abort.ForeColor = SystemColors.ButtonHighlight;
            btn_Abort.Location = new Point(620, 347);
            btn_Abort.Margin = new Padding(3, 4, 3, 4);
            btn_Abort.Name = "btn_Abort";
            btn_Abort.Size = new Size(150, 30);
            btn_Abort.TabIndex = 74;
            btn_Abort.Text = "Abbrechen";
            btn_Abort.UseVisualStyleBackColor = false;
            btn_Abort.Click += btn_Abort_Click;
            // 
            // btn_SaveChanges
            // 
            btn_SaveChanges.BackColor = Color.FromArgb(0, 46, 119);
            btn_SaveChanges.FlatStyle = FlatStyle.Flat;
            btn_SaveChanges.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SaveChanges.ForeColor = SystemColors.ButtonHighlight;
            btn_SaveChanges.Location = new Point(406, 347);
            btn_SaveChanges.Margin = new Padding(3, 4, 3, 4);
            btn_SaveChanges.Name = "btn_SaveChanges";
            btn_SaveChanges.Size = new Size(150, 30);
            btn_SaveChanges.TabIndex = 73;
            btn_SaveChanges.Text = "Bestätigen";
            btn_SaveChanges.UseVisualStyleBackColor = false;
            btn_SaveChanges.Click += btn_SaveChanges_Click;
            // 
            // pBar_strength
            // 
            pBar_strength.Location = new Point(650, 230);
            pBar_strength.Margin = new Padding(3, 4, 3, 4);
            pBar_strength.Name = "pBar_strength";
            pBar_strength.Size = new Size(226, 15);
            pBar_strength.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(650, 198);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 71;
            label6.Text = "Passwortstärke:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(259, 250);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 33);
            pictureBox3.TabIndex = 70;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(300, 263);
            label5.Name = "label5";
            label5.Size = new Size(200, 20);
            label5.TabIndex = 69;
            label5.Text = "neues Passwort bestätigen:";
            // 
            // txtbVerificationNewPassword
            // 
            txtbVerificationNewPassword.Location = new Point(259, 287);
            txtbVerificationNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtbVerificationNewPassword.Multiline = true;
            txtbVerificationNewPassword.Name = "txtbVerificationNewPassword";
            txtbVerificationNewPassword.Size = new Size(350, 27);
            txtbVerificationNewPassword.TabIndex = 68;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 182);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(300, 195);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 66;
            label3.Text = "neues Passwort:";
            // 
            // txtbNewPassword
            // 
            txtbNewPassword.Location = new Point(259, 219);
            txtbNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtbNewPassword.Multiline = true;
            txtbNewPassword.Name = "txtbNewPassword";
            txtbNewPassword.Size = new Size(350, 27);
            txtbNewPassword.TabIndex = 65;
            txtbNewPassword.TextChanged += txtbNewPassword_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(261, 111);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(300, 124);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 63;
            label4.Text = "aktuelles Passwort:";
            // 
            // txtbCurrentPassword
            // 
            txtbCurrentPassword.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbCurrentPassword.Location = new Point(261, 148);
            txtbCurrentPassword.Margin = new Padding(3, 4, 3, 4);
            txtbCurrentPassword.Multiline = true;
            txtbCurrentPassword.Name = "txtbCurrentPassword";
            txtbCurrentPassword.Size = new Size(350, 27);
            txtbCurrentPassword.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(248, 46);
            label1.Name = "label1";
            label1.Size = new Size(244, 38);
            label1.TabIndex = 61;
            label1.Text = "Passwort Manager";
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.BackColor = Color.FromArgb(0, 46, 119);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(pic_fhlogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 400);
            panel1.TabIndex = 60;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Logo.ForeColor = Color.White;
            Logo.Location = new Point(15, 125);
            Logo.Name = "Logo";
            Logo.Size = new Size(175, 37);
            Logo.TabIndex = 8;
            Logo.Text = "Simple Scada";
            // 
            // pic_fhlogo
            // 
            pic_fhlogo.Image = (Image)resources.GetObject("pic_fhlogo.Image");
            pic_fhlogo.Location = new Point(15, 27);
            pic_fhlogo.Margin = new Padding(3, 5, 3, 5);
            pic_fhlogo.Name = "pic_fhlogo";
            pic_fhlogo.Size = new Size(177, 93);
            pic_fhlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fhlogo.TabIndex = 2;
            pic_fhlogo.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.FromArgb(224, 224, 224);
            btn_Close.BackgroundImageLayout = ImageLayout.Center;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.ForeColor = Color.Lime;
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.Location = new Point(832, 0);
            btn_Close.Margin = new Padding(3, 5, 3, 5);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(50, 65);
            btn_Close.TabIndex = 76;
            btn_Close.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Close.UseMnemonic = false;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // cbPasswordView
            // 
            cbPasswordView.AutoSize = true;
            cbPasswordView.Location = new Point(455, 192);
            cbPasswordView.Name = "cbPasswordView";
            cbPasswordView.Size = new Size(150, 24);
            cbPasswordView.TabIndex = 77;
            cbPasswordView.Text = "Passwort anzeigen";
            cbPasswordView.UseVisualStyleBackColor = true;
            cbPasswordView.CheckedChanged += cbPasswordView_CheckedChanged;
            // 
            // PasswordChangeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(893, 400);
            Controls.Add(cbPasswordView);
            Controls.Add(btn_Close);
            Controls.Add(tbcodestärke);
            Controls.Add(btn_Abort);
            Controls.Add(btn_SaveChanges);
            Controls.Add(pBar_strength);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(txtbVerificationNewPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtbNewPassword);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(txtbCurrentPassword);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_CloseRecipe);
            Controls.Add(label2);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "PasswordChangeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordChangeView";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CloseRecipe;
        private Label label2;
        private Button btn_Abort;
        private Button btn_SaveChanges;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox txtbVerificationNewPassword;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtbNewPassword;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtbCurrentPassword;
        private Label label1;
        private Panel panel1;
        private Label Logo;
        private PictureBox pic_fhlogo;
        private Button btn_Close;
        private CheckBox cbPasswordView;
        internal TextBox tbcodestärke;
        internal ProgressBar pBar_strength;
    }
}