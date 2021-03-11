using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class OnlineCashCheque
    {
        public Guid Id { get; set; }
        public string IdCashReport { get; set; }
        public string IdOrder { get; set; }
        public DateTime? DatePrint { get; set; }
    }
}
