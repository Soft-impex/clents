using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class LoginEcpControl
    {
        public string Login { get; set; }
        public int? Time { get; set; }
        public bool? Ssl { get; set; }
    }
}
