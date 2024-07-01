namespace SimpleSCADA_DesktopViewer
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            btn_CloseRecipe = new Button();
            btn_LogIn = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtbPassword = new TextBox();
            txtbUserName = new TextBox();
            pictureBox1 = new PictureBox();
            Grundaten = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pic_fhlogo = new PictureBox();
            btn_Close = new Button();
            cbPasswordView = new CheckBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            SuspendLayout();
            // 
            // btn_CloseRecipe
            // 
            btn_CloseRecipe.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseRecipe.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseRecipe.Image = (Image)resources.GetObject("btn_CloseRecipe.Image");
            btn_CloseRecipe.Location = new Point(873, -86);
            btn_CloseRecipe.Margin = new Padding(3, 4, 3, 4);
            btn_CloseRecipe.Name = "btn_CloseRecipe";
            btn_CloseRecipe.Size = new Size(50, 59);
            btn_CloseRecipe.TabIndex = 29;
            btn_CloseRecipe.UseVisualStyleBackColor = false;
            // 
            // btn_LogIn
            // 
            btn_LogIn.BackColor = Color.FromArgb(0, 46, 119);
            btn_LogIn.FlatStyle = FlatStyle.Flat;
            btn_LogIn.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LogIn.ForeColor = SystemColors.ButtonHighlight;
            btn_LogIn.Location = new Point(293, 260);
            btn_LogIn.Name = "btn_LogIn";
            btn_LogIn.Size = new Size(150, 30);
            btn_LogIn.TabIndex = 39;
            btn_LogIn.Text = "Log in";
            btn_LogIn.UseVisualStyleBackColor = false;
            btn_LogIn.Click += btn_LogIn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(214, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 40);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(261, 171);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 37;
            label4.Text = "Passwort:";
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(214, 208);
            txtbPassword.Multiline = true;
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(300, 27);
            txtbPassword.TabIndex = 36;
            txtbPassword.KeyDown += txtbPasswordKeyDown;
            // 
            // txtbUserName
            // 
            txtbUserName.Cursor = Cursors.No;
            txtbUserName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbUserName.Location = new Point(214, 131);
            txtbUserName.Multiline = true;
            txtbUserName.Name = "txtbUserName";
            txtbUserName.Size = new Size(300, 27);
            txtbUserName.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Grundaten
            // 
            Grundaten.AutoSize = true;
            Grundaten.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Grundaten.ForeColor = Color.Black;
            Grundaten.Location = new Point(261, 98);
            Grundaten.Name = "Grundaten";
            Grundaten.Size = new Size(84, 20);
            Grundaten.TabIndex = 33;
            Grundaten.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 221);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(214, 35);
            label2.Name = "label2";
            label2.Size = new Size(144, 38);
            label2.TabIndex = 31;
            label2.Text = "Anmelden";
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.BackColor = Color.FromArgb(0, 46, 119);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pic_fhlogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 319);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 162);
            label1.Name = "label1";
            label1.Size = new Size(175, 74);
            label1.TabIndex = 9;
            label1.Text = "Welcome to\r\nSimple Scada";
            // 
            // pic_fhlogo
            // 
            pic_fhlogo.Image = (Image)resources.GetObject("pic_fhlogo.Image");
            pic_fhlogo.Location = new Point(12, 58);
            pic_fhlogo.Margin = new Padding(3, 4, 3, 4);
            pic_fhlogo.Name = "pic_fhlogo";
            pic_fhlogo.Size = new Size(168, 100);
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
            btn_Close.Location = new Point(512, 0);
            btn_Close.Margin = new Padding(3, 4, 3, 4);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(44, 49);
            btn_Close.TabIndex = 40;
            btn_Close.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Close.UseMnemonic = false;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // cbPasswordView
            // 
            cbPasswordView.AutoSize = true;
            cbPasswordView.Location = new Point(390, 174);
            cbPasswordView.Name = "cbPasswordView";
            cbPasswordView.Size = new Size(123, 19);
            cbPasswordView.TabIndex = 41;
            cbPasswordView.Text = "Passwort anzeigen";
            cbPasswordView.UseVisualStyleBackColor = true;
            cbPasswordView.CheckedChanged += cbPasswordView_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(391, 102);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 42;
            label5.Text = "Vorname.Nachname";
            // 
            // LogView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(560, 319);
            Controls.Add(label5);
            Controls.Add(cbPasswordView);
            Controls.Add(btn_Close);
            Controls.Add(btn_LogIn);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(txtbPassword);
            Controls.Add(txtbUserName);
            Controls.Add(pictureBox1);
            Controls.Add(Grundaten);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_CloseRecipe);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "LogView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogView";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CloseRecipe;
        private Button btn_LogIn;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox txtbPassword;
        private TextBox txtbUserName;
        private PictureBox pictureBox1;
        private Label Grundaten;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pic_fhlogo;
        private Button btn_Close;
        private CheckBox cbPasswordView;
        private Label label5;
    }
}