using SN.BLL.Interfaces;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Friends.Controllers
{
    public class FriendController : Controller
    {

        private readonly IRepository<ApplicationUser> _repository;


        private readonly IUserService _userService;

        public FriendController(IUserService userService, IRepository<ApplicationUser> repository)
        {
            _userService = userService;
            _repository = repository;
        }

        public void RemoveFriend(string userId, string id)
        {
            _userService.RemoveFriend(userId, id);
        }


        public void AddToFriends(string userId, string id)
        {
            _userService.AddFriend(userId, id);
        }


        // GET: Friends/Friend
        public ActionResult Index(string id)
        {
            var friends = _userService.GetAllFriends(id);
            var others = new List<ApplicationUser>();
            if (friends != null)
            {
                foreach (var user in _repository.GetAll())
                {
                    foreach (var temp in friends)
                    {
                        if (user.Id != temp.Id && user.Id != id)
                        {
                            others.Add(user);
                        }
                    }
                }
            }
            else
            {
                foreach (var user in _repository.GetAll())
                {

                        if ( user.Id != id)
                        {
                            others.Add(user);
                        }
                }
            }
            ViewBag.UserId = id;
            ViewBag.Others = others;
            return View(friends);
        }
    }
}