using SN.DomainModels.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels
{
    public class Post
    {

        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<Document> AttachedDocuments { get; set; }

    }
}
