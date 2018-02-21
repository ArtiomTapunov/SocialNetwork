using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SN.DomainModels.SocialNetworkIModels;

namespace SN.DomainModels
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Message> Messages { get; set; }

        public bool IsOnline { get; set; }

        public ICollection<ApplicationUser> Friends { get; set; }

        //public ICollection<Photo> Photos { get; set; }

        //public ICollection<Video> Videos { get; set; }

        //public ICollection<UserDocument> UserDocuments { get; set; }

        //public Settings Settings { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}
