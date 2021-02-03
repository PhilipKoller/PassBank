using PassBankLibrary.Models;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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
        public static string FullFilePath(this string fileName )
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

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static void SaveToAccountFile(this List<AccountModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (AccountModel p in models)
            {
                lines.Add($"{p.Id},{p.AccountName},{p.Username},{p.Password}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
