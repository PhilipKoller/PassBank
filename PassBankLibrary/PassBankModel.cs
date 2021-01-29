
using System.Collections.Generic;

namespace PassBankLibrary
{
   public class PassBankModel
    {
        public string Username { get; set; }
        public List<List<AccountModel>> Accounts { get; set; } = new List<List<AccountModel>>();
    }
}
