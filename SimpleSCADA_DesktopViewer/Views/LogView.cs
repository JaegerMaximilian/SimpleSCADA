using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleSCADA_DesktopViewer
{
    public partial class LogView : Form
    {
        public event EventHandler<string> CheckLogInDataFromUser;

        public LogView()
        {
            InitializeComponent();

            //Setzen des Password Chatacters als Punkt für die Textboxen mit Passworteingabe
            txtbPassword.PasswordChar = '\u25CF';
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string userToLogIn = $"{txtbUserName.Text}.{txtbPassword.Text}";
            CheckLogInDataFromUser?.Invoke(this, userToLogIn);

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbPasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPasswordView.Checked)
            {
                txtbPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

            }
            else
            {
                txtbPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
        }

        public void ResetView(object sender, EventArgs e)
        {
            txtbPassword.Text = string.Empty;
            txtbUserName.Text = string.Empty;

            cbPasswordView.Checked = false;

            this.Hide();
        }

        private void txtbPasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_LogIn.PerformClick();
        }
    }
}
