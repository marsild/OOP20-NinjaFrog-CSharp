using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpahiuProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void LevelTests()
        {
            ILevel levelOne = new LevelOne();
            ILevel levelTwo = new LevelTwo();
            Assert.AreEqual("level1.tmx", levelOne.Map);
            Assert.AreEqual("level2.tmx", levelTwo.Map);
        }
    }
}

