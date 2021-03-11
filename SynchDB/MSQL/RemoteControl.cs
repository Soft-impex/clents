using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class RemoteControl
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Tid { get; set; }
        public string Tpass { get; set; }
        public string ContactFio { get; set; }
        public string ContactDolgnost { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail { get; set; }
        public string Note { get; set; }
    }
}
