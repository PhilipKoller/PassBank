using System;
using System.Collections.Generic;
using System.Text;

namespace PassBankLibrary
{
    public interface IDataConnection
    {
       AccountModel AddAccount(AccountModel model);
    }
}
