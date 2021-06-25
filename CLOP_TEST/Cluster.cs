using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    class Cluster
    {
        private List<Transaction> cluster_transactions = new List<Transaction>();

        public Cluster(Transaction transaction)
        {
            cluster_transactions.Add(transaction);
        }

        public void AddTransaction(Transaction transaction) => cluster_transactions.Add(transaction);

        public void RemoveTransaction(Transaction transaction) => cluster_transactions.Remove(transaction);

        public double GetWidth() => GetClusterDictionary().Count;

        public double NumberOfTransactions() => cluster_transactions.Count();

        public override string ToString() => "\n" + "{" + string.Join(", ", cluster_transactions) + "}";

        public double GetHeight()
        {
            double clusterHeight = 0;
            foreach (int height in GetClusterDictionary().Values)
            {
                if (clusterHeight < height)
                {
                    clusterHeight = height;
                }
            }
            return clusterHeight;
        }

        public Dictionary<string, int> GetClusterDictionary()
        {
            //var clusterMap = new MyDictionary();
            Dictionary<string, int> clusterMap = new Dictionary<string, int>();

            foreach (Transaction transaction in cluster_transactions)
            {
                foreach (string Vasya in transaction.getAllData())
                {
                    if (clusterMap.ContainsKey(Vasya))
                    {
                        clusterMap[Vasya] += 1;
                    }
                    else
                    {
                        clusterMap.Add(Vasya, 1);
                    }
                    //clusterMap.Add(new DictionaryItem(Vasya));
                    //Console.WriteLine(Vasya);
                }

                

            }
            return clusterMap;
        }
            
    }

}
