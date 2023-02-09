using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Budget_System
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert Into LoginCredentials Values(@username,@password,@role)");
            cmd.ExecuteNonQuery();
        }
    }
}
