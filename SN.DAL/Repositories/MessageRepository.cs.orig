<<<<<<< HEAD
﻿using SN.DAL.EFContexts;
=======
﻿using SN.DAL.EF;
>>>>>>> Added BLL and DomainModels projects. Recreated DAL
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
<<<<<<< HEAD
using SN.DAL.Entities;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> Added BLL and DomainModels projects. Recreated DAL

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
            var message = dbContext.Messages.Find(id);

            if (message != null)
                dbContext.Messages.Add(message);
        }
    }
}
