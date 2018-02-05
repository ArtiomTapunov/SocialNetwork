using SN.BLL.Interfaces;
using SN.DAL.Interfaces;

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
