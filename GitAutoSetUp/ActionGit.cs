using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LibGit2Sharp;
using Microsoft.TeamFoundation.Common;

namespace GitAutoSetUp
{
    public partial class ActionGit : Form
    {
        private string _pathForder;
        private string _repo;
        private string mess;
        private string browerpat;
        private string branch;


        public ActionGit()
        {
            InitializeComponent();
        }

        private void ActionGit_Load(object sender, EventArgs e)
        {
            LoadBranchesToComboBox();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!pathForder.Text.IsNullOrEmpty())
                _pathForder = pathForder.Text;
            UpdateGitInfo(_pathForder);
        }

        private void linkchoice_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    _pathForder = pathForder.Text = folderBrowserDialog.SelectedPath;
                    pathForder.Text = _pathForder;
                    UpdateGitInfo(_pathForder);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string namebrance = txtbranch.Text;
            if (namebrance.IsNullOrEmpty())
                mess += "Name name branch null:" + Environment.NewLine;

            mess += GitHelper.CreatenewBrench(_pathForder, namebrance);
            messiger.Text = mess;
        }


       

        private void addRepo_Click(object sender, EventArgs e)
        {
            browerpat = txtRepo.Text.Trim();

            if (string.IsNullOrWhiteSpace(browerpat))
            {
                mess += "Error: Đường dẫn đến repo sai hoặc không tồn tại. ";
            }

            if (string.IsNullOrEmpty(mess))
            {
                try
                {
                    string log = GitHelper.InitializeGitRepository(_pathForder.Trim(), browerpat);
                    mess += $"Mess :{log}";
                    UpdateGitInfo(_pathForder);
                }
                catch (ArgumentException argEx)
                {
                    mess += $"erro: Đã xảy ra lỗi: {argEx.Message}";
                }
                catch (UnauthorizedAccessException uaEx)
                {
                    mess += $"erro: Lỗi quyền truy cập: {uaEx.Message}";
                }
                catch (Exception ex)
                {
                    mess += $"erro: Đã xảy ra lỗi khi khởi tạo repository: {ex.Message}";
                }
            }
            messiger.Text = mess;
        }


        private void btnpush_Click(object sender, EventArgs e)
        {
            
            var inf = GitHelper.LoadCredentials();
            messiger.Text += GitHelper.PushChanges(_pathForder,branch, inf.Password, inf.Username);
        }

        private void chbAddAll_CheckedChanged(object sender, EventArgs e)
        {
            messiger.Text += chbAddAll.Checked ? GitHelper.StageAllChanges(_pathForder) :
                "Thông Báo: Thay đổi trạng thái thành không lưu tất cả !" + Environment.NewLine;

            AutoScrollTextBox(messiger);
        }
        
        private void AutoScrollTextBox(TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.ScrollToCaret(); 
        }

        private void UpdateGitInfo(string path)
        {
            inforGit(path:path,repo:out _repo,branch:out branch);
            txtRepo.Text = _repo;
            txtbranch.Text = branch;
            addRepo.Visible = string.IsNullOrEmpty(_repo);
            LoadBranchesToComboBox();
        }
        public static void inforGit(string path, out string repo, out string branch)
        {
            repo = GitHelper.GetRepositoryNameFromRemote(path);
            branch = GitHelper.GetCurrentBranch(path);
        }
        
        
        private void LoadBranchesToComboBox()
        {
            List<string> branches = GitHelper.GetAllBranches(_pathForder);
            treeBranch.Items.Clear();
            foreach (var br in branches)
            {
                treeBranch.Items.Add(br); 
            }
        }


        private void treeBranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedBranch = treeBranch.SelectedItem.ToString();
            treeBranch.Text = selectedBranch;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            Console.Write(treeBranch.SelectedItem.ToString());
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            messiger.Text += GitHelper.CloneRepository(txtRepo.Text.Trim(), _pathForder);
            UpdateGitInfo(_pathForder);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            messiger.Text += GitHelper.CommitChanges(_pathForder, txtCommit.Text, chbAddAll.Checked);
        }

        private void btnauthen_Click(object sender, EventArgs e)
        {
            new newbranch().ShowDialog();
        }
    }
}   