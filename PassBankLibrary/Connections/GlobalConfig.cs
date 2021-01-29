using System;
using System.Collections.Generic;
using System.Text;

namespace PassBankLibrary
{
  public static class GlobalConfig
    {
        //TODO: Remove Connections folder when finished with applicaton 
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {

        }
    }
}
