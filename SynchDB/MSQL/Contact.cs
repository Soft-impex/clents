using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Contact
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Post { get; set; }
        public string Fio { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mail { get; set; }
        public int? Status { get; set; }
        public int? Predstavitel { get; set; }
    }
}
