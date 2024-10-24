using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CredentialManagement;
using LibGit2Sharp;

namespace GitAutoSetUp
{
    public class GitHelper
    {
        public static string GetRepositoryNameFromRemote(string folderPath)
        {
            try
            {
                string repoPath = Repository.Discover(folderPath);

                if (repoPath != null)
                {
                    using (var repo = new Repository(repoPath))
                    {
                        var remote = repo.Network.Remotes["origin"];
                        if (remote != null)
                        {
                            string remoteUrl = remote.Url;

                            string repoName = GetRepoNameFromUrl(remoteUrl);
                            return repoName;
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
                else
                {
                    return "";
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

        public static string GetCurrentBranch(string folderPath)
        {
            try
            {
                string repoPath = Repository.Discover(folderPath);

                if (repoPath != null)
                {
                    using (var repo = new Repository(repoPath))
                    {
                        string currentBranch = repo.Head.FriendlyName;
                        return currentBranch;
                    }
                }
                else
                {
                    return "N/A";
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

        public static string InitializeGitRepository(string repoPath, string remoteUrl)
        {
            string log = "";
            
            Repository.Init(repoPath);
            log += "Initialized empty Git repository in " + repoPath + Environment.NewLine;

            using (var repo = new Repository(repoPath))
            {
                Remote remote = repo.Network.Remotes.Add("origin", remoteUrl);
                log += $"Added remote 'origin' with URL: {remote.Url}" + Environment.NewLine;
            }

            return log;
        }
        
        public static string CreatenewBrench(string repoPath, string namebranch)
        {
            string log = "";
            
            using (var repo = new Repository(repoPath))
            {
                Branch newBranch = repo.Branches.Add(namebranch, repo.Head.Tip);
                log += $"Created new branch: {newBranch.FriendlyName}" + Environment.NewLine;
                
                Commands.Checkout(repo, newBranch);
                log += $"Switched to branch: {newBranch.FriendlyName}" + Environment.NewLine;
            }

            return log;
        }
        

        public static List<string> GetAllBranches(string repoPath)
        {
            var branchesList = new List<string>();
            try
            {
                using (var repo = new Repository(repoPath))
                {
                    foreach (var branch in repo.Branches)
                    {
                        branchesList.Add(branch.FriendlyName); 
                    }
                }
            }
            catch (RepositoryNotFoundException)
            {
                branchesList.Add("Repository not found");
            }
            catch (Exception ex)
            {
                branchesList.Add($"Error: {ex.Message}");
            }

            return branchesList;
        }
        
        public static string CloneRepository(string gitUrl, string localPath)
        {
            try
            {
                Repository.Clone(gitUrl, localPath);
                return $"Repository đã được clone về: {localPath}" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                return $"Lỗi khi clone repository: {ex.Message}" + Environment.NewLine;
            }
        }
        
        
        public static string CommitChanges(string repoPath, string commitMessage, bool stageAll)
        {
            try
            {
                using (var repo = new Repository(repoPath))
                {
                    if (stageAll)
                    {
                        Commands.Stage(repo, "*");  
                    }

                    var (authorName, authorEmail) = GetGitUserInfo(repoPath);

                    if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(authorEmail))
                    {
                        return "Không thể lấy thông tin người dùng từ Git config." + Environment.NewLine;
                    }

                    var author = new Signature(authorName, authorEmail, DateTime.Now);
                    var committer = author;

                    var commit = repo.Commit(commitMessage, author, committer);

                    return $"Commit thành công với mã commit: {commit.Sha}" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi khi commit: {ex.Message}";
            }
        }
        
        public static string PushCode(string repoPath, string username, string email, string branchName)
        {
            try
            {
                using (var repo = new Repository(repoPath))
                {
                    // Kiểm tra xem branch có tồn tại không
                    var branch = repo.Branches[branchName];
                    if (branch == null)
                    {
                        return $"Branch '{branchName}' không tồn tại trong repository.";
                    }

                    // Set người dùng và committer
                    var author = new Signature(username, email, DateTime.Now);
                    var committer = author;

                    // Commit code (nếu có thay đổi)
                    Commands.Stage(repo, "*");
                    repo.Commit("Auto commit by GitHelper", author, committer);

                    // Thực hiện push lên nhánh đã chọn
                    var options = new PushOptions
                    {
                        CredentialsProvider = (_url, _user, _cred) =>
                            new UsernamePasswordCredentials { Username = username, Password = email } // Sử dụng email làm password cho mục đích minh họa, bạn nên dùng password hoặc token.
                    };

                    repo.Network.Push(branch, options);

                    return $"Push thành công lên nhánh '{branchName}'.";
                }
            }
            catch (LibGit2SharpException ex)
            {
                return $"Lỗi khi push: {ex.Message}";
            }
        }
        
        public static (string authorName, string authorEmail) GetGitUserInfo(string repoPath)
        {
            try
            {
                using (var repo = new Repository(repoPath))
                {
                    var config = repo.Config;
                    string authorName = config.Get<string>("user.name").Value;
                    string authorEmail = config.Get<string>("user.email").Value;

                    return (authorName, authorEmail);
                }
            }
            catch (Exception ex)
            {
                return (null, null);  
            }
        }

        public static string StageAllChanges(string repoPath)
        {
            string log;

            using (var repo = new Repository(repoPath))
            {
                Commands.Stage(repo, "*");
                log = "SAVE: Lưu Tất cả thay đổi. " + Environment.NewLine;
            }
            return log;
        }
        
        public static string SaveCredentials(string username, string password)
        {
            try
            {
                using (var cm = new Credential())
                {
                    cm.Target = "GitCredentials"; 
                    cm.Username = username;
                    cm.Password = password;
                    cm.Save();
                }

                return "Lưu thông tin đăng nhập thành công" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                return $"Lỗi khi lưu thông tin đăng nhập: {ex.Message}" + Environment.NewLine;
            }
        }

        public static (string Username, string Password) LoadCredentials()
        {
            try
            {
                using (var cm = new Credential())
                {
                    cm.Target = "GitCredentials";
                    if (cm.Load())
                    {
                        return (cm.Username, cm.Password);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải thông tin đăng nhập: {ex.Message}");
            }
    
            return (null, null); // Trả về null nếu không tải được
        }


        

        private static string GetRepoNameFromUrl(string url)
        {
            string repoName = Path.GetFileNameWithoutExtension(url);
            return repoName;
        }
    }
}