using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiniProject
{
	public interface IEnemyView
	{
		void Update();

		bool Killable { get; }

		float X { get; }


		float Y { get; }

	}

}
