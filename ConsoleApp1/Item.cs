using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        public string name;
        //private Item[] items;

        public Item() { }

        ~Item() { }

        public Item(string name)
        {
            this.name = name;
        }
        /*
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }
        */

    }
        
}
