using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BusinessLayer
{
    public class VaultBusiness : IVaultBusiness
    {
        private readonly IVaultRepository vaultRepository;
        private readonly IUserRepository userRepository;
     
        public VaultBusiness(IVaultRepository _vaultRepository, IUserRepository _userRepository)
        {
            this.vaultRepository = _vaultRepository;
            this.userRepository = _userRepository;
           
        }
        // ============================ METHODS FOR DATA MANIPULATION =================================


        public string ConvertVaultDataObjectToJsonString(VaultData vaultData)
        {
            return JsonSerializer.Serialize(vaultData);

        }

        public VaultData ConvertJsonStringToObjectVaultData(string vaultDataJsonString)
        {
            return JsonSerializer.Deserialize<VaultData>(vaultDataJsonString);
        }

        // ========================== END OF METHODS FOR DATA MANIPULATION ============================


       

        public List<Vault> GetDecryptedUserVaults(User user, string password)
        {

            List<Vault> vaults = vaultRepository.GetUserVaults(user.UserID);

            
            string salt = user.Salt;

            string emailAddress = user.EmailAddress;

            byte[] VaultKey = CryptoHelper.CreateVaultKey(emailAddress, password, salt);

            foreach (Vault vault in vaults)
            {
                string decryptedVaultData = CryptoHelper.DecryptData(vault.VaultDataEncrypted, VaultKey);

                VaultData vaultData = ConvertJsonStringToObjectVaultData(decryptedVaultData);

                vault.VaultDataDecrypted = vaultData;
            }


            return vaults;
        
        }
        


        //  ============================== METHODS FOR WORKING WITH DATABASE  =========================










        //  ============================ END OF METHODS FOR WORKING WITH DATABASE  =====================
    }
}
