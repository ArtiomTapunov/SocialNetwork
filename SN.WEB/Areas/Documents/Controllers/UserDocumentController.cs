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
    public class UserDocumentController : Controller
    {

        private readonly IDocumentService<UserDocument> documentService;

        public UserDocumentController(IDocumentService<UserDocument> service)
        {
            documentService = service;
        }

        public ActionResult AddDocument()
        {
            return new EmptyResult();
        }


        // GET: Documents/UserDocument
        public ActionResult Index()
        {
            return View(documentService.GetAllDocuments());
        }
    }
}