using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Cms;
using SimpleSCADA_SharedResources;
using Utility = SimpleSCADA_SharedResources.Utility;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class RecipeManagerPresenter
    {
        #region Membervariables
        //Models
        private RecipeManager _recipeManager;

        //View
        private RecipeView _recipeView;

        //Events
        public event EventHandler<Recipe> LoadRecipe;
        #endregion

        #region Constructor

        public RecipeManagerPresenter(RecipeManager recipeManager)
        {
            _recipeManager = recipeManager;
            _recipeView = new RecipeView();
            
            SetUpLinks();
        }

        #endregion

        #region Methods

        private void SetUpLinks()
        {
            LoadRecipe += _recipeView.LoadRecipeFromDB;

            _recipeView.GetRecipe += GetRecipe;
            _recipeView.DeleteRecipe += DeleteRecipe;
            _recipeView.SaveRecipe += SaveRecipe;
            _recipeView.UpdateView += UpdateView;
            _recipeView.EditRecipe += UpdateRecipe;
            _recipeView.GetEstimatedTimeOnIndexChanged1 += ShowEstimatedTimeToUtility1;
            _recipeView.GetEstimatedTimeOnIndexChanged2 += ShowEstimatedTimeToUtility2;
            _recipeView.GetEstimatedTimeOnIndexChanged3 += ShowEstimatedTimeToUtility3;
            _recipeView.GetEstimatedTimeOnIndexChanged4 += ShowEstimatedTimeToUtility4;
            _recipeView.GetEstimatedTimeOnIndexChanged5 += ShowEstimatedTimeToUtility5;
            _recipeView.GetEstimatedTimeOnIndexChanged6 += ShowEstimatedTimeToUtility6;

            _recipeView.CalculateTime += CalculateTime;

        }

        private void SaveRecipe(object? sender, SimpleSCADA_SharedResources.Recipe recipeToAdd)
        {
            AddStationsToRecipe(recipeToAdd);
            _recipeManager.AddRecipe(recipeToAdd);
            
        }

        public void OpenWindow(object sender, EventArgs e)
        {
            _recipeView.Show();
            UpdateView(this,EventArgs.Empty);
        }

        private void GetRecipe(object sender, string e)
        {
            Recipe recipefromDB = CheckIfRecipeExistces(e);

            if (recipefromDB != null)
            {
                LoadRecipe?.Invoke(this,recipefromDB);
            }
        }

        private void UpdateRecipe(object sender, int recipeToEdit)
        {
            Recipe newRecipe = _recipeManager.GetRecipe(recipeToEdit);
            newRecipe.Stations.Clear();
            Recipe recipe = new Recipe(recipeToEdit, _recipeView.txtb_recipename.Text);
            AddStationsToRecipe(recipe);
            newRecipe = recipe;
            _recipeManager.EditRecipe(newRecipe);
        }
        private void UpdateView(object sender, EventArgs e)
        {
            //Update the list of Already existing Recipoes

            IEnumerable<string?> allRecipes = _recipeManager.GetRecipes().Select(x=>x.Name);
            
            _recipeView.cbox_recipeExisting.Items.Clear();
            _recipeView.cbox_recipeExisting.Items.Add("-Neues Rezept-");

            foreach (string? item in allRecipes)
            {
                _recipeView.cbox_recipeExisting.Items.Add(item);
            }

            _recipeView.cbox_recipeExisting.SelectedIndex = 0;
            
            //Update the list of Uttilities for each Station

            List<Station> allStations = _recipeManager.GetStations();
            int count = 0;
            
            foreach (Station station in allStations)
            {
                count++;
;
                switch (count)
                {
                    case 1:
                        _recipeView.cbox_ConfigStation1.Items.Clear();
                        _recipeView.cbox_ConfigStation1.Items.AddRange(station.Utilities.Select(x =>x.Name).ToArray());
                        _recipeView.cbox_ConfigStation1.SelectedIndex = 0;
                        
                        break;
                    case 2:
                        _recipeView.cbox_ConfigStation2.Items.Clear();
                        _recipeView.cbox_ConfigStation2.Items.AddRange(station.Utilities.Select(x => x.Name).ToArray());
                        _recipeView.cbox_ConfigStation2.SelectedIndex = 0;
                        break;
                    case 3:
                        _recipeView.cbox_ConfigStation3.Items.Clear();
                        _recipeView.cbox_ConfigStation3.Items.AddRange(station.Utilities.Select(x => x.Name).ToArray());
                        _recipeView.cbox_ConfigStation3.SelectedIndex = 0;
                        break;
                    case 4:
                        _recipeView.cbox_ConfigStation4.Items.Clear();
                        _recipeView.cbox_ConfigStation4.Items.AddRange(station.Utilities.Select(x => x.Name).ToArray());
                        _recipeView.cbox_ConfigStation4.SelectedIndex = 0;
                        break;
                    case 5:
                        _recipeView.cbox_ConfigStation5.Items.Clear();
                        _recipeView.cbox_ConfigStation5.Items.AddRange(station.Utilities.Select(x => x.Name).ToArray());
                        _recipeView.cbox_ConfigStation5.SelectedIndex = 0;
                        break;
                    case 6:
                        _recipeView.cbox_ConfigStation6.Items.Clear();
                        _recipeView.cbox_ConfigStation6.Items.AddRange(station.Utilities.Select(x => x.Name).ToArray());
                        _recipeView.cbox_ConfigStation6.SelectedIndex = 0;
                        break;

                }
            }


        }

        private void DeleteRecipe(object sender, string e)
        {
            Recipe recipeToDeleteFromDB = CheckIfRecipeExistces(e);
            if (recipeToDeleteFromDB != null)
            {
                _recipeManager.RemoveRecipe(recipeToDeleteFromDB.Id);
                UpdateView(this,EventArgs.Empty);
            }
            
        }

        private void ShowEstimatedTimeToUtility1(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(1);
            _recipeView.txtb_EstimatedTime1.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this, EventArgs.Empty);
        }

        private void ShowEstimatedTimeToUtility2(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(2);
            _recipeView.txtb_EstimatedTime2.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this, EventArgs.Empty);
        }

        private void ShowEstimatedTimeToUtility3(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(3);
            _recipeView.txtb_EstimatedTime3.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this, EventArgs.Empty);
        }

        private void ShowEstimatedTimeToUtility4(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(4);
            _recipeView.txtb_EstimatedTime4.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this, EventArgs.Empty);
        }

        private void ShowEstimatedTimeToUtility5(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(5);
            _recipeView.txtb_EstimatedTime5.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this, EventArgs.Empty);
        }

        private void ShowEstimatedTimeToUtility6(object sender, string utilityName)
        {
            Station station = _recipeManager.GetStation(6);
            _recipeView.txtb_EstimatedTime6.Text = station.Utilities.SingleOrDefault(x => x.Name == utilityName).SecondsToWait.ToString();
            CalculateTime(this,EventArgs.Empty);
        }

        private Recipe CheckIfRecipeExistces(string recipename)
        {
            List<Recipe> allRecipes = _recipeManager.GetRecipes();

            Recipe recipeFromDB= allRecipes.SingleOrDefault(x=> x.Name==recipename);
            if (recipeFromDB != null)
            {
                return recipeFromDB;
            }
            else
            {
                return null;
            }
        }
        private void AddStationwithChosenUtitiltyToRecipe(string needeedUtility, int stationID, int order, Recipe recipeToAdd)
        {
            List<Station> allStations = _recipeManager.GetStations();
            Station station = allStations.SingleOrDefault(x => x.Id == stationID);
            SimpleSCADA_SharedResources.Utility utility = station.Utilities.SingleOrDefault(x => x.Name == needeedUtility);
            recipeToAdd.AddStation(new StationWithChosenUtility(recipeToAdd, station, utility,order));
        }

        private void AddStationsToRecipe(Recipe recipe)
        {
            if (_recipeView.cb_station1.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation1.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 1, int.Parse(_recipeView.cbox_OrderStation1.Text), recipe);

            }
            if (_recipeView.cb_station2.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation2.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 2, int.Parse(_recipeView.cbox_OrderStation2.Text), recipe);
            }
            if (_recipeView.cb_station3.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation3.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 3, int.Parse(_recipeView.cbox_OrderStation3.Text), recipe);
            }
            if (_recipeView.cb_station4.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation4.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 4, int.Parse(_recipeView.cbox_OrderStation4.Text), recipe);
            }
            if (_recipeView.cb_station5.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation5.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 5, int.Parse(_recipeView.cbox_OrderStation5.Text), recipe);
            }
            if (_recipeView.cb_station6.Checked)
            {
                string needeedUtility = _recipeView.cbox_ConfigStation6.Text;

                AddStationwithChosenUtitiltyToRecipe(needeedUtility, 6, int.Parse(_recipeView.cbox_OrderStation6.Text), recipe);
            }
        }
        #endregion

        private void CalculateTime(object sender, EventArgs e)
        {
            int SumTime = 0;
            if (_recipeView.cb_station1.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime1.Text, out Time);
                SumTime += Time;
            }
            if (_recipeView.cb_station2.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime2.Text, out Time);
                SumTime += Time;
            }
            if (_recipeView.cb_station3.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime3.Text, out Time);
                SumTime += Time;
            }
            if (_recipeView.cb_station4.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime4.Text, out Time);
                SumTime += Time;
            }
            if (_recipeView.cb_station5.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime5.Text, out Time);
                SumTime += Time;
            }
            if (_recipeView.cb_station6.Checked)
            {
                int Time;
                int.TryParse(_recipeView.txtb_EstimatedTime6.Text, out Time);
                SumTime += Time;
            }

            int driveTime = SumTime / 10;
            _recipeView.txtb_EstimatedTimeDrive.Text = driveTime.ToString();
            SumTime += driveTime;
            _recipeView.txtb_EstimatedTimeAll.Text = SumTime.ToString();
        }
    }
}
