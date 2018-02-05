using SN.DAL.EF;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Message> Messages { get; }
        IRepository<ApplicationUser> Users { get; }
        void Save();
    }
}
