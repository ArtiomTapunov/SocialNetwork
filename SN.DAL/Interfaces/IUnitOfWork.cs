using SN.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SN.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Message> Messages { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}
