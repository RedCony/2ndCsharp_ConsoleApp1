using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {





            /*
            Marine marine1 = new Marine("임꺽정");
            Marine marine2 = new Marine("임꺽정");
            Marine marine3 = new Marine("장길산");

            MarinesGroup group = new MarinesGroup(5);
            group.AddMarine(marine1);
           // Console.WriteLine(marine1);
            
            group.AddMarine(marine2);
            group.AddMarine(marine3);

            int count = group.GetMarineCount();
            Console.WriteLine(count);
            */



            /*
            
            //Item item = new Item("장검");

            Inventory inventory = new Inventory(6);
            //inventory.AddItem(item);
            inventory.AddItem(new Item("장검"));
            inventory.AddItem(new Item("단검"));
            inventory.AddItem(new Item("활"));
            inventory.AddItem(new Item("창"));
            inventory.AddItem(new Item("도끼"));
            inventory.AddItem(new Item("지팡이"));
            int count = inventory.GetCount();
            Console.WriteLine(count);
           

            string searchItemName = "단검";
            Item item = inventory.FindItemByName(searchItemName);
            if (item != null)
            {
                Console.WriteLine("{0}을 찾았습니다.", searchItemName);
            }
            else
            {
                Console.WriteLine("{0}은 없습니다.", searchItemName);
            }
            */
            /*
            Console.WriteLine(item.name);

            Item[] inventory = new Item[5];
            inventory[0] = item;
            
            for (int n = 0; n < inventory.Length; n++)
            {
                Item item1 = inventory[n];
                if (item1 != null)
                {
                    Console.WriteLine(item1.name);
                }
                else
                {
                    Console.WriteLine("-->");
                }
                
            }
            
            foreach(Item item2 in inventory)
            {
                if(item2 != null)
                {
                    Console.WriteLine(item2.name);
                }
                else
                {
                    Console.WriteLine("-->");
                }
            }
            

           
            Vulture vulture = new Vulture ("벌쳐1");
          
            vulture.Init(new Position(2,3),45);

            vulture.Move(new Position(0, 0));

            vulture.InstallMine();
            



            //Console.WriteLine("Hellow World");

                       Marine marine = new Marine("홍길동");
                        Zerg zerg = new Zerg("임꺽정");
                        marine.Attack(zerg);
            */
        }
    }
}
