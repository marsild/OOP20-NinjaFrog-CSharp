using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiniProject
{
   public class EnemyViewImpl : IEnemyView
    { 
        private bool isKillable;
        private float x;
        private float y;
        private IEnemyModel model;
        public EnemyViewImpl(IEnemyModel model)
        {
            this.model = model;
            this.isKillable = true;
            this.x = 32f;
            this.y = 32f;
        }
        public void Update()
        {
            if(model.Destroyed == true)
            {
                this.isKillable = false;
                this.x = 0;
                this.y = 0;
            }
        }
    
        public bool Killable
        {
        get
            {
               return this.isKillable;
            }

        }

        public float X
        {
            get
            {
                return this.x;
            }
        }

        public float Y
        {
            get
            {
                return this.y;
            }
        }
    }
}
