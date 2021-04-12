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

namespace profile
{
    public partial class ProfileForm :MetroForm
    {
        string username;
        private loadingframe.LobbyForm lobbyForm;
        public ProfileForm()
        {
            InitializeComponent();
        }
        public ProfileForm(loadingframe.LobbyForm lobbyForm, string username) : this()
        {
            this.lobbyForm = lobbyForm;
            this.username = username;

            string sqlUsernameCheck = @"select * from userinfo where username = '" + username + "';";
            loadingframe.DataAccess d = new loadingframe.DataAccess();
            DataSet dss = d.ExecuteQuery(sqlUsernameCheck);

            lblUserName.Text = dss.Tables[0].Rows[0]["username"].ToString();
            lblIdValue.Text = dss.Tables[0].Rows[0]["id"].ToString();
            lblNameValue.Text = dss.Tables[0].Rows[0]["name"].ToString();
            lblEmailValue.Text = dss.Tables[0].Rows[0]["email"].ToString();
            lblTotalWinValue.Text = dss.Tables[0].Rows[0]["totalwin"].ToString();
            lblTotalGamePlayedValue.Text = dss.Tables[0].Rows[0]["totalgameplayed"].ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lobbyForm.Show();
            this.Dispose();
        }
    }
}
