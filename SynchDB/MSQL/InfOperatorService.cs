using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class InfOperatorService
    {
        public Guid Id { get; set; }
        public string IdOperator { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Note { get; set; }
        public string TypePay { get; set; }
    }
}
