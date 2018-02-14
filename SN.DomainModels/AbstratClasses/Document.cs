using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels.Abstract_classes
{
    public abstract class Document
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime UploadDate { get; set; }

        public ICollection<Like> Likes { get; set; }

        public int LookAmount { get; set; }

        public byte[] Content { get; set; }
    }
}
