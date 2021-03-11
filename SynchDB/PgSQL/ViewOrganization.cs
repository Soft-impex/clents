using System;
using System.Collections.Generic;
using System.Text;

namespace SynchDB.PgSQL
{
    public class ViewOrganization
    {

        public int Id { get; set; }
        public string Alias { get; set; }
        public int LegalForm { get; set; }
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
        public string ConstractED { get; set; }
        public DateTime? DateED { get; set; }
        public string ContractLD { get; set; }
        public DateTime? DateLD { get; set; }
    }
}
