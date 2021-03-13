using System;
using System.Collections.Generic;

#nullable disable

namespace Clients.DataContext
{
    public partial class ContractsLd
    {
        public int Id { get; set; }
        public int IdOrg { get; set; }
        public string Num { get; set; }
        public DateTime Date { get; set; }
        public string Agent { get; set; }

        public virtual Organization IdOrgNavigation { get; set; }
    }
}
