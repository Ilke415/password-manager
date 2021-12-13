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



        // ================================ CRYPTOGRAPHY METHODS ====================================== 


        // Method for decrypting Vaults







        // ============================== END OF CRYPTOGRAPHY METHODS  ================================



        //  ============================== METHODS FOR WORKING WITH DATABASE  =========================










        //  ============================ END OF METHODS FOR WORKING WITH DATABASE  =====================
    }
}
