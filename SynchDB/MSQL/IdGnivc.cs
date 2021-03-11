using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class IdGnivc
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string AdressOtprav { get; set; }
        public string Pass { get; set; }
        public string IdDecl { get; set; }
        public int? Status { get; set; }
        public string Operator { get; set; }
        public string Note { get; set; }
    }
}
