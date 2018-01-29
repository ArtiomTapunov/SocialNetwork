using SN.BLL.Interfaces;
using SN.DAL.Entities;
using SN.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
