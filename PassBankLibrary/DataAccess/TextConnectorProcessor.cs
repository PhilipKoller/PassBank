using PassBankLibrary.Models;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System;

namespace PassBankLibrary.DataAccess.TextHelpers
{
    // *Load textfile ( Comes in as a list of strings ) 
    // *Convert list of strings to List<PrizeModel>
    // *Find Max id 
    // *Add new record with the new ID ( MAX + 1) 
    // *Convert prizes to list<string>
    // *Save the list<string> to the text file
    public static class TextConnectorProcessor
    {
        private static string hash = "f0xldfe@rn";
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }/{fileName}";
        }

        public static List<AccountModel> ConvertToAccountModels(this List<string> model)
        {
            List<AccountModel> output = new List<AccountModel>();

            foreach (string line in model)
            {
                string[] cols = line.Split(',');
                AccountModel a = new AccountModel();

                a.Id = int.Parse(cols[0]);
                a.AccountName = cols[1];
                a.Username = cols[2];
                a.Password = cols[3];
                output.Add(a);
            }
            return output;
        }

        public static List<UserModel> ConvertToUserModels(this List<string> model)
        {
            List<UserModel> output = new List<UserModel>();

            foreach (string line in model)
            {
                UserModel u = new UserModel();
                string[] cols = line.Split(',');

                u.Id = Int32.Parse(cols[0]);
                u.Name = cols[1];
                u.MasterPassword = cols[2];

                output.Add(u);
            }
            return output;
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<string> EncryptAccount(this List<AccountModel> models)
        {
            List<string> lines = new List<string>();

            foreach (AccountModel p in models)
            {

                if (p.Id == models.Count)
                {
                    // Encrypt password
                    byte[] userBytePass = UTF8Encoding.UTF8.GetBytes(p.Password);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {

                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripleDES.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(userBytePass, 0, userBytePass.Length);
                            p.Password = Convert.ToBase64String(results, 0, results.Length);
                        }

                    }
                }
                lines.Add($"{p.Id},{p.AccountName},{p.Username},{p.Password}");
            }
            return lines;
        }

        public static List<string> EncryptUsers(this List<UserModel> models)
        {
            List<string> lines = new List<string>();

            foreach (UserModel p in models)
            {

                if (p.Id == models.Count)
                {
                    // Encrypt password
                    byte[] userBytePass = UTF8Encoding.UTF8.GetBytes(p.MasterPassword);
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {

                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                        {
                            ICryptoTransform transform = tripleDES.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(userBytePass, 0, userBytePass.Length);
                            p.MasterPassword = Convert.ToBase64String(results, 0, results.Length);
                        }

                    }
                }
                lines.Add($"{p.Id},{p.Name},{p.MasterPassword}");
            }
            return lines;
        }

        public static void SaveToAccountFile(this List<string> models, string fileName)
        {
            File.WriteAllLines(fileName.FullFilePath(), models);
        }
    }
}
