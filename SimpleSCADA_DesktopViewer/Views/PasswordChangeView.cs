using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSCADA_DesktopViewer.Views
{
    public partial class PasswordChangeView : Form
    {
        public event EventHandler<string> PasswordChange;
        public event EventHandler<string> InputNewPasswordChanged;


        public PasswordChangeView()
        {
            InitializeComponent();

            //Setzen des Password Chatacters als Punkt für die Textboxen mit Passworteingabe
            txtbNewPassword.PasswordChar = '\u25CF';
            txtbVerificationNewPassword.PasswordChar = '\u25CF';
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearView();
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (txtbNewPassword.Text == txtbVerificationNewPassword.Text)
            {
                PasswordChange?.Invoke(this, $"{txtbCurrentPassword.Text}.{txtbNewPassword.Text}");
                ClearView();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Bitte prüfen Sie Ihre Eingabe des neuen Passworts die beiden Eingaben stimmen nicht überein.");
            }
        }

        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearView();
        }

        #region Helpful Methods

        private void ClearView()
        {
            txtbCurrentPassword.Text = String.Empty;
            txtbNewPassword.Text = String.Empty;
            txtbVerificationNewPassword.Text = String.Empty;

        }

        private void cbPasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPasswordView.Checked)
            {
                txtbNewPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                txtbVerificationNewPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

            }
            else
            {
                txtbNewPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                txtbVerificationNewPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
        }

        public void ShowMessageBoxPasswordChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ihr Passwort wurde auf Ihre neue Eingabe geändert");
        }

        #endregion


        private void txtbNewPassword_TextChanged(object sender, EventArgs e)
        {
            InputNewPasswordChanged?.Invoke(this, txtbNewPassword.Text);

        }
    }
}
