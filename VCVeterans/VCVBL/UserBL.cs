using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;
using VCVDL;
namespace VCVBL
{
    public class UserBL : IUserBL
    {
        private IUserRepository _repo;
        public UserBL(IUserRepository repo)
        {
            _repo = repo;
        }
        public User AddUser(User newUser)
        {
            return _repo.AddUser(newUser);
        }

        public User GetUserByID(int userID)
        {
            return _repo.GetUserByID(userID);
        }
    }
}
