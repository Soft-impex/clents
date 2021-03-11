using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class EcpTemp
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Nositel { get; set; }
        public string Num { get; set; }
        public string UserEcp { get; set; }
        public string Note1 { get; set; }
    }
}
