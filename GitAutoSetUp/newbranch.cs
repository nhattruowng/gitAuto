using System;
using System.Windows.Forms;

namespace GitAutoSetUp
{
    public partial class newbranch : Form
    {
        private string _pathFolder;
        public newbranch(string pathFolder)
        {
            InitializeComponent();
            _pathFolder = pathFolder;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Console.Write(_pathFolder);
        }
    }
}