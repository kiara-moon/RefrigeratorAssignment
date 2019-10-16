using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Refrigerator
    {
        public double maxWeight;
        
        public List<int> items = new List<int> { };

        public List<double> weights = new List<double> { };

        

        public Refrigerator(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        //public int SetItemNo(int item)
        //{
        //    items.Add(item);
        //    return item;

        //}

        //public double SetWeight(double weight)
        //{
        //    weights.Add(weight);
        //    return weight;

        //}

        
        

        public int item { set; get; }
        public double weight { set; get; }


        public void Add(int item, double weight)
        {

            items.Add(this.item);
            weights.Add(this.weight);
        }

        public double GetCurrentWeight()
        {
            double CurrentWeight = 0.0;

            for (int i = 0; i < items.Count(); i++)
            {
                CurrentWeight += items[i] * weights[i];

            }
            return CurrentWeight;
        }

        public double GetRemainingWeight()
        {
            double RemainingWeight = this.maxWeight - GetCurrentWeight();

            return RemainingWeight;
        }



        //public double SetCurrentWeight(double currentWeight)
        //{
        //    currentWeight=
        //}








    }
}
