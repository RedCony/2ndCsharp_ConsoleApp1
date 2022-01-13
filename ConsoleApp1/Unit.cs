using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Unit
    {

		eUnitType eUnitType;
		public string mName
		{
			get;
			private set;
		}

		public Unit(string name)
		{
			this.mName = name;
		}


		~Unit() { }

		public virtual void Attack(Unit target)
		{

		}
		public virtual void Hit(Unit sender)
		{

		}
	}
}
