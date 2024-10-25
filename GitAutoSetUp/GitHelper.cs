﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        // public static string PushChanges(string repoPath, string branchName, string username)
        // {
        //     string resultMessage = "";
        //
        //     try
        //     {
        //         using (var repo = new Repository(repoPath))
        //         {
        //             var remote = repo.Network.Remotes["origin"];
        //             var pushOptions = new PushOptions
        //             {
        //                 CredentialsProvider = (url, user, cred) =>
        //                     new UsernamePasswordCredentials { Username = username, Password = PromptForPassword() } // Gọi hàm nhập mật khẩu
        //             };
        //
        //             var branch = repo.Branches[branchName];
        //             if (branch == null)
        //             {
        //                 return $"Branch {branchName} không tồn tại.";
        //             }
        //
        //             // Kiểm tra và thiết lập upstream branch nếu cần
        //             if (branch.TrackedBranch == null)
        //             {
        //                 repo.Branches.Update(branch, b => b.Remote = remote.Name, b => b.UpstreamBranch = branch.CanonicalName);
        //                 resultMessage += $"Thiết lập upstream cho nhánh {branchName}. ";
        //             }
        //
        //             // Push thay đổi lên remote
        //             repo.Network.Push(branch, pushOptions);
        //             resultMessage += $"Push thành công lên nhánh {branchName}!";
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         return $"Lỗi khi push: {ex.Message}";
        //     }
        //
        //     return resultMessage;
        // }



        
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
        
        public static string SaveCredentials(string username, string email, string token)
        {
            try
            {
                using (var cm = new Credential())
                {
                    cm.Target = "GitCredentials"; 
                    cm.Username = username;
                    cm.Password = token;  
                    cm.Description = email;  
                    cm.Save();
                }

                return "Lưu thông tin đăng nhập thành công" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                return $"Lỗi khi lưu thông tin đăng nhập: {ex.Message}" + Environment.NewLine;
            }
        }


        public static (string Username, string Password, string token) LoadCredentials()
        {
            try
            {
                using (var cm = new Credential())
                {
                    cm.Target = "GitCredentials";
                    if (cm.Load())
                    {
                        return (cm.Username,cm.Description,cm.Password);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải thông tin đăng nhập: {ex.Message}" + Environment.NewLine);
            }
    
            return (null, null,null); // Trả về null nếu không tải được
        }

        public static List<string> CheckGit()
        {
            List<string> logMessages = new List<string>();
            
            if (IsGitInstalled(logMessages) && IsGitInPath(logMessages))
            {
                logMessages.Add("Git is fully installed and available in the PATH." + Environment.NewLine);
            }
            else
            {
                logMessages.Add("Git is not fully installed or not available in the PATH." + Environment.NewLine);
            }

            return logMessages;
        }

        private static bool IsGitInstalled(List<string> logMessages)
        {
            try
            {
                var processInfo = new ProcessStartInfo()
                {
                    FileName = "git",
                    Arguments = "--version",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Nếu có đầu ra, nghĩa là Git đã được cài đặt
                    if (process.ExitCode == 0)
                    {
                        logMessages.Add($"Git is installed: {output.Trim()}" + Environment.NewLine);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                logMessages.Add($"Error checking Git installation: {ex.Message}" + Environment.NewLine);
            }

            return false;
        }

        private static bool IsGitInPath(List<string> logMessages)
        {
            string pathVariable = Environment.GetEnvironmentVariable("PATH");

            // Kiểm tra xem đường dẫn đến Git có trong biến môi trường PATH không
            bool isInPath = pathVariable?.Contains("git") ?? false;

            logMessages.Add(isInPath 
                ? "Git is in the PATH environment variable." + Environment.NewLine 
                : "Git is NOT in the PATH environment variable." + Environment.NewLine);

            return isInPath;
        }

        

        private static string GetRepoNameFromUrl(string url)
        {
            string repoName = Path.GetFileNameWithoutExtension(url);
            return repoName;
        }
    }
}