using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class DogovorCtm
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string OrgName { get; set; }
        public string Inn { get; set; }
        public string TypeProgram { get; set; }
        public string VedYear { get; set; }
        public string RailYear { get; set; }
    }
}
