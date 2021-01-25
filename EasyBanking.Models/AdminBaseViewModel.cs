using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Models
{
   public class AdminBaseViewModel
    {
        public virtual Guid Id { get; set; }

        public virtual bool Deleted { get; set; }
    }
}
