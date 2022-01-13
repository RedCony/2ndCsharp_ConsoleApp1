using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mine
    {
        public Position position;
        public float Damage
        {
            get; set;
        }
       
        public Mine(Position pos, float damage)
        {
            this.position = pos;
            this.Damage = damage;

            Console.WriteLine("마인이 생성되었습니다 ({0},{1})", this.position.X, this.position.Y);
        }

        public float Explode()
        {
            Console.WriteLine("마인이 폭발 합니다.");
            return this.Damage;
        }
    }
        
    
}
