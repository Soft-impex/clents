using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class Post
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Type { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
    }
}
