using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DAL.Repositories
{
    public class MessageRepository : IRepository<Message>
    {
        ApplicationDbContext dbContext;

        public MessageRepository(ApplicationDbContext context)
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
            var message = dbContext.Messages.Find(id);

            if (message != null)
                dbContext.Messages.Add(message);
        }
    }
}
