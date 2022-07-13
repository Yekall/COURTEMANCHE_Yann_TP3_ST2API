using System;
using ApiControler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApi
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void testCity()
        {
            var p = new APIcontrol();
            p.GetCity("45.2605","4.2325");
            Assert.AreEqual(p.objectRes.name,"Saint-Étienne","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"gggg","Error Api City");

        }
        
        [TestMethod]
        public void testCity2()
        {
            var p = new APIcontrol();
            p.GetCity("34.3629","58.2213");
            Assert.AreEqual(p.objectRes.name,"Buenos Aires","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"Paris","Error Api City");

        }
        [TestMethod]
        public void testCity3()
        {
            var p = new APIcontrol();
            p.GetInfo2("Tokyo");
            Assert.AreEqual(p.objectRes.name,"Tokyo","Error Api City");
            Assert.AreNotEqual(p.objectRes.name,"Kyoto","Error Api City");

        }
        
        [TestMethod]
        public void testForecast()
        {
            var p = new APIcontrol();
            p.GetInfo2("London");
            Assert.AreNotEqual(p.objectRes2.list[8].dt,p.objectRes2.list[16].dt,"Error Api City");

        }
        [TestMethod]
        public void testForecast2()
        {
            var p = new APIcontrol();
            p.GetInfo2("thisCityDon'tExist");
            Assert.AreEqual(p.objectRes.name,"Bordeaux","Error Api City");

        }
    }
}