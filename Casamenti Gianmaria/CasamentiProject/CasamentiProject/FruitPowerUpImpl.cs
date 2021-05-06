using System;

namespace CasamentiProject
{
    public class FruitPowerUpImpl : IFruitPowerUp
    {
        private IPlayScreen screen;
        private float x;
        private float y;
        private FruitTypeEnum.FruitType type;

        public FruitPowerUpImpl(IPlayScreen screen, float x, float y, FruitTypeEnum.FruitType type)
        {
            this.screen = screen;
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void print()
        {
            System.Console.WriteLine(screen + " " + x + " " + y + " " + type);
        }

        public FruitTypeEnum.FruitType GetTypeEnum()
        {
            return type;
        }

        public float getY()
        {
            return y;
        }

        public float getX()
        {
            return x;
        }

        public void Collide()
        {
            throw new System.NotImplementedException();
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }

        public void ReverseVelocity()
        {
            throw new System.NotImplementedException();
        }

        public void Update(float dt)
        {
            throw new System.NotImplementedException();
        }
    }
}