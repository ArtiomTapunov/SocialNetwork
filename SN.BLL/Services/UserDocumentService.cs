using SN.BLL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Services
{
    public class UserDocumentService : IDocumentService<UserDocument>
    {
        public IEnumerable<UserDocument> GetAllDocuments()
        {
            return null;
        }
    }
}
