using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public class PlayScreen
    {
        public PlayScreen()
        {
            Score = 0;
        }
        public void AddScore(ICollidable entity)
        {
            Score += entity.Score;
        }
        public int Score { get; private set; }
    }
}
