using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public sealed class NonInteractiveObject
	{
        public NonInteractiveObject(PlayScreen screen, object mapObj, short bit)
		{
			this.Screen = screen;
			this.Object = mapObj;
			this.Bit = bit;
		}

        public PlayScreen Screen { get; }
        public object Object { get; }
        public short Bit { get; }
    }

}
