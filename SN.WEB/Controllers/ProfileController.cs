using Ninject;
using SN.BLL.Interfaces;
using SN.DomainModels;
using SN.DomainModels.SocialNetworkIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Controllers
{
    public class ProfileController : Controller
    {


        // GET: Profile


        public ActionResult Index()
        {
            return View();
        }
    }
}