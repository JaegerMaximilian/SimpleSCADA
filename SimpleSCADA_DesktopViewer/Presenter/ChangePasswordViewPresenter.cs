using SimpleSCADA_DesktopViewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class ChangePasswordViewPresenter
    {
        #region Variables
        private PasswordChangeView _passwordChangeView;
        private UserManager _userManager;

        #endregion

        #region Events
        public event EventHandler PasswordChangedInDB;
        #endregion

        #region Constructor
        public ChangePasswordViewPresenter(UserManager userManager)
        {
            _userManager = userManager;
            _passwordChangeView = new PasswordChangeView();

            SetUpLinks();
        }
        #endregion
        
        #region Methods
        public void OpenWindow(object? sender, EventArgs e)
        {
            _passwordChangeView.Show();
        }

        private void SetUpLinks()
        {
            _passwordChangeView.PasswordChange += ChangePasswordInDB;
            _passwordChangeView.InputNewPasswordChanged += CheckProtectionLevelOfPassword;

            PasswordChangedInDB += _passwordChangeView.ShowMessageBoxPasswordChanged;
        }

        private void CheckProtectionLevelOfPassword(object? sender, string e)
        {

            PasswordLevel level = CheckStrength(e);
            
            _passwordChangeView.tbcodestärke.Text=level.ToString();
            _passwordChangeView.pBar_strength.Value = (int)level * 25;


        }

        private void ChangePasswordInDB(object? sender, string passwords)
        {
            string[] seperatedpasswords = passwords.Split('.');

            string oldpassword = seperatedpasswords[0];
            string newpassword = seperatedpasswords[1];

            

            try
            {
                User userOldPassword = _userManager.activeUser;
                _userManager.activeUser.ChangePassword(oldpassword, newpassword);
                _userManager.EditUser(userOldPassword,_userManager.activeUser);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (_userManager.activeUser.Password == newpassword)
            {
                PasswordChangedInDB(this, EventArgs.Empty);
            }
        }


        private PasswordLevel CheckStrength(string password)
        {
            PasswordLevel level;

            Regex checKLowerAndLength = new Regex("^(?=.*?[a-z]).{8,}$");
            Regex ckeckUpperLowerAndLength = new Regex("^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$");
            Regex checkUpperLowerDigitAndLength = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
            Regex checkUpperLowerDigitSpecialAndLength =
                new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-+]).{8,}$");

            if (checkUpperLowerDigitSpecialAndLength.IsMatch(password))
            {
                level = PasswordLevel.VeryStrong;
            }
            else if (checkUpperLowerDigitAndLength.IsMatch(password))
            {
                level = PasswordLevel.Strong;
            }
            else if (ckeckUpperLowerAndLength.IsMatch(password))
            {
                level = PasswordLevel.Medium;
            }
            else if (checKLowerAndLength.IsMatch(password))
            {
                level = PasswordLevel.Low;
            }
            else
            {
                level = PasswordLevel.VeryLow;
            }
            return level;
        }
        #endregion


    }
}
