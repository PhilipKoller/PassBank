using System.Data;
using Dapper;
using PassBankLibrary.Models;

namespace PassBankLibrary.DataAccess
{
    // Class that will connect to databse 
  public  class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new account to database 
        /// </summary>
        /// <param name="model">The account information</param>
        /// <returns>The account information, including the unique identifier</returns>
        public AccountModel AddAccount(AccountModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("PassBank")))
            {
                var p = new DynamicParameters();
                p.Add(@"AccountName", model.AccountName);
                p.Add(@"UserName", model.Username);
                p.Add(@"UserPassword", model.Password);
                p.Add(@"id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spAccounts_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
       
                return model;
            }
        }
        public UserModel AddUser(UserModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("PassBank")))
            {
                var p = new DynamicParameters();
                p.Add(@"Username", model.Name);
                p.Add(@"MasterPassword", model.MasterPassword);
                p.Add(@"id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

       
    }
}
