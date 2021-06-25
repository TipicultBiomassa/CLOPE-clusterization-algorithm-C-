using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    public class Transaction
    {
        private List<string> data = new List<string>();


        public Transaction(params string[] strings)
        {
            foreach (string s in strings)
            {
                data.Add(s);
            }
        }

        public List<string> getAllData()
        {
            return data;
        }

        public override string ToString()
        {
            return string.Join(", ", data);
        }



    }
}
