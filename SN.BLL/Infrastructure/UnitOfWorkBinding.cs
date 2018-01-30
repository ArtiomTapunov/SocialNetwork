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
    class UnitOfWorkBinding : NinjectModule
    {
        private string connectionString;

        public UnitOfWorkBinding(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
