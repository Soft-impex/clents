using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class IdT
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string UserDec { get; set; }
        public string Pass { get; set; }
        public string IdDec { get; set; }
        public string Data { get; set; }
        public string MailCustoms { get; set; }
        public string Note { get; set; }
    }
}
