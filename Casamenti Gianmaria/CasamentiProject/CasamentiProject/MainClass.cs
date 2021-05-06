using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasamentiProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            FruitTypeEnum.FruitType type = FruitTypeEnum.FruitType.CHERRY;
            FruitPowerUpImpl fruit = new FruitPowerUpImpl(null, 1, 1, type);
            fruit.print();
            System.Console.ReadLine();
        }
    }
}
