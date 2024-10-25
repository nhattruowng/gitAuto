using System;
using System.Windows.Forms;

namespace GitAutoSetUp
{
    public partial class newbranch : Form
    {
        public newbranch()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            textBox2.Text += GitHelper.SaveCredentials(username: txtname.Text, email:txtpass.Text, token:txttoken.Text );
        }

        private void newbranch_Load(object sender, EventArgs e)
        {
            var inf = GitHelper.LoadCredentials();

            txtname.Text = inf.Username != null ? inf.Username : "N/A";
            txtpass.Text = inf.Password != null ? inf.Password : "N/A";
            txttoken.Text = inf.token != null ? inf.token : "N/A";
        }
    }
}