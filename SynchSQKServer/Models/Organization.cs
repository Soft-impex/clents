using System;
using System.Collections.Generic;

#nullable disable

namespace SynchSQKServer.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Contacts = new HashSet<Contact>();
            ContractsEd = new HashSet<ContractEd>();
            ContractsLd = new HashSet<ContractLD>();
            TarifsED = new HashSet<TarifED>();
        }
        public int Id { get; set; }
        public string Alias { get; set; }
        public int LegalForm { get; set; }
        public string Name { get; set; }
        public string NameFull { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string DirectorName { get; set; }
        public string DirectorDolgnost { get; set; }
        public string BankName { get; set; } = null;
        public string BankBik { get; set; } = null;
        public string BankAccount { get; set; } = null;
        public string BankCorrsepondentAccount { get; set; } = null;

        public string SQLGuid { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<ContractEd> ContractsEd { get; set; }
        public virtual ICollection<ContractLD> ContractsLd { get; set; }
        public virtual ICollection<TarifED> TarifsED { get; set; }
    }
}
