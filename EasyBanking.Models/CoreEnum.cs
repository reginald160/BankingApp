using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models
{
   public class CoreEnum
    {
        public enum AccountTypeDescription
        {
            Savings, Current, Fx, Kiddies, Dom
        }
        public enum AccountStatusDescription
        {
            Dormant, Active, Lien, Blocked, Freeze
        }

        public enum Gender
        {
            Male, Female
        }
        public enum IdentificationType
        {   
            [Display(Name ="Voters card")]
            VoterCard,

           [Display(Name = "Internation Passport")]
            Passport,

            [Display(Name = "National Identity Card")]
            NIMC,

            [Display(Name = "Drivers Lisence")]
            DriversLiscence,

   
        }
        public enum TransactionCategory
        {
            Debit, Credit
        }
        public enum TransactionTypeDescription
        {
            Deposit, Withdraw
        }

        public enum Designition
        {   
            Manager,
            [Display(Name = "Account officer")]
            AccountOfficer,
            [Display(Name = "CSO")]
            CSO,
            [Display(Name = "DSA")]
            DSA,
            [Display(Name = "Zonal Head")]
            ZonalHead

        }
    }
}
