using System.Collections.Generic;
using System.Diagnostics;

namespace CharpTipsTraps.SupportCode
{    
    internal class PersonWithDebuggerBrowsable
    {
        public PersonWithDebuggerBrowsable()
        {
            FaveColors = new List<string>();
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int AgeInYears { get; set; }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<string> FaveColors { get; set; }
    }
}