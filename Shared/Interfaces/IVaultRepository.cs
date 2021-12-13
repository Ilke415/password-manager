using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IVaultRepository
    {
        User GetUserByEmailAndAuthKey(string email, string authKey);
        List<Vault> GetUserVaults(int userID);
    }
}
