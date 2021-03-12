using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;

namespace VCVDL
{
    class UserRepoDB : IUserRepository
    {
        private readonly VCVDBContext _context;
        public UserRepoDB(VCVDBContext context)
        {
            _context = context;
        }
        public User AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User GetUserByID(int userID)
        {
            return _context.Users.AsNoTracking().Select(user => user).FirstOrDefault(user => user.UserID == userID);
        }
    }
}
