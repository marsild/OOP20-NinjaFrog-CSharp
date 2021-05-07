using Frog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    class FrogTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            FrogModelImpl frog = new FrogModelImpl();
            Assert.AreEqual("[FROG] created ", frog.DefineFrog());
            HandleInput input = new HandleInput();
            Assert.AreEqual("Standing", input.Input(1));
            Assert.AreEqual("Running left", input.Input(2));
            Assert.AreEqual("Running right", input.Input(3));
            Assert.AreEqual("jumping", input.Input(4));
            Assert.AreEqual("Command Error", input.Input(8));
        }

    }
}


