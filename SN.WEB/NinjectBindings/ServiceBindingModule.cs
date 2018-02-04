using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using SN.BLL.Interfaces;
using SN.BLL.Services;

namespace SN.WEB.NinjectBindings
{
    public class ServiceBindingModule : NinjectModule
    {      
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IMessageService>().To<MessageService>();
        }
    }
}