using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Settings.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings/Settings
        public ActionResult Index()
        {
            return View();
        }
    }
}