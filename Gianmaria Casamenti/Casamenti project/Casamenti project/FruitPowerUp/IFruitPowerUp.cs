using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casamenti_project.FruitPowerUp
{
	/// <summary>
	/// Definition of FruitPowerUp interface.
	/// </summary>
	public interface IFruitPowerUp
	{
		/// <summary>
		/// Method that draw FruitPowerUp object on the screen.
		/// </summary>
		void Draw();

		/// <summary>
		/// Method that update FruitPowerUP object every frame.
		/// </summary>
		/// <param name="dt"> delta time. </param>
		void Update(float dt);

		/// <summary>
		/// Method that reverse velocity's value.
		/// </summary>
		void ReverseVelocity();

		/// <summary>
		/// Method to be called when a collision with the main character occurs.
		/// </summary>
		void Collide();
	}

}
