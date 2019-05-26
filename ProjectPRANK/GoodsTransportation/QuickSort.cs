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
                int middle = low + (high - low) / 2;// TODO
                Goods pivot = good.ElementAt(middle);
                int i = low;
                int j = high;

                while (i <= j)
                {
                  
                    while (i <= j)
                    {              
                        if (Compare(good[i], pivot, property) != -1)
                            break;
                        ++i;
                    }                    

                    while (j>=0)
                    {
                        if (Compare(good[j], pivot, property) != 1)
                            break;
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
        public void Sort1(List<Goods> goods, int left, int right, Property property)
        {
            int i = left;
            int j = right;
            Goods middle = goods[(left + right) / 2];
            do
            {
                while (Compare1(goods[i], middle, property) == 1) i++;
                while (Compare1(goods[j], middle, property) == -1) j--;
                if (i <= j)
                {
                    Goods temp = goods[i];
                    goods[i] = goods[j];
                    goods[j] = temp;
                    ++i;
                    --j;
                }
            }
            while (j > i);
            if (j > left) Sort1(goods, left, j, property);
            if (i < right) Sort1(goods, i, right, property);
        }

        private int Compare(Goods a, Goods b, Property property)
        {
            switch (property)
            {
                case Property.Weight:
                    return (a.weight < b.weight ? 1 : -1);
                case Property.Name:
                    return String.Compare(a.name, b.name);
                case Property.Price:
                    return (a.price < b.price ? 1 : -1);
                default:
                    return 0;
            }
        }
        private int Compare1(Goods a, Goods b, Property property)
        {
            switch (property)
            {
                case Property.Weight:
                    if (a.weight < b.weight) return 1;
                    else if (a.weight < b.weight) return -1;
                    else return 0;
                case Property.Name:
                    return String.Compare(a.name, b.name);
                case Property.Price:
                    if (a.price < b.price) return 1;
                    else if (a.price < b.price) return -1;
                    else return 0;
                default:
                    return 0;
            }
        }
    }
}
