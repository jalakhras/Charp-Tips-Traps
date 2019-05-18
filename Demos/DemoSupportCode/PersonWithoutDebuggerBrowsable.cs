using System.Collections.Generic;

namespace CharpTipsTraps.SupportCode
{
    internal class PersonWithoutDebuggerBrowsable
    {
        public PersonWithoutDebuggerBrowsable()
        {
            FaveColors = new List<string>();
        }

        public int AgeInYears { get; set; }
        public string Name { get; set; }

        public List<string> FaveColors { get; set; }
    }
}