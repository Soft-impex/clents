using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktHistoryAction
    {
        public Guid Id { get; set; }
        public string IdHistory { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string Note { get; set; }
    }
}
