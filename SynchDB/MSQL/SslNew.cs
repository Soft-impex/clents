using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class SslNew
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string AdressGnivc { get; set; }
        public string IdDecl { get; set; }
        public string Note { get; set; }
        public int? Status { get; set; }
        public string DateGo { get; set; }
        public string PassOld { get; set; }
    }
}
