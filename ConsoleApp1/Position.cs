using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Position
    {
        public float X {get;}
        public float Y {get;}

        //생성자 
        public Position(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() => $"({X}, {Y})";

        //public void Pos(float x,float y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}
    }
}
