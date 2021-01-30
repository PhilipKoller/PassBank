using PassBankLibrary.Models;

namespace PassBankLibrary.DataAccess
{
    // Class that will connect to databse 
    // TODO: Make the AddAccount method actually save to the database
  public  class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new account to database 
        /// </summary>
        /// <param name="model">The account information</param>
        /// <returns>The account information, including the unique identifier</returns>
        public AccountModel AddAccount(AccountModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
