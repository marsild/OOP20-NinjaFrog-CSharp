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
        private bool threadOn;
        private readonly PlayScreen playScreen;
        private int destroyedTile;
        public Brick(PlayScreen screen)
        {
            this.destroyed = false;
            this.playScreen = screen;
            this.threadOn = false;
            this.destroyedTile = CELL_NOT_SET;
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
            if(this.destroyedTile == CELL_NOT_SET)
            {
                this.destroyedTile = DESTROYED_CELL;
            }
            while (this.threadOn)
            {

            }
            if (!this.destroyed)
            {
                this.threadOn = true; ;
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
                    this.destroyed = true;
                    this.threadOn = false;
                }).Start();
                playScreen.AddScore(this);
            }
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
