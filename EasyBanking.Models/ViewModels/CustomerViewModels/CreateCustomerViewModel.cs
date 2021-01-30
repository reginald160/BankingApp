using EasyBanking.Models.CoreBanking;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.CustomerViewModels
{
    public class CreateCustomerViewModel : AdminBaseModel
    {

        [Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {

            get { return (LastName + "" + FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : " " + MiddleName)).ToUpper(); }

        }

        [Display(Name = "Home Address ")]
        [DataType(DataType.MultilineText)]
        public string Address1 { get; set; }

        [Display(Name = "Additional Address")]
        [DataType(DataType.MultilineText)]
        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string BVN { get; set; }

        [Display(Name = "Identification Type")]
        public IdentificationType IdentificationType { get; set; }

        [Display(Name = "Identification Number")]
        public string IdentificationNum { get; set; }

        [Display(Name = "Account Number")]
        public long AccountNumber { get; set; }


        [Display(Name = "Image")]
        public IFormFile ImagePath { get; set; }

        [Display(Name = "Mandate card")]
        public IFormFile MandatePath { get; set; }
        public Guid UserLoginId { get; set; }

        public virtual UserLogins UserLogin { get; set; }

        public Guid EmployeeId { get; set; }

        //public virtual Employee AccountOfficer { get; set; }

        public Guid ManagerId { get; set; }

     
        //public virtual Employee BranchManager { get; set; }
        public Gender Gender { get; set; }



    }
}
