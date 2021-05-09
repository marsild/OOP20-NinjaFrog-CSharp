using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiniProject
{ 

	public interface IEnemyModel 
	{

		void Update();

		bool SetToDestroy { get; }

		bool Destroyed { get; }

		float StateTime { get; }



	}
}

