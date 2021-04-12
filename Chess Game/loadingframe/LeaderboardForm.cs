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
    public partial class LeaderboardForm : MetroForm
    {
        private LobbyForm lb;
        public LeaderboardForm()
        {
            InitializeComponent();
        }
        public LeaderboardForm(LobbyForm lb):this()
        {
            this.lb = lb;

            string sqlUsernameCheck = @"select * from userinfo order by totalwin desc;";
            DataAccess d = new DataAccess();
            DataSet ds = d.ExecuteQuery(sqlUsernameCheck);

            lbl1st.Text = ds.Tables[0].Rows[0]["username"].ToString();
            lbl1stScore.Text = ds.Tables[0].Rows[0]["totalwin"].ToString();

            lbl2nd.Text = ds.Tables[0].Rows[1]["username"].ToString();
            lbl2ndScore.Text = ds.Tables[0].Rows[1]["totalwin"].ToString();

            lbl3rd.Text = ds.Tables[0].Rows[2]["username"].ToString();
            lbl3rdScore.Text = ds.Tables[0].Rows[2]["totalwin"].ToString();

            lbl4th.Text = ds.Tables[0].Rows[3]["username"].ToString();
            lbl4thScore.Text = ds.Tables[0].Rows[3]["totalwin"].ToString();

            lbl5th.Text = ds.Tables[0].Rows[4]["username"].ToString();
            lbl5thScore.Text = ds.Tables[0].Rows[4]["totalwin"].ToString();

            lbl6th.Text = ds.Tables[0].Rows[5]["username"].ToString();
            lbl6thScore.Text = ds.Tables[0].Rows[5]["totalwin"].ToString();

            lbl7th.Text = ds.Tables[0].Rows[6]["username"].ToString();
            lbl7thScore.Text = ds.Tables[0].Rows[6]["totalwin"].ToString();

            lbl8th.Text = ds.Tables[0].Rows[7]["username"].ToString();
            lbl8thScore.Text = ds.Tables[0].Rows[7]["totalwin"].ToString();

            lbl9th.Text = ds.Tables[0].Rows[8]["username"].ToString();
            lbl9thScore.Text = ds.Tables[0].Rows[8]["totalwin"].ToString();

            lbl10th.Text = ds.Tables[0].Rows[9]["username"].ToString();
            lbl10thScore.Text = ds.Tables[0].Rows[9]["totalwin"].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lb.Show();
            this.Dispose();
        }
    }
}
