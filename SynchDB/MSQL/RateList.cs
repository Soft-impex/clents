using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class RateList
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string LetterFilename { get; set; }
        public int? CurrentRate { get; set; }
    }
}
