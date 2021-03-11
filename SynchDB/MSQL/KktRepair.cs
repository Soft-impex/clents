using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktRepair
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdCash { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
