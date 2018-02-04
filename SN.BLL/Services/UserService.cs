using SN.BLL.Interfaces;
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

        IUnitOfWork Database { get; set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Database.Users.GetAll();
        }

        //Realization business logic for users
    }
}
