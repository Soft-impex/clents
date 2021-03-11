using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class WorksClient
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string OrgName { get; set; }
        public string Note { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public string Shet { get; set; }
        public string ContactFio { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMail { get; set; }
        public string Sotrudnik { get; set; }
    }
}
