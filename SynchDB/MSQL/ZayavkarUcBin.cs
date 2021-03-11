using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class ZayavkarUcBin
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string IdOrder { get; set; }
        public int Num { get; set; }
        public DateTime? Step1Date { get; set; }
        public string Step1Worker { get; set; }
        public DateTime? Step2Date { get; set; }
        public string Step2Worker { get; set; }
        public string Step2ContactFio { get; set; }
        public string Step2ContactPhone { get; set; }
        public string Step2ContactMail { get; set; }
        public DateTime? Step3Date { get; set; }
        public string Step3Worker { get; set; }
        public bool? Step3DocZayavka { get; set; }
        public bool? Step3DocDoverenost { get; set; }
        public bool? Step3DocInn { get; set; }
        public bool? Step3DocOgrn { get; set; }
        public bool? Step3DocPasport { get; set; }
        public bool? Step3DocPropiska { get; set; }
        public bool? Step3DocSnils { get; set; }
        public bool? Step3DocPay { get; set; }
        public bool? Step3DocOrderOriginal { get; set; }
        public bool? Step3DocDoverenostOriginal { get; set; }
        public bool? Step3DocInnoriginal { get; set; }
        public bool? Step3DocOgrnoriginal { get; set; }
        public bool? Step3DocPasportOriginal { get; set; }
        public bool? Step3DocPropiskaOriginal { get; set; }
        public bool? Step3DocSnilsOriginal { get; set; }
        public DateTime? Step4Date { get; set; }
        public string Step4Worker { get; set; }
        public DateTime? Step5Date { get; set; }
        public string Step5Worker { get; set; }
        public string Step5ContactFio { get; set; }
        public string Step5ContactPhone { get; set; }
        public string Step5ContactMail { get; set; }
        public DateTime? Step6Date { get; set; }
        public string Step6Worker { get; set; }
        public DateTime? Step7Date { get; set; }
        public string Step7Worker { get; set; }
        public bool? Step7DocBinDogovor { get; set; }
        public bool? Step7DocBinAct { get; set; }
        public bool? Step7DocBinCer { get; set; }
        public bool? Step7DocSidogovor { get; set; }
        public bool? Step7DocSiact { get; set; }
        public string Note { get; set; }
    }
}
