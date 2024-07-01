using SimpleSCADA_SharedResources;
using System.ComponentModel;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class MainWindowPresenter
    {
        #region Membervariables
        //Models
        private PlantManager _plantManager;
        private ProductionCycleManager _productionCycleManager;

        //Presenter
        private ChangePasswordViewPresenter _changePasswordViewPresenter;
        private ProductionHistoryWindowPresenter _historyWindowPresenter;
        private ErrorPopUpWindowPresenter _errorPopUpWindowPresenter;
        private ErrorViewPresenter _errorViewPresenter;
        private LogInWindowPresenter _logInWindowPresenter;
        private OEEWindowPresenter _oEEWindowPresenter;
        private JobPorcessingManagerPresenter _jobPorcessingManagerPresenter;
        private RecipeManagerPresenter _recipeManagerPresenter;
        private UserManagerPresenter _userManagerPresenter;
        private JokeWindowPresenter _jokeWindowPresenter;

        //View ....
        private PlantView _plantView;

        //Backgroundworker
        private BackgroundWorker _backgroundWorkerAktiveProductioncycle;
        private BackgroundWorker _backgroundWorkerSensorData;
        private BackgroundWorker _backgroundWorkerProductionQueue;

        private List<Panel> SensorDataControls;
        #endregion

        #region Constructor

        public MainWindowPresenter()
        {
            // Globaler UserManager und RecipeManager
            UserManager userManager = new UserManager();
            RecipeManager recipeManager = new RecipeManager();

            //globaler Production Cycle 
            _productionCycleManager = new ProductionCycleManager();

            // init Model
            _plantManager = new PlantManager();

            // init other Presenters
            _changePasswordViewPresenter = new ChangePasswordViewPresenter(userManager);
            _historyWindowPresenter = new ProductionHistoryWindowPresenter();
            _errorPopUpWindowPresenter = new ErrorPopUpWindowPresenter();
            _errorViewPresenter = new ErrorViewPresenter();
            _logInWindowPresenter = new LogInWindowPresenter(userManager);
            _oEEWindowPresenter = new OEEWindowPresenter();
            _jobPorcessingManagerPresenter = new JobPorcessingManagerPresenter(_productionCycleManager, recipeManager);
            _recipeManagerPresenter = new RecipeManagerPresenter(recipeManager);
            _userManagerPresenter = new UserManagerPresenter(userManager);
            _jokeWindowPresenter = new JokeWindowPresenter();

            // init Main View
            _plantView = new PlantView();

            //init BackgroundWorker
            _backgroundWorkerAktiveProductioncycle = _plantView.backgroundworkerAktiveProductioncycle;
            _backgroundWorkerSensorData = _plantView.backgroundWorkerSensorData;
            _backgroundWorkerProductionQueue = _plantView.backgroundworkerAktiveProductioncycle;

            SensorDataControls = _plantView.GetPlantControls();

            // Setup Connection between Events
            SetupLinks();

            //Start Backgroundworker
            if (!_backgroundWorkerAktiveProductioncycle.IsBusy)
            {
                _backgroundWorkerAktiveProductioncycle.RunWorkerAsync();
            }

            if (!_backgroundWorkerSensorData.IsBusy)
            {
                _backgroundWorkerSensorData.RunWorkerAsync();
            }

            if (!_backgroundWorkerProductionQueue.IsBusy)
            {
                _backgroundWorkerProductionQueue.RunWorkerAsync();
            }
        }

        #endregion

        #region Methods

        private void SetupLinks()
        {
            //hier die Events verknüpfen

            //open each window
            _plantView.RecipeWindowRequired += _recipeManagerPresenter.OpenWindow;
            _plantView.JobProcessingWindowRequired +=_jobPorcessingManagerPresenter.OpenWindow;
            _plantView.LogInWindowRequired += _logInWindowPresenter.OpenWindow;
            _plantView.PasswordChangeViewRequired += _changePasswordViewPresenter.OpenWindow;
            _plantView.UserViewRequired += _userManagerPresenter.OpenWindow;
            _plantView.OEEViewRequired += _oEEWindowPresenter.OpenWindow;
            _plantView.ErrorViewRequired += _errorViewPresenter.OpenWindow;
            _plantView.PoductionHistoryWindowRequired += _historyWindowPresenter.OpenWindow;
            _plantView.JokeViewRequired += _jokeWindowPresenter.OpenWindow;
            _plantView.LogOutUser += _logInWindowPresenter.LogOutUser;
            _plantView.PauseStateRequested += RequestPlantState;
            _plantView.StartStateRequested += RequestPlantState;
            _plantView.StopStateRequested += RequestPlantState;
            _plantView.MaintanceStateRequested += RequestPlantState;
            _plantView.DateTimeRequested += DateTime;


            _logInWindowPresenter.UserToLogIn+= ViewSettingsOnUserPermission;


            //BackgroundWorker
            _backgroundWorkerAktiveProductioncycle.DoWork += new DoWorkEventHandler(UpdateProductionQueueList);
            _backgroundWorkerAktiveProductioncycle.ProgressChanged +=
                new ProgressChangedEventHandler(OnProgessChangedProductionQueueList);
            _backgroundWorkerAktiveProductioncycle.RunWorkerCompleted += BackgroundWorker_RunWorkerCompletedProductionQueueList;
            _backgroundWorkerAktiveProductioncycle.WorkerReportsProgress=true;
            _backgroundWorkerAktiveProductioncycle.WorkerSupportsCancellation = true;


            _backgroundWorkerSensorData.DoWork += new DoWorkEventHandler(UpdateSensorData);
            _backgroundWorkerSensorData.ProgressChanged += new ProgressChangedEventHandler(OnProgressChangedSensorData);
            _backgroundWorkerSensorData.RunWorkerCompleted += BackgroundWorker_RunWorkerCompletedSensorData;
            _backgroundWorkerSensorData.WorkerReportsProgress = true;
            _backgroundWorkerSensorData.WorkerSupportsCancellation = true;

            _backgroundWorkerProductionQueue.DoWork += new DoWorkEventHandler(UpdateActiveProductionCycle);
            _backgroundWorkerProductionQueue.ProgressChanged +=
                new ProgressChangedEventHandler(OnProgressActiveProductionCycle);
            _backgroundWorkerProductionQueue.RunWorkerCompleted += BackgroundWorker_RunWorkComplededQueue;
            _backgroundWorkerProductionQueue.WorkerSupportsCancellation = true;
            _backgroundWorkerProductionQueue.WorkerReportsProgress = true;
            
        }


        public void Run()
        {
            _plantView.Show();
            Application.Run();
        }

        private void DateTime(object sender, PlantView plantView)
        {
            new Thread(new ThreadStart(() =>
            {
                do
                {
                    try
                    {
                        DateTime DateTime = DateTime.Now;
                        string date = Convert.ToString(DateTime.Date).Substring(0, 10);
                        string time = Convert.ToString(DateTime.TimeOfDay).Substring(0, 5);
                        plantView.BeginInvoke((MethodInvoker)delegate
                        {
                            plantView.txt_time.Text = time;
                            plantView.txt_date.Text = date;
                        });
                        Thread.Sleep(500);
                    }
                    catch
                    {
                        return;
                    }
                } while (true);
            })).Start();
        }

        private void ViewSettingsOnUserPermission(object sender,User UserToLogIn)
        {
            
            UserRole permission=UserToLogIn.Role;
            string LoggedOnUser = $"{UserToLogIn.Prename}.{UserToLogIn.Surname}";

            //Logged on User Text
            _plantView.txt_user.Text = LoggedOnUser;
            _plantView.btn_login.Enabled = false;

            //Change View according to Logged on User
            if (permission == UserRole.SUPERUSER)
            {
                //folgende Buttons änderen sich zum Initial State
                _plantView.btn_password.Enabled = true;
                _plantView.btn_user_manager.Enabled = true;
                _plantView.btn_joke.Enabled = true;
                
            }
            else if (permission == UserRole.OPERATOR)
            {
                //folgende Buttons änderen sich zum Initial State

                //Buttons Kontrollzentrum
                _plantView.btn_pause.Enabled = true;
                _plantView.btn_maintenance.Enabled = true;
                _plantView.btn_startPlant.Enabled = true;
                _plantView.btn_stopPlant.Enabled = true;
                
                //Buttons Taskleiste
                _plantView.btn_error.Enabled = true;
                _plantView.btn_history.Enabled = true;
                _plantView.btn_ooe.Enabled = true;
                _plantView.btn_order_edit.Enabled = true;
                _plantView.btn_recipe_edit.Enabled = true;
                _plantView.btn_password.Enabled = true;
                _plantView.btn_joke.Enabled = true;
            }
            else if(permission==UserRole.SPECTATOR)
            {
                //folgende Buttons änderen sich zum Initial State

                //Buttons Kontrollzentrum
                _plantView.btn_stopPlant.Enabled = true;

                //Buttons Taskleiste
                _plantView.btn_error.Enabled = true;
                _plantView.btn_history.Enabled = true;
                _plantView.btn_ooe.Enabled = true;
                _plantView.btn_password.Enabled = true;
                _plantView.btn_joke.Enabled = true;
            }
            else
            {
                throw new Exception("User Role not found in the System");
            }
        }

        private void UpdateProductionQueueList(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // Do the long-duration work here, and optionally
                // send the update back to the UI thread...
                int p = 0;// set your progress if appropriate
                object param = "something"; // use this to pass any additional parameter back to the UI
                _backgroundWorkerProductionQueue.ReportProgress(p, param);
                Thread.Sleep(1000);
            }
        }

        private async void OnProgessChangedProductionQueueList(object sender,ProgressChangedEventArgs e)
        {
            List<ProductionCycle> queue = await _productionCycleManager.GetProductionQueueAsync();
            
            if (queue != null)
            {
                _plantView.lv_Queue.Items.Clear();
                _plantView.lv_Queue.AutoSize = true;

                int i = 0;
                foreach (ProductionCycle cycle in queue)
                {
                    ListViewItem context = new ListViewItem(cycle.Id.ToString(),i);
                    context.SubItems.Add(cycle.Customer);
                    context.SubItems.Add(cycle.RecipeId.ToString());
                    context.SubItems.Add(cycle.Recipe.Name);
                    context.SubItems.Add(cycle.NumberOfProducts.ToString());

                    _plantView.lv_Queue.Items.Add(context);
                    i++;
                }
            }

        }

        private void BackgroundWorker_RunWorkerCompletedProductionQueueList(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void UpdateSensorData(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // Do the long-duration work here, and optionally
                // send the update back to the UI thread...
                int p = 0;// set your progress if appropriate
                object param = "something"; // use this to pass any additional parameter back to the UI
                _backgroundWorkerSensorData.ReportProgress(p, param);
                Thread.Sleep(1000);
            }
        }

        private async void OnProgressChangedSensorData(object sender, ProgressChangedEventArgs e)
        {            
            foreach (Panel panel in SensorDataControls)
            {
                if (panel.Name.Contains("_TS") || panel.Name.Contains("_laufwagen"))
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }            
            List<SensorData> sensor = await _plantManager.GetSensorDataAsync();
            if (sensor != null)
            {
                foreach (Panel panel in SensorDataControls)
                {   
                    foreach(SensorData sensorData in sensor)
                    {
                        if (panel.Name.Contains(sensorData.sensorName)) 
                        {
                            if (panel.Name.Contains("_TS") || panel.Name.Contains("_laufwagen"))
                            {
                                panel.Visible = true;
                            }
                            else
                            {
                                panel.Visible = false;                                                              
                            }
                        }
                    }                    
                }
            }
            else
            {
                foreach (Panel panel in SensorDataControls)
                {
                    if (panel.Name.Contains("_TS") || panel.Name.Contains("_laufwagen"))
                    {
                        panel.Visible = false;
                    }
                    else
                    {
                        panel.Visible = true;
                    }                                  
                }
            }            
        }

        private void BackgroundWorker_RunWorkerCompletedSensorData(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void BackgroundWorker_RunWorkComplededQueue(object? sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void OnProgressActiveProductionCycle(object? sender, ProgressChangedEventArgs e)
        {
            Plant activePlant = await _plantManager.GetPlantAsync();
            if (activePlant != null && activePlant.ActiveProductionCycle != null)
            {
                //_plantView.SetOrderWindowText(activePlant.ActiveProductionCycle.Id.ToString());
                this._plantView.txt_orderNumber.Text = activePlant.ActiveProductionCycle.Id.ToString();
                this._plantView.txt_orderName.Text =
                    $"{activePlant.ActiveProductionCycle.Id} - {activePlant.ActiveProductionCycle.Customer}";
                this._plantView.txt_recipeNumber.Text = $"{activePlant.ActiveProductionCycle.RecipeId} - {activePlant.ActiveProductionCycle.Recipe.Name}";
                this._plantView.txt_totalAmount.Text = activePlant.ActiveProductionCycle.NumberOfProducts.ToString();
                this._plantView.txt_amountFinished.Text = activePlant.ActiveProductionCycle.FinishedProducts.ToString();

                double percentage = (activePlant.ActiveProductionCycle.FinishedProducts / (activePlant.ActiveProductionCycle.NumberOfProducts * 1.0)) * 100;
                //int per = percentage;
                this._plantView.txt_percentageFinished.Text = $"{Math.Round(percentage,2)} %";

                this._plantView.txt_status.Text = "aktiv";
                
                _plantView.txt_MachineStatus.Text = activePlant.ActualPlantState.ToString();
            }
        }

        private void UpdateActiveProductionCycle(object? sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // Do the long-duration work here, and optionally
                // send the update back to the UI thread...
                int p = 0;// set your progress if appropriate
                object param = "something"; // use this to pass any additional parameter back to the UI
                _backgroundWorkerAktiveProductioncycle.ReportProgress(p, param);
                Thread.Sleep(1000);
            }
        }


        private void RequestPlantState(object sender, PlantState state)
        {
            Plant edittedPlant = _plantManager.GetPlant();
            edittedPlant.requestedPlantState=state;

            _plantManager.EditPlant(edittedPlant);
        }
        #endregion

    }
}
