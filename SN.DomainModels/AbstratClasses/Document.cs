using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels.Abstract_classes
{
    public abstract class Document
    {
        protected int Id { get; set; }

        protected string Title { get; set; }

        protected string Description { get; set; }

        protected DateTime UploadDate { get; set; }

        protected ICollection<Like> Likes { get; set; }

        protected int LookAmount { get; set; }

        protected byte[] Content { get; set; }
    }
}
