using SN.BLL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Services
{
    public class VideoService : IDocumentService<Video>
    {
        public IEnumerable<Video> GetAllDocuments()
        {
            return null;
        }
    }
}
