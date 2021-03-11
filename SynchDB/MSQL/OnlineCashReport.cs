using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class OnlineCashReport
    {
        public Guid Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public decimal? SumAll { get; set; }
        public string KassirFio { get; set; }
        public string KassirInn { get; set; }
    }
}
