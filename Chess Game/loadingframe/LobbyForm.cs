using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGameForm;
using MetroFramework.Forms;
using profile;

namespace loadingframe
{
    public partial class LobbyForm : MetroForm
    {
        private string username;
        public LobbyForm()
        {
            InitializeComponent();
        }
        public LobbyForm(string username):this()
        {
            this.username = username;
        }

        private void LobbyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Dispose();
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string sql = @"update userinfo set totalgameplayed = totalgameplayed +1 where username = '"+username+"';";
            DataAccess da = new DataAccess();
            da.ExecuteQuery(sql);
            Form1 f1 = new Form1(this,username);
            f1.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ProfileForm pf = new ProfileForm(this,username);
            pf.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            LeaderboardForm lbForm = new LeaderboardForm(this);
            lbForm.Show();
            this.Hide();
        }
    }
}
