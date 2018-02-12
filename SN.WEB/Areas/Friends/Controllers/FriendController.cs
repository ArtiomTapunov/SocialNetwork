using SN.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Friends.Controllers
{
    public class FriendController : Controller
    {

        private readonly IUserService _userService;

        public FriendController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: Friends/Friend
        public ActionResult Index()
        {
            return View(_userService.GetAllFriends());
        }
    }
}