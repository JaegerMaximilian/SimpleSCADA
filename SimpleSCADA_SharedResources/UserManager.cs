using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class UserManager : DbContext
    {
        #region Properties
        public DbSet<User>? Users { get; set; }
        public User activeUser { get; private set; }
        #endregion

        #region Constructor
        public UserManager()
        {
            
        }


        #endregion

        #region Settings DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = $"Data Source=" + AbsoluteDbPath.PathGeneration();
            optionsBuilder.UseSqlite(conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbCreationContext.setAllModelConnections(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Methods

        public User GetUser(int id)
        {
            try
            {
                return Users.SingleOrDefault(x => x.Id == id);
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to fetch User from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
                return null;
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                return Users.ToList<User>();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to fetch Users from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
                return null;
            }
        }

        public void AddUser(User user)
        {
            try
            {
                bool isNameEqual = false;

                foreach (var checkUser in Users)
                {
                    if (checkUser.Prename == user.Prename &&
                        checkUser.Surname == user.Surname) isNameEqual = true; break;
                }

                if (Users.Contains(user) == false && isNameEqual == false)
                {
                    Users.Add(user);
                    SaveChanges();
                }
                else
                {
                    Error error = new Error("User already exists!",
                        ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                        DateTime.Now);
                    ErrorManager.AddError(error);
                }
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to save User to Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }

        public void EditUser(User oldUser, User newUser)
        { 
            try
            {
                User userToEdit = GetUser(oldUser.Id);
                userToEdit.Prename = newUser.Prename;
                userToEdit.Surname = newUser.Surname;
                userToEdit.ChangePassword(oldUser.Password, newUser.Password);
                userToEdit.Role = newUser.Role;
                SaveChanges();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to edit User!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                User user = Users.SingleOrDefault(x => x.Id == id);
                Users.Remove(user);
                SaveChanges();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to remove User!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }

        public void SetActiveUser(User user)
        {
            activeUser=user;
        }
        #endregion
    }
}
