using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Marine:Unit
    {
        public Marine(string name) : base(name)
        {

        }
        override public void Attack(Unit target)
        {
            Console.WriteLine("{0}이 {1}을 공격합니다.", this.mName, target.mName);
            target.Hit(this);
        }

        public override void Hit(Unit sender)
        {
            Console.WriteLine("{0}가 {1}부터 공격을 받았습니다. (녹색 피를 흘립니다.)", this.mName, sender.mName);
        }
    }
}
