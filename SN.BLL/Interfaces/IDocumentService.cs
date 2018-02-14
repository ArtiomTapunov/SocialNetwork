using SN.DomainModels.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Interfaces
{
    public interface IDocumentService<T> where T : Document
    {
        IEnumerable<T> GetAllDocuments();

        //void Upload(T document);
    }
}
