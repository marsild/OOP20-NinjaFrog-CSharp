using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpahiuProject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnitTest
{
    [TestClass]
    public class InteractiveObjectTests
    {
        [TestMethod]
        public void BrickTest()
        {
            PlayScreen screen = new PlayScreen();
            Brick brick = new Brick(screen);
            int screenScore = screen.Score;
            Assert.AreEqual(0, screenScore);
            Assert.AreEqual(-1, brick.Tile);
            Assert.IsFalse(brick.Destroyed);
            brick.Collide();
            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(110);
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                Assert.IsTrue(brick.Destroyed);
            }).Start();
            Assert.AreEqual(988, brick.Tile);
            screenScore += brick.Score;
            Assert.AreEqual(screenScore, screen.Score);
            brick.Collide();
            Assert.AreEqual(screenScore, screen.Score);
        }

        [TestMethod]
        public void FruitBoxTest()
        {
            PlayScreen screen = new PlayScreen();
            FruitBox fruitBox = new FruitBox(screen);
            int screenScore = screen.Score;
            Assert.AreEqual(0, screenScore);
            Assert.AreEqual(-1, fruitBox.Tile);
            Assert.IsTrue(fruitBox.Interactive);
            Assert.IsFalse(screen.FruitSpawned);
            fruitBox.Collide();
            Assert.IsFalse(fruitBox.Interactive);
            Assert.AreEqual(998, fruitBox.Tile);
            screenScore += fruitBox.Score;
            Assert.AreEqual(screenScore, screen.Score);
            fruitBox.Collide();
            Assert.AreEqual(screenScore, screen.Score);
        }
    }
}
