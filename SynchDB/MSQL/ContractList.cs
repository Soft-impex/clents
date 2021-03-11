using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class ContractList
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string ShortName { get; set; }
        public string Num { get; set; }
        public DateTime? Date { get; set; }
        public bool? Disabled { get; set; }
    }
}
