using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasamentiProject
{
    public class FruitBuilderImpl : IFruitBuilder
    {
        private IPlayScreen screen;
        private float x;
        private float y;
        private FruitTypeEnum.FruitType type;

        public static FruitBuilderImpl newBuilder()
        {
            return new FruitBuilderImpl();
        }
        public IFruitPowerUp Build()
        {
            return new FruitPowerUpImpl(this.screen, this.x, this.y, this.type);
        }

        public IFruitBuilder ChooseXPosition(float x)
        {
            this.x = x;
            return this;

        }

        public IFruitBuilder ChooseYPosition(float x)
        {
            this.y = y;
            return this;

        }

        public IFruitBuilder SelectFruitType(FruitTypeEnum.FruitType type)
        {
            this.type = type;
            return this;
        }

        public IFruitBuilder SelectScreen(IPlayScreen screen)
        {
            this.screen = screen;
            return this;
        }
    }
}
