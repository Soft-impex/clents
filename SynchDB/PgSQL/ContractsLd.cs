using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.PgSQL
{
    public partial class ContractsLd
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Num { get; set; }
        public DateTime Date { get; set; }

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
