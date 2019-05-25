using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTransportation
{
    class QuickSort
    {
        public enum Property
        {
            Weight, Name, Price
        }
        public void Sort(List<Goods> good, int low, int high, Property property)
        {
            if (good.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (low >= high)
            {
                Console.WriteLine(1);
            }
            else
            {
                int middle = low + (high - low) / 2;
                Goods pivot = good.ElementAt(middle);
                int i = low;
                int j = high;

                while (i <= j)
                {
                    while (Compare(good[i], pivot, property) == -1 && i<=j)// Compare(a, b, property)
                    {
                        
                        ++i;
                    }

                    while (Compare(good[j], pivot, property) == 1 && j>=0)
                    {
                        --j;
                    }

                    if (i <= j)
                    {
                        Goods temp = good[i];
                        good[i] = good[j];
                        good[j] = temp;
                        ++i;
                        --j;
                    }
                }

                if (low < j)
                {
                    this.Sort(good, low, j, property);
                }

                if (high > i)
                {
                    this.Sort(good, i, high, property);
                }

            }
        }

        private int Compare(Goods a, Goods b, Property property)
        {
            switch (property)
            {
                case Property.Weight:
                    return (a.weight > b.weight ? 1 : -1);
                case Property.Name:
                    return String.Compare(a.name, b.name);
                case Property.Price:
                    return (a.price > b.price ? 1 : -1);
                default:
                    return 0;
            }
        }
    }
}
