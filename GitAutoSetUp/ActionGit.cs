using System;
using System.IO;
using System.Windows.Forms;
using LibGit2Sharp;

namespace GitAutoSetUp
{
    public partial class ActionGit : Form
    {
        private string _pathForder;
        private string _repo;

        public ActionGit()
        {
            InitializeComponent();
        }


        private void linkchoice_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    _pathForder = textBox1.Text = folderBrowserDialog.SelectedPath;
                    textBox1.Text = _pathForder;
                    _repo = GetRepositoryName(_pathForder);
                    txtRepo.Text = _repo;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new newbranch(_pathForder).Show();
        }


        // private void SavePathToFile(string path)
        // {
        //     // Đường dẫn tương đối đến file trong thư mục Resources của dự án
        //     string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        //     string filePath = Path.Combine(folderPath, "pathHistory.txt");
        //
        //     try
        //     {
        //         // Kiểm tra và tạo thư mục Resources nếu chưa tồn tại
        //         if (!Directory.Exists(folderPath))
        //         {
        //             Directory.CreateDirectory(folderPath);
        //         }
        //
        //         // Mở file để ghi thêm (append mode)
        //         using (StreamWriter writer = new StreamWriter(filePath, true))
        //         {
        //             writer.WriteLine(path); // Ghi đường dẫn vào dòng mới
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         MessageBox.Show("Có lỗi xảy ra khi lưu lịch sử: " + ex.Message);
        //     }
        // }

        public static string GetRepositoryName(string folderPath)
        {
            try
            {
                string repoPath = Repository.Discover(folderPath);

                if (repoPath != null)
                {
                    using (var repo = new Repository(repoPath))
                    {
                        string repoName = new DirectoryInfo(repo.Info.WorkingDirectory).Name;
                        return repoName;
                    }
                }
                else
                {
                    return "Thư mục không nằm trong repository Git.";
                }
            }
            catch (RepositoryNotFoundException)
            {
                return "Không tìm thấy repository Git.";
            }
            catch (Exception ex)
            {
                return "Có lỗi xảy ra: " + ex.Message;
            }
        }
    }
}