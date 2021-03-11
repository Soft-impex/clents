using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.PgSQL
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }
        public string Phone1 { get; set; }
        public string Email { get; set; }
        public string Email1 { get; set; }
        public string Sqlguid { get; set; }
        public string Post { get; set; }
        public int? IsRepresentative { get; set; }

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
