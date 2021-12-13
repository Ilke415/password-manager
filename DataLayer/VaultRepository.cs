using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shared.Models;
using Shared.Interfaces;

namespace DataLayer
{
    public class VaultRepository: IVaultRepository
    {
        public List<Vault> GetUserVaults(int userID)
        {
            List<Vault> vaults = new List<Vault>();
            using (SqlConnection sqlConnection = new SqlConnection(Helper.GetConnectionString("PasswordManagerDB")))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Vaults WHERE UserID = @userID";
                    sqlCommand.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Vault vault = new Vault();
                        vault.VaultID = sqlDataReader.GetInt32(0);
                        vault.UserID = sqlDataReader.GetInt32(1);
                        vault.VaultDataEncrypted = sqlDataReader.GetString(2);
                        vaults.Add(vault);
                    }
                }
            }
            return vaults;
        }
        //public void InserVault(int userID, string encryptedVaultData)
    }
}
