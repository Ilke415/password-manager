using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces {
    public interface IUserBusiness {
        bool IsValidEmailAddress(string emailAddress);
        List<bool> ValidationOfPasswordRequirements(string password);
        string CreateRandomPassword(int length);
        bool IsEmailAddressExist(string emailAddress);
        void InsertUser(string emailAddress, string password);

        Dictionary<string, string> CalculatePasswordStrength(string password);
    }
}
