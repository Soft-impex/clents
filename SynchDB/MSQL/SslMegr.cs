using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class SslMegr
    {
        public Guid Id { get; set; }
        public string SslLoginId { get; set; }
        public string OrgOld { get; set; }
        public string OrgNew { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public string Note { get; set; }
    }
}
