using SN.DAL.EF;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAllUsers();

        void AddFriend(string user_id, string friend_id);

        void RemoveFriend(string user_id, string friend_id);

        ICollection<ApplicationUser> GetAllFriends(string id);

        ICollection<ApplicationUser> GetNotFriends(string id);

        ApplicationUser GetUser(string id);
    }
}
