using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class EcpVladelec
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Fio { get; set; }
        public string Post { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Note { get; set; }
    }
}
