using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpahiuProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class LevelTests
    {
        [TestMethod]
        public void LevelOneTest()
        {
            ILevel levelOne = new LevelOne();
            Assert.AreEqual("level1.tmx", levelOne.Map);
        }

        [TestMethod]
        public void LevelTwoTest()
        {
            ILevel levelTwo = new LevelTwo();
            Assert.AreEqual("level2.tmx", levelTwo.Map);
        }
    }
}

