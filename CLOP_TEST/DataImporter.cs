using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CLOP_TEST
{
    class DataImporter
    {
        private String Path;


        public DataImporter(String path)
        {
            Path = path;
        }

        public List<Transaction> read()
        {
            List<Transaction> data = new List<Transaction>();
            StreamReader sr = new StreamReader(Path);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                //data.Add(new Transaction(line.Split(',')));
                data.Add(new Transaction(line.Split(',')));
            }
            Console.WriteLine(data.ToString());
            return data;
        }


    }
}
