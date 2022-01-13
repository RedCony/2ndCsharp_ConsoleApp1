using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UnitGroup
    {
        Unit[] units;
        eUnitType eUnitType;
        
        public UnitGroup() { }
        ~UnitGroup() { }

        public int GetUnitCount() 
        {
            int count = 0;
            for (int n = 0; n < this.units.Length; n++)
            {
                if (this.units[n] != null)
                {
                    count++;
                }
            }
            return count;
        }
    
        public void AddUnit(Unit unit)
        {

        }
        public Unit[] GetMarines()
        {

        }

        public Unit[] GetMedics()
        {

        }

        public void PrintAllUnits()
        {
         Console.WriteLine("타입 : {0} 이름 : {1} ",eUnitType,base. );
        }
    }
}
