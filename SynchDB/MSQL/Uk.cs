using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Uk
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string PointIn { get; set; }
        public string Note { get; set; }
    }
}
