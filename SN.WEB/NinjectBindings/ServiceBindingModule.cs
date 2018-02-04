using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using SN.DAL.Interfaces;

namespace SN.WEB.NinjectBindings
{
    public class ServiceBindingModule : NinjectModule
    {
        private string connectionString;

        public ServiceBindingModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<IUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}