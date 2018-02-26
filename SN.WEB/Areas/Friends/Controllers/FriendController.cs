using SN.BLL.Interfaces;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SN.WEB.Areas.Friends.Controllers
{
    public class FriendController : Controller
    {
        private readonly IUserService _userService;

        public FriendController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult RemoveFriend(string userId, string id)
        {
            _userService.RemoveFriend(userId, id);

            var friends = _userService.GetAllFriends(userId);
            var others = _userService.GetNotFriends(userId);

            ViewBag.UserId = id;
            ViewBag.Others = others;
            return RedirectToAction("Index", new { id = userId });
        }


        public ActionResult AddToFriends(string userId, string id)
        {
            _userService.AddFriend(userId, id);

            var friends = _userService.GetAllFriends(userId);
            var others = _userService.GetNotFriends(userId);

            ViewBag.UserId = id;
            ViewBag.Others = others;
            return RedirectToAction("Index", new { id = userId });
        }


        // GET: Friends/Friend
        public ActionResult Index(string id)
        {
            var friends = _userService.GetAllFriends(id);
            var others = _userService.GetNotFriends(id);
            //if (friends != null)
            ////{
            ////    foreach (var user in _userService.GetAllUsers())
            ////    {
            ////        foreach (var temp in friends)
            ////        {
            ////            if (user.Id != temp.Id && user.Id != id)
            ////            {
            ////                others.Add(user);
            ////            }
            ////        }
            ////    }
            ////}
            ////else
            ////{
            ////    foreach (var user in _userService.GetAllUsers())
            ////    {

            ////            if ( user.Id != id)
            ////            {
            ////                others.Add(user);
            ////            }
            ////    }
            ////}
            ViewBag.UserId = id;
            ViewBag.Others = _userService.GetNotFriends(id);
            return View(friends);
        }
    }
}