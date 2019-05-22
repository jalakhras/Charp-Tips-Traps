using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Demos4
{
    [TestClass]
    public class ParseExactDateTimeExample
    {
        [TestMethod]
        public void AmbiguousParse()
        {
            const string ambiguousDateString = "01/12/2000";

            var d = DateTime.Parse(ambiguousDateString);

            Debug.WriteLine(d.ToLongDateString());

            d = DateTime.ParseExact(ambiguousDateString, "MM/dd/yyyy", null);

            Debug.WriteLine(d.ToLongDateString());
        }

        [TestMethod]
        public void StrictParse()
        {
            const string nonLocalFormat = "01-12-2000";

            var d = DateTime.Parse(nonLocalFormat);

            Debug.WriteLine(d.ToLongDateString());

            d = DateTime.ParseExact(nonLocalFormat, "dd/MM/yyyy", null);
        }

    }
}
