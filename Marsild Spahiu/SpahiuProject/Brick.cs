using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpahiuProject
{
    public sealed class Brick : ICollidable
    {
        private const int BRICK_SCORE = 25;
        private const int CELL_NOT_SET = -1;
        private const int DESTROYED_CELL = 988;
        private const int MillisecondsTimeout = 100;
        private bool destroyed;
        private readonly PlayScreen playScreen;
        private int destroyedTile;
        public Brick(PlayScreen screen)
        {
            destroyed = false;
            playScreen = screen;
            destroyedTile = CELL_NOT_SET;
        }
        public int Score
        {
            get
            {
                return BRICK_SCORE;
            }
        }

        public void Collide()
        {
            if(destroyedTile == CELL_NOT_SET)
            {
                destroyedTile = DESTROYED_CELL;
            }
            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(MillisecondsTimeout);
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                destroyed = true;
                Console.WriteLine("ciao");
            }).Start();
            playScreen.AddScore(this);
        }
        public bool Destroyed
        {
            get
            {
                return this.destroyed;
            }
        }
        public int Tile
        {
            get
            {
                return this.destroyedTile;
            }
        }

    }
}
