using SN.DAL.EF;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAllUsers();

        //Business logic abstract for users
    }
}
