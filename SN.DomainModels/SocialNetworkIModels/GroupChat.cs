using SN.DomainModels.AbstratClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN.DomainModels.SocialNetworkIModels
{
    public class GroupChat : Group
    {
        public ICollection<Message> Сorrespondence { get; set; }
    }
}
