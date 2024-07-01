using Microsoft.VisualBasic.ApplicationServices;
using SimpleSCADA_DesktopViewer.CustomEventArgs;
using SimpleSCADA_SharedResources;
using System.Runtime.ConstrainedExecution;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = SimpleSCADA_SharedResources.User;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class UserManagerPresenter
    {
        #region Membervariables

        //Model
        private UserManager _userManager;

        //View
        private UserView _userView;

        //Events
        public event EventHandler<User> LoadUser;


        #endregion

        #region Constructor

        public UserManagerPresenter(UserManager userManager)
        {
            _userManager = userManager;
            _userView = new UserView();

           SetUpLinks();
        }


        #endregion

        #region Methods

        private void SetUpLinks()
        {

            LoadUser += _userView.LoadUserFromDB;
   

            _userView.UpdateView += UpdateView;
            _userView.GetUser += GetUser;
            _userView.SaveUser += SaveUser;
            _userView.UpdateUser += EditUser;
            _userView.DeleteUser += DeleteUser;

        }

        private void EditUser(object? sender, EditUserEventArgs newUser)
        {
            User userInDB = CheckIfUserExistces(newUser.UserName);

            if (userInDB != null)
            {
                if (newUser.EdittedUser.Password == String.Empty)
                {
                    newUser.EdittedUser.ChangePassword("", userInDB.Password);
                    _userManager.EditUser(userInDB, newUser.EdittedUser);
                }
                else
                {
                    _userManager.EditUser(userInDB,newUser.EdittedUser);
                }
            }
            //if (userInDB != null)
            //{


            //    userInDB.Prename = newUser.EdittedUser.Prename;
            //    userInDB.Surname = newUser.EdittedUser.Surname;
            //    if (newUser.EdittedUser.Password.ToString() != string.Empty)
            //    {
            //        userInDB.ChangePassword(userInDB.Password, newUser.EdittedUser.Password.ToString());
            //    }
            //    userInDB.Role = newUser.EdittedUser.Role;

            //}

        }

        public void OpenWindow(object sender, EventArgs e)
        {
            _userView.Show();
            UpdateView(this, EventArgs.Empty);
        }

        private void UpdateView(object sender, EventArgs e)
        {
            List<User> allUsers = _userManager.GetUsers();
            List<string> usersToString = new List<string>();

            _userView.cbox_usersExisting.Items.Clear();
            _userView.cbox_usersExisting.Items.Add("-Neuer Benutzer-");

            foreach (User user in allUsers)
            {
                
                _userView.cbox_usersExisting.Items.Add(user.ToString());
                
                
            }
            _userView.cbox_usersExisting.SelectedIndex = 0;

        }

        private void GetUser(object sender, string username)
        {

            //string[] seperatedUserLogIn = username.Split('.');

            //string firstName = seperatedUserLogIn[0];
            //string lastName = seperatedUserLogIn[1];

            //List<User> allUsers = _userManager.GetUsers();

            //User userFromDB = allUsers.SingleOrDefault(x => x.Prename == firstName && x.Surname == lastName);

            User userFromDB = CheckIfUserExistces(username);
            
            if (userFromDB != null)
            {
                LoadUser?.Invoke(this,userFromDB);
            }

        }
        
        private void SaveUser(object sender, User user)
        {
            if (user != null)
            {
                _userManager.AddUser(user);
            }
            
        }

        private void DeleteUser(object sender, string username)
        {
            User userToDeleteFromDN = CheckIfUserExistces(username);
            //string[] seperatedUserLogIn = username.Split('.');

            //string firstName = seperatedUserLogIn[0];
            //string lastName = seperatedUserLogIn[1];

            //List<User> allUsers = _userManager.GetUsers();
            //User userToDeleteFromDN = allUsers.SingleOrDefault(x => x.Prename == firstName && x.Surname == lastName);
            if (userToDeleteFromDN != null)
            {
                _userManager.DeleteUser(userToDeleteFromDN.Id);
                UpdateView(this,EventArgs.Empty);
            }

        }

        private User CheckIfUserExistces(string username)
        {
            string[] seperatedUserLogIn = username.Split('.');

            string firstName = seperatedUserLogIn[0];
            string lastName = seperatedUserLogIn[1];

            List<User> allUsers = _userManager.GetUsers();

            User userFromDB = allUsers.SingleOrDefault(x => x.Prename == firstName && x.Surname == lastName);

            if (userFromDB != null) { return  userFromDB; }
            else
            {
                return null;
            }

        } 
        #endregion
    }
}