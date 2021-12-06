﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;
using Shared.Models;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;

namespace BusinessLayer {

    public class UserBusiness : IUserBusiness {
        private readonly IUserRepository userRepository;

        public UserBusiness(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }


        //  =================================== METHODS FOR VALIDATION  ===================================


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


        // Method for checking if password contains special characters
        private bool IsContainingSpecialCharacters(string input)
        {

            char[] specialCharacters = new char[] {
           '`', '~', '!', '@', '#', '$', '%', '^',
            '&', '*', '(', ')', '-', '=', '+', '[',
            ']', '{', '}', '\\', '|', ';', '"', '\'',
            ',', '.', ':', '<', '>', '/', '?', '_'
            };


            return input.IndexOfAny(specialCharacters) != -1;

        }

        // Method for checking if user password fulfills minimum requirements
        public List<bool> ValidationOfPasswordRequirements(string password)
        {

            List<bool> requirements = new List<bool>() { false, false, false, false, false };


            // List[0] => true if password is 12 or more characters long
            // List[1] => true if password have at least one number
            // List[2] => true if password have at least one lowercase letter
            // List[3] => true if password have at least one uppercase letter
            // List[4] => true if password contains at least one special character

            if (password.Length >= 12)
                requirements[0] = true;
            if (Regex.Match(password, "[0-9]{1}").Success)
                requirements[1] = true;
            if (Regex.Match(password, "[a-z]{1}").Success)
                requirements[2] = true;
            if (Regex.Match(password, "[A-Z]{1}").Success)
                requirements[3] = true;
            if (IsContainingSpecialCharacters(password))
                requirements[4] = true;



            return requirements;
        }
        // End of  IsValidPassword() method


        // Method for checking if email address already exist if user try to register with same email address

        public bool IsEmailAddressExist(string emailAddress)
        {
            List<String> emailAddresses = userRepository.GetAllEmailAddresses();

            if (emailAddresses.Contains(emailAddress))
                return true;

            return false;
        }
        // End of method  IsEmailAddressExist(string emailAddress)



        //  =================================== END OF VALIDATION METHODS  ===================================


        //  =================================== PASSWORD METHODS  ===================================

        public int CalculatePasswordPoolSize(string password)
        {
            password.Trim();

            int passwordPoolSize = 0;

            List<int> poolSizes = new List<int>() { 10, 26, 26, 32 };

            List<bool> isPasswordContains = ValidationOfPasswordRequirements(password);

            for (int i = 0, j = 1; i < poolSizes.Count && j < 5; i++, j++)
            {
                if (isPasswordContains[j])
                {
                    passwordPoolSize += poolSizes[i];
                }
            }


            return passwordPoolSize;

        }


        public int CalculatePasswordEntropy(string password)
        {

            password.Trim();

            // Calcuate password entropy
            // Formula E = L * log2(R)
            // E = Entropy
            // L = password length
            // R = size of the pool

            int R = 0;

            int L = password.Length;

            // List[0] => number of digits
            // List[1] => number of lowercase latin letters
            // List[2] => number of uppercase latin letters
            // List[3] => number of special chars

            // Calculate R

            R = CalculatePasswordPoolSize(password);

            // To get log with base two u can do log(10)X / log(10)2

            // Calculate log(2) from R
            double E = Math.Log10(R) / Math.Log10(2);

            int positionOfDecimalDot = E.ToString().IndexOf('.');

            // Calculate password Entropy
            int integerValueOfE = Convert.ToInt32(E.ToString().Substring(0, positionOfDecimalDot)) * L;


            return integerValueOfE;

        }

        public int CalculatePasswordLengthScore(string password)
        {

            int Score = 0;

            password.Trim();

            int passwordLength = password.Length;

            if (passwordLength > 12) Score = 10;
            if (passwordLength >= 10 && passwordLength < 12) Score = 8;
            if (passwordLength >= 8 && passwordLength < 10) Score = 6;
            if (passwordLength >= 6 && passwordLength < 8) Score = 4;
            if (passwordLength < 6) Score = 0;

            return Score;
        }



