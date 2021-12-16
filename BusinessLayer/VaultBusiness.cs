﻿using System;
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
  
     
        public VaultBusiness(IVaultRepository _vaultRepository)
        {
            this.vaultRepository = _vaultRepository;
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


        //  ============================== METHODS FOR WORKING WITH DATABASE  =========================

        public List<Vault> GetUserVaults(User user, string password)
        {

            List<Vault> vaults = vaultRepository.GetUserVaults(user.UserID);

            if (vaults.Count != 0)
            {
                string salt = user.Salt;

                string emailAddress = user.EmailAddress;

                byte[] VaultKey = CryptoHelper.CreateVaultKey(emailAddress, password, salt);

                foreach (Vault vault in vaults)
                {
                    string decryptedVaultData = CryptoHelper.DecryptData(vault.VaultDataEncrypted, VaultKey);

                    VaultData vaultData = ConvertJsonStringToObjectVaultData(decryptedVaultData);

                    vault.VaultDataDecrypted = vaultData;
                }

            }
            return vaults;

        }

        public void InsertVault(int userID, string vaultKey, VaultData vaultData)
        {
            string vaultDataJsonString = ConvertVaultDataObjectToJsonString(vaultData);

            byte[] vaultKeyBytes = Convert.FromBase64String(vaultKey);

            string vaultEncrypted = CryptoHelper.EncryptData(vaultDataJsonString, vaultKeyBytes);

            vaultRepository.InsertVault(userID, vaultEncrypted);

        }

        public void DeleteVault(int userID, int vaultID)
        {
            vaultRepository.DeleteVault(userID, vaultID);
        }

        public void UpdateVault(int userID, int vaultID, string vaultKey, VaultData vaultData)
        {

            string vaultDataJsonString = ConvertVaultDataObjectToJsonString(vaultData);

            byte[] vaultKeyBytes = Convert.FromBase64String(vaultKey);

            string vaultEncrypted = CryptoHelper.EncryptData(vaultDataJsonString, vaultKeyBytes);

            vaultRepository.UpdateVault(userID, vaultID, vaultEncrypted);
        
        }

        //  ============================ END OF METHODS FOR WORKING WITH DATABASE  =====================


        public string CreateVaultKey(string emailAddress, string password, string salt)
        {
            return Convert.ToBase64String(CryptoHelper.CreateVaultKey(emailAddress, password, salt));
        }
    }
}
