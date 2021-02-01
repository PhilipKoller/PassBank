using PassBankLibrary.DataAccess;
using System.Configuration;

namespace PassBankLibrary
{
  public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector Sql = new SqlConnector();
                    Connections = Sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector Text = new TextConnector();
                    Connections = Text;
                    break;
                default:
                    break;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
