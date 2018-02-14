using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels.SocialNetworkIModels
{
    public class Album
    {
        public ICollection<Photo> Album_Photos { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
