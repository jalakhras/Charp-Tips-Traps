﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos4
{
    [TestClass]
    public class ConvertingBaseTypesToBinaryExample
    {

        [TestMethod]
        public void BasicTypes()
        {
            const float originalFloat = 24.56f;
            byte[] byteArray = BitConverter.GetBytes(originalFloat);
            float convertedBack = BitConverter.ToSingle(byteArray, 0);
        }

        [TestMethod]
        public void DateTimes()
        {
            DateTime originalDate = DateTime.Now;
            long originalLong = originalDate.ToBinary();
            byte[] byteArray = BitConverter.GetBytes(originalLong);
            DateTime convertedBack = DateTime.FromBinary(BitConverter.ToInt64(byteArray, 0));
            var isSameDate = originalDate == convertedBack;
        }
    }
}