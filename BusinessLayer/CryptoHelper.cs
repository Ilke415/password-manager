using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class CryptoHelper
    {
        // Generate 24bytes long PBKDF2 hash 
        public static byte[] CreatePBKDF2Hash(string input, byte[] salt, int lengthInBytes)
        {
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, iterations: 10000); // hard coded 10000 iterations
            return pbkdf2.GetBytes(lengthInBytes);
            // 24 bytes(192 bits) is for AuthKey
            // 32 bytes(256 bits) is for encryption/decryption key for AES256

        }


        // Generate a 128-bit salt using a random sequence of nonzero values
        public static byte[] CreateHashSalt()
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
        public static string CreateAuthKey(string password, string email, byte[] salt)
        {

            byte[] AuthKeyHash = CreatePBKDF2Hash(Convert.ToBase64String(CreatePBKDF2Hash(password + email, salt, 24)) + password, salt, 24);


            return Convert.ToBase64String(AuthKeyHash);
        }


        // Generate VaultKey for data encryption/decryption using PBKDF2 hash function

        // Formula: VaultKey = H(email,password)
        // H (hash function) = PBKDF2

        public static  string createVaultKey(string emailAddress, string password, string saltBase64String)
        {
   
            byte[] salt = Convert.FromBase64String(saltBase64String);

            byte[] VaultKeyHash = CreatePBKDF2Hash(emailAddress + password, salt, 32); // Key size is 32bytes(256bits) for AES256


            return Convert.ToBase64String(VaultKeyHash);
        }

       


    }
}
