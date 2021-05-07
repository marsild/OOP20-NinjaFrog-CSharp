using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public interface ICollidable
    {
        void Collide();
        int Score { get; }
    }
}
