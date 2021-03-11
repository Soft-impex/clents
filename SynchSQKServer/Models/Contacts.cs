using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SynchSQKServer.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Post { get; set; } = null;
        public string Fio { get; set; }
        public string Phone { get; set; } = null;
        public string Phone1 { get; set; } = null;
        public string Email { get; set; } = null;
        public string Email1 { get; set; } = null;
        public int isRepresentative { get; set; } = 0;

        public string SQLGuidOrg;
        public string SQLGuid { get; set; }

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
