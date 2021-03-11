using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktHistory
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdCash { get; set; }
        public string UserName { get; set; }
        public DateTime? DateChange { get; set; }
    }
}
