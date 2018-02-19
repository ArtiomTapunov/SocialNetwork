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

        public void AddFriend(string id, string friend_id)
        {
            var user = Database.Users.Get(id);
            var friend = Database.Users.Get(friend_id);
            friend.Friends.Add(user);
            user.Friends.Add(friend);
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

        public void RemoveFriend(string user_id, string friend_id)
        {
            var user = Database.Users.Get(user_id);
            var friend = Database.Users.Get(friend_id);
            user.Friends.Remove(friend);
            friend.Friends.Remove(user);
        }

    }
}
