using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Models
{
    public  class NumberSequence : AdminBaseModel
    {
      
        public string NumberSequenceName { get; set; }

        public string Module { get; set; }

        public string Prefix { get; set; }
        public int LastNumber { get; set; }


        
    }
}
