using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasiniProject;
using System;
using System.Collections.Generic;
using System.Text;
namespace UnitTest
{
    [TestClass]
    public class EnemyTest
    {
        [TestMethod]
        public void EnemiesTest()
        {
            IEnemyModel model = new EnemyModelImpl();
            IEnemyView view = new EnemyViewImpl(model);
            Assert.AreEqual(3f, model.StateTime);
            Assert.AreEqual(false, model.Destroyed);
            Assert.AreEqual(false, model.SetToDestroy);
            Assert.AreEqual(150, model.Score);
            Assert.AreEqual(true, view.Killable);
            Assert.AreEqual(32f, view.X);
            Assert.AreEqual(32f, view.Y);
            model.Collide();
            Assert.AreEqual(true, model.SetToDestroy);
            Assert.AreEqual(0, model.StateTime);
            model.Update();
            Assert.AreEqual(true, model.Destroyed);
            Assert.AreEqual(false, model.SetToDestroy);
            view.Update();
            Assert.AreEqual(false, view.Killable);
            Assert.AreEqual(0, view.X);
            Assert.AreEqual(0, view.Y);
        }
    }
}
