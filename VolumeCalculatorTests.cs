using Microsoft.VisualStudio.TestTools.UnitTesting;
using L;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Tests
{
    [TestClass()]
    public class VolumeCalculatorTests
    {
        [TestMethod()]
        [DataRow(24, 2, 6, 2)]
        [DataRow(30, 1, 6, 5)]

        public void GetVolumeTest(double V, double a, double b, double c)
        {
            var raw_Volume = VolumeCalculator.GetVolume(a, b, c);

            Assert.AreEqual(V, raw_Volume);
        }

        [TestMethod()]
        [DataRow(0, 0, 1, 1)]
        [DataRow(0, 0, 5, 5)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetVInvalidArgsTest(double V, double a, double b, double c)
        {
            var raw_Volume = VolumeCalculator.GetVolume(a, b, c);

            Assert.AreEqual(V, raw_Volume);

        }

        [TestMethod()]
        public void GetVDescriptionTest()
        {
            var des = VolumeDescription.GetVolumeDescription(24);

            Assert.AreEqual("Маленький объем", des);
        }
    }
}