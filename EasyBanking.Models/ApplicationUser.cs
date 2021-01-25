using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models
{
    public  class ApplicationUser : IdentityUser
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName {

            get { return LastName + FirstName; }

        }
        public string  Role { get; set; }
    }
}
