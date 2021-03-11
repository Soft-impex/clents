using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class OnlineCashGood
    {
        public Guid Id { get; set; }
        public string IdCheque { get; set; }
        public string GoodName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Sum { get; set; }
    }
}
