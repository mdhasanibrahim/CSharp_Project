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
using System.Data.SqlClient;
namespace loadingframe
{
    public partial class LoginForm :MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string sql = @"select * from userinfo where username = '"+this.metroTextBoxUsername.Text+"' and password = '"+metroTextBoxPassword.Text+ "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            if(ds.Tables[0].Rows.Count==1)
            {
                LobbyForm f3 = new LobbyForm(metroTextBoxUsername.Text);
                f3.Show();
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Incorrect Username or Password");
            }

            
        }

        private void metrobtnSignUp_Click(object sender, EventArgs e)
        {
            SignupForm f4 = new SignupForm();
            f4.Show();
            this.Dispose();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
