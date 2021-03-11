using System;
using System.Collections.Generic;

#nullable disable

namespace SynchSQKServer.Models
{
    public partial class ContractEd
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Num { get; set; }
        public DateTime Date { get; set; }
        public string SQLGuid;

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
