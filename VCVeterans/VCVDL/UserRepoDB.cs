using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCVModels;

namespace VCVDL
{
    public class UserRepoDB : IUserRepository
    {
        private readonly VCVDBContext _context;
        public UserRepoDB(VCVDBContext context)
        {
            _context = context;
        }
        public User AddNewUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User GetUserByEmail(string userEmail)
        {
            return _context.Users.AsNoTracking().Select(user => user).FirstOrDefault(user => user.Email == userEmail);
        }

        public User GetUserByID(int userID)
        {
            return _context.Users.AsNoTracking().Select(user => user).FirstOrDefault(user => user.UserID == userID);
        }
        public ICollection<Image> GetUserImages(int userID)
        {
            var query =
            (from user in _context.Users
             join image in _context.Images
             on user.UserID equals image.User.UserID
             where user.UserID == userID
             select image);
            if(query == null)
            {
                return null;
            }
            else
            {
                return query.ToList();
            }

        }
    }
}
