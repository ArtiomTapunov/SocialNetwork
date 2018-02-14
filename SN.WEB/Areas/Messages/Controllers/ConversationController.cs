using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Messages.Controllers
{
    public class ConversationController : Controller
    {
        // GET: Messages/Conversation
        public ActionResult Index()
        {
            return View();
        }
    }
}