using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class DogovorEd
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public DateTime? DateGenerate { get; set; }
        public byte? Num { get; set; }
        public string NumPril { get; set; }
        public string Theme { get; set; }
    }
}
