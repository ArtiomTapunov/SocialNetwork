﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SN.DAL.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string PoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
	public ICollection<Message> Messages { get; set; }

        //public bool IsOnline { get; set; }
        //ICollection<User> Friends { get; set; }     
    }
}
