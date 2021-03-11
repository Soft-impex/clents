using System;
using System.Collections.Generic;
using System.Text;

namespace SynchSQKServer.Models
{
    public class TarifED
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Name { get; set; }
        public DateTime DateApply { get; set; }
        public string LetterFileName { get; set; }
        public string SQLGuid;

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
