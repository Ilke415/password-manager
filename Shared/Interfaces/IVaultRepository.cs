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
        User GetUserInformation(string email);
        List<Vault> GetUserVaults(int userID);
    }
}
