using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PyanzinaMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Маша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual ("Привет..., Маша", res);
        }
    }
}
