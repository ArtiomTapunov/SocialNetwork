using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public ApplicationUser From { get; set; }
        public ApplicationUser To { get; set; }

        //public bool IsRead { get; set }
    }
}
