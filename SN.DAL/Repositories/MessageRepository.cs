using SN.DAL.EFContexts;
using SN.DAL.Entities;
using SN.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace SN.DAL.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        MessageContext dbContext;

        public MessageRepository(MessageContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Message> GetAll()
        {
            return dbContext.Messages;
        }

        public Message Get(string id)
        {
            return dbContext.Messages.Find(id);
        }

        public void Create(Message message)
        {
            dbContext.Messages.Add(message);
        }

        public void Update(Message message)
        {
            dbContext.Entry(message).State = EntityState.Modified;
        }

        public void Delete(string id)
        {
            Message message = dbContext.Messages.Find(id);

            if (message != null)
                dbContext.Messages.Add(message);
        }
    }
}
