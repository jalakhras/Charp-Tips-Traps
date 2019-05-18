using CharpTipsTraps.SupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class DebuggerBrowsableAttributeExample
    {
        [TestMethod]
        public void Without()
        {
            var p = new PersonWithoutDebuggerBrowsable
            {
                AgeInYears = 50,
                Name = "Jassar",
                FaveColors = { "Red", "Green", "Blue" }
            };
        }
        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerBrowsable
            {
                AgeInYears = 50,
                Name = "Jassar",
                FaveColors = { "Red", "Green", "Blue" }
            };
        }

    }
}