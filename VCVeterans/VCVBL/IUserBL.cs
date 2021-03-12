using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;

namespace VCVBL
{
    public interface IUserBL
    {
        User AddUser(User newUser);
        User GetUserByID(int userID);
    }
}
