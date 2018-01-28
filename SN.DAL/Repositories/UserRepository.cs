using SN.DAL.EFContexts;
using SN.DAL.Entities;
using SN.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace SN.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        MessageContext dbContext;

        public UserRepository(MessageContext context)
        {
            dbContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users;
        }

        public User Get(string id)
        {
            return dbContext.Users.Find(id);
        }

        public void Create(User user)
        {
            dbContext.Users.Add(user);
        }

        public void Update(User user)
        {
            dbContext.Entry(user).State = EntityState.Modified;
        }

        public void Delete(string id)
        {
            User user = dbContext.Users.Find(id);

            if (user != null)
                dbContext.Users.Remove(user);
        }
    }
}
