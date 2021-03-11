using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.PgSQL
{
    public partial class TarifsEd
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Name { get; set; }
        public DateTime DateApply { get; set; }
        public string LetterFileName { get; set; }

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
