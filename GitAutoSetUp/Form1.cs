
using System;
using System.Windows.Forms;

namespace GitAutoSetUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            new ActionGit().Show();
            this.Hide();
        }
    }
}