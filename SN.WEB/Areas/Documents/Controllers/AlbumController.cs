using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Documents.Controllers
{
    public class AlbumController : Controller
    {

        public AlbumController()
        {

        }


        // GET: Documents/Album
        public ActionResult Index()
        {
            return View();
        }
    }
}