using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SN.DomainModels;

namespace SN.DAL.EF
{
    public class MessageContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        static MessageContext()
        {
            //Database.SetInitializer<MobileContext>(new StoreDbInitializer());
        }

        public MessageContext(string connectionString) : base(connectionString)
        {

        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<MessageContext>
        {
            protected override void Seed(MessageContext db)
            {
                //put your initialize data into this method
                //db.SaveChanges();
            }
        }
    }
}
