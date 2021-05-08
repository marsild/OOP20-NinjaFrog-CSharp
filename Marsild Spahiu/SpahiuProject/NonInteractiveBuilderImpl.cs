using System;
using System.Collections.Generic;
using System.Text;

namespace SpahiuProject
{
    public sealed class NonInteractiveBuilderImpl : INonInteractiveBuilder
    {
		private const short GROUND = 1;
		private const short GROUND_OBJECT = 512;
		private const short FINISH = 4096;
		private object mapObject;
		private readonly PlayScreen screen;
		private short bit;

		public NonInteractiveBuilderImpl(PlayScreen screen)
		{
			this.screen = screen;
		}

		public INonInteractiveBuilder SelectObject(object Object)
		{
			this.mapObject = Object;
			return this;
		}

		public INonInteractiveBuilder ChooseCategoryBit(short b)
		{
			this.bit = b;
			return this;
		}

		public NonInteractiveObject Build()
		{
			if (this.mapObject == null)
			{
				throw new ArgumentNullException("Object can't be null.");
			}
			if (this.screen == null)
			{
				throw new ArgumentNullException("Screen can't be null.");
			}
			if (!(this.bit.Equals(GROUND) || this.bit.Equals(GROUND_OBJECT) || this.bit.Equals(FINISH)))
			{
				throw new ArgumentOutOfRangeException("Illegal category-bit input.");
			}
			return new NonInteractiveObject(this.screen, this.mapObject, this.bit);
		}

	}
}
