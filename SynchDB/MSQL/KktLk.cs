using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktLk
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdCash { get; set; }
        public string Lktype { get; set; }
        public string Lkhttp { get; set; }
        public string Lklogin { get; set; }
        public string Lkpass { get; set; }
        public bool? Lkecp { get; set; }
        public string Note { get; set; }
    }
}
