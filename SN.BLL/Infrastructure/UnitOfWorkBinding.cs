using Ninject.Modules;
using SN.DAL.Interfaces;
using SN.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.BLL.Infrastructure
{
    public class UnitOfWorkBinding : NinjectModule
    {
        private string connectionString;

        public UnitOfWorkBinding(string connection)
        {
            connectionString = "Data Source=DESKTOP-RB8PI6P;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
