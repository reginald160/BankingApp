
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
    public class Employee : AdminBaseModel, ICoreDeletable
    {
        public Employee()
        {
            CreatedDate = DateTime.Now;
        }
        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name"), Required]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Last Name")]
        public string StaffCode { get; set; }

        [Display(Name = "Account Created date")]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [DataType(DataType.Date), Display(Name = "Employment Datw")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public string Phone { get; set; }

        [Required(ErrorMessage = "Job Role is required")]
        public Designition Designation { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public Gender Gender { get; set; }
        public bool ActivityStatus { get; set; }


    }
}
