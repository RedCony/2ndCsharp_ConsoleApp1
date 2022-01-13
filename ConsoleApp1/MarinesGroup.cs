using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MarinesGroup
    {
        Marine[] marines;
        private int idx;

        public MarinesGroup() { }
        ~MarinesGroup() { }

        public MarinesGroup(int narrycnt)
        {
            this.marines = new Marine[narrycnt];
        }

        public void AddMarine(Marine marine)
        {
            Console.WriteLine("{0},{1}", idx, this.marines.Length - 1);
            if (idx > this.marines.Length - 1)
            {
                Console.WriteLine("마린이 최대입니다.");
            }
            else
            {
                this.marines[idx] = marine;
                idx++;
            }
        }
        public int GetMarineCount()
        {
            int count = 0;
            for (int n = 0; n < this.marines.Length; n++)
            {
                if (this.marines[n] != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
