using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class TriggerOrderPaymentTable
    {
        public Guid Id { get; set; }
        public Guid IdOrder { get; set; }
        public string Shet { get; set; }
        public string OrderNote { get; set; }
        public DateTime? DateOrder { get; set; }
        public DateTime? DatePaymet { get; set; }
    }
}
