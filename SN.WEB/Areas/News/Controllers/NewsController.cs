using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.News.Controllers
{
    public class NewsController : Controller
    {

        public NewsController()
        {

        }

        // GET: News/News
        public ActionResult Index()
        {
            return View();
        }
    }
}