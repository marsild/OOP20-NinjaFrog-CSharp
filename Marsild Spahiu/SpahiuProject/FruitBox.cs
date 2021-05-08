using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public class FruitBox : ICollidable
    {
        private const int FRUIBOX_SCORE = 50;
        private const int CELL_NOT_SET = -1;
        private const int NON_INTERACTIVE_TILE = 998;
        private bool interactive;
        private readonly PlayScreen playScreen;
        private int tile;
        public FruitBox(PlayScreen screen)
        {
            this.interactive = true;
            this.playScreen = screen;
            this.tile = CELL_NOT_SET;
        }
        public int Score => FRUIBOX_SCORE;

        public void Collide()
        {
            if (this.tile == CELL_NOT_SET)
            {
                this.tile = NON_INTERACTIVE_TILE;
            }
            if (this.interactive)
            {
                this.interactive = false;
                this.playScreen.AddScore(this);
                this.playScreen.SpawnFruit();
            }
        }
        public bool Interactive
        {
            get
            {
                return this.interactive;
            }
        }
        public int Tile
        {
            get
            {
                return this.tile;
            }
        }
    }
}
