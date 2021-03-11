using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class SslBlock
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdSsl { get; set; }
        public string SslName { get; set; }
        public DateTime? DateBlock { get; set; }
        public DateTime? DateUnblick { get; set; }
    }
}
