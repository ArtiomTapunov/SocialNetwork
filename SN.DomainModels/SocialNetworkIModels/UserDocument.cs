using SN.DomainModels.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels.SocialNetworkIModels
{
    public class UserDocument : Document
    {
        public int DownloadAmount { get; set; }
    }
}
