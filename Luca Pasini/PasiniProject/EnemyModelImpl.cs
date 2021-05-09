using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiniProject
{




    public class EnemyModelImpl : ICollidable, IEnemyModel
    {
        private float stateTime;
        private bool destroyed;
        private bool setToDestroy;
        private const int ENEMY_SCORE = 150;
        public EnemyModelImpl()
        {
            this.stateTime = 3f;
            this.destroyed = false;
            this.setToDestroy = false;
        }
        public void Update()
        {
            if (setToDestroy == true)
            {
            this.destroyed = true;
            this.setToDestroy = false;
            }
        }

        public bool SetToDestroy
        {
            get
            {
                return this.setToDestroy;
            }
        }
        public bool Destroyed
        {
            get
            {
                return this.destroyed;
            }
        }

        public float StateTime
        {
            get
            {
                return this.stateTime;
            }
        }

        public int Score => ENEMY_SCORE;

        public void Collide()
        {
            if(this.destroyed == false)
            {
                this.setToDestroy = true;
                this.stateTime = 0;
            }
        }

    }
    
}
