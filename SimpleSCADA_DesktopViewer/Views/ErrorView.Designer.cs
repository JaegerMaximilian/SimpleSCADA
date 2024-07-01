namespace SimpleSCADA_DesktopViewer
{
    partial class ErrorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorView));
            panel_blueFH = new Panel();
            pic_fhlogo = new PictureBox();
            Logo = new Label();
            btn_Close = new Button();
            panel_transparent = new Panel();
            ErrorListView = new ListView();
            colId = new ColumnHeader();
            colDescription = new ColumnHeader();
            colErrorType = new ColumnHeader();
            colSeverity = new ColumnHeader();
            colLogDecription = new ColumnHeader();
            colLogPlantState = new ColumnHeader();
            colTimeOcurred = new ColumnHeader();
            colTimeFixed = new ColumnHeader();
            btn_Refresh = new Button();
            panel_blueFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            panel_transparent.SuspendLayout();
            SuspendLayout();
            // 
            // panel_blueFH
            // 
            panel_blueFH.BackColor = Color.FromArgb(0, 46, 119);
            panel_blueFH.Controls.Add(pic_fhlogo);
            panel_blueFH.Controls.Add(Logo);
            panel_blueFH.Location = new Point(0, 0);
            panel_blueFH.Margin = new Padding(3, 4, 3, 4);
            panel_blueFH.Name = "panel_blueFH";
            panel_blueFH.Size = new Size(206, 510);
            panel_blueFH.TabIndex = 8;
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
            // btn_Close
            // 
            btn_Close.BackColor = Color.FromArgb(224, 224, 224);
            btn_Close.BackgroundImageLayout = ImageLayout.Center;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.ForeColor = Color.Lime;
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.Location = new Point(551, 0);
            btn_Close.Margin = new Padding(3, 4, 3, 4);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(44, 49);
            btn_Close.TabIndex = 60;
            btn_Close.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Close.UseMnemonic = false;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // panel_transparent
            // 
            panel_transparent.BackColor = Color.Transparent;
            panel_transparent.Controls.Add(btn_Close);
            panel_transparent.Location = new Point(206, 0);
            panel_transparent.Name = "panel_transparent";
            panel_transparent.Size = new Size(595, 45);
            panel_transparent.TabIndex = 61;
            panel_transparent.MouseDown += panel_mouse_down;
            panel_transparent.MouseMove += panel_move;
            panel_transparent.MouseUp += panel_mouse_up;
            // 
            // ErrorListView
            // 
            ErrorListView.Columns.AddRange(new ColumnHeader[] { colId, colDescription, colErrorType, colSeverity, colLogDecription, colLogPlantState, colTimeOcurred, colTimeFixed });
            ErrorListView.Location = new Point(212, 92);
            ErrorListView.Name = "ErrorListView";
            ErrorListView.Size = new Size(576, 406);
            ErrorListView.TabIndex = 63;
            ErrorListView.UseCompatibleStateImageBehavior = false;
            ErrorListView.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "Nr";
            colId.Width = 30;
            // 
            // colDescription
            // 
            colDescription.Text = "Beschreibung";
            colDescription.Width = 100;
            // 
            // colErrorType
            // 
            colErrorType.Text = "Fehlerart";
            colErrorType.Width = 80;
            // 
            // colSeverity
            // 
            colSeverity.Text = "Schwere";
            // 
            // colLogDecription
            // 
            colLogDecription.Text = "Logbeschreibung";
            colLogDecription.Width = 80;
            // 
            // colLogPlantState
            // 
            colLogPlantState.Text = "Anlagenstatus";
            colLogPlantState.Width = 70;
            // 
            // colTimeOcurred
            // 
            colTimeOcurred.Text = "Zeit Aufgetreten";
            colTimeOcurred.Width = 90;
            // 
            // colTimeFixed
            // 
            colTimeFixed.Text = "Zeit Behoben";
            colTimeFixed.Width = 90;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.FromArgb(0, 46, 119);
            btn_Refresh.FlatStyle = FlatStyle.Flat;
            btn_Refresh.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Refresh.ForeColor = SystemColors.ButtonHighlight;
            btn_Refresh.Location = new Point(648, 51);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(112, 30);
            btn_Refresh.TabIndex = 65;
            btn_Refresh.Text = "Aktualisieren";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // ErrorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 510);
            ControlBox = false;
            Controls.Add(btn_Refresh);
            Controls.Add(ErrorListView);
            Controls.Add(panel_transparent);
            Controls.Add(panel_blueFH);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorView";
            panel_blueFH.ResumeLayout(false);
            panel_blueFH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            panel_transparent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_blueFH;
        private Label Logo;
        private PictureBox pic_fhlogo;
        private Button btn_Close;
        private Panel panel_transparent;
        private ListView ErrorListView;
        private Button btn_Refresh;
        private ColumnHeader colId;
        private ColumnHeader colDescription;
        private ColumnHeader colErrorType;
        private ColumnHeader colSeverity;
        private ColumnHeader colLogDecription;
        private ColumnHeader colLogPlantState;
        private ColumnHeader colTimeOcurred;
        private ColumnHeader colTimeFixed;
    }
}