using SimpleSCADA_DesktopViewer.CustomEventArgs;
using SimpleSCADA_SharedResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSCADA_DesktopViewer
{
    public partial class UserView : Form
    {
        #region Events
        public event EventHandler<string> GetUser;
        public event EventHandler<User> SaveUser;
        public event EventHandler<EditUserEventArgs> UpdateUser;
        public event EventHandler<string> DeleteUser;
        public event EventHandler UpdateView;
        #endregion

        public UserView()
        {
            InitializeComponent();
            cbox_premission.DataSource = Enum.GetValues(typeof(UserRole));

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (cbox_usersExisting.SelectedIndex != 0)
            {
                GetUser?.Invoke(this, cbox_usersExisting.Text);
            }
            else
            {
                MessageBox.Show("Es muss ein User aus der Liste ausgewählt werden um diesen Laden zu können");
            }


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cbox_usersExisting.SelectedIndex == 0)
            {
                UserRole role = (UserRole)Enum.ToObject(typeof(UserRole), cbox_premission.SelectedIndex + 1);
                User user = new User(txtb_firstName.Text, txtb_lastName.Text, txtb_initalPassword.Text, role);
                SaveUser?.Invoke(this, user);
            }
            else
            {
                UserRole role = (UserRole)Enum.ToObject(typeof(UserRole), cbox_premission.SelectedIndex + 1);
                User user = new User(txtb_firstName.Text, txtb_lastName.Text, txtb_initalPassword.Text, role);

                UpdateUser?.Invoke(this, new EditUserEventArgs(cbox_usersExisting.Text, user));
            }
            ResetViewToDefault();

        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            ResetViewToDefault();
            this.Hide();
        }



        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetViewToDefault();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cbox_usersExisting.SelectedIndex != 0)
            {
                DeleteUser?.Invoke(this, cbox_usersExisting.Text);
                ResetViewToDefault();
            }



        }

        #region Methods

        private void ResetViewToDefault()
        {
            //Update List of Users
            UpdateView(this, EventArgs.Empty);
            cbox_usersExisting.Refresh();

            //Empty the strings
            txtb_firstName.Text = String.Empty;
            txtb_lastName.Text = String.Empty;
            txtb_initalPassword.Text = String.Empty;

            //Rücksetzen der Rechte
            cbox_premission.SelectedIndex = 0;
        }

        public void LoadUserFromDB(object sender, User user)
        {
            txtb_firstName.Text = user.Prename;
            txtb_lastName.Text = user.Surname;

            int userPermissionInt = (int)user.Role;
            cbox_premission.SelectedIndex = userPermissionInt - 1;
        }
        #endregion


    }
}
