using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        ApplicationDbContext dbContext;
        MessageRepository messageRepository;
        UserRepository userRepository;

        public EFUnitOfWork(string connectionString)
        {
            dbContext = new ApplicationDbContext(); 
        }

        public IRepository<Message> Messages
        {
            get
            {
                if (dbContext != null)
                    messageRepository = new MessageRepository(dbContext);
                return messageRepository;
            }
        }

        public IRepository<ApplicationUser> Users
        {
            get
            {
                if (dbContext != null)
                    userRepository = new UserRepository(dbContext);
                return userRepository;
            }
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
