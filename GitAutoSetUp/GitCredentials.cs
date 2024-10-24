using System.IO;
using Newtonsoft.Json;

namespace GitAutoSetUp
{
    public class GitCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        
        public static void SaveCredentials(string path, GitCredentials credentials)
        {
            var json = JsonConvert.SerializeObject(credentials);
            File.WriteAllText(path, json);
        }
        
        public static GitCredentials LoadCredentials(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<GitCredentials>(json);
            }
            return null;
        }
    }
    
}