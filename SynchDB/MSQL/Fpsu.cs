using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Fpsu
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string RegNum { get; set; }
        public string UserDec { get; set; }
        public string Status { get; set; }
        public string Adres { get; set; }
        public string Host { get; set; }
        public string NastrDate { get; set; }
        public string Performed { get; set; }
        public string Pin1 { get; set; }
        public string Pin2 { get; set; }
        public string Puk1 { get; set; }
        public string Puk2 { get; set; }
        public string Note { get; set; }
        public string Note1 { get; set; }
    }
}
