using SN.DomainModels.Abstract_classes;
using SN.DomainModels.SocialNetworkIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels
{
    public class Photo : Document
    {
        public Album Album { get; set; }
    }
}
