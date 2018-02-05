using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System.Collections.Generic;
using System.Data.Entity;

namespace SN.DAL.Repositories
{
    public class UserRepository : IRepository<ApplicationUser>
    {
        ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return dbContext.Users;
        }

        public ApplicationUser Get(string id)
        {
            return dbContext.Users.Find(id);
        }

        public void Create(ApplicationUser user)
        {
            dbContext.Users.Add(user);
        }

        public void Update(ApplicationUser user)
        {
            dbContext.Entry(user).State = EntityState.Modified;
        }

        public void Delete(string id)
        {
            var user = dbContext.Users.Find(id);

            if (user != null)
                dbContext.Users.Remove(user);
        }

    }
}
