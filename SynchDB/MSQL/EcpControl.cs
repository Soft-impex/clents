using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class EcpControl
    {
        public Guid Id { get; set; }
        public Guid IdOrg { get; set; }
        public string OrgName { get; set; }
        public string Type { get; set; }
        public string Srok { get; set; }
        public int? Day { get; set; }
        public string UserEcp { get; set; }
        public string Fio { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Note { get; set; }
        public Guid IdEcp { get; set; }
    }
}
