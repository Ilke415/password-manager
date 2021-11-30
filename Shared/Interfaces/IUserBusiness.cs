﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces {
    public interface IUserBusiness {
        bool IsValidEmailAddress(string emailAddress);
        List<bool> IsValidPassword(string password);
        string CreateRandomPassword(int length);

        bool IsEmailAddressExist(string emailAddress);
    }
}