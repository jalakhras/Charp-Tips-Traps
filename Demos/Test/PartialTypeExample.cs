using CharpTipsTraps.SupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PartialTypeExample
    {
        [TestMethod]
        public void Example()
        {
            var a = new APartialType();

            a.SomeMethod();
            a.SomeOtherMethod();
        }
    }
}