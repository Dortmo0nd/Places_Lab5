using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.BLL
{
    public class UserAuth
    {
        public bool Authenticate(string user, string pass) => user == "admin";
    }
}
