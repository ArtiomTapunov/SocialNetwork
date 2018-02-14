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
        [Inject]
        private readonly IUserService userService;

        [Inject]
        private readonly IMessageService messageService;

        [Inject]
        private readonly IDocumentService<Photo> photoService;

        [Inject]
        private readonly IDocumentService<Video> videoService;

        [Inject]
        private readonly IDocumentService<UserDocument> documentService;

        // GET: Profile

        public ActionResult Photos()
        {
            return View(photoService.GetAllDocuments());
        }

        public ActionResult Videos()
        {
            return View(videoService.GetAllDocuments());
        }

        public ActionResult UserDocuments()
        {
            return View(documentService.GetAllDocuments());
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}