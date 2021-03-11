using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktReport
    {
        public Guid Id { get; set; }
        public string IdParent { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
    }
}
