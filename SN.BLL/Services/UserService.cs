using SN.BLL.Interfaces;
using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Services
{
    public class UserService : IUserService
    {
        
        private readonly IUnitOfWork Database;

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddFriend(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ICollection<ApplicationUser> GetAllFriends(string id)
        {
            var user = Database.Users.Get(id);
            return user.Friends;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return null;
        }

        public void RemoveFriend(int id)
        {
            throw new NotImplementedException();
        }

        //Realization business logic for users
    }
}
