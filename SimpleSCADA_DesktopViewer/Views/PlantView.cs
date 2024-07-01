using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer
{

    public partial class PlantView : Form
    {
        //Events
        public event EventHandler RecipeWindowRequired;
        public event EventHandler ErrorViewRequired;
        public event EventHandler JobProcessingWindowRequired;
        public event EventHandler LogInWindowRequired;
        public event EventHandler OEEViewRequired;
        public event EventHandler PasswordChangeViewRequired;
        public event EventHandler PoductionHistoryWindowRequired;
        public event EventHandler UserViewRequired;
        public event EventHandler JokeViewRequired;
        public event EventHandler LogOutUser;
        public event EventHandler<PlantView> DateTimeRequested;
        public event EventHandler<PlantState> PauseStateRequested;
        public event EventHandler<PlantState> StartStateRequested;
        public event EventHandler<PlantState> StopStateRequested;
        public event EventHandler<PlantState> MaintanceStateRequested;


        //Variables
        bool isMaximized;
        bool isDropdownPanel;
        bool isMouseDown;
        Point lastLocation;

        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }

        public PlantView()
        {
            InitializeComponent();
            dropdownPanel.Visible = false; // User Panel wo Login, PW Changer, User Manager und Logout drinnen ist
            InitialStateOfView();
            //DateTime(this);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_max_min_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                isMaximized = false;
                WindowState = FormWindowState.Normal;
                return;
            }
            WindowState = FormWindowState.Maximized;
            isMaximized = true;
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_history_click(object sender, EventArgs e)
        {
            PoductionHistoryWindowRequired?.Invoke(this, e);
        }

        private void btn_ooe_Click(object sender, EventArgs e)
        {
            OEEViewRequired?.Invoke(this, e);
        }

        private void btn_order_edit_Click(object sender, EventArgs e)
        {
            JobProcessingWindowRequired?.Invoke(this, e);
        }

        private void btn_recipe_edit_Click(object sender, EventArgs e)
        {
            RecipeWindowRequired?.Invoke(this, e);
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (isDropdownPanel)
            {
                isDropdownPanel = false;
                dropdownPanel.Visible = false;
                return;
            }
            dropdownPanel.Visible = true;
            isDropdownPanel = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            isDropdownPanel = false;
            dropdownPanel.Visible = false;
            LogInWindowRequired?.Invoke(this, e);
        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            isDropdownPanel = false;
            dropdownPanel.Visible = false;
            PasswordChangeViewRequired?.Invoke(this, e);
        }

        private void btn_user_manager_Click(object sender, EventArgs e)
        {
            isDropdownPanel = false;
            dropdownPanel.Visible = false;
            UserViewRequired?.Invoke(this, e);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            isDropdownPanel = false;
            dropdownPanel.Visible = false;

            LogOutUser?.Invoke(this, e);
            InitialStateOfView();

        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            ErrorViewRequired?.Invoke(this, e);
        }



        private void panel_mouse_down(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void panel_mouse_up(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel_move(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            PauseStateRequested?.Invoke(this, PlantState.PAUSED);//DateTimeRequested
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            MaintanceStateRequested?.Invoke(this, PlantState.MAINTENANCE);
        }

        private void btn_startPlant_Click(object sender, EventArgs e)
        {
            StartStateRequested?.Invoke(this, PlantState.RUNNING);
        }

        private void btn_stopPlant_Click(object sender, EventArgs e)
        {
            StartStateRequested?.Invoke(this, PlantState.STOP);
        }

        private void DateTime(object sender, EventArgs e)
        {
            DateTimeRequested?.Invoke(this, this);
        }

        private void btn_joke_Click(object sender, EventArgs e)
        {
            JokeViewRequired?.Invoke(this, e);
        }

        #region Helpful Methods

        public List<Panel> GetPlantControls()
        {
            List<Panel> panels = new List<Panel>();
            var controls = GetAllControls(this);
            foreach (var control in controls)
            {
                if (control is Panel && (control.Name.Contains("_SE") || control.Name.Contains("_TS") || control.Name.Contains("_laufwagen")))
                    panels.Add(control as Panel);
            }
            return panels;
        }
        private void InitialStateOfView()
        {
            //Buttons Kontrollzentrum
            this.btn_pause.Enabled = false;
            this.btn_maintenance.Enabled = false;
            this.btn_startPlant.Enabled = false;
            this.btn_stopPlant.Enabled = false;

            //Buttons Taskleiste
            this.btn_error.Enabled = false;
            this.btn_history.Enabled = false;
            this.btn_ooe.Enabled = false;
            this.btn_order_edit.Enabled = false;
            this.btn_recipe_edit.Enabled = false;
            this.btn_password.Enabled = false;
            this.btn_user_manager.Enabled = false;
            this.btn_login.Enabled = true;
            this.btn_joke.Enabled = false;

            //Logged on User Text
            this.txt_user.Text = "-";

            //Laufwagen Stationen
            this.panel_laufwagen_Station_1.Visible = false;
            this.panel_laufwagen_Station_2.Visible = false;
            this.panel_laufwagen_Station_3.Visible = false;
            this.panel_laufwagen_Station_4.Visible = false;
            this.panel_laufwagen_Station_5.Visible = false;
            this.panel_laufwagen_Station_6.Visible = false;
        }
        #endregion


    }
}