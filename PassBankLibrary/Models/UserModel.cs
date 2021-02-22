using System;
using System.Collections.Generic;
using System.Text;

namespace PassBankLibrary.Models
{
   public class UserModel
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public string MasterPassword { get; set; }
    }
}
