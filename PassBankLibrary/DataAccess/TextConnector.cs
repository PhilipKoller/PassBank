using PassBankLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using PassBankLibrary.DataAccess.TextHelpers;

namespace PassBankLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string AccountFile = "AccountModels.csv";
        public AccountModel AddAccount(AccountModel model)
        {
            // Load the text file and convert the text to List<AcountModel>
            List<AccountModel> accounts = AccountFile.FullFilePath().LoadFile().ConvertToAccountModels();

            // Find the max ID and Add 1
            int currentId = 1;
            if (accounts.Count > 0)
            {
                currentId = accounts.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add new record with the new ID
            accounts.Add(model);

            accounts.SaveToAccountFile(AccountFile);

            return model;
        }
    }
}
