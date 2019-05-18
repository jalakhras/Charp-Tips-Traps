using System.Diagnostics;
using CharpTipsTraps.SupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CallerInfoAttributesExample
    {
        [TestMethod]
        public void ExampleFooMethod()
        {
            var c = new CallerInfoAttribute();

            Debug.WriteLine(c.WhoCalledMe());

            Debug.WriteLine(c.WhatFileCalledMe());

            Debug.WriteLine(c.WhatLineCalledMe());
        }
    }
}