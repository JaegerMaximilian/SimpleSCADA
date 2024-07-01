using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{
    public class User
    {
        #region Properties
        public int Id { get; private set; }
        public string Prename { get; set; }
        public string Surname { get; set; }


        public string Password { get; private set; }
        public UserRole Role { get; set; }

        #endregion

        #region Constructor
        public User(string prename, string surname, string password, UserRole role)
        {
            //FL: ist Autoinkrement auf der DB daher nicht benötigt
            //this.Id = id;
            this.Prename = prename;
            this.Surname = surname;
            this.Password = password;
            this.Role = role;
        }
        #endregion

        #region Methods
        // BL: Eigentlich Überlüssig da $"{myUser.Prename}.{myUser.Surname}"
        public string GetUserName()
        {
            return "";
        }
        // BL: Eigentlich Überflüssig da UserManager.EditUser
        // FL: Edit würds schon lassen und prüfen ob des alte Passwort richtig eingegeben wurde und dann des neue eingeben
        public void ChangePassword(string oldPassword,string newPassword)
        {
            if (Password == oldPassword)
            {
                Password=newPassword;
            }
            else
            {
                throw new AccessViolationException("Ihr altes Passwort ist falsch eingeben worden.");
            }

        }

        public override string ToString()
        {
            return $"{Prename}.{Surname}";
        }

        #endregion
    }
}
