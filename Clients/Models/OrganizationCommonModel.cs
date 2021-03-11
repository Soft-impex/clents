using System;
using Clients.DataContext;
using System.Collections.Generic;
using System.Text;

namespace Clients.Models
{
    class OrganizationCommonModel:ViewOrgsummary
    {
        public List<string> Activities { get; set; }
        public int? ECPCount { get; set; } = null;
        public int? SSLCount { get; set; } = null;
        public int? SSLCountFree { get; set; } = null;
        public int? KKTCount { get; set; } = null;
        public bool Debt { get; set; }
        public OrderStateEnum OrdersState { get; set; } = OrderStateEnum.Default;

        public OrganizationCommonModel() { }
        public OrganizationCommonModel(ViewOrgsummary viewOrgsummary)
        {
            Name = viewOrgsummary.Name;
            NameFull = viewOrgsummary.NameFull;
            LegalForm = viewOrgsummary.LegalForm;
            ContractED = viewOrgsummary.ContractED;
            DateEd = viewOrgsummary.DateEd;
            ContractLd = viewOrgsummary.ContractLd;
            DateLd = viewOrgsummary.DateLd;
            Inn = viewOrgsummary.Inn;
            Kpp = viewOrgsummary.Kpp;
            Alias = viewOrgsummary.Alias;
            LicenseeOrgAlias = viewOrgsummary.LicenseeOrgAlias;
        }
    }
}
