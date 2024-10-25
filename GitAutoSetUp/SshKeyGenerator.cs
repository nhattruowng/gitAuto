// using System


// using System.IO;
// using System.Security.Cryptography;
// using System.Text;
//
// namespace GitAutoSetUp
// {
//     public class SshKeyGenerator
//     {
//         public static void GenerateSshKey(string keyName)
//         {
//             // Tạo khóa RSA mới
//             using (var rsa = RSA.Create(2048))
//             {
//                 // Lưu khóa riêng vào file theo định dạng PEM
//                 var privateKeyPem = ConvertToPem(rsa.ExportRSAPrivateKey(), "PRIVATE KEY");
//                 File.WriteAllText($"{keyName}_private_key.pem", privateKeyPem);
//
//                 // Tạo khóa công khai
//                 var publicKeyPem = ConvertToPem(rsa.ExportSubjectPublicKeyInfo(), "PUBLIC KEY");
//                 File.WriteAllText($"{keyName}_public_key.pem", publicKeyPem);
//
//                 // Xuất khóa công khai theo định dạng OpenSSH
//                 var sshPublicKey = $"ssh-rsa {Convert.ToBase64String(rsa.ExportRSAPublicKey())} {keyName}";
//
//                 // Lưu khóa công khai theo định dạng OpenSSH
//                 File.WriteAllText($"{keyName}_public_key.txt", sshPublicKey);
//
//                 Console.WriteLine($"SSH key pair created successfully: {keyName}_private_key.pem and {keyName}_public_key.txt");
//             }
//         }
//
//         private static string ConvertToPem(byte[] key, string keyType)
//         {
//             var sb = new StringBuilder();
//             sb.AppendLine($"-----BEGIN {keyType}-----");
//             sb.AppendLine(Convert.ToBase64String(key, Base64FormattingOptions.InsertLineBreaks));
//             sb.AppendLine($"-----END {keyType}-----");
//             return sb.ToString();
//         }
//     }
// }