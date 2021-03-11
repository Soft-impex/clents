using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class DogovorLd
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public int? Year { get; set; }
        public string Num { get; set; }
        public int? NumPril { get; set; }
        public string Theme { get; set; }
        public string TypeDoc { get; set; }
        public int? ProgVed { get; set; }
        public int? ProgRail { get; set; }
    }
}
