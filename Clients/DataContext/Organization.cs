﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Clients.DataContext
{
    public partial class Organization
    {
        public Organization()
        {
            Contacts = new HashSet<Contact>();
            ContractsEds = new HashSet<ContractsEd>();
            ContractsLds = new HashSet<ContractsLd>();
            TarifsEds = new HashSet<TarifsEd>();
            InverseLicenseeLdidOrgNavigation = new HashSet<Organization>();
        }

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
        public Boolean EDOSbis { get; set; }
        public Boolean EDOTaxcom { get; set; }
        public Boolean EDODiadok { get; set; }
        public Boolean EDODiadok820 { get; set; }
        public string Sqlguid { get; set; }
        public int? LicenseeLdidOrg { get; set; }
        public string SubDiller { get; set; }
        public Boolean StatusWork { get; set; }

        public virtual Organization LicenseeLdidOrgNavigation { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<ContractsEd> ContractsEds { get; set; }
        public virtual ICollection<ContractsLd> ContractsLds { get; set; }
        public virtual ICollection<TarifsEd> TarifsEds { get; set; }
        public virtual ICollection<Organization> InverseLicenseeLdidOrgNavigation { get; set; }
    }
}
