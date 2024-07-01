using SimpleSCADA_DesktopViewer.CustomEventArgs;
using SimpleSCADA_SharedResources;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleSCADA_DesktopViewer
{
    public partial class RecipeView : Form
    {
        #region Eventhandler

        public event EventHandler<string> GetRecipe;
        public event EventHandler<Recipe> SaveRecipe;
        public event EventHandler<string> DeleteRecipe;
        public event EventHandler<int> EditRecipe;
        public event EventHandler UpdateView;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged1;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged2;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged3;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged4;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged5;
        public event EventHandler<string> GetEstimatedTimeOnIndexChanged6;
        public event EventHandler CalculateTime;


        #endregion

        #region Variables
        //derzeit Hardcoded vll gibts eine schönere Lösung
        private List<int> _orderNumber = new List<int> { 1, 2, 3, 4, 5, 6 };
        private List<string> usedOrderNumbers = new List<string>();

        bool isMouseDown;
        Point lastLocation;

        private Dictionary<int, ComboBox> boxes;

        #endregion

        #region Events and Constructor

        public RecipeView()
        {
            InitializeComponent();
            DataBindingOrderComboBox();

            boxes = new Dictionary<int, ComboBox>()
            {
                {1, cbox_OrderStation1},
                {2, cbox_OrderStation2},
                {3, cbox_OrderStation3},
                {4, cbox_OrderStation4},
                {5, cbox_OrderStation5},
                {6, cbox_OrderStation6},

            };
        }

        // Get Recipe on Button Load clicked
        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (cbox_recipeExisting.SelectedIndex != 0)
            {
                GetRecipe?.Invoke(this, cbox_recipeExisting.Text);
            }
            else
            {
                MessageBox.Show("Es muss ein Rezept aus der Liste ausgewählt werden um dieses Laden zu können");
            }
        }

        // Save Recipe on Button save clicked
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Überprüfung ob Station inkludiert ist im Rezept -> weitere Prüfung ob ein Wert für die Reihenfolge doppelt ist
            // bei doppeltem Wert Fehlermeldung anzeigen
            if (cb_station1.Checked)
                usedOrderNumbers.Add(cbox_OrderStation1.SelectedValue.ToString());
            if (cb_station2.Checked)
                usedOrderNumbers.Add(cbox_OrderStation2.SelectedValue.ToString());
            if (cb_station3.Checked)
                usedOrderNumbers.Add(cbox_OrderStation3.SelectedValue.ToString());
            if (cb_station4.Checked)
                usedOrderNumbers.Add(cbox_OrderStation4.SelectedValue.ToString());
            if (cb_station5.Checked)
                usedOrderNumbers.Add(cbox_OrderStation5.SelectedValue.ToString());
            if (cb_station6.Checked)
                usedOrderNumbers.Add(cbox_OrderStation6.SelectedValue.ToString());

            if (usedOrderNumbers.GroupBy(x => x).All(y => y.Count() == 1))
            {
                if (cbox_recipeExisting.SelectedIndex == 0)
                {
                    Recipe recipe = new Recipe(txtb_recipename.Text);
                    SaveRecipe?.Invoke(this, recipe);

                }
                else
                {
                    int recipeID;
                    int.TryParse(txtb_recipeNumber.Text, out recipeID);
                    EditRecipe?.Invoke(this, recipeID);
                }
                ResetViewToDefault();
            }
            else
            {
                var duplicates = usedOrderNumbers.GroupBy(x => x).Where(y => y.Count() > 1).SelectMany(x => x.Key).ToList();
                usedOrderNumbers.Clear();
                MessageBox.Show($"Folgenden Werte kommen des öfteren in der Reihenfolgevor: {string.Join(" | ", duplicates)}" + System.Environment.NewLine +
                                    $"Die Werte dürfen nur einmal ausgewählt werden");
            }
        }

        //Delete Recipe on Button Delete clicked
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteRecipe?.Invoke(this, cbox_recipeExisting.Text);
            ResetViewToDefault();

        }

        //Hide Window on Button Abort clicked and clear all fields
        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetViewToDefault();
        }
        //Close Window on Button Close clicked and clear all fields
        private void btn_CloseRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetViewToDefault();

        }

        private void cbox_recipeExisting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Help Methods

        private void DataBindingOrderComboBox()
        {
            cbox_OrderStation1.DataSource = new BindingList<int>(_orderNumber);
            cbox_OrderStation2.DataSource = new BindingList<int>(_orderNumber);
            cbox_OrderStation3.DataSource = new BindingList<int>(_orderNumber);
            cbox_OrderStation4.DataSource = new BindingList<int>(_orderNumber);
            cbox_OrderStation5.DataSource = new BindingList<int>(_orderNumber);
            cbox_OrderStation6.DataSource = new BindingList<int>(_orderNumber);
        }

        private void ResetViewToDefault()
        {
            //Reset List of Recipes to whats in DB
            UpdateView?.Invoke(this, EventArgs.Empty);
            cbox_recipeExisting.Refresh();

            //Uncheck all Checkboxes on Form
            cb_station1.Checked = false;
            cb_station2.Checked = false;
            cb_station3.Checked = false;
            cb_station4.Checked = false;
            cb_station5.Checked = false;
            cb_station6.Checked = false;

            // set all Order Values back to first element of list
            cbox_OrderStation1.Text = _orderNumber.ElementAt(0).ToString();
            cbox_OrderStation2.Text = _orderNumber.ElementAt(0).ToString();
            cbox_OrderStation3.Text = _orderNumber.ElementAt(0).ToString();
            cbox_OrderStation4.Text = _orderNumber.ElementAt(0).ToString();
            cbox_OrderStation5.Text = _orderNumber.ElementAt(0).ToString();
            cbox_OrderStation6.Text = _orderNumber.ElementAt(0).ToString();

            //

            //Set all Konfigurations back
            txtb_recipeNumber.Text = String.Empty;
            txtb_recipename.Text = String.Empty;
            txtb_EstimatedTimeAll.Text = String.Empty;
            txtb_EstimatedTimeDrive.Text = String.Empty;

            usedOrderNumbers.Clear();
        }

        public void LoadRecipeFromDB(object sender, Recipe recipe)
        {
            int sumTime = 0;

            txtb_recipename.Text = recipe.Name;
            txtb_recipeNumber.Text = recipe.Id.ToString();

            ICollection<StationWithChosenUtility> allStations = recipe.Stations;

            foreach (StationWithChosenUtility station in allStations)
            {

                if (station.StationId == 1)
                {
                    cbox_ConfigStation1.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime1.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station1.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation1.Text = station.OrderNumber.ToString();
                }
                if (station.StationId == 2)
                {
                    cbox_ConfigStation2.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime2.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station2.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation2.Text = station.OrderNumber.ToString();
                }
                if (station.StationId == 3)
                {
                    cbox_ConfigStation3.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime3.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station3.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation3.Text = station.OrderNumber.ToString();
                }
                if (station.StationId == 4)
                {
                    cbox_ConfigStation4.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime4.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station4.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation4.Text = station.OrderNumber.ToString();
                }
                if (station.StationId == 5)
                {
                    cbox_ConfigStation5.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime5.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station5.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation5.Text = station.OrderNumber.ToString();
                }
                if (station.StationId == 6)
                {
                    cbox_ConfigStation6.Text = station.ChosenUtility.Name;
                    txtb_EstimatedTime6.Text = station.ChosenUtility.SecondsToWait.ToString();
                    cb_station6.Checked = true;
                    sumTime += station.ChosenUtility.SecondsToWait;
                    cbox_OrderStation6.Text = station.OrderNumber.ToString();
                }
            }

            int driveTime = sumTime / 10;
            txtb_EstimatedTimeDrive.Text = driveTime.ToString();
            sumTime += driveTime;
            txtb_EstimatedTimeAll.Text = sumTime.ToString();

            //Add the loading of the visualization of the stations and which station is included in the recipe
        }

        private void cbox_ConfigStation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged1?.Invoke(this, cbox_ConfigStation1.Text);

        }

        private void cbox_ConfigStation2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged2?.Invoke(this, cbox_ConfigStation2.Text);
        }

        private void cbox_ConfigStation3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged3?.Invoke(this, cbox_ConfigStation3.Text);
        }

        private void cbox_ConfigStation4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged4?.Invoke(this, cbox_ConfigStation4.Text);
        }

        private void cbox_ConfigStation5_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged5?.Invoke(this, cbox_ConfigStation5.Text);
        }

        private void cbox_ConfigStation6_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEstimatedTimeOnIndexChanged6?.Invoke(this, cbox_ConfigStation6.Text);
        }
        #endregion

        private void cb_station1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void cb_station2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void cb_station3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void cb_station4_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void cb_station5_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void cb_station6_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTime?.Invoke(this, EventArgs.Empty);
        }

        private void panel_move(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
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
    }
}

