using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using SN.DAL.Entities;

namespace SN.DAL.EFContexts
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
