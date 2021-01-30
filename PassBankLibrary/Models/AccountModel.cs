using System;
using System.Collections.Generic;
using System.Text;

namespace PassBankLibrary.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
