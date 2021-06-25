using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOP_TEST
{
    class Clope
    {
        private List<Cluster> Allclusters = new List<Cluster>();


        public List<Cluster> Calculate(List<Transaction> transactions, double r)
        {
            foreach (Transaction transaction in transactions)
            {
                Cluster NewCluster = new Cluster(transaction);
                Allclusters.Add(NewCluster);
                double profitFromNewCluster = GetProfit(Allclusters, r);
                double profitMax = profitFromNewCluster;
                Allclusters.Remove(NewCluster);
                foreach (Cluster cluster in Allclusters)
                {
                    cluster.AddTransaction(transaction);
                    double profit = GetProfit(Allclusters, r);
                    if (profitMax <= profit)
                    {
                        profitMax = profit;
                    }
                    else
                    {
                        cluster.RemoveTransaction(transaction);
                    }
                }
                if (profitMax == profitFromNewCluster)
                {
                    Allclusters.Add(NewCluster);    
                }
            }
            return Allclusters;
        }


        private double GetProfit(List<Cluster> clusters, double repulsion)
        {
            double profit1 = 0;
            double profit2 = 0;
            foreach (Cluster cluster in clusters)
            {
                profit1 += cluster.GetHeight() * cluster.GetWidth() / Math.Pow(cluster.GetWidth(), repulsion) * cluster.NumberOfTransactions();
                profit2 += cluster.NumberOfTransactions();
            }
            return profit1 / profit2;

        }
    }
}
