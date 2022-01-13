using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zealot
    {
        public Position position;
        public string name;
        public float damage;
        public float hp;
        public float maxHp;

        
        public Zealot(Position pos)
        {
            this.position = pos;
        }

        public void Init(string name, float maxHp, float damage)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = this.maxHp;
            this.damage = damage;
        }

        public void Move(Position movepos)
        {
            Console.WriteLine("{0}이(가) ({1},{2})에서 ({3},{4})으로 이동합니다", this.name, this.position.X, this.position.Y, movepos.X, movepos.Y);
            this.position =movepos;
        }

        public void Hit(float damage)
        {
            this.hp -= damage;
            Console.WriteLine("{0}만큼 피해를 입었습니다 남은 hp : {1}/{2}", this.damage, this.hp, this.maxHp);

            if (this.hp <= 0) {
                this.Die();
            }
        }

        public void Die() 
        {
            this.hp = 0;
            Console.WriteLine("죽었습니다... 꾸엑~~~~");
        }
    }
}
