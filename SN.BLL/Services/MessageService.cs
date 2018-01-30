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
        private readonly IRepository<Message> messageRepository;

        public MessageService(IRepository<Message> _messageRepository)
        {
            messageRepository = _messageRepository;
        }

        //Business logic for messages
    }
}
