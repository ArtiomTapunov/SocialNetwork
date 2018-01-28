using SN.DAL.Interfaces;
using SN.DAL.Entities;
using SN.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using SN.DAL.EFContexts;

namespace SN.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        MessageContext dbContext;
        MessageRepository messageRepository;
        UserRepository userRepository;

        public EFUnitOfWork(string connectionString)
        {
            dbContext = new MessageContext(connectionString);
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

        public IRepository<User> Users
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
