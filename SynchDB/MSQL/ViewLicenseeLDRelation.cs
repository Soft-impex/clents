using System;
using System.Collections.Generic;
using System.Text;

namespace SynchDB.MSQL
{
    public class ViewLicenseeLDRelation
    {
        public Guid ParentID { get; set; }
        public string ParentOrgName { get; set; }
        public Guid ChildrenID { get; set; }
        public string ChildrenOrgName { get; set; }
    }
}
