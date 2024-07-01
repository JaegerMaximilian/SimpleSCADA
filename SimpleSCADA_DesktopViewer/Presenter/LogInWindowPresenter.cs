using SimpleSCADA_DesktopViewer.Views;
using SimpleSCADA_SharedResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class LogInWindowPresenter
    {
        #region Membervariables

        //View
        private LogView _logView;

        //Modell
        private UserManager _userManager;
        

        #endregion

        #region Constructor
        public LogInWindowPresenter(UserManager userManager)
        {

            _logView = new LogView();
            _userManager= userManager;

            SetUpLinks();

        }


        #endregion

        #region Events

        public event EventHandler<User> UserToLogIn;
        public event EventHandler ResetView;

        #endregion

        #region Methods

        public void OpenWindow(object? sender, EventArgs e)
        {
            _logView.Show();
        }

        public void LogInSucessful(object? sender, string userToLogIn)
        {
            List<User> allUsers =_userManager.GetUsers();

            string[] seperatedUserLogIn=userToLogIn.Split('.');
            string firstName = seperatedUserLogIn[0];
            string lastName = seperatedUserLogIn[1];
            string password = seperatedUserLogIn[2];

            User activeUser = allUsers.SingleOrDefault(x=> x.Prename==firstName && x.Surname==lastName&& x.Password==password);

            if (activeUser != null)
            {
                UserToLogIn?.Invoke(this, activeUser);
                _userManager.SetActiveUser(activeUser);
                ResetView?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Bitte Log In Daten überprüfen. Hier Benutzername oder Passwort ist falsch."
                                +System.Environment.NewLine+
                                "Bitte Versuchen Sie es noch einmal");
            }
            
        }

        private void SetUpLinks()
        {
            ResetView += _logView.ResetView;
            
            _logView.CheckLogInDataFromUser += LogInSucessful;

        }

        public void LogOutUser(object sender, EventArgs e)
        {
            _userManager.SetActiveUser(null);
        }


        #endregion

    }


}
