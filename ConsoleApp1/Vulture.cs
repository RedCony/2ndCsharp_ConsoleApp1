using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vulture
    {
         int hp;
         float damage;
         string name;
         Position position;
         List<Mine> mines=new List<Mine>();
         int mineCapacity = 3;

        public Vulture(string name)
        {
            this.name = name;
            Console.WriteLine("{0}이 생성되었습니다.",name);
        }

        /*
        public  Vulture (string name,int na,float fb)
        {
            this.name = name;
            this.hp = na;
            this.damage = fb;
        }
        */

        public void Init(Position pos,float damage)
        {
            this.position = pos;
            this.damage = damage;
            Console.WriteLine("벌쳐가 생성({0},{1}) 되었습니다.",this.position.X,this.position.Y);
          
            for (int n = 0; n < 3; n++)
            {
                this.mines.Add(new Mine(this.position, 45));
            }

        }

        public void Move(Position movepos)
        {
            Console.WriteLine("벌쳐가 ({0},{1})에서 ({2},{3})로 이동합니다.", this.position.X, this.position.Y, movepos.X, movepos.Y);
            this.position = movepos;
        }

        public void Attack(Zealot zealot)
        {
            zealot.Hit(this.damage);
        }
        public void Destroy()
        {
            this.hp = 0;
            Console.WriteLine("벌쳐가 파괴되었습니다.");
        }
        public Mine InstallMine()
        {
              if (this.mines.Count > 0)
            {
                Mine oldMine = this.mines.First();
                Mine mine = new Mine(oldMine.position, oldMine.Damage);
                this.mines.Remove(oldMine);
                
                Console.WriteLine("마인을 ({0},{1})에 매설합니다, 마인: {2}/{3}", mine.position.X, mine.position.Y, this.mines.Count, this.mineCapacity);
                return mine;
            }

            Console.WriteLine("마인이 없습니다");
            return null;
        }
       
    }
}
