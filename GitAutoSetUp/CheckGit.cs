using System;
using System.Windows.Forms;

namespace GitAutoSetUp
{
    public partial class CheckGit : Form
    {

        private string mess;
        public CheckGit()
        {
            InitializeComponent();
        }

        private void CheckGit_Load(object sender, EventArgs e)
        {
            var logs = GitHelper.CheckGit();
            foreach (var log in logs)
            {
                mess += logs;
                txtBox.Text += mess;
            }
        }
    }
}