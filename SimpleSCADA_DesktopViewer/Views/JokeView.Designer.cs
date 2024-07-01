namespace SimpleSCADA_DesktopViewer.Views
{
    partial class JokeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JokeView));
            txt_joke = new TextBox();
            btn_Serious = new Button();
            btn_CloseRecipe = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel_transparent = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_transparent.SuspendLayout();
            SuspendLayout();
            // 
            // txt_joke
            // 
            txt_joke.AllowDrop = true;
            txt_joke.Location = new Point(30, 422);
            txt_joke.Multiline = true;
            txt_joke.Name = "txt_joke";
            txt_joke.ReadOnly = true;
            txt_joke.ScrollBars = ScrollBars.Horizontal;
            txt_joke.Size = new Size(303, 72);
            txt_joke.TabIndex = 0;
            // 
            // btn_Serious
            // 
            btn_Serious.BackColor = Color.FromArgb(0, 46, 119);
            btn_Serious.FlatStyle = FlatStyle.Flat;
            btn_Serious.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Serious.ForeColor = Color.White;
            btn_Serious.Location = new Point(30, 386);
            btn_Serious.Name = "btn_Serious";
            btn_Serious.Size = new Size(303, 30);
            btn_Serious.TabIndex = 1;
            btn_Serious.Text = "Keine Angst bin super seriös?";
            btn_Serious.UseVisualStyleBackColor = false;
            btn_Serious.Click += btn_Serious_Click;
            // 
            // btn_CloseRecipe
            // 
            btn_CloseRecipe.BackColor = Color.FromArgb(224, 224, 224);
            btn_CloseRecipe.BackgroundImageLayout = ImageLayout.Center;
            btn_CloseRecipe.FlatAppearance.BorderSize = 0;
            btn_CloseRecipe.FlatStyle = FlatStyle.Flat;
            btn_CloseRecipe.ForeColor = Color.Lime;
            btn_CloseRecipe.Image = (Image)resources.GetObject("btn_CloseRecipe.Image");
            btn_CloseRecipe.Location = new Point(319, -4);
            btn_CloseRecipe.Margin = new Padding(3, 4, 3, 4);
            btn_CloseRecipe.Name = "btn_CloseRecipe";
            btn_CloseRecipe.Size = new Size(44, 49);
            btn_CloseRecipe.TabIndex = 6;
            btn_CloseRecipe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_CloseRecipe.UseMnemonic = false;
            btn_CloseRecipe.UseVisualStyleBackColor = true;
            btn_CloseRecipe.Click += btn_CloseRecipe_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 254);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 9);
            label2.Name = "label2";
            label2.Size = new Size(226, 114);
            label2.TabIndex = 43;
            label2.Text = "Diese Anlage\r\nrespektiert sogar\r\nChuck Norris";
            label2.MouseDown += panel_mouse_down;
            label2.MouseMove += panel_move;
            label2.MouseUp += panel_mouse_up;
            // 
            // panel_transparent
            // 
            panel_transparent.BackColor = Color.Transparent;
            panel_transparent.Controls.Add(btn_CloseRecipe);
            panel_transparent.Location = new Point(0, 0);
            panel_transparent.Name = "panel_transparent";
            panel_transparent.Size = new Size(363, 45);
            panel_transparent.TabIndex = 90;
            panel_transparent.MouseDown += panel_mouse_down;
            panel_transparent.MouseMove += panel_move;
            panel_transparent.MouseUp += panel_mouse_up;
            // 
            // JokeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(363, 506);
            Controls.Add(label2);
            Controls.Add(panel_transparent);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Serious);
            Controls.Add(txt_joke);
            FormBorderStyle = FormBorderStyle.None;
            Name = "JokeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JokeView";
            Load += JokeView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_transparent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_joke;
        private Button btn_Serious;
        private Button btn_CloseRecipe;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel_transparent;
    }
}