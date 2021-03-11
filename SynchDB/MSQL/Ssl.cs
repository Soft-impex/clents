using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Ssl
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string UserDec { get; set; }
        public string Pass { get; set; }
        public string IdDec { get; set; }
        public string AdresOtprav { get; set; }
        public string Note { get; set; }
    }
}
