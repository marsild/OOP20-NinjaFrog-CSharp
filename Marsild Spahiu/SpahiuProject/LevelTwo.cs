using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public sealed class LevelTwo : ILevel
    {
        private const string MAP_NAME = "level2.tmx";

        public string Map
        {
            get
            {
                return MAP_NAME;
            }
        }
    }
}
