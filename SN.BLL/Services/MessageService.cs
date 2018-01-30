using SN.BLL.Interfaces;
<<<<<<< HEAD
using SN.DAL.Entities;
using SN.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
=======
using SN.DAL.Interfaces;
using SN.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> Added BLL and DomainModels projects. Recreated DAL

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
