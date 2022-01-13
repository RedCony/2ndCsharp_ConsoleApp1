using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inventory
    {
        private Item[] items;
        private int idx;
        


        public Inventory() { }
        ~Inventory() { }

        public Inventory(int narrycnt)
        {
            this.items = new Item[narrycnt];
        }
        public void AddItem(Item item)
        {
            Console.WriteLine("{0},{1}", idx, this.items.Length - 1);
            if(idx > this.items.Length - 1)
            {
                Console.WriteLine("가방이 가득 찼습니다.");
            }
            else
            {
                this.items[idx] = item;
                idx++;
            }
        }

        public int GetCount()
        {
            int count = 0;
            for (int n = 0; n < this.items.Length; n++)
            {
                if(this.items[n] != null)
                {
                    count++;
                }
            }
            return count;
        }



        
        //아이템 배열에서 찾고자 하는 아이템 이름과 같은 이름이 있다면 찾은 아이템을 반환 하는 메서드 
        public Item FindItemByName(string name)
        {
            Item foundItem = null;

            //[null] [null] [null] ...
            for (int i = 0; i < this.items.Length; i++) {
                Item item = this.items[i];
                if (item != null) {
                    //비교 
                    if (item.name == name) {
                        //찾았을때 어딘가에 저장 
                        foundItem = item;
                        break;
                    }
                }
            }

            //찾은아이템 오디찌...?
            return foundItem;
            

            //Item[] itemslist = null;

            //if (items == null)
            //{
            //    return null;
            //}

            //int nidx = 0;

            //for (int nn = 0; nn < items.Length; nn++)
            //{
            //    if (items[nn] == null)
            //    {
            //        continue;
            //    }
                    
            //    if (items[nn].name == name)
            //    {
            //        itemslist[nidx++] = items[nn];
            //    }
                    
            //}
            //if (nidx == 0)
            //{
            //    Console.WriteLine("{0}없습니다.", name);
            //}
                
            //return itemslist;
        }
      
    }

    
}
