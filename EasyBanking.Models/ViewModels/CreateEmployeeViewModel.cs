using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels
{
    public  class CreateEmployeeViewModel : AdminBaseViewModel
    {
        [Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {

            get { return (LastName + " " + FirstName + " "+ (string.IsNullOrEmpty(MiddleName) ? " " : " " + MiddleName)).ToUpper(); }

        }

        [Display(Name = "Staff code")]
        public string StaffCode { get; set; }

        [Display(Name = "Account Created date")]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [DataType(DataType.Date), Display(Name = "Employement Date")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public string Phone { get; set; }

        [Required(ErrorMessage = "Job Role is required")]
        public Designition Designation { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please select image for employee")]
        public string Email { get; set; }
        [Display(Name = "Image")]
        public IFormFile ImageUrl { get; set; }
        public Gender  Gender { get; set; }


    }
}
