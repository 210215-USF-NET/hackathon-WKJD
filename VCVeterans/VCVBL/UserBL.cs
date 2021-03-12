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
        private readonly IUserRepository _repo;
        public UserBL(IUserRepository repo)
        {
            _repo = repo;
        }
        public User AddNewUser(User newUser)
        {
            return _repo.AddNewUser(newUser);
            
        }

        public User GetUserByEmail(string userEmail)
        {
            return _repo.GetUserByEmail(userEmail);
        }

        public User GetUserByID(int userID)
        {
            return _repo.GetUserByID(userID);
        }

        public ICollection<Image> GetUserImages(int userID)
        {
            return _repo.GetUserImages(userID);
        }
    }
}
