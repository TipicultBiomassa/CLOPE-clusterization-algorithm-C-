using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    class MyDictionary : IEnumerable
    {

        // Не пригодилось
        private List<DictionaryItem> Items = new List<DictionaryItem>();

        public List<string> Keys = new List<string>();


        public int Count => Items.Count;

        public List<int> GetValues()
        {
            var Values = new List<int>();
            foreach (var item in Items)
            {
                Values.Add(item.Value);
            }
            return Values;
        }

        public MyDictionary()
        {
        }

        public void Add(DictionaryItem item)
        {
            if(Search(item.Key) == true)
            {
                //Если такого не найдено, то мы добавляем item и Value=1
                Keys.Add(item.Key);
                Items.Add(item);
                item.Value = 1;
            }
            else if (Search(item.Key) == false)
            {
                //Если найдено, то мы добавляем ему Value\
                item.Value++;
                return;
            }
                
        }
       
        public void ShowKeys ()
        {
            foreach (string item in Keys)
            {
                Console.WriteLine(item);
            }

        }

        public bool Search(string key)
        {
           foreach (string atribute in Keys)
            {
                if (key == atribute) return true;
            }
            return false;
        }



        public bool CointainsKey(DictionaryItem item)
        {
            if (Keys.Contains(item.Key))
            {
                return true;
            }
            else return false;
        }   

        public IEnumerator GetEnumerator ()
        {
            return Items.GetEnumerator();
        }

    }
}
