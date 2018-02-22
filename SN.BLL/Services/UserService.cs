using SN.BLL.Interfaces;
using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SN.BLL.Services
{
    public class UserService : IUserService
    {
        
        private readonly IUnitOfWork Database;
        private readonly ApplicationUser user;

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void AddFriend(string id, string friend_id)
        {
            var user = Database.Users.Get(id);
            var friend = Database.Users.Get(friend_id);

            if (user.Friends == null)
            {
                user.Friends = new List<ApplicationUser>();
                friend.Friends = new List<ApplicationUser>();

                user.Friends.Add(friend);
                friend.Friends.Add(user);
            }
            else
            {              
                user.Friends.Add(friend);
                friend.Friends.Add(user);
            }

            Database.Users.Update(user);
            Database.Users.Update(friend);
        }

        public ICollection<ApplicationUser> GetAllFriends(string id)
        {
            var user = Database.Users.Get(id);

            if (user.Friends == null)
                user.Friends = new List<ApplicationUser>();

            return user.Friends;
        }

        public ICollection<ApplicationUser> GetNotFriends(string id)
        {
            var friends = GetAllFriends(id);
            var others = new List<ApplicationUser>();

            if (GetAllFriends(id).Count != 0)
            {
                //foreach (var user in GetAllUsers())
                //{
                //    foreach (var temp in friends)
                //    {
                //        if (user.Id != temp.Id && user.Id != id)
                //        {
                //            others.Add(user);
                //        }
                //    }
                //}

                others = GetAllUsers().ToList().Except(GetAllFriends(id)).ToList<ApplicationUser>();
            }
            else
            {
                others = Database.Users.GetAll().ToList<ApplicationUser>();
                others.Remove(GetUser(id));
            }

            return others;
        }

        public ApplicationUser GetUser(string id)
        {
            return Database.Users.Get(id);
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return Database.Users.GetAll();
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
