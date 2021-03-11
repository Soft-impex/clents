using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Organization
    {
        public Guid Id { get; set; }
        public string OrgName { get; set; }
        public string Contract { get; set; }
        public string Date { get; set; }
        public string ContractLd { get; set; }
        public string DateLd { get; set; }
        public string Type { get; set; }
        public string Operator { get; set; }
        public string Rate { get; set; }
        public string Licensee { get; set; }
        public int? Status { get; set; }
        public string UCList { get; set; }
        public string LdOrgName { get; set; }
        public int? LdBlock { get; set; }
        public string LdBlockWho { get; set; }
        public string CspLicensee { get; set; }
        public int? Diadok { get; set; }
        public string Contractor { get; set; }
        public string ContractorLd { get; set; }
        public string RespresentativeRegion { get; set; }
        public int? Sbis { get; set; }
        public int? StatusWork { get; set; }
        public int? StatusWorkEd { get; set; }
        public int? StatusWorkLd { get; set; }
    }
}
