using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class ZayavkaPerechen
    {
        public Guid Id { get; set; }
        public string IdZayavki { get; set; }
        public string Unit { get; set; }
        public string Fio { get; set; }
        public string Post { get; set; }
        public string Adress { get; set; }
        public string Snils { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public bool? UsePi { get; set; }
        public bool? UseEd { get; set; }
        public bool? UseSvx { get; set; }
        public string Nositel { get; set; }
        public string Worker { get; set; }
        public string DataComplite { get; set; }
        public string Scope { get; set; }
    }
}
