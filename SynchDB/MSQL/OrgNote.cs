using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class OrgNote
    {
        public string GuidOrg { get; set; }
        public string LegalForm { get; set; }
        public string OrgNameOriginal { get; set; }
        public string AdressFactIndex { get; set; }
        public string AdressFact { get; set; }
        public string AdressUridIndex { get; set; }
        public string AdressUrid { get; set; }
        public string Director { get; set; }
        public string Dolgnost { get; set; }
        public string Polnomochia { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string RShet { get; set; }
        public string Bank { get; set; }
        public string KorShet { get; set; }
        public string Bik { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string StrahNum { get; set; }
        public int? KolKanalov { get; set; }
        public string CryptoPro { get; set; }
        public string Note { get; set; }
        public string CorrespondenceType { get; set; }
        public string CorrespondenceAdres { get; set; }
        public string CorrespondenceMail { get; set; }
    }
}
