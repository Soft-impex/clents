using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class ZayavkaNew
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public int Num { get; set; }
        public string Ecpscope { get; set; }
        public int? Ecpcount { get; set; }
        public string Contracter { get; set; }
        public string Prinyal { get; set; }
        public string PrinyalData { get; set; }
        public string Sostav { get; set; }
        public string ShetEd { get; set; }
        public string AktEd { get; set; }
        public string ShetEdPrinyal { get; set; }
        public string ShetEdOtpravil { get; set; }
        public string ShetEdOtpravilMail { get; set; }
        public string ShetEdOplata { get; set; }
        public string ShetEdNote { get; set; }
        public string ShetLd { get; set; }
        public string AktLd { get; set; }
        public string ShetLdPrinyal { get; set; }
        public string ShetLdOtpravil { get; set; }
        public string ShetLdOtpravilMail { get; set; }
        public string ShetLdOplata { get; set; }
        public string ShetLdNote { get; set; }
        public string ZayavkaIn { get; set; }
        public string Infodek { get; set; }
        public string ZayavkaInOperator { get; set; }
        public DateTime? ZayavkaInOperatorDate { get; set; }
        public string ShetEcp { get; set; }
        public string ShetEcpPrinyal { get; set; }
        public string ShetEcpOplata { get; set; }
        public string ShetEcpNote { get; set; }
        public string ShetEcpAkt { get; set; }
        public string ShetEcpAktDate { get; set; }
        public string PoluchenoEcp { get; set; }
        public int? ChPoluchenoEcp { get; set; }
        public string PoluchenId { get; set; }
        public int? ChPoluchenId { get; set; }
        public string PoluchenFpsu { get; set; }
        public int? ChPoluchenFpsu { get; set; }
        public string PoluchenSsl { get; set; }
        public int? ChPoluchenSsl { get; set; }
        public string Technology { get; set; }
        public string Crypto { get; set; }
        public string Cspversion { get; set; }
        public bool? Cspchecked { get; set; }
        public string Csplicensee { get; set; }
        public string CryptoZakaz { get; set; }
        public int? DocComplite { get; set; }
        public string DataComplite { get; set; }
        public string Complite { get; set; }
        public string Note { get; set; }
        public int? Del { get; set; }
        public string DocumentsWorker { get; set; }
        public string DocumentsPeredanData { get; set; }
        public string DocumentsPeredanFio { get; set; }
        public bool? SpeedZayavka { get; set; }
        public int? WebNum { get; set; }
        public string RateChange { get; set; }
    }
}
