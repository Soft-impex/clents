using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class SelectOrgTmp
    {
        public Guid Id { get; set; }
        public string OrgName { get; set; }
        public string OrgNameOriginal { get; set; }
        public string Inn { get; set; }
        public string ContractorEd { get; set; }
        public string ContractEd { get; set; }
        public string DateEd { get; set; }
        public string ContractorLd { get; set; }
        public string ContractLd { get; set; }
        public string DateLd { get; set; }
        public string Type { get; set; }
        public string Operator { get; set; }
        public string Rate { get; set; }
        public string RespresentativeRegion { get; set; }
        public string Licensee { get; set; }
        public int? Status { get; set; }
        public int? EcpNotEmpty { get; set; }
        public int? ConnectNotEmpty { get; set; }
        public int? Contacts { get; set; }
        public int? StatusAllert { get; set; }
        public int? CryptoZakaz { get; set; }
        public int? UkCount { get; set; }
        public int? SslBlockCount { get; set; }
        public int? SslBlockNow { get; set; }
        public string UC { get; set; }
        public int? LdBlock { get; set; }
        public int? Diadok { get; set; }
        public int? Sbis { get; set; }
    }
}
