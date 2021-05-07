using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public class PlayScreen
    {
        public PlayScreen()
        {
            this.FruitSpawned = false;
            this.Score = 0;
        }
        public void AddScore(ICollidable entity)
        {
            Score += entity.Score;
        }
        public void SpawnFruit()
        {
            this.FruitSpawned = true;
        }
        public int Score { get; private set; }
        public bool FruitSpawned { get; private set; }
    }
}
