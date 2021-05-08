using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public sealed class LevelOne : ILevel
    {
        private const string MAP_NAME = "level1.tmx";

        public string Map
        {
            get
            {
                return MAP_NAME;
            }
        }
    }
}
