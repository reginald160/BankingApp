using System;
using System.Collections.Generic;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.EmployeeViewModels
{
    public class EmployeeProfileViewModel : AdminBaseViewModel
    {
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    
        public string FullName { get; set; }
        public string StaffCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; } 
        public string Phone { get; set; }
        public Designition Designation { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public Gender Gender { get; set; }
        public bool ActivityStatus { get; set; }
    }
}
