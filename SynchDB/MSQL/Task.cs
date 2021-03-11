using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Task
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Manager { get; set; }
        public DateTime DataNach { get; set; }
        public DateTime? DataZav { get; set; }
        public string Tema { get; set; }
        public string Note { get; set; }
        public int? Vajn { get; set; }
        public DateTime? Napomin { get; set; }
        public string NapominPeriod { get; set; }
        public bool? Complite { get; set; }
    }
}
