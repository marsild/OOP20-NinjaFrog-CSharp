using System;
using CasamentiProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CasamentiTest
{
    [TestClass]
    public class FruitPowerUpTest
    {
        [TestMethod]
        public void MelonTest()
        {   
            float x = 100;
            float y = 100;
            FruitTypeEnum.FruitType type = FruitTypeEnum.FruitType.MELON;
            FruitPowerUpImpl fruit = new FruitPowerUpImpl(null, x, y, type);
            Assert.AreEqual( x, fruit.getX());
            Assert.AreEqual(y, fruit.getY());
        }

       
        
    }
}
