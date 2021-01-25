using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public  class UserLogins : AdminBaseModel
    {
        public string UserLoginId { get; set; }
        public string Password { get; set; }
    }
}
