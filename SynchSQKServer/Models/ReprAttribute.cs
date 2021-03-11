using System;
using System.Collections.Generic;
using System.Text;

namespace SynchSQKServer.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ReprAttribute : Attribute
    {
        public string Representation;
        public ReprAttribute(string representation)
        {
            this.Representation = representation;
        }
        public override string ToString()
        {
            return this.Representation;
        }
    }

}
