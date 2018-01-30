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

        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> _userRepository)
        {
            userRepository = _userRepository;
        }

        //Realization business logic for users
    }
}
