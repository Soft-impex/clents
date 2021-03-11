using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class StUser
    {
        public string LoginName { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Policy { get; set; }
        public string Dolgnost { get; set; }
    }
}
