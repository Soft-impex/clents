using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class InfOperatorsList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PostAdres { get; set; }
        public string MethodDostavki { get; set; }
        public string DogovorPony { get; set; }
        public string Note { get; set; }
    }
}
