namespace SimpleSCADA_DesktopViewer
{
    partial class ProductionHistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionHistoryView));
            this.panel_transparent = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel_blueFH = new System.Windows.Forms.Panel();
            this.pic_fhlogo = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            this.listView_ProductionCycle = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colCustomer = new System.Windows.Forms.ColumnHeader();
            this.colRecipeName = new System.Windows.Forms.ColumnHeader();
            this.colPieces = new System.Windows.Forms.ColumnHeader();
            this.colEstimatedTime = new System.Windows.Forms.ColumnHeader();
            this.listView_Logs = new System.Windows.Forms.ListView();
            this.colLogId = new System.Windows.Forms.ColumnHeader();
            this.colLogDescription = new System.Windows.Forms.ColumnHeader();
            this.colLogProdCycleId = new System.Windows.Forms.ColumnHeader();
            this.colLogPlantState = new System.Windows.Forms.ColumnHeader();
            this.colLogStartTime = new System.Windows.Forms.ColumnHeader();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Grundaten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_transparent.SuspendLayout();
            this.panel_blueFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fhlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_transparent
            // 
            this.panel_transparent.BackColor = System.Drawing.Color.Transparent;
            this.panel_transparent.Controls.Add(this.btn_Close);
            this.panel_transparent.Location = new System.Drawing.Point(206, 0);
            this.panel_transparent.Name = "panel_transparent";
            this.panel_transparent.Size = new System.Drawing.Size(595, 45);
            this.panel_transparent.TabIndex = 63;
            this.panel_transparent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_mouse_down);
            this.panel_transparent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_move);
            this.panel_transparent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_mouse_up);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.Lime;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(551, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(44, 49);
            this.btn_Close.TabIndex = 60;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseMnemonic = false;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_blueFH
            // 
            this.panel_blueFH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.panel_blueFH.Controls.Add(this.pic_fhlogo);
            this.panel_blueFH.Controls.Add(this.Logo);
            this.panel_blueFH.Location = new System.Drawing.Point(0, 0);
            this.panel_blueFH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_blueFH.Name = "panel_blueFH";
            this.panel_blueFH.Size = new System.Drawing.Size(206, 510);
            this.panel_blueFH.TabIndex = 62;
            // 
            // pic_fhlogo
            // 
            this.pic_fhlogo.Image = ((System.Drawing.Image)(resources.GetObject("pic_fhlogo.Image")));
            this.pic_fhlogo.Location = new System.Drawing.Point(14, 16);
            this.pic_fhlogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_fhlogo.Name = "pic_fhlogo";
            this.pic_fhlogo.Size = new System.Drawing.Size(177, 92);
            this.pic_fhlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fhlogo.TabIndex = 2;
            this.pic_fhlogo.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Location = new System.Drawing.Point(14, 112);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(175, 37);
            this.Logo.TabIndex = 8;
            this.Logo.Text = "Simple Scada";
            // 
            // listView_ProductionCycle
            // 
            this.listView_ProductionCycle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colCustomer,
            this.colRecipeName,
            this.colPieces,
            this.colEstimatedTime});
            this.listView_ProductionCycle.Location = new System.Drawing.Point(228, 84);
            this.listView_ProductionCycle.Name = "listView_ProductionCycle";
            this.listView_ProductionCycle.Size = new System.Drawing.Size(548, 206);
            this.listView_ProductionCycle.TabIndex = 64;
            this.listView_ProductionCycle.UseCompatibleStateImageBehavior = false;
            this.listView_ProductionCycle.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 50;
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Kunde";
            this.colCustomer.Width = 140;
            // 
            // colRecipeName
            // 
            this.colRecipeName.Text = "Produkt";
            this.colRecipeName.Width = 160;
            // 
            // colPieces
            // 
            this.colPieces.Text = "Stückzahl";
            this.colPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPieces.Width = 80;
            // 
            // colEstimatedTime
            // 
            this.colEstimatedTime.Text = "Produkionszeit /s";
            this.colEstimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEstimatedTime.Width = 120;
            // 
            // listView_Logs
            // 
            this.listView_Logs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLogId,
            this.colLogDescription,
            this.colLogProdCycleId,
            this.colLogPlantState,
            this.colLogStartTime});
            this.listView_Logs.Location = new System.Drawing.Point(228, 330);
            this.listView_Logs.Name = "listView_Logs";
            this.listView_Logs.Size = new System.Drawing.Size(548, 168);
            this.listView_Logs.TabIndex = 65;
            this.listView_Logs.UseCompatibleStateImageBehavior = false;
            this.listView_Logs.View = System.Windows.Forms.View.Details;
            // 
            // colLogId
            // 
            this.colLogId.Text = "Id";
            this.colLogId.Width = 40;
            // 
            // colLogDescription
            // 
            this.colLogDescription.Text = "Beschreibung";
            this.colLogDescription.Width = 200;
            // 
            // colLogProdCycleId
            // 
            this.colLogProdCycleId.Text = "Auftragnr.";
            this.colLogProdCycleId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLogProdCycleId.Width = 70;
            // 
            // colLogPlantState
            // 
            this.colLogPlantState.Text = "Maschinenstatus";
            this.colLogPlantState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLogPlantState.Width = 110;
            // 
            // colLogStartTime
            // 
            this.colLogStartTime.Text = "Startzeit";
            this.colLogStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLogStartTime.Width = 120;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(666, 51);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(100, 30);
            this.btn_Refresh.TabIndex = 66;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Grundaten
            // 
            this.Grundaten.AutoSize = true;
            this.Grundaten.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Grundaten.ForeColor = System.Drawing.Color.Black;
            this.Grundaten.Location = new System.Drawing.Point(228, 51);
            this.Grundaten.Name = "Grundaten";
            this.Grundaten.Size = new System.Drawing.Size(193, 25);
            this.Grundaten.TabIndex = 67;
            this.Grundaten.Text = "Produktion-Historie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(228, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Log-Historie";
            // 
            // ProductionHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grundaten);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.listView_Logs);
            this.Controls.Add(this.listView_ProductionCycle);
            this.Controls.Add(this.panel_transparent);
            this.Controls.Add(this.panel_blueFH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionHistoryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionQueueView";
            this.panel_transparent.ResumeLayout(false);
            this.panel_blueFH.ResumeLayout(false);
            this.panel_blueFH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fhlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_transparent;
        private Button btn_Close;
        private Panel panel_blueFH;
        private PictureBox pic_fhlogo;
        private Label Logo;
        private ListView listView_ProductionCycle;
        private ListView listView_Logs;
        private Button btn_Refresh;
        private ColumnHeader colId;
        private ColumnHeader colCustomer;
        private ColumnHeader colRecipeName;
        private ColumnHeader colPieces;
        private ColumnHeader colEstimatedTime;
        private ColumnHeader colLogId;
        private ColumnHeader colLogDescription;
        private ColumnHeader colLogProdCycleId;
        private ColumnHeader colLogPlantState;
        private ColumnHeader colLogStartTime;
        private Label Grundaten;
        private Label label1;
    }
}