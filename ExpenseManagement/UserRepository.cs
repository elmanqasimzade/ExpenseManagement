using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement
{
    internal class UserRepository :GenericRepository<User>
    {
        public UserRepository(ExpenseManagementContext context) : base(context)
        {
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
