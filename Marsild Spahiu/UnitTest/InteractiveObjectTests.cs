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
            Assert.AreEqual(screenScore + brick.Score, screen.Score);
        }
    }
}
