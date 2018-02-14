using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SN.DomainModels;
using System.Configuration;
using SN.DomainModels.SocialNetworkIModels;

namespace SN.DAL.EF
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static readonly object Lock = new object();
        private static bool _databaseInitialized;

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;

            //if (_databaseInitialized)
            //{
            //    return;
            //}
            //lock (Lock)
            //{
            //    if (!_databaseInitialized)
            //    {
            //        Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            //        _databaseInitialized = true;
            //    }
            //}
        }

        public ApplicationDbContext(string connectionString)
            : base(connectionString, throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Message> Messages { get; set; }

        //public DbSet<Like> Likes { get; set; }

        //public DbSet<Video> Videos { get; set; }

        //public DbSet<Photo> Photos { get; set; }

        //public DbSet<Post> Posts { get; set; }

        //public DbSet<Album> Albums { get; set; }
    }
}
























