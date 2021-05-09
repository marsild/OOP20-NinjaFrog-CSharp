using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiniProject
{
    public interface ICollidable
    {
        void Collide ();

        int Score { get; }
    }
}
