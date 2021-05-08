using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpahiuProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class NonInteractiveTests
    {
        private const short GROUND = 1;
        private const short GROUND_OBJECT = 512;
        private const short FINISH = 4096;
        [TestMethod]
        public void BuilderTest()
        {
            object Object = new object();
            PlayScreen screen = new PlayScreen();
            INonInteractiveBuilder builder = new NonInteractiveBuilderImpl(screen);
            NonInteractiveObject ground = builder.SelectObject(Object).ChooseCategoryBit(GROUND).Build();
            NonInteractiveObject groundObject = builder.SelectObject(Object).ChooseCategoryBit(GROUND_OBJECT).Build();
            NonInteractiveObject finish = builder.SelectObject(Object).ChooseCategoryBit(FINISH).Build();
            Assert.AreEqual(GROUND, ground.Bit);
            Assert.AreEqual(GROUND_OBJECT, groundObject.Bit);
            Assert.AreEqual(FINISH, finish.Bit);
            Assert.AreSame(Object, ground.Object);
            Assert.AreSame(Object, groundObject.Object);
            Assert.AreSame(Object, finish.Object);
            Assert.AreSame(screen, ground.Screen);
            Assert.AreSame(screen, groundObject.Screen);
            Assert.AreSame(screen, finish.Screen);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Screen can't be null.")]
        public void Exception1Test()
        {
            object Object = new object();
            INonInteractiveBuilder builder = new NonInteractiveBuilderImpl(null);
            builder.SelectObject(Object).ChooseCategoryBit(GROUND).Build();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Screen can't be null.")]
        public void Exception2Test()
        {
            PlayScreen screen = new PlayScreen();
            INonInteractiveBuilder builder = new NonInteractiveBuilderImpl(screen);
            builder.SelectObject(null).ChooseCategoryBit(GROUND).Build();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Illegal category-bit input.")]
        public void Exception3Test()
        {
            object Object = new object();
            PlayScreen screen = new PlayScreen();
            INonInteractiveBuilder builder = new NonInteractiveBuilderImpl(screen);
            builder.SelectObject(Object).ChooseCategoryBit(777).Build();
        }
    }
}
