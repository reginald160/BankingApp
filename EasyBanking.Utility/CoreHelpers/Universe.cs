using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Utility.CoreHelpers
{
    public static class Universe
    {
        public const string FirstUser = "Employee";
        public const string SecondUser = "Customer";
        public const string EmployeeNumenclature = "Emp";
        public static bool Deleted = true;
        public const string ColorGrey = "#808080";
        public const string ButtonRed = "btn-danger";
        public const string ButtonTheme = "btn-theme";
        public const string ButtonGreen = "btn-primary";
        public const string ButtonBlue = "btn-secondary";
        private static string result;
        public static bool NewRecord = true;
        public static string MyProperty { get; set; }
		public static string AdminPass {
            get

            {
                 result = LogicHelper.GetAdminPass();
                return result;
            }
            set
			{
                result = value;	
            }
        }
		
    }
}
