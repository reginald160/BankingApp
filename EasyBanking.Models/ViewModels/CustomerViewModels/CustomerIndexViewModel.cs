using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.ViewModels.CustomerViewModels
{
    public class CustomerIndexViewModel: AdminBaseViewModel
    {

        [Display(Name = "Staff code")]
        public string FullName { get; set; }

        [Display(Name = "Account Number")]
        public long AccountNumber { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
