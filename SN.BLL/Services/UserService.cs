using SN.BLL.Interfaces;
using SN.DAL.EF;
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Services
{
    public class UserService : IUserService
    {
        
        private readonly IUnitOfWork Database;

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return Database.Users.GetAll();
        }

        //Realization business logic for users
    }
}
