using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    class Program
    {
        static void Main(string[] o)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            
            Console.OutputEncoding = Encoding.UTF8;
            double r = 7.6;
            // с 7.7 считает
            foreach(Cluster cluster_ in new Clope().Calculate(new DataImporter("./mushrooms.txt").read(), r))
            {
                Console.WriteLine("New cluster:");
                Console.WriteLine(cluster_.ToString());
            }
            watch.Stop();
            Console.WriteLine("_____________________");
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Прошло времени: " + elapsedMs/1000+ " Секунд");
        }
    }
}
