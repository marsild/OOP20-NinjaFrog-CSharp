namespace Frog
{
		public interface IFrogModel
		{
			/// <summary>
			/// define the frog.
			/// </summary>
			string DefineFrog();

		/// <returns> frog's state. </returns>
		FrogState State();

			/// <summary>
			/// the frog jump.
			/// </summary>
			void Jump();

			/// <param name="direction"> the direction; </param>
			void Move(float direction);

			/// <summary>
			/// add one life to the frog.
			/// </summary>
			void AddLife();

			/// <summary>
			/// remove one life from the frog.
			/// </summary>
			void RemoveLife();

			/// <summary>
			/// update the model .
			/// </summary>
			/// <param name="dt"> delta of time. </param>
			void Update(float dt);


		/// <summary>
		/// set the double jump frog.
		/// </summary>
		/// <param name="b"> true if the frog is double jumping. </param>
		bool DoubleJumping{ set; }

		}

	}