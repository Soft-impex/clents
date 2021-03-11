using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktOfd
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdCash { get; set; }
        public string Operator { get; set; }
        public string Code { get; set; }
        public DateTime DateActivate { get; set; }
        public DateTime? DateBy { get; set; }
        public string Tarif { get; set; }
    }
}
