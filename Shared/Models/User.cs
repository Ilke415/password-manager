using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string EmailAddress { get; set; }
        public string AuthKey { get; set; }
        public string Salt { get; set; }

    }
}
