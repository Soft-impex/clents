using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Ecp
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Nositel { get; set; }
        public string Num { get; set; }
        public string NumSer { get; set; }
        public int? ChSrok { get; set; }
        public DateTime? Srok { get; set; }
        public string Status { get; set; }
        public string UserEcp { get; set; }
        public string Pass { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string ZayavkaNum { get; set; }
        public string Poluchena { get; set; }
    }
}
