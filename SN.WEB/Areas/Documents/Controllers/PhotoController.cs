using SN.BLL.Interfaces;
using SN.DomainModels;
using SN.DomainModels.SocialNetworkIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SN.WEB.Areas.Documents.Controllers
{
    public class PhotoController : Controller
    {

        private readonly IDocumentService<Photo> photoService;

        public PhotoController(IDocumentService<Photo> Service)
        {
            photoService = Service;
        }


        // GET: Documents/Photo
        public ActionResult Index()
        {
            return View(photoService.GetAllDocuments());
        }
    }
}