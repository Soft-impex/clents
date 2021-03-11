using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktFiscal
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdCash { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string Num { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateBy { get; set; }
        public string Note { get; set; }
    }
}