        public int CalculatePasswordPoolSizeScore(string password)
        {
            int Score = 0;
            int poolSize = CalculatePasswordPoolSize(password);

            switch (poolSize)
            {
                case 26:
                    return Score = 2;
                case 36:
                    return Score = 4;
                case 52:
                    return Score = 6;
                case 62:
                    return Score = 8;
                case 94:
                    return Score = 10;
                default:
                    return Score;
            }

            return Score;
        }

        public int CalculatePasswordEntropyScore(string password) {

            int Score = 0;

            password.Trim();

            int entropy = CalculatePasswordEntropy(password);


            if (entropy <= 28) Score = 2;
            if (entropy > 28 && entropy <= 47) Score = 4;
            if (entropy > 47 && entropy <= 66) Score = 6;
            if (entropy > 66 && entropy <= 85) Score = 8;
            if (entropy > 85) Score = 10;

            return Score;

        }


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


        public bool CommonPasswordChecker(string password)
        {

            password.Trim();
            Regex filter = new Regex("(password|pass)", RegexOptions.IgnoreCase);

            var match = filter.Match(password);

            if (match.Success)
                return true;



            return false;

        }

        public int CalculateCommonPasswordScore(string password)
        {
            bool isCommonPassword = CommonPasswordChecker(password);

            return isCommonPassword ? 4 : 8;

        }



        public Dictionary<string, string> CalculatePasswordStrength(string password)
        {

            password.Trim();

            Dictionary<string, string> resultScore = new Dictionary<string, string>();

            int lengthScore = CalculatePasswordLengthScore(password);
            int poolSizeScore = CalculatePasswordPoolSizeScore(password);
            int entropyScore = CalculatePasswordEntropyScore(password);


            int averageScore = (lengthScore + poolSizeScore + entropyScore) / 3;

            if (averageScore <= 4)
                resultScore.Add("Strength", "Weak");

            else if (averageScore >= 4 && averageScore <= 8)
                resultScore.Add("Strength", "Fair");

            else if (averageScore > 8)
                resultScore.Add("Strength", "Strong");



            return resultScore;

        }


        //  =================================== END OF PASSWORD METHODS  ===================================


        // =================================== CRYPTOGRAPHY METHODS =================================== 

        // Generate 24bytes long PBKDF2 hash 
        public byte[] CreatePBKDF2Hash(string input, byte[] salt, int lengthInBytes)
        {
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, iterations: 10000); // hard coded 10000 iterations
            return pbkdf2.GetBytes(lengthInBytes); 
            // 24 bytes(192 bits) is for AuthKey
            // 32 bytes(256 bits) is for encryption/decryption key for AES256

        }


        // Generate a 128-bit salt using a random sequence of nonzero values
        public byte[] CreateHashSalt()
        {
            byte[] salt = new byte[128 / 8];

            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }


        // Generate AuthKey for authentication using PBKDF2 hash function

        // Formula: AuthKey = H(H(password,email)+password)
        // H (hash function) = PBKDF2
        public string CreateAuthKey(string password, string email, byte[] salt)
        {
            // This must reworked because you didn't append masterPassword again in function
            byte[] AuthKeyHash = CreatePBKDF2Hash(Convert.ToBase64String(CreatePBKDF2Hash(password + email, salt, 24)) + password, salt, 24);


            return Convert.ToBase64String(AuthKeyHash);
        }

        // =================================== END OF CRYPTOGRAPHY METHODS  ===================================


        //  =================================== METHODS FOR WORKING WITH DATABASE  ===================================


        // Method for inserting new User in database
        public void InsertUser(string password, string emailAddress)
        {
            password.Trim();
            emailAddress.Trim();

            // Create AuthKey and salt 
            byte[] saltBytes = CreateHashSalt();

            string saltString = Convert.ToBase64String(saltBytes);

            string AuthKey = CreateAuthKey(password, emailAddress, saltBytes);

            // Create User object
            User newUser = new User(emailAddress, AuthKey, saltString);

            // Call method from DataLayer through IUserRepository interface to insert User in database
            userRepository.InsertUser(newUser);

        } // End of method InsertUser()

        //  =================================== END OF METHODS FOR WORKING WITH DATABASE  ===================================
    }
}