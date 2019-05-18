using CharpTipsTraps.SupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class DebuggerDisplayAttributeExample
    {
        [TestMethod]
        public void Without()
        {
            var p = new PersonWithoutDebuggerDisplay
            {
                AgeInYears = 50,
                Name = "Jassar"
            };
        }
        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerDisplay
            {
                AgeInYears = 50,
                Name = "Jassar"
            };
        }
        // DebuggerDisplay can be applied to:
        //Classes
        //Structs
        //Delegates
        //Enums
        //Fields
        //Properties
        //Assemblies
    }
}