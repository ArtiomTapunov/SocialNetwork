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
    public class VideoController : Controller
    {

        private readonly IDocumentService<Video> videoService;

        public VideoController(IDocumentService<Video> Service)
        {
            videoService = Service;
        }

        // GET: Documents/Video
        public ActionResult Index()
        {
            return View(videoService.GetAllDocuments());
        }
    }
}