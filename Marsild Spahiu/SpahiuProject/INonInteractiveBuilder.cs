using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public interface INonInteractiveBuilder
    {
        public INonInteractiveBuilder SelectObject(object Object);
        public INonInteractiveBuilder ChooseCategoryBit(short b);
        public NonInteractiveObject Build();
    }
}
