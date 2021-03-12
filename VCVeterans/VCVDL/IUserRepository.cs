using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;
namespace VCVDL
{
    public interface IUserRepository
    {
        User AddUser(User newUser);
        User GetUserByID(int userID);
    }
}
