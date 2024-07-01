namespace SimpleSCADA_DesktopViewer
{
    partial class OEEView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OEEView));
            btn_Close = new Button();
            panel_blueFH = new Panel();
            pic_fhlogo = new PictureBox();
            Logo = new Label();
            labeltest = new Label();
            radialGauge1 = new Syncfusion.Windows.Forms.Gauge.RadialGauge();
            chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            digitalGauge1 = new Syncfusion.Windows.Forms.Gauge.DigitalGauge();
            btn_CloseWindow = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel_transparent = new Panel();
            panel_blueFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            panel_transparent.SuspendLayout();
            SuspendLayout();
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
            panel_blueFH.TabIndex = 62;
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
            // labeltest
            // 
            labeltest.AutoSize = true;
            labeltest.Location = new Point(517, 34);
            labeltest.Name = "labeltest";
            labeltest.Size = new Size(0, 15);
            labeltest.TabIndex = 65;
            // 
            // radialGauge1
            // 
            radialGauge1.ArcThickness = 2F;
            radialGauge1.BackgroundGradientStartColor = SystemColors.ButtonFace;
            radialGauge1.EnableCustomNeedles = false;
            radialGauge1.FillColor = Color.FromArgb(1, 115, 199);
            radialGauge1.FrameThickness = 12;
            radialGauge1.GaugeLabel = "Quality";
            radialGauge1.GaugeLableFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.GaugeValueFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radialGauge1.InnerFrameGradientStartColor = SystemColors.ActiveBorder;
            radialGauge1.Location = new Point(211, 118);
            radialGauge1.Margin = new Padding(2);
            radialGauge1.MaximumValue = 100F;
            radialGauge1.MinimumSize = new Size(125, 125);
            radialGauge1.Name = "radialGauge1";
            radialGauge1.RightToLeft = RightToLeft.No;
            radialGauge1.ShowTicks = true;
            radialGauge1.Size = new Size(207, 207);
            radialGauge1.TabIndex = 67;
            radialGauge1.ThemeName = "Custom";
            radialGauge1.ThemeStyle.ArcThickness = 20F;
            radialGauge1.VisualStyle = Syncfusion.Windows.Forms.Gauge.ThemeStyle.Custom;
            // 
            // chartControl1
            // 
            chartControl1.BorderAppearance.BaseColor = Color.FromArgb(78, 100, 142);
            chartControl1.BorderAppearance.Interior.ForeColor = Color.FromArgb(121, 140, 171);
            chartControl1.ChartArea.BorderColor = Color.Transparent;
            chartControl1.ChartArea.CursorLocation = new Point(0, 0);
            chartControl1.ChartArea.CursorReDraw = false;
            chartControl1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            chartControl1.Legend.Location = new Point(248, 31);
            chartControl1.Legend.Margin = new Padding(2);
            chartControl1.Localize = null;
            chartControl1.Location = new Point(432, 118);
            chartControl1.Margin = new Padding(2);
            chartControl1.Name = "chartControl1";
            chartControl1.PrimaryXAxis.ForeColor = Color.FromArgb(38, 38, 38);
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryXAxis.Margin = true;
            chartControl1.PrimaryXAxis.MinorGridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryXAxis.TickColor = Color.FromArgb(171, 171, 171);
            chartControl1.PrimaryXAxis.TitleColor = Color.FromArgb(38, 38, 38);
            chartControl1.PrimaryXAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.PrimaryYAxis.ForeColor = Color.FromArgb(38, 38, 38);
            chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            chartControl1.PrimaryYAxis.Margin = true;
            chartControl1.PrimaryYAxis.MinorGridLineType.ForeColor = Color.FromArgb(225, 225, 225);
            chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0D, 100D, 10D);
            chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            chartControl1.PrimaryYAxis.TickColor = Color.FromArgb(171, 171, 171);
            chartControl1.PrimaryYAxis.TitleColor = Color.FromArgb(38, 38, 38);
            chartControl1.PrimaryYAxis.TitleFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.RightToLeft = RightToLeft.No;
            chartControl1.Size = new Size(357, 258);
            chartControl1.Skins = Syncfusion.Windows.Forms.Chart.Skins.VS2010;
            chartControl1.Style3D = true;
            chartControl1.TabIndex = 68;
            // 
            // 
            // 
            chartControl1.Title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            chartControl1.Title.Name = "Default";
            chartControl1.VisualTheme = "";
            // 
            // digitalGauge1
            // 
            digitalGauge1.DisplayRecordIndex = 0;
            digitalGauge1.Location = new Point(581, 381);
            digitalGauge1.MaximumSize = new Size(500, 180);
            digitalGauge1.MinimumSize = new Size(90, 90);
            digitalGauge1.Name = "digitalGauge1";
            digitalGauge1.Size = new Size(90, 90);
            digitalGauge1.TabIndex = 69;
            // 
            // btn_CloseWindow
            // 
            btn_CloseWindow.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseWindow.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseWindow.FlatAppearance.BorderSize = 0;
            btn_CloseWindow.FlatStyle = FlatStyle.Flat;
            btn_CloseWindow.ForeColor = Color.Lime;
            btn_CloseWindow.Image = (Image)resources.GetObject("btn_CloseWindow.Image");
            btn_CloseWindow.Location = new Point(551, 0);
            btn_CloseWindow.Margin = new Padding(3, 4, 3, 4);
            btn_CloseWindow.Name = "btn_CloseWindow";
            btn_CloseWindow.Size = new Size(44, 45);
            btn_CloseWindow.TabIndex = 84;
            btn_CloseWindow.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CloseWindow.UseMnemonic = false;
            btn_CloseWindow.UseVisualStyleBackColor = true;
            btn_CloseWindow.Click += btn_CloseWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(226, 34);
            label2.Name = "label2";
            label2.Size = new Size(76, 38);
            label2.TabIndex = 85;
            label2.Text = "OEE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(222, 406);
            label1.Name = "label1";
            label1.Size = new Size(332, 50);
            label1.TabIndex = 86;
            label1.Text = "Durchschnitt von Leistungseffizienz \r\nder letzten Woche in Prozent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(212, 91);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 87;
            label3.Text = "Heutige Qualitätsrate ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(477, 91);
            label4.Name = "label4";
            label4.Size = new Size(291, 25);
            label4.TabIndex = 88;
            label4.Text = "Leistungseffizienz diese Woche ";
            // 
            // panel_transparent
            // 
            panel_transparent.BackColor = Color.Transparent;
            panel_transparent.Controls.Add(btn_CloseWindow);
            panel_transparent.Location = new Point(206, 0);
            panel_transparent.Name = "panel_transparent";
            panel_transparent.Size = new Size(595, 45);
            panel_transparent.TabIndex = 89;
            panel_transparent.MouseDown += panel_mouse_down;
            panel_transparent.MouseMove += panel_move;
            panel_transparent.MouseUp += panel_mouse_up;
            // 
            // OEEView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 482);
            Controls.Add(panel_transparent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(digitalGauge1);
            Controls.Add(chartControl1);
            Controls.Add(radialGauge1);
            Controls.Add(labeltest);
            Controls.Add(panel_blueFH);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OEEView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OEEView";
            Load += OEEView_Load;
            panel_blueFH.ResumeLayout(false);
            panel_blueFH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            panel_transparent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Close;
        private Panel panel_blueFH;
        private PictureBox pic_fhlogo;
        private Label Logo;
        internal Label labeltest;
        internal Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
        internal Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        internal Syncfusion.Windows.Forms.Gauge.DigitalGauge digitalGauge1;
        private Button btn_CloseWindow;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel_transparent;
    }
}