using System;
using System.Collections.Generic;
using System.Text;

namespace SN.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public User From { get; set; }
        public User To { get; set; }

        //public bool IsRead { get; set }
    }
}
