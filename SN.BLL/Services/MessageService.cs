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
    public class MessageService : IMessageService
    {
        IUnitOfWork Database { get; set; }

        public MessageService(IUnitOfWork uow)
        {
            Database = uow;
        }

        //Business logic for messages
    }
}
