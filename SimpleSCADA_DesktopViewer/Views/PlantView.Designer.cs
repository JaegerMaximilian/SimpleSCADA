namespace SimpleSCADA_DesktopViewer
{
    partial class PlantView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantView));
            bluestripe_top = new Panel();
            label1 = new Label();
            txt_MachineStatus = new TextBox();
            txt_simpleScada = new TextBox();
            btn_minimized = new Button();
            btn_exit = new Button();
            btn_max_min = new Button();
            pic_fhlogo = new PictureBox();
            txt_user = new TextBox();
            btn_user = new Button();
            bluestripe_bottom = new Panel();
            btn_joke = new Button();
            DezeitEingelogged = new Label();
            txt_time = new TextBox();
            txt_date = new TextBox();
            btn_recipe_edit = new Button();
            btn_order_edit = new Button();
            btn_ooe = new Button();
            btn_history = new Button();
            btn_error = new Button();
            dropdownPanel = new Panel();
            btn_user_manager = new Button();
            btn_password = new Button();
            btn_logout = new Button();
            btn_login = new Button();
            panel_railsystem = new Panel();
            panel_TS_501 = new Panel();
            panel_TS_402 = new Panel();
            panel_TS_401 = new Panel();
            panel_TS_302 = new Panel();
            panel_TS_304 = new Panel();
            panel_TS_204 = new Panel();
            panel_TS_303 = new Panel();
            panel_TS_203 = new Panel();
            panel_TS_301 = new Panel();
            panel_TS_202 = new Panel();
            panel_TS_201 = new Panel();
            panel_TS_102 = new Panel();
            panel_TS_101 = new Panel();
            panel_laufwagen_Station_5 = new Panel();
            panel_laufwagen_Station_4 = new Panel();
            panel_laufwagen_Station_3 = new Panel();
            panel_laufwagen_Station_2 = new Panel();
            panel_laufwagen_Station_1 = new Panel();
            panel_laufwagen_Station_6 = new Panel();
            panel_SE_301 = new Panel();
            panel_SE_302 = new Panel();
            panel_SE_303 = new Panel();
            panel_SE_304 = new Panel();
            panel_SE_305 = new Panel();
            panel_SE_306 = new Panel();
            panel_SE_307 = new Panel();
            panel_SE_309 = new Panel();
            panel_SE_308 = new Panel();
            panel_SE_201 = new Panel();
            panel_SE_202 = new Panel();
            panel_SE_203 = new Panel();
            panel_SE_204 = new Panel();
            panel_SE_205 = new Panel();
            panel_SE_206 = new Panel();
            panel_SE_207 = new Panel();
            panel_SE_209 = new Panel();
            panel_SE_208 = new Panel();
            panel_SE_101 = new Panel();
            panel_SE_102 = new Panel();
            panel_SE_103 = new Panel();
            panel_SE_104 = new Panel();
            panel_SE_105 = new Panel();
            panel_SE_106 = new Panel();
            panel_SE_107 = new Panel();
            panel_Controller = new Panel();
            panel_blackStrip05 = new Panel();
            panel_blackStrip04 = new Panel();
            txt_order_queue = new TextBox();
            lv_Queue = new ListView();
            ID = new ColumnHeader();
            Customer = new ColumnHeader();
            Recipe_ID = new ColumnHeader();
            Recipe = new ColumnHeader();
            Amount = new ColumnHeader();
            panel_blackStrip03 = new Panel();
            groupBox_Prodution = new GroupBox();
            txt_status = new TextBox();
            txt_percentageFinished = new TextBox();
            txt_amountFinished = new TextBox();
            txt_totalAmount = new TextBox();
            txt_recipeNumber = new TextBox();
            txt_orderNumber = new TextBox();
            txt_orderName = new TextBox();
            panel1 = new Panel();
            label_groupBox_Prodution_status = new Label();
            label_groupBox_Prodution_finishedVolume = new Label();
            label_groupBox_Prodution_totalVolume = new Label();
            label_groupBox_Prodution_recipeNr = new Label();
            label_groupBox_Prodution_order = new Label();
            panel_blackStrip01 = new Panel();
            panel_blackStrip02 = new Panel();
            txt_productionList = new TextBox();
            txt_control = new TextBox();
            btn_stopPlant = new Button();
            pic_stopPlant = new PictureBox();
            btn_startPlant = new Button();
            pic_startPlant = new PictureBox();
            btn_maintenance = new Button();
            pic_maintenance = new PictureBox();
            btn_pause = new Button();
            pic_pause = new PictureBox();
            backgroundworkerAktiveProductioncycle = new System.ComponentModel.BackgroundWorker();
            backgroundWorkerSensorData = new System.ComponentModel.BackgroundWorker();
            backgroundWorkerProductionQueue = new System.ComponentModel.BackgroundWorker();
            bluestripe_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).BeginInit();
            bluestripe_bottom.SuspendLayout();
            dropdownPanel.SuspendLayout();
            panel_railsystem.SuspendLayout();
            panel_Controller.SuspendLayout();
            groupBox_Prodution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_stopPlant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_startPlant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_maintenance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_pause).BeginInit();
            SuspendLayout();
            // 
            // bluestripe_top
            // 
            bluestripe_top.BackColor = Color.FromArgb(0, 46, 119);
            bluestripe_top.Controls.Add(label1);
            bluestripe_top.Controls.Add(txt_MachineStatus);
            bluestripe_top.Controls.Add(txt_simpleScada);
            bluestripe_top.Controls.Add(btn_minimized);
            bluestripe_top.Controls.Add(btn_exit);
            bluestripe_top.Controls.Add(btn_max_min);
            bluestripe_top.Controls.Add(pic_fhlogo);
            bluestripe_top.Dock = DockStyle.Top;
            bluestripe_top.Location = new Point(0, 0);
            bluestripe_top.Name = "bluestripe_top";
            bluestripe_top.Size = new Size(1600, 50);
            bluestripe_top.TabIndex = 0;
            bluestripe_top.MouseDown += panel_mouse_down;
            bluestripe_top.MouseMove += panel_move;
            bluestripe_top.MouseUp += panel_mouse_up;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(115, 12);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 12;
            label1.Text = "Maschinen Status:";
            // 
            // txt_MachineStatus
            // 
            txt_MachineStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_MachineStatus.BackColor = Color.FromArgb(0, 46, 119);
            txt_MachineStatus.BorderStyle = BorderStyle.None;
            txt_MachineStatus.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_MachineStatus.ForeColor = SystemColors.Window;
            txt_MachineStatus.Location = new Point(286, 12);
            txt_MachineStatus.Name = "txt_MachineStatus";
            txt_MachineStatus.ReadOnly = true;
            txt_MachineStatus.Size = new Size(161, 25);
            txt_MachineStatus.TabIndex = 11;
            txt_MachineStatus.Text = "Running";
            // 
            // txt_simpleScada
            // 
            txt_simpleScada.Anchor = AnchorStyles.Top;
            txt_simpleScada.BackColor = Color.FromArgb(0, 46, 119);
            txt_simpleScada.BorderStyle = BorderStyle.None;
            txt_simpleScada.Font = new Font("Nirmala UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_simpleScada.ForeColor = SystemColors.Window;
            txt_simpleScada.Location = new Point(680, 0);
            txt_simpleScada.Name = "txt_simpleScada";
            txt_simpleScada.ReadOnly = true;
            txt_simpleScada.Size = new Size(250, 45);
            txt_simpleScada.TabIndex = 8;
            txt_simpleScada.Text = "Simple SCADA";
            txt_simpleScada.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_minimized
            // 
            btn_minimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimized.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_minimized.BackColor = Color.FromArgb(0, 46, 119);
            btn_minimized.BackgroundImageLayout = ImageLayout.Center;
            btn_minimized.FlatStyle = FlatStyle.Flat;
            btn_minimized.ForeColor = Color.FromArgb(0, 46, 119);
            btn_minimized.Image = (Image)resources.GetObject("btn_minimized.Image");
            btn_minimized.Location = new Point(1435, 0);
            btn_minimized.Name = "btn_minimized";
            btn_minimized.Size = new Size(50, 50);
            btn_minimized.TabIndex = 4;
            btn_minimized.UseVisualStyleBackColor = false;
            btn_minimized.Click += btn_minimized_Click;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_exit.BackColor = Color.FromArgb(0, 46, 119);
            btn_exit.BackgroundImageLayout = ImageLayout.Center;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.FromArgb(0, 46, 119);
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.Location = new Point(1547, 0);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(50, 50);
            btn_exit.TabIndex = 3;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_max_min
            // 
            btn_max_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_max_min.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_max_min.BackColor = Color.FromArgb(0, 46, 119);
            btn_max_min.BackgroundImageLayout = ImageLayout.Center;
            btn_max_min.FlatStyle = FlatStyle.Flat;
            btn_max_min.ForeColor = Color.FromArgb(0, 46, 119);
            btn_max_min.Image = (Image)resources.GetObject("btn_max_min.Image");
            btn_max_min.Location = new Point(1491, 0);
            btn_max_min.Name = "btn_max_min";
            btn_max_min.Size = new Size(50, 50);
            btn_max_min.TabIndex = 3;
            btn_max_min.UseVisualStyleBackColor = false;
            btn_max_min.Click += btn_max_min_Click;
            // 
            // pic_fhlogo
            // 
            pic_fhlogo.Image = (Image)resources.GetObject("pic_fhlogo.Image");
            pic_fhlogo.Location = new Point(12, 2);
            pic_fhlogo.Name = "pic_fhlogo";
            pic_fhlogo.Size = new Size(90, 45);
            pic_fhlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fhlogo.TabIndex = 1;
            pic_fhlogo.TabStop = false;
            // 
            // txt_user
            // 
            txt_user.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txt_user.BackColor = Color.FromArgb(0, 46, 119);
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_user.ForeColor = SystemColors.Window;
            txt_user.Location = new Point(623, 16);
            txt_user.Name = "txt_user";
            txt_user.ReadOnly = true;
            txt_user.Size = new Size(375, 25);
            txt_user.TabIndex = 7;
            txt_user.Text = "Max Mustermann";
            // 
            // btn_user
            // 
            btn_user.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_user.BackColor = Color.FromArgb(0, 46, 119);
            btn_user.BackgroundImageLayout = ImageLayout.Center;
            btn_user.FlatStyle = FlatStyle.Flat;
            btn_user.ForeColor = Color.FromArgb(0, 46, 119);
            btn_user.Image = (Image)resources.GetObject("btn_user.Image");
            btn_user.Location = new Point(342, 0);
            btn_user.Name = "btn_user";
            btn_user.Size = new Size(50, 50);
            btn_user.TabIndex = 6;
            btn_user.UseVisualStyleBackColor = false;
            btn_user.Click += btn_user_Click;
            // 
            // bluestripe_bottom
            // 
            bluestripe_bottom.BackColor = Color.FromArgb(0, 46, 119);
            bluestripe_bottom.Controls.Add(btn_joke);
            bluestripe_bottom.Controls.Add(DezeitEingelogged);
            bluestripe_bottom.Controls.Add(txt_time);
            bluestripe_bottom.Controls.Add(txt_date);
            bluestripe_bottom.Controls.Add(btn_user);
            bluestripe_bottom.Controls.Add(txt_user);
            bluestripe_bottom.Controls.Add(btn_recipe_edit);
            bluestripe_bottom.Controls.Add(btn_order_edit);
            bluestripe_bottom.Controls.Add(btn_ooe);
            bluestripe_bottom.Controls.Add(btn_history);
            bluestripe_bottom.Controls.Add(btn_error);
            bluestripe_bottom.Dock = DockStyle.Bottom;
            bluestripe_bottom.Location = new Point(0, 850);
            bluestripe_bottom.Name = "bluestripe_bottom";
            bluestripe_bottom.Size = new Size(1600, 50);
            bluestripe_bottom.TabIndex = 1;
            // 
            // btn_joke
            // 
            btn_joke.BackColor = Color.FromArgb(0, 46, 119);
            btn_joke.BackgroundImageLayout = ImageLayout.Center;
            btn_joke.FlatStyle = FlatStyle.Flat;
            btn_joke.ForeColor = Color.FromArgb(0, 46, 119);
            btn_joke.Image = (Image)resources.GetObject("btn_joke.Image");
            btn_joke.Location = new Point(286, 0);
            btn_joke.Name = "btn_joke";
            btn_joke.Size = new Size(50, 50);
            btn_joke.TabIndex = 11;
            btn_joke.UseVisualStyleBackColor = false;
            btn_joke.Click += btn_joke_Click;
            // 
            // DezeitEingelogged
            // 
            DezeitEingelogged.AutoSize = true;
            DezeitEingelogged.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            DezeitEingelogged.ForeColor = SystemColors.Control;
            DezeitEingelogged.Location = new Point(428, 16);
            DezeitEingelogged.Name = "DezeitEingelogged";
            DezeitEingelogged.Size = new Size(189, 25);
            DezeitEingelogged.TabIndex = 10;
            DezeitEingelogged.Text = "Dezeit eingelogged:";
            // 
            // txt_time
            // 
            txt_time.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_time.BackColor = Color.FromArgb(0, 46, 119);
            txt_time.BorderStyle = BorderStyle.None;
            txt_time.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_time.ForeColor = SystemColors.Window;
            txt_time.Location = new Point(1397, 0);
            txt_time.Name = "txt_time";
            txt_time.ReadOnly = true;
            txt_time.Size = new Size(200, 25);
            txt_time.TabIndex = 9;
            txt_time.Text = "Zeit";
            txt_time.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_date
            // 
            txt_date.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_date.BackColor = Color.FromArgb(0, 46, 119);
            txt_date.BorderStyle = BorderStyle.None;
            txt_date.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_date.ForeColor = SystemColors.Window;
            txt_date.Location = new Point(1397, 22);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(200, 25);
            txt_date.TabIndex = 8;
            txt_date.Text = "Datum";
            txt_date.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_recipe_edit
            // 
            btn_recipe_edit.BackColor = Color.FromArgb(0, 46, 119);
            btn_recipe_edit.BackgroundImageLayout = ImageLayout.Center;
            btn_recipe_edit.FlatStyle = FlatStyle.Flat;
            btn_recipe_edit.ForeColor = Color.FromArgb(0, 46, 119);
            btn_recipe_edit.Image = (Image)resources.GetObject("btn_recipe_edit.Image");
            btn_recipe_edit.Location = new Point(227, 0);
            btn_recipe_edit.Name = "btn_recipe_edit";
            btn_recipe_edit.Size = new Size(50, 50);
            btn_recipe_edit.TabIndex = 5;
            btn_recipe_edit.UseVisualStyleBackColor = false;
            btn_recipe_edit.Click += btn_recipe_edit_Click;
            // 
            // btn_order_edit
            // 
            btn_order_edit.BackColor = Color.FromArgb(0, 46, 119);
            btn_order_edit.BackgroundImageLayout = ImageLayout.Center;
            btn_order_edit.FlatStyle = FlatStyle.Flat;
            btn_order_edit.ForeColor = Color.FromArgb(0, 46, 119);
            btn_order_edit.Image = (Image)resources.GetObject("btn_order_edit.Image");
            btn_order_edit.Location = new Point(171, 0);
            btn_order_edit.Name = "btn_order_edit";
            btn_order_edit.Size = new Size(50, 50);
            btn_order_edit.TabIndex = 5;
            btn_order_edit.UseVisualStyleBackColor = false;
            btn_order_edit.Click += btn_order_edit_Click;
            // 
            // btn_ooe
            // 
            btn_ooe.BackColor = Color.FromArgb(0, 46, 119);
            btn_ooe.BackgroundImageLayout = ImageLayout.Center;
            btn_ooe.FlatStyle = FlatStyle.Flat;
            btn_ooe.ForeColor = Color.FromArgb(0, 46, 119);
            btn_ooe.Image = (Image)resources.GetObject("btn_ooe.Image");
            btn_ooe.Location = new Point(115, 0);
            btn_ooe.Name = "btn_ooe";
            btn_ooe.Size = new Size(50, 50);
            btn_ooe.TabIndex = 4;
            btn_ooe.UseVisualStyleBackColor = false;
            btn_ooe.Click += btn_ooe_Click;
            // 
            // btn_history
            // 
            btn_history.BackColor = Color.FromArgb(0, 46, 119);
            btn_history.BackgroundImageLayout = ImageLayout.Center;
            btn_history.FlatStyle = FlatStyle.Flat;
            btn_history.ForeColor = Color.FromArgb(0, 46, 119);
            btn_history.Image = (Image)resources.GetObject("btn_history.Image");
            btn_history.Location = new Point(59, 0);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(50, 50);
            btn_history.TabIndex = 3;
            btn_history.UseVisualStyleBackColor = false;
            btn_history.Click += btn_history_click;
            // 
            // btn_error
            // 
            btn_error.BackColor = Color.FromArgb(0, 46, 119);
            btn_error.BackgroundImageLayout = ImageLayout.Center;
            btn_error.FlatStyle = FlatStyle.Flat;
            btn_error.ForeColor = Color.FromArgb(0, 46, 119);
            btn_error.Image = (Image)resources.GetObject("btn_error.Image");
            btn_error.Location = new Point(3, 0);
            btn_error.Name = "btn_error";
            btn_error.Size = new Size(50, 50);
            btn_error.TabIndex = 2;
            btn_error.UseVisualStyleBackColor = false;
            btn_error.Click += btn_error_Click;
            // 
            // dropdownPanel
            // 
            dropdownPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dropdownPanel.BackColor = Color.FromArgb(0, 46, 119);
            dropdownPanel.Controls.Add(btn_user_manager);
            dropdownPanel.Controls.Add(btn_password);
            dropdownPanel.Controls.Add(btn_logout);
            dropdownPanel.Controls.Add(btn_login);
            dropdownPanel.Location = new Point(254, 794);
            dropdownPanel.Name = "dropdownPanel";
            dropdownPanel.Size = new Size(225, 50);
            dropdownPanel.TabIndex = 3;
            // 
            // btn_user_manager
            // 
            btn_user_manager.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_user_manager.BackColor = Color.FromArgb(0, 46, 119);
            btn_user_manager.BackgroundImageLayout = ImageLayout.Center;
            btn_user_manager.FlatStyle = FlatStyle.Flat;
            btn_user_manager.ForeColor = Color.FromArgb(0, 46, 119);
            btn_user_manager.Image = (Image)resources.GetObject("btn_user_manager.Image");
            btn_user_manager.Location = new Point(116, 0);
            btn_user_manager.Name = "btn_user_manager";
            btn_user_manager.Size = new Size(50, 50);
            btn_user_manager.TabIndex = 10;
            btn_user_manager.UseVisualStyleBackColor = false;
            btn_user_manager.Click += btn_user_manager_Click;
            // 
            // btn_password
            // 
            btn_password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_password.BackColor = Color.FromArgb(0, 46, 119);
            btn_password.BackgroundImageLayout = ImageLayout.Center;
            btn_password.FlatStyle = FlatStyle.Flat;
            btn_password.ForeColor = Color.FromArgb(0, 46, 119);
            btn_password.Image = (Image)resources.GetObject("btn_password.Image");
            btn_password.Location = new Point(60, 0);
            btn_password.Name = "btn_password";
            btn_password.Size = new Size(50, 50);
            btn_password.TabIndex = 9;
            btn_password.UseVisualStyleBackColor = false;
            btn_password.Click += btn_password_Click;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.FromArgb(0, 46, 119);
            btn_logout.BackgroundImageLayout = ImageLayout.Center;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.ForeColor = Color.FromArgb(0, 46, 119);
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.Location = new Point(172, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(50, 50);
            btn_logout.TabIndex = 8;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = Color.FromArgb(0, 46, 119);
            btn_login.BackgroundImageLayout = ImageLayout.Center;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.FromArgb(0, 46, 119);
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.Location = new Point(4, 0);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(50, 50);
            btn_login.TabIndex = 7;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel_railsystem
            // 
            panel_railsystem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_railsystem.BackgroundImage = (Image)resources.GetObject("panel_railsystem.BackgroundImage");
            panel_railsystem.BackgroundImageLayout = ImageLayout.Stretch;
            panel_railsystem.Controls.Add(panel_TS_501);
            panel_railsystem.Controls.Add(panel_TS_402);
            panel_railsystem.Controls.Add(panel_TS_401);
            panel_railsystem.Controls.Add(panel_TS_302);
            panel_railsystem.Controls.Add(panel_TS_304);
            panel_railsystem.Controls.Add(panel_TS_204);
            panel_railsystem.Controls.Add(panel_TS_303);
            panel_railsystem.Controls.Add(panel_TS_203);
            panel_railsystem.Controls.Add(panel_TS_301);
            panel_railsystem.Controls.Add(panel_TS_202);
            panel_railsystem.Controls.Add(panel_TS_201);
            panel_railsystem.Controls.Add(panel_TS_102);
            panel_railsystem.Controls.Add(panel_TS_101);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_5);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_4);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_3);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_2);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_1);
            panel_railsystem.Controls.Add(panel_laufwagen_Station_6);
            panel_railsystem.Controls.Add(panel_SE_301);
            panel_railsystem.Controls.Add(panel_SE_302);
            panel_railsystem.Controls.Add(panel_SE_303);
            panel_railsystem.Controls.Add(panel_SE_304);
            panel_railsystem.Controls.Add(panel_SE_305);
            panel_railsystem.Controls.Add(panel_SE_306);
            panel_railsystem.Controls.Add(panel_SE_307);
            panel_railsystem.Controls.Add(panel_SE_309);
            panel_railsystem.Controls.Add(panel_SE_308);
            panel_railsystem.Controls.Add(panel_SE_201);
            panel_railsystem.Controls.Add(panel_SE_202);
            panel_railsystem.Controls.Add(panel_SE_203);
            panel_railsystem.Controls.Add(panel_SE_204);
            panel_railsystem.Controls.Add(panel_SE_205);
            panel_railsystem.Controls.Add(panel_SE_206);
            panel_railsystem.Controls.Add(panel_SE_207);
            panel_railsystem.Controls.Add(panel_SE_209);
            panel_railsystem.Controls.Add(panel_SE_208);
            panel_railsystem.Controls.Add(panel_SE_101);
            panel_railsystem.Controls.Add(panel_SE_102);
            panel_railsystem.Controls.Add(panel_SE_103);
            panel_railsystem.Controls.Add(panel_SE_104);
            panel_railsystem.Controls.Add(panel_SE_105);
            panel_railsystem.Controls.Add(panel_SE_106);
            panel_railsystem.Controls.Add(panel_SE_107);
            panel_railsystem.Location = new Point(42, 85);
            panel_railsystem.Name = "panel_railsystem";
            panel_railsystem.Size = new Size(1150, 730);
            panel_railsystem.TabIndex = 4;
            // 
            // panel_TS_501
            // 
            panel_TS_501.BackgroundImage = (Image)resources.GetObject("panel_TS_501.BackgroundImage");
            panel_TS_501.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_501.Location = new Point(1066, 367);
            panel_TS_501.Name = "panel_TS_501";
            panel_TS_501.Size = new Size(55, 55);
            panel_TS_501.TabIndex = 44;
            // 
            // panel_TS_402
            // 
            panel_TS_402.BackgroundImage = (Image)resources.GetObject("panel_TS_402.BackgroundImage");
            panel_TS_402.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_402.Location = new Point(53, 635);
            panel_TS_402.Name = "panel_TS_402";
            panel_TS_402.Size = new Size(55, 55);
            panel_TS_402.TabIndex = 43;
            // 
            // panel_TS_401
            // 
            panel_TS_401.BackgroundImage = (Image)resources.GetObject("panel_TS_401.BackgroundImage");
            panel_TS_401.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_401.Location = new Point(53, 462);
            panel_TS_401.Name = "panel_TS_401";
            panel_TS_401.Size = new Size(55, 55);
            panel_TS_401.TabIndex = 42;
            // 
            // panel_TS_302
            // 
            panel_TS_302.BackgroundImage = (Image)resources.GetObject("panel_TS_302.BackgroundImage");
            panel_TS_302.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_302.Location = new Point(368, 165);
            panel_TS_302.Name = "panel_TS_302";
            panel_TS_302.Size = new Size(55, 55);
            panel_TS_302.TabIndex = 39;
            // 
            // panel_TS_304
            // 
            panel_TS_304.BackgroundImage = (Image)resources.GetObject("panel_TS_304.BackgroundImage");
            panel_TS_304.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_304.Location = new Point(1066, 165);
            panel_TS_304.Name = "panel_TS_304";
            panel_TS_304.Size = new Size(55, 55);
            panel_TS_304.TabIndex = 41;
            // 
            // panel_TS_204
            // 
            panel_TS_204.BackgroundImage = (Image)resources.GetObject("panel_TS_204.BackgroundImage");
            panel_TS_204.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_204.Location = new Point(1066, 109);
            panel_TS_204.Name = "panel_TS_204";
            panel_TS_204.Size = new Size(55, 55);
            panel_TS_204.TabIndex = 37;
            // 
            // panel_TS_303
            // 
            panel_TS_303.BackgroundImage = (Image)resources.GetObject("panel_TS_303.BackgroundImage");
            panel_TS_303.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_303.Location = new Point(673, 165);
            panel_TS_303.Name = "panel_TS_303";
            panel_TS_303.Size = new Size(55, 55);
            panel_TS_303.TabIndex = 40;
            // 
            // panel_TS_203
            // 
            panel_TS_203.BackgroundImage = (Image)resources.GetObject("panel_TS_203.BackgroundImage");
            panel_TS_203.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_203.Location = new Point(673, 109);
            panel_TS_203.Name = "panel_TS_203";
            panel_TS_203.Size = new Size(55, 55);
            panel_TS_203.TabIndex = 36;
            // 
            // panel_TS_301
            // 
            panel_TS_301.BackgroundImage = (Image)resources.GetObject("panel_TS_301.BackgroundImage");
            panel_TS_301.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_301.Location = new Point(53, 165);
            panel_TS_301.Name = "panel_TS_301";
            panel_TS_301.Size = new Size(55, 55);
            panel_TS_301.TabIndex = 38;
            // 
            // panel_TS_202
            // 
            panel_TS_202.BackgroundImage = (Image)resources.GetObject("panel_TS_202.BackgroundImage");
            panel_TS_202.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_202.Location = new Point(368, 109);
            panel_TS_202.Name = "panel_TS_202";
            panel_TS_202.Size = new Size(55, 55);
            panel_TS_202.TabIndex = 35;
            // 
            // panel_TS_201
            // 
            panel_TS_201.BackgroundImage = (Image)resources.GetObject("panel_TS_201.BackgroundImage");
            panel_TS_201.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_201.Location = new Point(53, 109);
            panel_TS_201.Name = "panel_TS_201";
            panel_TS_201.Size = new Size(55, 55);
            panel_TS_201.TabIndex = 34;
            // 
            // panel_TS_102
            // 
            panel_TS_102.BackgroundImage = (Image)resources.GetObject("panel_TS_102.BackgroundImage");
            panel_TS_102.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_102.Location = new Point(1066, 49);
            panel_TS_102.Name = "panel_TS_102";
            panel_TS_102.Size = new Size(55, 55);
            panel_TS_102.TabIndex = 33;
            // 
            // panel_TS_101
            // 
            panel_TS_101.BackgroundImage = (Image)resources.GetObject("panel_TS_101.BackgroundImage");
            panel_TS_101.BackgroundImageLayout = ImageLayout.Stretch;
            panel_TS_101.Location = new Point(673, 49);
            panel_TS_101.Name = "panel_TS_101";
            panel_TS_101.Size = new Size(55, 55);
            panel_TS_101.TabIndex = 32;
            // 
            // panel_laufwagen_Station_5
            // 
            panel_laufwagen_Station_5.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_5.BackgroundImage");
            panel_laufwagen_Station_5.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_5.Location = new Point(201, 632);
            panel_laufwagen_Station_5.Name = "panel_laufwagen_Station_5";
            panel_laufwagen_Station_5.Size = new Size(63, 63);
            panel_laufwagen_Station_5.TabIndex = 31;
            // 
            // panel_laufwagen_Station_4
            // 
            panel_laufwagen_Station_4.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_4.BackgroundImage");
            panel_laufwagen_Station_4.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_4.Location = new Point(201, 458);
            panel_laufwagen_Station_4.Name = "panel_laufwagen_Station_4";
            panel_laufwagen_Station_4.Size = new Size(63, 63);
            panel_laufwagen_Station_4.TabIndex = 30;
            // 
            // panel_laufwagen_Station_3
            // 
            panel_laufwagen_Station_3.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_3.BackgroundImage");
            panel_laufwagen_Station_3.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_3.Location = new Point(366, 449);
            panel_laufwagen_Station_3.Name = "panel_laufwagen_Station_3";
            panel_laufwagen_Station_3.Size = new Size(63, 63);
            panel_laufwagen_Station_3.TabIndex = 29;
            // 
            // panel_laufwagen_Station_2
            // 
            panel_laufwagen_Station_2.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_2.BackgroundImage");
            panel_laufwagen_Station_2.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_2.Location = new Point(669, 449);
            panel_laufwagen_Station_2.Name = "panel_laufwagen_Station_2";
            panel_laufwagen_Station_2.Size = new Size(63, 63);
            panel_laufwagen_Station_2.TabIndex = 28;
            // 
            // panel_laufwagen_Station_1
            // 
            panel_laufwagen_Station_1.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_1.BackgroundImage");
            panel_laufwagen_Station_1.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_1.Location = new Point(1063, 572);
            panel_laufwagen_Station_1.Name = "panel_laufwagen_Station_1";
            panel_laufwagen_Station_1.Size = new Size(63, 63);
            panel_laufwagen_Station_1.TabIndex = 27;
            // 
            // panel_laufwagen_Station_6
            // 
            panel_laufwagen_Station_6.BackgroundImage = (Image)resources.GetObject("panel_laufwagen_Station_6.BackgroundImage");
            panel_laufwagen_Station_6.BackgroundImageLayout = ImageLayout.Stretch;
            panel_laufwagen_Station_6.Location = new Point(907, 363);
            panel_laufwagen_Station_6.Name = "panel_laufwagen_Station_6";
            panel_laufwagen_Station_6.Size = new Size(63, 63);
            panel_laufwagen_Station_6.TabIndex = 26;
            // 
            // panel_SE_301
            // 
            panel_SE_301.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_301.BackgroundImage = (Image)resources.GetObject("panel_SE_301.BackgroundImage");
            panel_SE_301.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_301.Location = new Point(141, 179);
            panel_SE_301.Name = "panel_SE_301";
            panel_SE_301.Size = new Size(27, 27);
            panel_SE_301.TabIndex = 24;
            // 
            // panel_SE_302
            // 
            panel_SE_302.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_302.BackgroundImage = (Image)resources.GetObject("panel_SE_302.BackgroundImage");
            panel_SE_302.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_302.Location = new Point(222, 179);
            panel_SE_302.Name = "panel_SE_302";
            panel_SE_302.Size = new Size(27, 27);
            panel_SE_302.TabIndex = 23;
            // 
            // panel_SE_303
            // 
            panel_SE_303.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_303.BackgroundImage = (Image)resources.GetObject("panel_SE_303.BackgroundImage");
            panel_SE_303.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_303.Location = new Point(308, 179);
            panel_SE_303.Name = "panel_SE_303";
            panel_SE_303.Size = new Size(27, 27);
            panel_SE_303.TabIndex = 22;
            // 
            // panel_SE_304
            // 
            panel_SE_304.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_304.BackgroundImage = (Image)resources.GetObject("panel_SE_304.BackgroundImage");
            panel_SE_304.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_304.Location = new Point(452, 178);
            panel_SE_304.Name = "panel_SE_304";
            panel_SE_304.Size = new Size(27, 27);
            panel_SE_304.TabIndex = 21;
            // 
            // panel_SE_305
            // 
            panel_SE_305.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_305.BackgroundImage = (Image)resources.GetObject("panel_SE_305.BackgroundImage");
            panel_SE_305.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_305.Location = new Point(533, 178);
            panel_SE_305.Name = "panel_SE_305";
            panel_SE_305.Size = new Size(27, 27);
            panel_SE_305.TabIndex = 20;
            // 
            // panel_SE_306
            // 
            panel_SE_306.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_306.BackgroundImage = (Image)resources.GetObject("panel_SE_306.BackgroundImage");
            panel_SE_306.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_306.Location = new Point(619, 178);
            panel_SE_306.Name = "panel_SE_306";
            panel_SE_306.Size = new Size(27, 27);
            panel_SE_306.TabIndex = 19;
            // 
            // panel_SE_307
            // 
            panel_SE_307.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_307.AutoSize = true;
            panel_SE_307.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_307.BackgroundImage = (Image)resources.GetObject("panel_SE_307.BackgroundImage");
            panel_SE_307.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_307.Location = new Point(773, 179);
            panel_SE_307.MaximumSize = new Size(35, 35);
            panel_SE_307.MinimumSize = new Size(27, 27);
            panel_SE_307.Name = "panel_SE_307";
            panel_SE_307.Size = new Size(27, 27);
            panel_SE_307.TabIndex = 4;
            // 
            // panel_SE_309
            // 
            panel_SE_309.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_309.AutoSize = true;
            panel_SE_309.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_309.BackgroundImage = (Image)resources.GetObject("panel_SE_309.BackgroundImage");
            panel_SE_309.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_309.Location = new Point(994, 179);
            panel_SE_309.MaximumSize = new Size(27, 27);
            panel_SE_309.MinimumSize = new Size(27, 27);
            panel_SE_309.Name = "panel_SE_309";
            panel_SE_309.Size = new Size(27, 27);
            panel_SE_309.TabIndex = 4;
            // 
            // panel_SE_308
            // 
            panel_SE_308.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_308.AutoSize = true;
            panel_SE_308.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_308.BackgroundImage = (Image)resources.GetObject("panel_SE_308.BackgroundImage");
            panel_SE_308.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_308.Location = new Point(894, 179);
            panel_SE_308.MaximumSize = new Size(35, 35);
            panel_SE_308.MinimumSize = new Size(27, 27);
            panel_SE_308.Name = "panel_SE_308";
            panel_SE_308.Size = new Size(27, 27);
            panel_SE_308.TabIndex = 4;
            // 
            // panel_SE_201
            // 
            panel_SE_201.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_201.BackgroundImage = (Image)resources.GetObject("panel_SE_201.BackgroundImage");
            panel_SE_201.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_201.Location = new Point(141, 123);
            panel_SE_201.Name = "panel_SE_201";
            panel_SE_201.Size = new Size(27, 27);
            panel_SE_201.TabIndex = 15;
            // 
            // panel_SE_202
            // 
            panel_SE_202.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_202.BackgroundImage = (Image)resources.GetObject("panel_SE_202.BackgroundImage");
            panel_SE_202.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_202.Location = new Point(222, 123);
            panel_SE_202.Name = "panel_SE_202";
            panel_SE_202.Size = new Size(27, 27);
            panel_SE_202.TabIndex = 14;
            // 
            // panel_SE_203
            // 
            panel_SE_203.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_203.BackgroundImage = (Image)resources.GetObject("panel_SE_203.BackgroundImage");
            panel_SE_203.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_203.Location = new Point(308, 123);
            panel_SE_203.Name = "panel_SE_203";
            panel_SE_203.Size = new Size(27, 27);
            panel_SE_203.TabIndex = 13;
            // 
            // panel_SE_204
            // 
            panel_SE_204.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_204.BackgroundImage = (Image)resources.GetObject("panel_SE_204.BackgroundImage");
            panel_SE_204.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_204.Location = new Point(451, 124);
            panel_SE_204.Name = "panel_SE_204";
            panel_SE_204.Size = new Size(27, 27);
            panel_SE_204.TabIndex = 12;
            // 
            // panel_SE_205
            // 
            panel_SE_205.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_205.BackgroundImage = (Image)resources.GetObject("panel_SE_205.BackgroundImage");
            panel_SE_205.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_205.Location = new Point(532, 124);
            panel_SE_205.Name = "panel_SE_205";
            panel_SE_205.Size = new Size(27, 27);
            panel_SE_205.TabIndex = 11;
            // 
            // panel_SE_206
            // 
            panel_SE_206.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_206.BackgroundImage = (Image)resources.GetObject("panel_SE_206.BackgroundImage");
            panel_SE_206.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_206.Location = new Point(618, 124);
            panel_SE_206.Name = "panel_SE_206";
            panel_SE_206.Size = new Size(27, 27);
            panel_SE_206.TabIndex = 10;
            // 
            // panel_SE_207
            // 
            panel_SE_207.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_207.AutoSize = true;
            panel_SE_207.BackgroundImage = (Image)resources.GetObject("panel_SE_207.BackgroundImage");
            panel_SE_207.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_207.Location = new Point(773, 123);
            panel_SE_207.MaximumSize = new Size(35, 35);
            panel_SE_207.MinimumSize = new Size(27, 27);
            panel_SE_207.Name = "panel_SE_207";
            panel_SE_207.Size = new Size(27, 27);
            panel_SE_207.TabIndex = 4;
            // 
            // panel_SE_209
            // 
            panel_SE_209.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_209.AutoSize = true;
            panel_SE_209.BackgroundImage = (Image)resources.GetObject("panel_SE_209.BackgroundImage");
            panel_SE_209.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_209.Location = new Point(994, 123);
            panel_SE_209.MaximumSize = new Size(35, 35);
            panel_SE_209.MinimumSize = new Size(27, 27);
            panel_SE_209.Name = "panel_SE_209";
            panel_SE_209.Size = new Size(27, 27);
            panel_SE_209.TabIndex = 4;
            // 
            // panel_SE_208
            // 
            panel_SE_208.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_208.AutoSize = true;
            panel_SE_208.BackgroundImage = (Image)resources.GetObject("panel_SE_208.BackgroundImage");
            panel_SE_208.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_208.Location = new Point(894, 123);
            panel_SE_208.MaximumSize = new Size(35, 35);
            panel_SE_208.MinimumSize = new Size(27, 27);
            panel_SE_208.Name = "panel_SE_208";
            panel_SE_208.Size = new Size(27, 27);
            panel_SE_208.TabIndex = 4;
            // 
            // panel_SE_101
            // 
            panel_SE_101.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_101.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_101.BackgroundImage = (Image)resources.GetObject("panel_SE_101.BackgroundImage");
            panel_SE_101.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_101.Location = new Point(737, 63);
            panel_SE_101.MaximumSize = new Size(35, 35);
            panel_SE_101.MinimumSize = new Size(27, 27);
            panel_SE_101.Name = "panel_SE_101";
            panel_SE_101.Size = new Size(27, 27);
            panel_SE_101.TabIndex = 7;
            // 
            // panel_SE_102
            // 
            panel_SE_102.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_102.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_102.BackgroundImage = (Image)resources.GetObject("panel_SE_102.BackgroundImage");
            panel_SE_102.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_102.Location = new Point(773, 63);
            panel_SE_102.MaximumSize = new Size(35, 35);
            panel_SE_102.MinimumSize = new Size(27, 27);
            panel_SE_102.Name = "panel_SE_102";
            panel_SE_102.Size = new Size(27, 27);
            panel_SE_102.TabIndex = 6;
            // 
            // panel_SE_103
            // 
            panel_SE_103.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_103.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_103.BackgroundImage = (Image)resources.GetObject("panel_SE_103.BackgroundImage");
            panel_SE_103.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_103.Location = new Point(809, 63);
            panel_SE_103.MaximumSize = new Size(35, 35);
            panel_SE_103.MinimumSize = new Size(27, 27);
            panel_SE_103.Name = "panel_SE_103";
            panel_SE_103.Size = new Size(27, 27);
            panel_SE_103.TabIndex = 5;
            // 
            // panel_SE_104
            // 
            panel_SE_104.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_104.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_104.BackgroundImage = (Image)resources.GetObject("panel_SE_104.BackgroundImage");
            panel_SE_104.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_104.Location = new Point(845, 63);
            panel_SE_104.MaximumSize = new Size(35, 35);
            panel_SE_104.MinimumSize = new Size(27, 27);
            panel_SE_104.Name = "panel_SE_104";
            panel_SE_104.Size = new Size(27, 27);
            panel_SE_104.TabIndex = 4;
            // 
            // panel_SE_105
            // 
            panel_SE_105.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_105.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_105.BackgroundImage = (Image)resources.GetObject("panel_SE_105.BackgroundImage");
            panel_SE_105.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_105.Location = new Point(881, 63);
            panel_SE_105.MaximumSize = new Size(35, 35);
            panel_SE_105.MinimumSize = new Size(27, 27);
            panel_SE_105.Name = "panel_SE_105";
            panel_SE_105.Size = new Size(27, 27);
            panel_SE_105.TabIndex = 3;
            // 
            // panel_SE_106
            // 
            panel_SE_106.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_106.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_106.BackgroundImage = (Image)resources.GetObject("panel_SE_106.BackgroundImage");
            panel_SE_106.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_106.Location = new Point(917, 63);
            panel_SE_106.MaximumSize = new Size(35, 35);
            panel_SE_106.MinimumSize = new Size(27, 27);
            panel_SE_106.Name = "panel_SE_106";
            panel_SE_106.Size = new Size(27, 27);
            panel_SE_106.TabIndex = 2;
            // 
            // panel_SE_107
            // 
            panel_SE_107.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_SE_107.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_SE_107.BackgroundImage = (Image)resources.GetObject("panel_SE_107.BackgroundImage");
            panel_SE_107.BackgroundImageLayout = ImageLayout.Stretch;
            panel_SE_107.Location = new Point(953, 63);
            panel_SE_107.MaximumSize = new Size(35, 35);
            panel_SE_107.MinimumSize = new Size(27, 27);
            panel_SE_107.Name = "panel_SE_107";
            panel_SE_107.Size = new Size(27, 27);
            panel_SE_107.TabIndex = 1;
            // 
            // panel_Controller
            // 
            panel_Controller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel_Controller.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_Controller.BackColor = Color.FromArgb(224, 224, 224);
            panel_Controller.Controls.Add(panel_blackStrip05);
            panel_Controller.Controls.Add(panel_blackStrip04);
            panel_Controller.Controls.Add(txt_order_queue);
            panel_Controller.Controls.Add(lv_Queue);
            panel_Controller.Controls.Add(panel_blackStrip03);
            panel_Controller.Controls.Add(groupBox_Prodution);
            panel_Controller.Controls.Add(panel_blackStrip01);
            panel_Controller.Controls.Add(panel_blackStrip02);
            panel_Controller.Controls.Add(txt_productionList);
            panel_Controller.Controls.Add(txt_control);
            panel_Controller.Controls.Add(btn_stopPlant);
            panel_Controller.Controls.Add(pic_stopPlant);
            panel_Controller.Controls.Add(btn_startPlant);
            panel_Controller.Controls.Add(pic_startPlant);
            panel_Controller.Controls.Add(btn_maintenance);
            panel_Controller.Controls.Add(pic_maintenance);
            panel_Controller.Controls.Add(btn_pause);
            panel_Controller.Controls.Add(pic_pause);
            panel_Controller.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel_Controller.ForeColor = Color.FromArgb(156, 156, 156);
            panel_Controller.ImeMode = ImeMode.On;
            panel_Controller.Location = new Point(1224, 54);
            panel_Controller.Name = "panel_Controller";
            panel_Controller.Size = new Size(370, 790);
            panel_Controller.TabIndex = 5;
            panel_Controller.Tag = "";
            // 
            // panel_blackStrip05
            // 
            panel_blackStrip05.BackColor = Color.Black;
            panel_blackStrip05.Location = new Point(14, 477);
            panel_blackStrip05.Name = "panel_blackStrip05";
            panel_blackStrip05.Size = new Size(350, 2);
            panel_blackStrip05.TabIndex = 21;
            // 
            // panel_blackStrip04
            // 
            panel_blackStrip04.BackColor = Color.Black;
            panel_blackStrip04.Location = new Point(14, 418);
            panel_blackStrip04.Name = "panel_blackStrip04";
            panel_blackStrip04.Size = new Size(350, 2);
            panel_blackStrip04.TabIndex = 20;
            // 
            // txt_order_queue
            // 
            txt_order_queue.Anchor = AnchorStyles.Top;
            txt_order_queue.BackColor = Color.FromArgb(224, 224, 224);
            txt_order_queue.BorderStyle = BorderStyle.None;
            txt_order_queue.Font = new Font("Nirmala UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_order_queue.ForeColor = Color.Black;
            txt_order_queue.Location = new Point(18, 426);
            txt_order_queue.Name = "txt_order_queue";
            txt_order_queue.ReadOnly = true;
            txt_order_queue.Size = new Size(339, 45);
            txt_order_queue.TabIndex = 19;
            txt_order_queue.Text = "Auftragsqueue";
            txt_order_queue.TextAlign = HorizontalAlignment.Center;
            // 
            // lv_Queue
            // 
            lv_Queue.BackColor = Color.FromArgb(224, 224, 224);
            lv_Queue.BorderStyle = BorderStyle.FixedSingle;
            lv_Queue.Columns.AddRange(new ColumnHeader[] { ID, Customer, Recipe_ID, Recipe, Amount });
            lv_Queue.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lv_Queue.GridLines = true;
            lv_Queue.Location = new Point(20, 489);
            lv_Queue.Name = "lv_Queue";
            lv_Queue.Size = new Size(340, 287);
            lv_Queue.TabIndex = 18;
            lv_Queue.UseCompatibleStateImageBehavior = false;
            lv_Queue.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // Customer
            // 
            Customer.Text = "Kunde";
            Customer.TextAlign = HorizontalAlignment.Center;
            Customer.Width = 80;
            // 
            // Recipe_ID
            // 
            Recipe_ID.Text = "Rezept ID";
            Recipe_ID.TextAlign = HorizontalAlignment.Center;
            Recipe_ID.Width = 80;
            // 
            // Recipe
            // 
            Recipe.Text = "Rezept";
            Recipe.TextAlign = HorizontalAlignment.Center;
            Recipe.Width = 100;
            // 
            // Amount
            // 
            Amount.Text = "STK";
            Amount.TextAlign = HorizontalAlignment.Center;
            Amount.Width = 45;
            // 
            // panel_blackStrip03
            // 
            panel_blackStrip03.BackColor = Color.Black;
            panel_blackStrip03.Location = new Point(14, 231);
            panel_blackStrip03.Name = "panel_blackStrip03";
            panel_blackStrip03.Size = new Size(350, 2);
            panel_blackStrip03.TabIndex = 17;
            // 
            // groupBox_Prodution
            // 
            groupBox_Prodution.BackColor = Color.Moccasin;
            groupBox_Prodution.Controls.Add(txt_status);
            groupBox_Prodution.Controls.Add(txt_percentageFinished);
            groupBox_Prodution.Controls.Add(txt_amountFinished);
            groupBox_Prodution.Controls.Add(txt_totalAmount);
            groupBox_Prodution.Controls.Add(txt_recipeNumber);
            groupBox_Prodution.Controls.Add(txt_orderNumber);
            groupBox_Prodution.Controls.Add(txt_orderName);
            groupBox_Prodution.Controls.Add(panel1);
            groupBox_Prodution.Controls.Add(label_groupBox_Prodution_status);
            groupBox_Prodution.Controls.Add(label_groupBox_Prodution_finishedVolume);
            groupBox_Prodution.Controls.Add(label_groupBox_Prodution_totalVolume);
            groupBox_Prodution.Controls.Add(label_groupBox_Prodution_recipeNr);
            groupBox_Prodution.Controls.Add(label_groupBox_Prodution_order);
            groupBox_Prodution.Location = new Point(20, 245);
            groupBox_Prodution.Name = "groupBox_Prodution";
            groupBox_Prodution.Size = new Size(340, 163);
            groupBox_Prodution.TabIndex = 16;
            groupBox_Prodution.TabStop = false;
            // 
            // txt_status
            // 
            txt_status.BackColor = Color.Moccasin;
            txt_status.BorderStyle = BorderStyle.None;
            txt_status.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_status.Location = new Point(144, 136);
            txt_status.Name = "txt_status";
            txt_status.ReadOnly = true;
            txt_status.Size = new Size(180, 20);
            txt_status.TabIndex = 22;
            txt_status.Text = "1234";
            // 
            // txt_percentageFinished
            // 
            txt_percentageFinished.BackColor = Color.Moccasin;
            txt_percentageFinished.BorderStyle = BorderStyle.None;
            txt_percentageFinished.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_percentageFinished.Location = new Point(229, 110);
            txt_percentageFinished.Name = "txt_percentageFinished";
            txt_percentageFinished.ReadOnly = true;
            txt_percentageFinished.Size = new Size(80, 20);
            txt_percentageFinished.TabIndex = 21;
            txt_percentageFinished.Text = "1234";
            // 
            // txt_amountFinished
            // 
            txt_amountFinished.BackColor = Color.Moccasin;
            txt_amountFinished.BorderStyle = BorderStyle.None;
            txt_amountFinished.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_amountFinished.Location = new Point(144, 111);
            txt_amountFinished.Name = "txt_amountFinished";
            txt_amountFinished.ReadOnly = true;
            txt_amountFinished.Size = new Size(80, 20);
            txt_amountFinished.TabIndex = 20;
            txt_amountFinished.Text = "1234";
            // 
            // txt_totalAmount
            // 
            txt_totalAmount.BackColor = Color.Moccasin;
            txt_totalAmount.BorderStyle = BorderStyle.None;
            txt_totalAmount.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_totalAmount.Location = new Point(144, 86);
            txt_totalAmount.Name = "txt_totalAmount";
            txt_totalAmount.ReadOnly = true;
            txt_totalAmount.Size = new Size(180, 20);
            txt_totalAmount.TabIndex = 19;
            txt_totalAmount.Text = "1234";
            // 
            // txt_recipeNumber
            // 
            txt_recipeNumber.BackColor = Color.Moccasin;
            txt_recipeNumber.BorderStyle = BorderStyle.None;
            txt_recipeNumber.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_recipeNumber.Location = new Point(144, 62);
            txt_recipeNumber.Name = "txt_recipeNumber";
            txt_recipeNumber.ReadOnly = true;
            txt_recipeNumber.Size = new Size(180, 20);
            txt_recipeNumber.TabIndex = 18;
            txt_recipeNumber.Text = "1234";
            // 
            // txt_orderNumber
            // 
            txt_orderNumber.BackColor = Color.Moccasin;
            txt_orderNumber.BorderStyle = BorderStyle.None;
            txt_orderNumber.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_orderNumber.Location = new Point(144, 36);
            txt_orderNumber.Name = "txt_orderNumber";
            txt_orderNumber.ReadOnly = true;
            txt_orderNumber.Size = new Size(180, 20);
            txt_orderNumber.TabIndex = 17;
            txt_orderNumber.Text = "1234";
            // 
            // txt_orderName
            // 
            txt_orderName.BackColor = Color.Moccasin;
            txt_orderName.BorderStyle = BorderStyle.None;
            txt_orderName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_orderName.Location = new Point(11, 2);
            txt_orderName.Name = "txt_orderName";
            txt_orderName.ReadOnly = true;
            txt_orderName.Size = new Size(312, 26);
            txt_orderName.TabIndex = 16;
            txt_orderName.Text = "Auftragsname";
            txt_orderName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 2);
            panel1.TabIndex = 15;
            // 
            // label_groupBox_Prodution_status
            // 
            label_groupBox_Prodution_status.AutoSize = true;
            label_groupBox_Prodution_status.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_groupBox_Prodution_status.ForeColor = Color.Black;
            label_groupBox_Prodution_status.Location = new Point(4, 136);
            label_groupBox_Prodution_status.Name = "label_groupBox_Prodution_status";
            label_groupBox_Prodution_status.Size = new Size(52, 20);
            label_groupBox_Prodution_status.TabIndex = 4;
            label_groupBox_Prodution_status.Text = "Status:";
            // 
            // label_groupBox_Prodution_finishedVolume
            // 
            label_groupBox_Prodution_finishedVolume.AutoSize = true;
            label_groupBox_Prodution_finishedVolume.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_groupBox_Prodution_finishedVolume.ForeColor = Color.Black;
            label_groupBox_Prodution_finishedVolume.Location = new Point(4, 111);
            label_groupBox_Prodution_finishedVolume.Name = "label_groupBox_Prodution_finishedVolume";
            label_groupBox_Prodution_finishedVolume.Size = new Size(114, 20);
            label_groupBox_Prodution_finishedVolume.TabIndex = 3;
            label_groupBox_Prodution_finishedVolume.Text = "Stückzahl fertig:";
            // 
            // label_groupBox_Prodution_totalVolume
            // 
            label_groupBox_Prodution_totalVolume.AutoSize = true;
            label_groupBox_Prodution_totalVolume.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_groupBox_Prodution_totalVolume.ForeColor = Color.Black;
            label_groupBox_Prodution_totalVolume.Location = new Point(4, 86);
            label_groupBox_Prodution_totalVolume.Name = "label_groupBox_Prodution_totalVolume";
            label_groupBox_Prodution_totalVolume.Size = new Size(127, 20);
            label_groupBox_Prodution_totalVolume.TabIndex = 2;
            label_groupBox_Prodution_totalVolume.Text = "Stückzahl gesamt:";
            // 
            // label_groupBox_Prodution_recipeNr
            // 
            label_groupBox_Prodution_recipeNr.AutoSize = true;
            label_groupBox_Prodution_recipeNr.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_groupBox_Prodution_recipeNr.ForeColor = Color.Black;
            label_groupBox_Prodution_recipeNr.Location = new Point(4, 63);
            label_groupBox_Prodution_recipeNr.Name = "label_groupBox_Prodution_recipeNr";
            label_groupBox_Prodution_recipeNr.Size = new Size(62, 20);
            label_groupBox_Prodution_recipeNr.TabIndex = 1;
            label_groupBox_Prodution_recipeNr.Text = "Rezept :";
            // 
            // label_groupBox_Prodution_order
            // 
            label_groupBox_Prodution_order.AutoSize = true;
            label_groupBox_Prodution_order.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_groupBox_Prodution_order.ForeColor = Color.Black;
            label_groupBox_Prodution_order.Location = new Point(4, 39);
            label_groupBox_Prodution_order.Name = "label_groupBox_Prodution_order";
            label_groupBox_Prodution_order.Size = new Size(90, 20);
            label_groupBox_Prodution_order.TabIndex = 0;
            label_groupBox_Prodution_order.Text = "Auftrags Nr.:";
            // 
            // panel_blackStrip01
            // 
            panel_blackStrip01.BackColor = Color.Black;
            panel_blackStrip01.Location = new Point(14, 56);
            panel_blackStrip01.Name = "panel_blackStrip01";
            panel_blackStrip01.Size = new Size(350, 2);
            panel_blackStrip01.TabIndex = 15;
            // 
            // panel_blackStrip02
            // 
            panel_blackStrip02.BackColor = Color.Black;
            panel_blackStrip02.Location = new Point(14, 172);
            panel_blackStrip02.Name = "panel_blackStrip02";
            panel_blackStrip02.Size = new Size(350, 2);
            panel_blackStrip02.TabIndex = 14;
            // 
            // txt_productionList
            // 
            txt_productionList.Anchor = AnchorStyles.Top;
            txt_productionList.BackColor = Color.FromArgb(224, 224, 224);
            txt_productionList.BorderStyle = BorderStyle.None;
            txt_productionList.Font = new Font("Nirmala UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_productionList.ForeColor = Color.Black;
            txt_productionList.Location = new Point(18, 180);
            txt_productionList.Name = "txt_productionList";
            txt_productionList.ReadOnly = true;
            txt_productionList.Size = new Size(339, 45);
            txt_productionList.TabIndex = 13;
            txt_productionList.Text = "Aktiver Auftrag";
            txt_productionList.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_control
            // 
            txt_control.Anchor = AnchorStyles.Top;
            txt_control.BackColor = Color.FromArgb(224, 224, 224);
            txt_control.BorderStyle = BorderStyle.None;
            txt_control.Font = new Font("Nirmala UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_control.ForeColor = Color.Black;
            txt_control.Location = new Point(18, 13);
            txt_control.Name = "txt_control";
            txt_control.ReadOnly = true;
            txt_control.Size = new Size(339, 45);
            txt_control.TabIndex = 12;
            txt_control.Text = "Kontrollzentrum";
            txt_control.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_stopPlant
            // 
            btn_stopPlant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_stopPlant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_stopPlant.BackColor = Color.FromArgb(0, 46, 119);
            btn_stopPlant.BackgroundImageLayout = ImageLayout.Center;
            btn_stopPlant.FlatAppearance.BorderSize = 0;
            btn_stopPlant.FlatStyle = FlatStyle.Flat;
            btn_stopPlant.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stopPlant.ForeColor = Color.White;
            btn_stopPlant.Location = new Point(210, 117);
            btn_stopPlant.Name = "btn_stopPlant";
            btn_stopPlant.Size = new Size(133, 45);
            btn_stopPlant.TabIndex = 11;
            btn_stopPlant.Tag = "";
            btn_stopPlant.Text = "Stop";
            btn_stopPlant.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_stopPlant.UseVisualStyleBackColor = false;
            btn_stopPlant.Click += btn_stopPlant_Click;
            // 
            // pic_stopPlant
            // 
            pic_stopPlant.AccessibleName = "";
            pic_stopPlant.BackColor = Color.Transparent;
            pic_stopPlant.BackgroundImage = (Image)resources.GetObject("pic_stopPlant.BackgroundImage");
            pic_stopPlant.BackgroundImageLayout = ImageLayout.Stretch;
            pic_stopPlant.Location = new Point(199, 117);
            pic_stopPlant.Name = "pic_stopPlant";
            pic_stopPlant.Size = new Size(160, 45);
            pic_stopPlant.TabIndex = 10;
            pic_stopPlant.TabStop = false;
            // 
            // btn_startPlant
            // 
            btn_startPlant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_startPlant.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_startPlant.BackColor = Color.FromArgb(0, 46, 119);
            btn_startPlant.BackgroundImageLayout = ImageLayout.Center;
            btn_startPlant.FlatAppearance.BorderSize = 0;
            btn_startPlant.FlatStyle = FlatStyle.Flat;
            btn_startPlant.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_startPlant.ForeColor = Color.White;
            btn_startPlant.Location = new Point(31, 117);
            btn_startPlant.Name = "btn_startPlant";
            btn_startPlant.Size = new Size(133, 45);
            btn_startPlant.TabIndex = 9;
            btn_startPlant.Tag = "";
            btn_startPlant.Text = "Start";
            btn_startPlant.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_startPlant.UseVisualStyleBackColor = false;
            btn_startPlant.Click += btn_startPlant_Click;
            // 
            // pic_startPlant
            // 
            pic_startPlant.AccessibleName = "";
            pic_startPlant.BackColor = Color.Transparent;
            pic_startPlant.BackgroundImage = (Image)resources.GetObject("pic_startPlant.BackgroundImage");
            pic_startPlant.BackgroundImageLayout = ImageLayout.Stretch;
            pic_startPlant.Location = new Point(20, 117);
            pic_startPlant.Name = "pic_startPlant";
            pic_startPlant.Size = new Size(160, 45);
            pic_startPlant.TabIndex = 8;
            pic_startPlant.TabStop = false;
            // 
            // btn_maintenance
            // 
            btn_maintenance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maintenance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_maintenance.BackColor = Color.FromArgb(0, 46, 119);
            btn_maintenance.BackgroundImageLayout = ImageLayout.Center;
            btn_maintenance.FlatAppearance.BorderSize = 0;
            btn_maintenance.FlatStyle = FlatStyle.Flat;
            btn_maintenance.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_maintenance.ForeColor = Color.White;
            btn_maintenance.Location = new Point(210, 64);
            btn_maintenance.Name = "btn_maintenance";
            btn_maintenance.Size = new Size(133, 45);
            btn_maintenance.TabIndex = 7;
            btn_maintenance.Tag = "";
            btn_maintenance.Text = "Wartung";
            btn_maintenance.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_maintenance.UseVisualStyleBackColor = false;
            btn_maintenance.Click += btn_maintenance_Click;
            // 
            // pic_maintenance
            // 
            pic_maintenance.AccessibleName = "";
            pic_maintenance.BackColor = Color.Transparent;
            pic_maintenance.BackgroundImage = (Image)resources.GetObject("pic_maintenance.BackgroundImage");
            pic_maintenance.BackgroundImageLayout = ImageLayout.Stretch;
            pic_maintenance.Location = new Point(199, 64);
            pic_maintenance.Name = "pic_maintenance";
            pic_maintenance.Size = new Size(160, 45);
            pic_maintenance.TabIndex = 6;
            pic_maintenance.TabStop = false;
            // 
            // btn_pause
            // 
            btn_pause.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pause.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_pause.BackColor = Color.FromArgb(0, 46, 119);
            btn_pause.BackgroundImageLayout = ImageLayout.Center;
            btn_pause.FlatAppearance.BorderSize = 0;
            btn_pause.FlatStyle = FlatStyle.Flat;
            btn_pause.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pause.ForeColor = Color.White;
            btn_pause.Location = new Point(31, 64);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(133, 45);
            btn_pause.TabIndex = 5;
            btn_pause.Tag = "";
            btn_pause.Text = "Pause";
            btn_pause.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_pause.UseVisualStyleBackColor = false;
            btn_pause.Click += btn_pause_Click;
            // 
            // pic_pause
            // 
            pic_pause.AccessibleName = "";
            pic_pause.BackColor = Color.Transparent;
            pic_pause.BackgroundImage = (Image)resources.GetObject("pic_pause.BackgroundImage");
            pic_pause.BackgroundImageLayout = ImageLayout.Stretch;
            pic_pause.Location = new Point(20, 64);
            pic_pause.Name = "pic_pause";
            pic_pause.Size = new Size(160, 45);
            pic_pause.TabIndex = 1;
            pic_pause.TabStop = false;
            // 
            // PlantView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(panel_Controller);
            Controls.Add(dropdownPanel);
            Controls.Add(bluestripe_bottom);
            Controls.Add(bluestripe_top);
            Controls.Add(panel_railsystem);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlantView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plant View";
            Activated += DateTime;
            bluestripe_top.ResumeLayout(false);
            bluestripe_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_fhlogo).EndInit();
            bluestripe_bottom.ResumeLayout(false);
            bluestripe_bottom.PerformLayout();
            dropdownPanel.ResumeLayout(false);
            panel_railsystem.ResumeLayout(false);
            panel_railsystem.PerformLayout();
            panel_Controller.ResumeLayout(false);
            panel_Controller.PerformLayout();
            groupBox_Prodution.ResumeLayout(false);
            groupBox_Prodution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_stopPlant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_startPlant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_maintenance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_pause).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bluestripe_top;
        private PictureBox pic_fhlogo;
        private Panel bluestripe_bottom;
        private Button btn_max_min;
        private Button btn_exit;
        private Button btn_minimized;
        private Panel dropdownPanel;
        private TextBox txt_simpleScada;
        private Panel panel_railsystem;
        private Panel panel_Controller;
        private PictureBox pic_maintenance;
        internal Button btn_pause;
        private PictureBox pic_pause;
        private PictureBox pic_stopPlant;
        private PictureBox pic_startPlant;
        private TextBox txt_control;
        private Label DezeitEingelogged;
        internal Button btn_error;
        internal Button btn_history;
        internal Button btn_ooe;
        internal Button btn_order_edit;
        internal Button btn_recipe_edit;
        internal Button btn_user;
        internal Button btn_user_manager;
        internal Button btn_password;
        internal Button btn_logout;
        internal Button btn_login;
        internal TextBox txt_user;
        internal Button btn_maintenance;
        internal Button btn_stopPlant;
        internal Button btn_startPlant;
        private Panel panel_SE_106;
        private Panel panel_SE_107;
        private Panel panel_SE_105;
        private Panel panel_SE_102;
        private Panel panel_SE_103;
        private Panel panel_SE_104;
        private Panel panel_SE_101;
        private Panel panel_SE_207;
        private Panel panel_SE_209;
        private Panel panel_SE_208;
        private Panel panel_SE_206;
        private Panel panel_SE_204;
        private Panel panel_SE_205;
        private Panel panel_SE_301;
        private Panel panel_se_302;
        private Panel panel_SE_303;
        private Panel panel_SE_304;
        private Panel panel_SE_305;
        private Panel panel_SE_306;
        private Panel panel_SE_307;
        private Panel panel_SE_309;
        private Panel panel_SE_308;
        private Panel panel_SE_201;
        private Panel panel_SE_202;
        private Panel panel_SE_203;
        private Panel panel_laufwagen_Station_4;
        private Panel panel_laufwagen_Station_6;
        private Panel panel_laufwagen_Station_5;
        private Panel panel_laufwagen_Station_3;
        private Panel panel_laufwagen_Station_2;
        private Panel panel_laufwagen_Station_1;
        private Panel panel6;
        private Panel panel5;
        internal System.ComponentModel.BackgroundWorker backgroundworkerAktiveProductioncycle;
        internal System.ComponentModel.BackgroundWorker backgroundWorkerSensorData;
        private Panel panel_blackStrip02;
        private TextBox txt_productionList;
        private Panel panel_blackStrip01;
        private GroupBox groupBox_Prodution;
        private Label label_groupBox_Prodution_order;
        private Label label_groupBox_Prodution_recipeNr;
        private Label label_groupBox_Prodution_finishedVolume;
        private Label label_groupBox_Prodution_totalVolume;
        private Label label_groupBox_Prodution_status;
        private Panel panel1;
        private Panel panel_blackStrip03;
        internal TextBox txt_orderNumber;
        internal TextBox txt_orderName;
        internal TextBox txt_totalAmount;
        internal TextBox txt_recipeNumber;
        internal TextBox txt_amountFinished;
        internal TextBox txt_status;
        internal TextBox txt_percentageFinished;
        private Panel panel_SE_302;
        internal System.ComponentModel.BackgroundWorker backgroundWorkerProductionQueue;
        internal ListView lv_Queue;
        private ColumnHeader ID;
        private ColumnHeader Customer;
        private ColumnHeader Recipe_ID;
        private ColumnHeader Recipe;
        private ColumnHeader Amount;
        private Panel panel_blackStrip05;
        private Panel panel_blackStrip04;
        private TextBox txt_order_queue;
        private Label label1;
        internal TextBox txt_MachineStatus;
        private Panel panel_TS_501;
        private Panel panel_TS_402;
        private Panel panel_TS_401;
        private Panel panel_TS_302;
        private Panel panel_TS_304;
        private Panel panel_TS_204;
        private Panel panel_TS_303;
        private Panel panel_TS_203;
        private Panel panel_TS_301;
        private Panel panel_TS_202;
        private Panel panel_TS_201;
        private Panel panel_TS_102;
        private Panel panel_TS_101;
        public TextBox txt_time;
        public TextBox txt_date;
        internal Button btn_joke;
    }
}