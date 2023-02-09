using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Budget_System.Forms;

namespace Budget_System
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void cbShowPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username" || txtPassword.Text == "Password")
            {
                MessageBox.Show("Please fill both the username and password.");
            }
            else if (txtUsername.Text == "dev" && txtPassword.Text == "123")
            {
                this.Hide();
                frmMainPage form = new frmMainPage();
                form.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUsers_MouseHover(object sender, EventArgs e)
        {
            pbUsers.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbUsers_MouseLeave(object sender, EventArgs e)
        {
            pbUsers.BorderStyle = BorderStyle.None;
        }

        private void lnklblUnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp form = new frmSignUp();
            form.ShowDialog();
        }
    }
}
