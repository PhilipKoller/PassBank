using PassBankLibrary.Models;

namespace PassBankLibrary.DataAccess
{
    public interface IDataConnection
    {
      AccountModel AddAccount(AccountModel model);
    }
}
