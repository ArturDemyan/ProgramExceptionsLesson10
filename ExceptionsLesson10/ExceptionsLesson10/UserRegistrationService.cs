using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLesson10
{
    public class UserRegistrationService
    {
        private readonly string _login;
        private readonly string _password;
        private readonly string _confirmPassword;

        public UserRegistrationService(string login, string password, string confirmPassword)
        {
           _login = login;
           _password = password;
           _confirmPassword = confirmPassword;
        }
        public static void RegisterUser(string login, string password, string confirmPassword)
        {
            try
            {
                UserValidator(login);
                PasswordValidator(password, confirmPassword);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex);
            }
        }

        public static bool UserValidator(string login)
        {
            bool validfLAG=false;
            bool hasSapce = login.Any(char.IsWhiteSpace);
            if (login.Length>20 && !hasSapce)
            {
                validfLAG=true;
                throw new WrongLoginException("Failed to confirm login." +
                    "\nlogin must be no more than 20 characters and without spaces\n");
                
            }

            return validfLAG;
        }  

        private static void PasswordValidator(string password, string confirmPassword)
        {
            bool hasSapce = password.Any(char.IsWhiteSpace);
            bool canNumberSearch = password.Any(char.IsDigit);
            bool canComparisonResult = password.Contains(confirmPassword);
            if (password.Length>20 && hasSapce && canNumberSearch && canComparisonResult)
                throw new WrongLoginException("Failed to confirm password." +
                                              "\nlogin must be no more than 20 characters and without spaces\n");


        }


    }
}
