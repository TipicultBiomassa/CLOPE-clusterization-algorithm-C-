using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    class DictionaryItem 
    {
        //Не пригодился
        public string Key { get; set; }

        public int Value;

        public DictionaryItem(string key)
        {
            Key = key;
        }

        public override int GetHashCode() => Key.GetHashCode();

        public override string ToString() => Value.ToString();

        public void Increment() => Value++;

    }
}
