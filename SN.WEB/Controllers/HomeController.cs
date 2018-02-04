using SN.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }


        public ActionResult Index()
        {
            return View(userService.GetAllUsers());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}