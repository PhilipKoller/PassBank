using PassBankLibrary.Models;

namespace PassBankLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO: Wire up AddAccount for text files
        public AccountModel AddAccount(AccountModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
