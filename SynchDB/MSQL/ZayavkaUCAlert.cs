using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class ZayavkaUCAlert
    {
        public Guid Id { get; set; }
        public int? Num { get; set; }
        public string OrgName { get; set; }
        public string S { get; set; }
        public string SAll { get; set; }
        public string IdZayavkaNew { get; set; }
        public string IdZayavkaUC { get; set; }
        public DateTime? DateShow { get; set; }
        public string LoginAuth { get; set; }
    }
}
