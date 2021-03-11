using System;
using System.Collections.Generic;
using System.Text;

namespace SynchSQKServer.Models
{
    public class ContractLD
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Num { get; set; }
        public DateTime Date { get; set; }
        public string SQLGuid;

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
