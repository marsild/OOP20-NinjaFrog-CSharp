using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasamentiProject
{
    public interface IFruitBuilder
    {
        IFruitBuilder SelectScreen(IPlayScreen screen);

        IFruitBuilder ChooseXPosition(float x);

        IFruitBuilder ChooseYPosition(float x);

        IFruitBuilder SelectFruitType(FruitTypeEnum.FruitType type);

        IFruitPowerUp Build();

    }
}
