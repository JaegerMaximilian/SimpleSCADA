namespace SimpleSCADA_DesktopViewer
{
    partial class RecipeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeView));
            btn_CloseRecipe = new Button();
            panel1 = new Panel();
            Logo = new Label();
            pic_fhlogo = new PictureBox();
            Rezeptbearbeitung = new Label();
            btn_Load = new Button();
            Grundaten = new Label();
            Rezeptname = new Label();
            Rezeptnummer = new Label();
            Ablauf = new Label();
            txtb_recipename = new TextBox();
            txtb_recipeNumber = new TextBox();
            inkl = new Label();
            Konfiguration = new Label();
            Timeestimated = new Label();
            order = new Label();
            cbox_recipeExisting = new ComboBox();
            cb_station2 = new CheckBox();
            Station2 = new Label();
            txtb_EstimatedTime2 = new TextBox();
            cbox_ConfigStation2 = new ComboBox();
            cbox_OrderStation2 = new ComboBox();
            grp_Station2 = new GroupBox();
            cb_station3 = new CheckBox();
            Station3 = new Label();
            txtb_EstimatedTime3 = new TextBox();
            cbox_ConfigStation3 = new ComboBox();
            cbox_OrderStation3 = new ComboBox();
            grp_Station3 = new GroupBox();
            cb_station4 = new CheckBox();
            Station4 = new Label();
            txtb_EstimatedTime4 = new TextBox();
            cbox_ConfigStation4 = new ComboBox();
            cbox_OrderStation4 = new ComboBox();
            grp_Station4 = new GroupBox();
            cb_station5 = new CheckBox();
            Station5 = new Label();
            txtb_EstimatedTime5 = new TextBox();
            cbox_ConfigStation5 = new ComboBox();
            cbox_OrderStation5 = new ComboBox();
            grp_Station5 = new GroupBox();
            cb_station6 = new CheckBox();
            Station6 = new Label();
            txtb_EstimatedTime6 = new TextBox();
            cbox_ConfigStation6 = new ComboBox();
            cbox_OrderStation6 = new ComboBox();
            grp_Station6 = new GroupBox();
            line = new Label();
            Zuschlag = new Label();
            label5 = new Label();
            label6 = new Label();
            Gesamtdauer = new Label();
            txtb_EstimatedTimeDrive = new TextBox();
            txtb_EstimatedTimeAll = new TextBox();
            label7 = new Label();
            btn_Save = new Button();
            btn_Delete = new Button();
            btn_Abort = new Button();
            cb_station1 = new CheckBox();
            Station1 = new Label();
            txtb_EstimatedTime1 = new TextBox();
            cbox_ConfigStation1 = new ComboBox();
            cbox_OrderStation1 = new ComboBox();
            grp_Station1 = new GroupBox();
            panel_transparent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            grp_Station2.SuspendLayout();
            grp_Station3.SuspendLayout();
            grp_Station4.SuspendLayout();
            grp_Station5.SuspendLayout();
            grp_Station6.SuspendLayout();
            grp_Station1.SuspendLayout();
            panel_transparent.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CloseRecipe
            // 
            btn_CloseRecipe.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseRecipe.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseRecipe.FlatAppearance.BorderSize = 0;
            btn_CloseRecipe.FlatStyle = FlatStyle.Flat;
            btn_CloseRecipe.ForeColor = Color.Lime;
            btn_CloseRecipe.Image = (Image)resources.GetObject("btn_CloseRecipe.Image");
            btn_CloseRecipe.Location = new Point(889, 0);
            btn_CloseRecipe.Margin = new Padding(3, 4, 3, 4);
            btn_CloseRecipe.Name = "btn_CloseRecipe";
            btn_CloseRecipe.Size = new Size(44, 45);
            btn_CloseRecipe.TabIndex = 5;
            btn_CloseRecipe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CloseRecipe.UseMnemonic = false;
            btn_CloseRecipe.UseVisualStyleBackColor = true;
            btn_CloseRecipe.Click += btn_CloseRecipe_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 46, 119);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(pic_fhlogo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 1000);
            panel1.TabIndex = 7;
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
            // Rezeptbearbeitung
            // 
            Rezeptbearbeitung.AutoSize = true;
            Rezeptbearbeitung.Font = new Font("Nirmala UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Rezeptbearbeitung.ForeColor = Color.Black;
            Rezeptbearbeitung.Location = new Point(213, 35);
            Rezeptbearbeitung.Name = "Rezeptbearbeitung";
            Rezeptbearbeitung.Size = new Size(264, 40);
            Rezeptbearbeitung.TabIndex = 8;
            Rezeptbearbeitung.Text = "Rezeptbearbeitung:";
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.FromArgb(0, 46, 119);
            btn_Load.FlatAppearance.BorderColor = Color.White;
            btn_Load.FlatStyle = FlatStyle.Flat;
            btn_Load.Location = new Point(553, 94);
            btn_Load.Margin = new Padding(3, 4, 3, 4);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(100, 30);
            btn_Load.TabIndex = 9;
            btn_Load.Text = "Laden";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // Grundaten
            // 
            Grundaten.AutoSize = true;
            Grundaten.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Grundaten.ForeColor = Color.Black;
            Grundaten.Location = new Point(225, 133);
            Grundaten.Name = "Grundaten";
            Grundaten.Size = new Size(200, 25);
            Grundaten.TabIndex = 10;
            Grundaten.Text = "Grunddaten Rezepte:";
            // 
            // Rezeptname
            // 
            Rezeptname.AutoSize = true;
            Rezeptname.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Rezeptname.ForeColor = Color.Black;
            Rezeptname.Location = new Point(225, 169);
            Rezeptname.Name = "Rezeptname";
            Rezeptname.Size = new Size(100, 20);
            Rezeptname.TabIndex = 11;
            Rezeptname.Text = "Rezeptname:";
            // 
            // Rezeptnummer
            // 
            Rezeptnummer.AutoSize = true;
            Rezeptnummer.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Rezeptnummer.ForeColor = Color.Black;
            Rezeptnummer.Location = new Point(225, 204);
            Rezeptnummer.Name = "Rezeptnummer";
            Rezeptnummer.Size = new Size(122, 20);
            Rezeptnummer.TabIndex = 12;
            Rezeptnummer.Text = "Rezeptnummer:";
            // 
            // Ablauf
            // 
            Ablauf.AutoSize = true;
            Ablauf.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Ablauf.ForeColor = Color.Black;
            Ablauf.Location = new Point(225, 254);
            Ablauf.Name = "Ablauf";
            Ablauf.Size = new Size(184, 25);
            Ablauf.TabIndex = 13;
            Ablauf.Text = "Ablauf Produktion:";
            // 
            // txtb_recipename
            // 
            txtb_recipename.BorderStyle = BorderStyle.FixedSingle;
            txtb_recipename.Location = new Point(398, 166);
            txtb_recipename.Name = "txtb_recipename";
            txtb_recipename.Size = new Size(363, 27);
            txtb_recipename.TabIndex = 14;
            // 
            // txtb_recipeNumber
            // 
            txtb_recipeNumber.BackColor = SystemColors.ScrollBar;
            txtb_recipeNumber.Location = new Point(398, 201);
            txtb_recipeNumber.Name = "txtb_recipeNumber";
            txtb_recipeNumber.ReadOnly = true;
            txtb_recipeNumber.Size = new Size(363, 27);
            txtb_recipeNumber.TabIndex = 15;
            // 
            // inkl
            // 
            inkl.AutoSize = true;
            inkl.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inkl.ForeColor = Color.Black;
            inkl.Location = new Point(415, 289);
            inkl.Name = "inkl";
            inkl.Size = new Size(38, 20);
            inkl.TabIndex = 17;
            inkl.Text = "inkl:";
            // 
            // Konfiguration
            // 
            Konfiguration.AutoSize = true;
            Konfiguration.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Konfiguration.ForeColor = Color.Black;
            Konfiguration.Location = new Point(555, 289);
            Konfiguration.Name = "Konfiguration";
            Konfiguration.Size = new Size(111, 20);
            Konfiguration.TabIndex = 18;
            Konfiguration.Text = "Konfiguration:";
            // 
            // Timeestimated
            // 
            Timeestimated.AutoSize = true;
            Timeestimated.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Timeestimated.ForeColor = Color.Black;
            Timeestimated.Location = new Point(768, 289);
            Timeestimated.Name = "Timeestimated";
            Timeestimated.Size = new Size(119, 20);
            Timeestimated.TabIndex = 19;
            Timeestimated.Text = "geschätzte Zeit:";
            // 
            // order
            // 
            order.AutoSize = true;
            order.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            order.ForeColor = Color.Black;
            order.Location = new Point(958, 289);
            order.Name = "order";
            order.Size = new Size(97, 20);
            order.TabIndex = 20;
            order.Text = "Reihenfolge:";
            // 
            // cbox_recipeExisting
            // 
            cbox_recipeExisting.FormattingEnabled = true;
            cbox_recipeExisting.Location = new Point(225, 94);
            cbox_recipeExisting.Name = "cbox_recipeExisting";
            cbox_recipeExisting.Size = new Size(310, 28);
            cbox_recipeExisting.TabIndex = 22;
            cbox_recipeExisting.SelectedIndexChanged += cbox_recipeExisting_SelectedIndexChanged;
            // 
            // cb_station2
            // 
            cb_station2.AutoSize = true;
            cb_station2.Location = new Point(187, 21);
            cb_station2.Name = "cb_station2";
            cb_station2.Size = new Size(15, 14);
            cb_station2.TabIndex = 0;
            cb_station2.UseVisualStyleBackColor = true;
            cb_station2.CheckedChanged += cb_station2_CheckedChanged;
            // 
            // Station2
            // 
            Station2.AutoSize = true;
            Station2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station2.ForeColor = Color.Black;
            Station2.Location = new Point(6, 18);
            Station2.Name = "Station2";
            Station2.Size = new Size(80, 20);
            Station2.TabIndex = 17;
            Station2.Text = "Station 2 :";
            // 
            // txtb_EstimatedTime2
            // 
            txtb_EstimatedTime2.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime2.Location = new Point(544, 12);
            txtb_EstimatedTime2.Name = "txtb_EstimatedTime2";
            txtb_EstimatedTime2.ReadOnly = true;
            txtb_EstimatedTime2.Size = new Size(95, 27);
            txtb_EstimatedTime2.TabIndex = 18;
            // 
            // cbox_ConfigStation2
            // 
            cbox_ConfigStation2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation2.FormattingEnabled = true;
            cbox_ConfigStation2.Location = new Point(280, 11);
            cbox_ConfigStation2.Name = "cbox_ConfigStation2";
            cbox_ConfigStation2.Size = new Size(184, 28);
            cbox_ConfigStation2.TabIndex = 23;
            cbox_ConfigStation2.SelectedIndexChanged += cbox_ConfigStation2_SelectedIndexChanged;
            // 
            // cbox_OrderStation2
            // 
            cbox_OrderStation2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation2.FormattingEnabled = true;
            cbox_OrderStation2.Location = new Point(724, 11);
            cbox_OrderStation2.Name = "cbox_OrderStation2";
            cbox_OrderStation2.Size = new Size(101, 28);
            cbox_OrderStation2.TabIndex = 24;
            // 
            // grp_Station2
            // 
            grp_Station2.Controls.Add(cbox_OrderStation2);
            grp_Station2.Controls.Add(cbox_ConfigStation2);
            grp_Station2.Controls.Add(txtb_EstimatedTime2);
            grp_Station2.Controls.Add(Station2);
            grp_Station2.Controls.Add(cb_station2);
            grp_Station2.Location = new Point(237, 362);
            grp_Station2.Name = "grp_Station2";
            grp_Station2.Size = new Size(862, 44);
            grp_Station2.TabIndex = 25;
            grp_Station2.TabStop = false;
            // 
            // cb_station3
            // 
            cb_station3.AutoSize = true;
            cb_station3.Location = new Point(187, 21);
            cb_station3.Name = "cb_station3";
            cb_station3.Size = new Size(15, 14);
            cb_station3.TabIndex = 0;
            cb_station3.UseVisualStyleBackColor = true;
            cb_station3.CheckedChanged += cb_station3_CheckedChanged;
            // 
            // Station3
            // 
            Station3.AutoSize = true;
            Station3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station3.ForeColor = Color.Black;
            Station3.Location = new Point(6, 18);
            Station3.Name = "Station3";
            Station3.Size = new Size(80, 20);
            Station3.TabIndex = 17;
            Station3.Text = "Station 3 :";
            // 
            // txtb_EstimatedTime3
            // 
            txtb_EstimatedTime3.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime3.Location = new Point(544, 12);
            txtb_EstimatedTime3.Name = "txtb_EstimatedTime3";
            txtb_EstimatedTime3.ReadOnly = true;
            txtb_EstimatedTime3.Size = new Size(95, 27);
            txtb_EstimatedTime3.TabIndex = 18;
            // 
            // cbox_ConfigStation3
            // 
            cbox_ConfigStation3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation3.FormattingEnabled = true;
            cbox_ConfigStation3.Location = new Point(280, 11);
            cbox_ConfigStation3.Name = "cbox_ConfigStation3";
            cbox_ConfigStation3.Size = new Size(184, 28);
            cbox_ConfigStation3.TabIndex = 23;
            cbox_ConfigStation3.SelectedIndexChanged += cbox_ConfigStation3_SelectedIndexChanged;
            // 
            // cbox_OrderStation3
            // 
            cbox_OrderStation3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation3.FormattingEnabled = true;
            cbox_OrderStation3.Location = new Point(724, 11);
            cbox_OrderStation3.Name = "cbox_OrderStation3";
            cbox_OrderStation3.Size = new Size(101, 28);
            cbox_OrderStation3.TabIndex = 24;
            // 
            // grp_Station3
            // 
            grp_Station3.Controls.Add(cbox_OrderStation3);
            grp_Station3.Controls.Add(cbox_ConfigStation3);
            grp_Station3.Controls.Add(txtb_EstimatedTime3);
            grp_Station3.Controls.Add(Station3);
            grp_Station3.Controls.Add(cb_station3);
            grp_Station3.Location = new Point(237, 412);
            grp_Station3.Name = "grp_Station3";
            grp_Station3.Size = new Size(862, 44);
            grp_Station3.TabIndex = 26;
            grp_Station3.TabStop = false;
            // 
            // cb_station4
            // 
            cb_station4.AutoSize = true;
            cb_station4.Location = new Point(187, 21);
            cb_station4.Name = "cb_station4";
            cb_station4.Size = new Size(15, 14);
            cb_station4.TabIndex = 0;
            cb_station4.UseVisualStyleBackColor = true;
            cb_station4.CheckedChanged += cb_station4_CheckedChanged;
            // 
            // Station4
            // 
            Station4.AutoSize = true;
            Station4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station4.ForeColor = Color.Black;
            Station4.Location = new Point(6, 18);
            Station4.Name = "Station4";
            Station4.Size = new Size(80, 20);
            Station4.TabIndex = 17;
            Station4.Text = "Station 4 :";
            // 
            // txtb_EstimatedTime4
            // 
            txtb_EstimatedTime4.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime4.Location = new Point(544, 12);
            txtb_EstimatedTime4.Name = "txtb_EstimatedTime4";
            txtb_EstimatedTime4.ReadOnly = true;
            txtb_EstimatedTime4.Size = new Size(95, 27);
            txtb_EstimatedTime4.TabIndex = 18;
            // 
            // cbox_ConfigStation4
            // 
            cbox_ConfigStation4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation4.FormattingEnabled = true;
            cbox_ConfigStation4.Location = new Point(280, 11);
            cbox_ConfigStation4.Name = "cbox_ConfigStation4";
            cbox_ConfigStation4.Size = new Size(184, 28);
            cbox_ConfigStation4.TabIndex = 23;
            cbox_ConfigStation4.SelectedIndexChanged += cbox_ConfigStation4_SelectedIndexChanged;
            // 
            // cbox_OrderStation4
            // 
            cbox_OrderStation4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation4.FormattingEnabled = true;
            cbox_OrderStation4.Location = new Point(724, 11);
            cbox_OrderStation4.Name = "cbox_OrderStation4";
            cbox_OrderStation4.Size = new Size(101, 28);
            cbox_OrderStation4.TabIndex = 24;
            // 
            // grp_Station4
            // 
            grp_Station4.Controls.Add(cbox_OrderStation4);
            grp_Station4.Controls.Add(cbox_ConfigStation4);
            grp_Station4.Controls.Add(txtb_EstimatedTime4);
            grp_Station4.Controls.Add(Station4);
            grp_Station4.Controls.Add(cb_station4);
            grp_Station4.Location = new Point(237, 462);
            grp_Station4.Name = "grp_Station4";
            grp_Station4.Size = new Size(862, 44);
            grp_Station4.TabIndex = 27;
            grp_Station4.TabStop = false;
            // 
            // cb_station5
            // 
            cb_station5.AutoSize = true;
            cb_station5.Location = new Point(187, 21);
            cb_station5.Name = "cb_station5";
            cb_station5.Size = new Size(15, 14);
            cb_station5.TabIndex = 0;
            cb_station5.UseVisualStyleBackColor = true;
            cb_station5.CheckedChanged += cb_station5_CheckedChanged;
            // 
            // Station5
            // 
            Station5.AutoSize = true;
            Station5.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station5.ForeColor = Color.Black;
            Station5.Location = new Point(6, 18);
            Station5.Name = "Station5";
            Station5.Size = new Size(80, 20);
            Station5.TabIndex = 17;
            Station5.Text = "Station 5 :";
            // 
            // txtb_EstimatedTime5
            // 
            txtb_EstimatedTime5.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime5.Location = new Point(544, 12);
            txtb_EstimatedTime5.Name = "txtb_EstimatedTime5";
            txtb_EstimatedTime5.ReadOnly = true;
            txtb_EstimatedTime5.Size = new Size(95, 27);
            txtb_EstimatedTime5.TabIndex = 18;
            // 
            // cbox_ConfigStation5
            // 
            cbox_ConfigStation5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation5.FormattingEnabled = true;
            cbox_ConfigStation5.Location = new Point(280, 11);
            cbox_ConfigStation5.Name = "cbox_ConfigStation5";
            cbox_ConfigStation5.Size = new Size(184, 28);
            cbox_ConfigStation5.TabIndex = 23;
            cbox_ConfigStation5.SelectedIndexChanged += cbox_ConfigStation5_SelectedIndexChanged;
            // 
            // cbox_OrderStation5
            // 
            cbox_OrderStation5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation5.FormattingEnabled = true;
            cbox_OrderStation5.Location = new Point(724, 11);
            cbox_OrderStation5.Name = "cbox_OrderStation5";
            cbox_OrderStation5.Size = new Size(101, 28);
            cbox_OrderStation5.TabIndex = 24;
            // 
            // grp_Station5
            // 
            grp_Station5.Controls.Add(cbox_OrderStation5);
            grp_Station5.Controls.Add(cbox_ConfigStation5);
            grp_Station5.Controls.Add(txtb_EstimatedTime5);
            grp_Station5.Controls.Add(Station5);
            grp_Station5.Controls.Add(cb_station5);
            grp_Station5.Location = new Point(237, 512);
            grp_Station5.Name = "grp_Station5";
            grp_Station5.Size = new Size(862, 44);
            grp_Station5.TabIndex = 28;
            grp_Station5.TabStop = false;
            // 
            // cb_station6
            // 
            cb_station6.AutoSize = true;
            cb_station6.Location = new Point(187, 21);
            cb_station6.Name = "cb_station6";
            cb_station6.Size = new Size(15, 14);
            cb_station6.TabIndex = 0;
            cb_station6.UseVisualStyleBackColor = true;
            cb_station6.CheckedChanged += cb_station6_CheckedChanged;
            // 
            // Station6
            // 
            Station6.AutoSize = true;
            Station6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station6.ForeColor = Color.Black;
            Station6.Location = new Point(6, 18);
            Station6.Name = "Station6";
            Station6.Size = new Size(80, 20);
            Station6.TabIndex = 17;
            Station6.Text = "Station 6 :";
            // 
            // txtb_EstimatedTime6
            // 
            txtb_EstimatedTime6.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime6.Location = new Point(544, 12);
            txtb_EstimatedTime6.Name = "txtb_EstimatedTime6";
            txtb_EstimatedTime6.ReadOnly = true;
            txtb_EstimatedTime6.Size = new Size(95, 27);
            txtb_EstimatedTime6.TabIndex = 18;
            // 
            // cbox_ConfigStation6
            // 
            cbox_ConfigStation6.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation6.FormattingEnabled = true;
            cbox_ConfigStation6.Location = new Point(280, 11);
            cbox_ConfigStation6.Name = "cbox_ConfigStation6";
            cbox_ConfigStation6.Size = new Size(184, 28);
            cbox_ConfigStation6.TabIndex = 23;
            cbox_ConfigStation6.SelectedIndexChanged += cbox_ConfigStation6_SelectedIndexChanged;
            // 
            // cbox_OrderStation6
            // 
            cbox_OrderStation6.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation6.FormattingEnabled = true;
            cbox_OrderStation6.Location = new Point(724, 11);
            cbox_OrderStation6.Name = "cbox_OrderStation6";
            cbox_OrderStation6.Size = new Size(101, 28);
            cbox_OrderStation6.TabIndex = 24;
            // 
            // grp_Station6
            // 
            grp_Station6.Controls.Add(cbox_OrderStation6);
            grp_Station6.Controls.Add(cbox_ConfigStation6);
            grp_Station6.Controls.Add(txtb_EstimatedTime6);
            grp_Station6.Controls.Add(Station6);
            grp_Station6.Controls.Add(cb_station6);
            grp_Station6.Location = new Point(237, 562);
            grp_Station6.Name = "grp_Station6";
            grp_Station6.Size = new Size(862, 44);
            grp_Station6.TabIndex = 29;
            grp_Station6.TabStop = false;
            // 
            // line
            // 
            line.BorderStyle = BorderStyle.FixedSingle;
            line.Location = new Point(234, 620);
            line.Name = "line";
            line.Size = new Size(842, 2);
            line.TabIndex = 30;
            // 
            // Zuschlag
            // 
            Zuschlag.AutoSize = true;
            Zuschlag.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Zuschlag.ForeColor = Color.Black;
            Zuschlag.Location = new Point(243, 634);
            Zuschlag.Name = "Zuschlag";
            Zuschlag.Size = new Size(156, 20);
            Zuschlag.TabIndex = 31;
            Zuschlag.Text = "Zuschlag Verfahrzeit:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(234, 666);
            label5.Name = "label5";
            label5.Size = new Size(842, 2);
            label5.TabIndex = 32;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(234, 716);
            label6.Name = "label6";
            label6.Size = new Size(842, 2);
            label6.TabIndex = 33;
            // 
            // Gesamtdauer
            // 
            Gesamtdauer.AutoSize = true;
            Gesamtdauer.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Gesamtdauer.ForeColor = Color.Black;
            Gesamtdauer.Location = new Point(243, 684);
            Gesamtdauer.Name = "Gesamtdauer";
            Gesamtdauer.Size = new Size(108, 20);
            Gesamtdauer.TabIndex = 34;
            Gesamtdauer.Text = "Gesamtdauer:";
            // 
            // txtb_EstimatedTimeDrive
            // 
            txtb_EstimatedTimeDrive.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTimeDrive.Location = new Point(781, 631);
            txtb_EstimatedTimeDrive.Name = "txtb_EstimatedTimeDrive";
            txtb_EstimatedTimeDrive.ReadOnly = true;
            txtb_EstimatedTimeDrive.Size = new Size(95, 27);
            txtb_EstimatedTimeDrive.TabIndex = 25;
            // 
            // txtb_EstimatedTimeAll
            // 
            txtb_EstimatedTimeAll.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTimeAll.Location = new Point(781, 681);
            txtb_EstimatedTimeAll.Name = "txtb_EstimatedTimeAll";
            txtb_EstimatedTimeAll.ReadOnly = true;
            txtb_EstimatedTimeAll.Size = new Size(95, 27);
            txtb_EstimatedTimeAll.TabIndex = 35;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(234, 723);
            label7.Name = "label7";
            label7.Size = new Size(842, 2);
            label7.TabIndex = 36;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(0, 46, 119);
            btn_Save.FlatAppearance.BorderColor = Color.White;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Location = new Point(397, 748);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 30);
            btn_Save.TabIndex = 37;
            btn_Save.Text = "Speichern";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(0, 46, 119);
            btn_Delete.FlatAppearance.BorderColor = Color.White;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Location = new Point(593, 748);
            btn_Delete.Margin = new Padding(3, 4, 3, 4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(150, 30);
            btn_Delete.TabIndex = 38;
            btn_Delete.Text = "Löschen";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Abort
            // 
            btn_Abort.BackColor = Color.FromArgb(0, 46, 119);
            btn_Abort.FlatAppearance.BorderColor = Color.White;
            btn_Abort.FlatStyle = FlatStyle.Flat;
            btn_Abort.Location = new Point(794, 748);
            btn_Abort.Margin = new Padding(3, 4, 3, 4);
            btn_Abort.Name = "btn_Abort";
            btn_Abort.Size = new Size(150, 30);
            btn_Abort.TabIndex = 39;
            btn_Abort.Text = "Abbrechen";
            btn_Abort.UseVisualStyleBackColor = false;
            btn_Abort.Click += btn_Abort_Click;
            // 
            // cb_station1
            // 
            cb_station1.AutoSize = true;
            cb_station1.Location = new Point(187, 18);
            cb_station1.Name = "cb_station1";
            cb_station1.Size = new Size(15, 14);
            cb_station1.TabIndex = 0;
            cb_station1.UseVisualStyleBackColor = true;
            cb_station1.CheckedChanged += cb_station1_CheckedChanged;
            // 
            // Station1
            // 
            Station1.AutoSize = true;
            Station1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Station1.ForeColor = Color.Black;
            Station1.Location = new Point(6, 15);
            Station1.Name = "Station1";
            Station1.Size = new Size(80, 20);
            Station1.TabIndex = 17;
            Station1.Text = "Station 1 :";
            // 
            // txtb_EstimatedTime1
            // 
            txtb_EstimatedTime1.BackColor = SystemColors.ScrollBar;
            txtb_EstimatedTime1.Location = new Point(544, 9);
            txtb_EstimatedTime1.Name = "txtb_EstimatedTime1";
            txtb_EstimatedTime1.ReadOnly = true;
            txtb_EstimatedTime1.Size = new Size(95, 27);
            txtb_EstimatedTime1.TabIndex = 18;
            // 
            // cbox_ConfigStation1
            // 
            cbox_ConfigStation1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_ConfigStation1.FormattingEnabled = true;
            cbox_ConfigStation1.Location = new Point(280, 8);
            cbox_ConfigStation1.Name = "cbox_ConfigStation1";
            cbox_ConfigStation1.Size = new Size(184, 28);
            cbox_ConfigStation1.TabIndex = 23;
            cbox_ConfigStation1.SelectedIndexChanged += cbox_ConfigStation1_SelectedIndexChanged;
            // 
            // cbox_OrderStation1
            // 
            cbox_OrderStation1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_OrderStation1.FormattingEnabled = true;
            cbox_OrderStation1.Location = new Point(724, 8);
            cbox_OrderStation1.Name = "cbox_OrderStation1";
            cbox_OrderStation1.Size = new Size(101, 28);
            cbox_OrderStation1.TabIndex = 24;
            // 
            // grp_Station1
            // 
            grp_Station1.Controls.Add(cbox_OrderStation1);
            grp_Station1.Controls.Add(cbox_ConfigStation1);
            grp_Station1.Controls.Add(txtb_EstimatedTime1);
            grp_Station1.Controls.Add(Station1);
            grp_Station1.Controls.Add(cb_station1);
            grp_Station1.Location = new Point(237, 312);
            grp_Station1.Name = "grp_Station1";
            grp_Station1.Size = new Size(862, 44);
            grp_Station1.TabIndex = 16;
            grp_Station1.TabStop = false;
            // 
            // panel_transparent
            // 
            panel_transparent.BackColor = Color.Transparent;
            panel_transparent.Controls.Add(btn_CloseRecipe);
            panel_transparent.Location = new Point(206, 0);
            panel_transparent.Name = "panel_transparent";
            panel_transparent.Size = new Size(933, 45);
            panel_transparent.TabIndex = 90;
            panel_transparent.MouseDown += panel_mouse_down;
            panel_transparent.MouseMove += panel_move;
            panel_transparent.MouseUp += panel_mouse_up;
            // 
            // RecipeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1140, 800);
            Controls.Add(panel_transparent);
            Controls.Add(btn_Abort);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Save);
            Controls.Add(label7);
            Controls.Add(txtb_EstimatedTimeAll);
            Controls.Add(txtb_EstimatedTimeDrive);
            Controls.Add(Gesamtdauer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Zuschlag);
            Controls.Add(line);
            Controls.Add(grp_Station6);
            Controls.Add(grp_Station5);
            Controls.Add(grp_Station4);
            Controls.Add(grp_Station3);
            Controls.Add(grp_Station2);
            Controls.Add(cbox_recipeExisting);
            Controls.Add(order);
            Controls.Add(Timeestimated);
            Controls.Add(Konfiguration);
            Controls.Add(inkl);
            Controls.Add(grp_Station1);
            Controls.Add(txtb_recipeNumber);
            Controls.Add(txtb_recipename);
            Controls.Add(Ablauf);
            Controls.Add(Rezeptnummer);
            Controls.Add(Rezeptname);
            Controls.Add(Grundaten);
            Controls.Add(btn_Load);
            Controls.Add(Rezeptbearbeitung);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecipeView";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            grp_Station2.ResumeLayout(false);
            grp_Station2.PerformLayout();
            grp_Station3.ResumeLayout(false);
            grp_Station3.PerformLayout();
            grp_Station4.ResumeLayout(false);
            grp_Station4.PerformLayout();
            grp_Station5.ResumeLayout(false);
            grp_Station5.PerformLayout();
            grp_Station6.ResumeLayout(false);
            grp_Station6.PerformLayout();
            grp_Station1.ResumeLayout(false);
            grp_Station1.PerformLayout();
            panel_transparent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_CloseRecipe;
        private Panel panel1;
        private PictureBox pic_fhlogo;
        private Label Logo;
        private Label Rezeptbearbeitung;
        private Button btn_Load;
        private Label Grundaten;
        private Label Rezeptname;
        private Label Rezeptnummer;
        private Label Ablauf;
        private TextBox txtb_recipeNumber;
        private Label inkl;
        private Label Konfiguration;
        private Label Timeestimated;
        private Label order;
        private Label Station2;
        internal ComboBox cbox_OrderStation2;
        private GroupBox grp_Station2;
        private Label Station3;
        internal ComboBox cbox_OrderStation3;
        private GroupBox grp_Station3;
        private Label Station4;
        internal ComboBox cbox_OrderStation4;
        private GroupBox grp_Station4;
        private Label Station5;
        internal ComboBox cbox_OrderStation5;
        private GroupBox grp_Station5;
        private Label Station6;
        internal ComboBox cbox_OrderStation6;
        private GroupBox grp_Station6;
        private Label line;
        private Label Zuschlag;
        private Label label5;
        private Label label6;
        private Label Gesamtdauer;
        private Label label7;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Abort;
        private Label Station1;
        internal ComboBox cbox_OrderStation1;
        private GroupBox grp_Station1;
        internal ComboBox cbox_recipeExisting;
        internal ComboBox cbox_ConfigStation1;
        internal ComboBox cbox_ConfigStation2;
        internal ComboBox cbox_ConfigStation3;
        internal ComboBox cbox_ConfigStation4;
        internal ComboBox cbox_ConfigStation5;
        internal ComboBox cbox_ConfigStation6;
        internal TextBox txtb_EstimatedTime2;
        internal TextBox txtb_EstimatedTime3;
        internal TextBox txtb_EstimatedTime4;
        internal TextBox txtb_EstimatedTime5;
        internal TextBox txtb_EstimatedTime6;
        internal TextBox txtb_EstimatedTimeDrive;
        internal TextBox txtb_EstimatedTimeAll;
        internal TextBox txtb_EstimatedTime1;
        internal CheckBox cb_station2;
        internal CheckBox cb_station3;
        internal CheckBox cb_station4;
        internal CheckBox cb_station1;
        internal CheckBox cb_station5;
        internal CheckBox cb_station6;
        internal TextBox txtb_recipename;
        private Panel panel_transparent;
    }
}