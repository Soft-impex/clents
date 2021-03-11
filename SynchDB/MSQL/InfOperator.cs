using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class InfOperator
    {
        public Guid Id { get; set; }
        public string IdOperator { get; set; }
        public string Fio { get; set; }
        public string Dolgnost { get; set; }
        public string Otvetstvennost { get; set; }
        public string PhoneWork1 { get; set; }
        public string PhoneWork2 { get; set; }
        public string PhoneMobil1 { get; set; }
        public string PhoneMobil2 { get; set; }
        public string Sip { get; set; }
        public string Mail { get; set; }
        public string Icq { get; set; }
        public string Skype { get; set; }
        public byte[] Foto { get; set; }
    }
}
