using SN.BLL.Interfaces;
using SN.DomainModels;
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


        // GET: Documents/UserDocument
        public ActionResult Index()
        {
            return View();
        }
    }
}