using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using Shared.Models;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace BusinessLayer {

    public class UserBusiness : IUserBusiness {
        private readonly IUserRepository userRepository;

        public UserBusiness(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }


        // Method for validating email from user input
        public bool IsValidEmailAddress(string emailAddress)
        {

            try
            {
                MailAddress m = new MailAddress(emailAddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        } // End of  IsValidEmailAddress method

        // Method for checking if user password fulfills minimum requirements
        public List<bool> IsValidPassword(string password)
        {

            // List[0] => true if password is 12 or more characters long
            // List[1] => true if password have at least one number
            // List[2] => true if password have at least one special character
            // List[3] => true if password have at least one upper case letter

            List<bool> passwordValidationValues = new List<bool>() { false, false, false, false };


            if (password.Length >= 12)
                passwordValidationValues[0] = true;
            if (Regex.Match(password, "[0-9]{1}").Success)
                passwordValidationValues[1] = true;
            if (Regex.Match(password, "[^A-Za-z0-9]").Success)
                passwordValidationValues[2] = true;
            if (Regex.Match(password, "[A-Z]{1}").Success)
                passwordValidationValues[3] = true;


            return passwordValidationValues;
        }
        // End of  IsValidPassword() method


        // Method for creating random password
        public string CreateRandomPassword(int length)
        {// Characters allowed in password
            string upperCase = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";

            string numbers = "0123456789";

            string specialCharacters = "!@#$%^&*?_-";
            Random random = new Random();


            string all = $"{upperCase}{lowerCase}{numbers}{specialCharacters}";

            char[] chars = new char[length];

            // Ensure password has at least one uppercase, number and special character
            chars[random.Next(0, length)] = upperCase[random.Next(0, upperCase.Length)];
            chars[random.Next(0, length)] = numbers[random.Next(0, numbers.Length)];
            chars[random.Next(0, length)] = specialCharacters[random.Next(0, specialCharacters.Length)];



            for (int i = 0; i < length; i++)
            {
                if (chars[i] == '\0')
                    chars[i] = all[random.Next(0, all.Length)];
            }


            return new string(chars);
        }
        // End of method CreateRandomPassword(int length)


        // Method for checking if email address already exist if user try to register with same email address

        public bool IsEmailAddressExist(string emailAddress)
        {
            List<String> emailAddresses = userRepository.GetAllEmailAddresses();

            if (emailAddresses.Contains(emailAddress))
                return true;

            return false;
        }
    }
}