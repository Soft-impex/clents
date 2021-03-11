using System;
using System.Collections.Generic;

#nullable disable

namespace Clients.DataContext
{
    public partial class ViewOrglist
    {
        public int? Id { get; set; }
        public string Alias { get; set; }
        public int? LegalForm { get; set; }
        public string Name { get; set; }
        public string NameFull { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string BankName { get; set; }
        public string BankBik { get; set; }
        public string BankAccount { get; set; }
        public string BankCorrsepondentAccount { get; set; }
        public string DirectorName { get; set; }
        public string DirectorDolgnost { get; set; }
        public string Sqlguid { get; set; }
        public string ConstractEd { get; set; }
        public DateTime? DateEd { get; set; }
        public string ContractLd { get; set; }
        public DateTime? DateLd { get; set; }
    }
}
