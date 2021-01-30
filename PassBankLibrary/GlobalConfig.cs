using PassBankLibrary.DataAccess;
using System.Collections.Generic;

namespace PassBankLibrary
{
  public static class GlobalConfig
    {
       

        // This list says I will hold anything that implements IDataConnection
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Setup the SQL Connector properly
                SqlConnector Sql = new SqlConnector();
                Connections.Add(Sql);
            }
            if (textFiles)
            {
                // TODO: Setup text connection 
                TextConnector Text = new TextConnector();
                Connections.Add(Text);
               
            }
        }
    }
}
