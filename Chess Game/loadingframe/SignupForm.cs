using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace loadingframe
{
    public partial class SignupForm :MetroForm
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void metrobtnSignup_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtUsername.Text != "" && txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    string sqlUsernameCheck = @"select * from userinfo where username = '" + this.txtUsername.Text + "';";
                    DataAccess d = new DataAccess();
                    DataSet dss = d.ExecuteQuery(sqlUsernameCheck);

                    if (dss.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("Username already taken");
                    }
                    else
                    {
                        string sql = @"insert into userinfo values('" + this.txtName.Text + "','" + this.txtUsername.Text + "','" + this.txtEmail.Text + "','" + this.txtPassword.Text + "','0','0');";

                        DataAccess da = new DataAccess();

                        int count = da.ExecuteUpdateQuery(sql);
                        if (count == 1)
                        {
                            MessageBox.Show(" SignUp Successful ");
                            LoginForm f2 = new LoginForm();
                            f2.Show();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show(" SignUp Denied ");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Passwords have to be same");
                }
            }
            else
            {
                MessageBox.Show("Fields can't be empty");
            }
        }

        private void metrobtnSignIn_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Dispose();
        }
        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
