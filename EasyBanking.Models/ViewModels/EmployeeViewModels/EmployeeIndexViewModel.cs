using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.EmployeeViewModels
{
    public class EmployeeIndexViewModel : AdminBaseViewModel
    {
        [Display(Name = "Staff code")]
        public string FullName { get; set; }

        [Display(Name = "Staff code")]
        public string StaffCode { get; set; }

        public Designition Designation { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
