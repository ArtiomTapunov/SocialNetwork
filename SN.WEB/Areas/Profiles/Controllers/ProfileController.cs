using Ninject;
using SN.BLL.Interfaces;
using SN.DomainModels;
using SN.DomainModels.SocialNetworkIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Profiles
{
    public class ProfileController : Controller
    {


        public ProfileController()
        {

        }

        // GET: Profile


        public ActionResult Index()
        {
            return View();
        }
    }
}