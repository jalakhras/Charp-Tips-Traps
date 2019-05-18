using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class DontCallVirtualMethodsFromCtorExample
    {
        [TestMethod]
        public void UsingBaseClass()
        {
            new BaseClass();
        }


        [TestMethod]
        public void UsingDerivedClass()
        {
            new DerivedClass();
        }


        private class BaseClass
        {
            private int _length;
            protected string Name;

            public BaseClass()
            {
                InitName();

                _length = Name.Length;
            }

            protected virtual void InitName()
            {
                Name = "Jassar";
            }
        }


        private class DerivedClass : BaseClass
        {
            protected override void InitName()
            {
                Name = null;
            }
        }
    }
}