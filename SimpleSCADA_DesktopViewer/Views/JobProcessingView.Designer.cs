namespace SimpleSCADA_DesktopViewer.Views
{
    partial class JobProcessingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobProcessingView));
            label8 = new Label();
            btn_Abort = new Button();
            btn_Save = new Button();
            cbFertigungsrezept = new ComboBox();
            tbAnzahl = new TextBox();
            tbKunde = new TextBox();
            tbAuftragsnummer = new TextBox();
            tbAuftragsname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            cboxAuftrag = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            Logo = new Label();
            pic_fhlogo = new PictureBox();
            btn_Load = new Button();
            btn_CloseJobs = new Button();
            panel_transparent = new Panel();
            btn_Delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            panel_transparent.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(226, 120);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 58;
            label8.Text = "Auftragsdaten";
            // 
            // btn_Abort
            // 
            btn_Abort.BackColor = Color.FromArgb(0, 46, 119);
            btn_Abort.FlatStyle = FlatStyle.Flat;
            btn_Abort.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Abort.ForeColor = SystemColors.ButtonHighlight;
            btn_Abort.Location = new Point(597, 457);
            btn_Abort.Name = "btn_Abort";
            btn_Abort.Size = new Size(150, 30);
            btn_Abort.TabIndex = 57;
            btn_Abort.Text = "Abbrechen";
            btn_Abort.UseVisualStyleBackColor = false;
            btn_Abort.Click += btn_Abort_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(0, 46, 119);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.ForeColor = SystemColors.ButtonHighlight;
            btn_Save.Location = new Point(226, 457);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 30);
            btn_Save.TabIndex = 56;
            btn_Save.Text = "Speichern";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // cbFertigungsrezept
            // 
            cbFertigungsrezept.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFertigungsrezept.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbFertigungsrezept.FormattingEnabled = true;
            cbFertigungsrezept.Location = new Point(423, 385);
            cbFertigungsrezept.Name = "cbFertigungsrezept";
            cbFertigungsrezept.Size = new Size(252, 28);
            cbFertigungsrezept.TabIndex = 55;
            // 
            // tbAnzahl
            // 
            tbAnzahl.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbAnzahl.Location = new Point(423, 331);
            tbAnzahl.Name = "tbAnzahl";
            tbAnzahl.Size = new Size(252, 27);
            tbAnzahl.TabIndex = 54;
            // 
            // tbKunde
            // 
            tbKunde.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbKunde.Location = new Point(423, 277);
            tbKunde.Name = "tbKunde";
            tbKunde.Size = new Size(252, 27);
            tbKunde.TabIndex = 53;
            // 
            // tbAuftragsnummer
            // 
            tbAuftragsnummer.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbAuftragsnummer.Location = new Point(423, 223);
            tbAuftragsnummer.Name = "tbAuftragsnummer";
            tbAuftragsnummer.ReadOnly = true;
            tbAuftragsnummer.Size = new Size(252, 27);
            tbAuftragsnummer.TabIndex = 52;
            // 
            // tbAuftragsname
            // 
            tbAuftragsname.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbAuftragsname.Location = new Point(423, 170);
            tbAuftragsname.Name = "tbAuftragsname";
            tbAuftragsname.ReadOnly = true;
            tbAuftragsname.Size = new Size(252, 27);
            tbAuftragsname.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(226, 277);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 50;
            label7.Text = "Kunde:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(226, 385);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 49;
            label6.Text = "Fertigungsrezept:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(226, 331);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 48;
            label5.Text = "Anzahl:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(226, 223);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 47;
            label3.Text = "Auftragsnummer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(226, 170);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 46;
            label1.Text = "Auftragsname:";
            // 
            // cboxAuftrag
            // 
            cboxAuftrag.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxAuftrag.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAuftrag.FormattingEnabled = true;
            cboxAuftrag.ItemHeight = 20;
            cboxAuftrag.Location = new Point(226, 74);
            cboxAuftrag.Name = "cboxAuftrag";
            cboxAuftrag.Size = new Size(351, 28);
            cboxAuftrag.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(226, 24);
            label2.Name = "label2";
            label2.Size = new Size(278, 38);
            label2.TabIndex = 42;
            label2.Text = "Auftragsbearbeitung:";
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
            panel1.Size = new Size(206, 511);
            panel1.TabIndex = 41;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Nirmala UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Logo.ForeColor = Color.White;
            Logo.Location = new Point(14, 122);
            Logo.Name = "Logo";
            Logo.Size = new Size(175, 37);
            Logo.TabIndex = 8;
            Logo.Text = "Simple Scada";
            // 
            // pic_fhlogo
            // 
            pic_fhlogo.Image = (Image)resources.GetObject("pic_fhlogo.Image");
            pic_fhlogo.Location = new Point(12, 24);
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
            btn_Load.Location = new Point(597, 74);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(100, 30);
            btn_Load.TabIndex = 45;
            btn_Load.Text = "Laden";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // btn_CloseJobs
            // 
            btn_CloseJobs.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseJobs.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseJobs.FlatAppearance.BorderSize = 0;
            btn_CloseJobs.FlatStyle = FlatStyle.Flat;
            btn_CloseJobs.ForeColor = Color.Lime;
            btn_CloseJobs.Image = (Image)resources.GetObject("btn_CloseJobs.Image");
            btn_CloseJobs.Location = new Point(536, 0);
            btn_CloseJobs.Margin = new Padding(3, 4, 3, 4);
            btn_CloseJobs.Name = "btn_CloseJobs";
            btn_CloseJobs.Size = new Size(44, 49);
            btn_CloseJobs.TabIndex = 59;
            btn_CloseJobs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CloseJobs.UseMnemonic = false;
            btn_CloseJobs.UseVisualStyleBackColor = true;
            btn_CloseJobs.Click += btn_CloseJobs_Click;
            // 
            // panel_transparent
            // 
            panel_transparent.BackColor = Color.Transparent;
            panel_transparent.Controls.Add(btn_CloseJobs);
            panel_transparent.Location = new Point(206, 0);
            panel_transparent.Name = "panel_transparent";
            panel_transparent.Size = new Size(580, 45);
            panel_transparent.TabIndex = 62;
            panel_transparent.MouseDown += panel_mouse_down;
            panel_transparent.MouseMove += panel_move;
            panel_transparent.MouseUp += panel_mouse_up;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(0, 46, 119);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.ForeColor = SystemColors.ButtonHighlight;
            btn_Delete.Location = new Point(412, 457);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(150, 30);
            btn_Delete.TabIndex = 63;
            btn_Delete.Text = "Stornieren";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // JobProcessingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(784, 511);
            Controls.Add(btn_Delete);
            Controls.Add(label2);
            Controls.Add(panel_transparent);
            Controls.Add(label8);
            Controls.Add(btn_Abort);
            Controls.Add(btn_Save);
            Controls.Add(cbFertigungsrezept);
            Controls.Add(tbAnzahl);
            Controls.Add(tbKunde);
            Controls.Add(tbAuftragsnummer);
            Controls.Add(tbAuftragsname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cboxAuftrag);
            Controls.Add(panel1);
            Controls.Add(btn_Load);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JobProcessingView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JobProcessingView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            panel_transparent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Button btn_Abort;
        private Button btn_Save;
        private ComboBox cbFertigungsrezept;
        private TextBox tbAnzahl;
        private TextBox tbKunde;
        private TextBox tbAuftragsnummer;
        private TextBox tbAuftragsname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private ComboBox cboxAuftrag;
        private Label label2;
        private Panel panel1;
        private Label Logo;
        private PictureBox pic_fhlogo;
        private Button btn_Load;
        private Button btn_CloseJobs;
        private Panel panel_transparent;
        private Button btn_Delete;
    }
}