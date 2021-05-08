using System;

namespace Frog
{

		public class FrogModelImpl : IFrogModel
		{
			private static readonly float WORLD_TIME_STEP = 1f / 60f;
			private const float ACC_DEF = 0.25f;
			private const int X_VELOCITY = 2;
			private const float VEL_MAX = 2.5f;

			private int life = 1;
			int yPos = 0;
			private bool b;
			private bool isDoubleJumpActive;
			private bool isDoubleJumping;
			private FrogState currentState;
			private FrogState prevState;
			private float linearVelocity;
			private float accumulator;
			private float delta;

		

        /// <summary>
        /// public constructor of the frog model.
        /// </summary>
        /// <param name="screen"> the playscreen. </param>
        public FrogModelImpl()
		{	
			this.prevState = FrogState.Standing;
			this.currentState = FrogState.Standing;
			this.isDoubleJumpActive = false;
			this.isDoubleJumping = false;
			DefineFrog();

		}

        public string DefineFrog()
        {
			System.Console.WriteLine("[FROG] created");
			return "[FROG] created";
        }

        public void Jump()
        {
			if (this.currentState == FrogState.DoubleJumping)
			{
				System.Console.WriteLine("The frog is already jumping");
			}
			else if (this.currentState != FrogState.Jumping && this.currentState != FrogState.Falling)
			{
				System.Console.WriteLine("The frog is doublejumping");
			}
			else if (DoubleJumpActive() && !isDoubleJumping)
			{
				isDoubleJumping = true;
				if (linearVelocity <= 0)
				{
					if (this.currentState != FrogState.Falling && this.prevState != FrogState.Falling)
					{
						System.Console.WriteLine("The frog is jumping");
					}
				}
				else
				{
					System.Console.WriteLine("The frog is already jumping");
				}
			}

		}

        private bool DoubleJumpActive()
        {
			return this.isDoubleJumpActive;
		}

		public void Move(float direction)
        {
			this.accumulator += Math.Min(this.delta, ACC_DEF);
			if (this.accumulator >= WORLD_TIME_STEP)
			{
				this.accumulator -= WORLD_TIME_STEP;
				if (direction > 0)
				{
					if (linearVelocity <= X_VELOCITY)
					{
						System.Console.WriteLine("Moving right");
					}
				}
				else
				{
					if (linearVelocity >= -X_VELOCITY)
					{
						System.Console.WriteLine("Moving left");
					}
				}
			}

		}
		public bool DoubleJumping
        {
			set {
				this.isDoubleJumping = b;
			}
			
        }

        public void AddLife()
        {
			this.life += 1;
        }

        public void RemoveLife()
        {
			this.life -= 1;
			if (this.life == 0)
			{
				System.Console.WriteLine("The frog is dead");
			}

		}
		public FrogState State()
		{
			
				if ((linearVelocity > 0 || linearVelocity < 0 && prevState == FrogState.DoubleJumping) && this.isDoubleJumping)
				{
					this.currentState = FrogState.DoubleJumping;
					return this.currentState;
				}
				else if ((linearVelocity > 0 || linearVelocity < 0 && prevState == FrogState.Jumping) && !this.isDoubleJumping)
				{
					this.currentState = FrogState.Jumping;
					return this.currentState;
				}
				else if (linearVelocity < 0)
				{
					this.currentState = FrogState.Falling;
					return this.currentState;
				}
				else if (linearVelocity != 0)
				{
					this.currentState = FrogState.Running;
					return this.currentState;
				}
				else
				{
					this.currentState = FrogState.Standing;
					return this.currentState;
				}

		}

		public void Update(float dt)
        {
			this.delta = dt;
			if (linearVelocity < -VEL_MAX)
			{
				linearVelocity = -VEL_MAX;
			}
            
            if (yPos < 0)
			{
				if (this.life > 0)
				{
					this.DefineFrog();
				}
				else
				{
					System.Console.WriteLine("GameOver");
				}
			}

		}
	}

    internal class Vector2
    {
        protected float v1;
        protected float v2;

        public Vector2(float v1, float v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}

