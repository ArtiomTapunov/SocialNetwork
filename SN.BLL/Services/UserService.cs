using SN.BLL.Interfaces;
using SN.DAL.Entities;
using SN.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
