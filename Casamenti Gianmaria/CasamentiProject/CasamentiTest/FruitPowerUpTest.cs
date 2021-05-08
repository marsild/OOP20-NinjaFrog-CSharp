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
            Assert.AreEqual(type, fruit.GetTypeEnum());
        }

        [TestMethod]
        public void CherryTest()
        {
            float x = 150;
            float y = 150;
            FruitTypeEnum.FruitType type = FruitTypeEnum.FruitType.CHERRY;
            FruitPowerUpImpl fruit = new FruitPowerUpImpl(null, x, y, type);
            Assert.AreEqual(x, fruit.getX());
            Assert.AreEqual(y, fruit.getY());
            Assert.AreEqual(type, fruit.GetTypeEnum());
        }

        [TestMethod]
        public void OrangeTest()
        {
            float x = 170;
            float y = 170;
            FruitTypeEnum.FruitType type = FruitTypeEnum.FruitType.ORANGE;
            FruitPowerUpImpl fruit = new FruitPowerUpImpl(null, x, y, type);
            Assert.AreEqual(x, fruit.getX());
            Assert.AreEqual(y, fruit.getY());
            Assert.AreEqual(type, fruit.GetTypeEnum());
        }

    }
}
