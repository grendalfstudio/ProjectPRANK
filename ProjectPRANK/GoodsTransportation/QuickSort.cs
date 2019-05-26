using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTransportation
{
    internal class QuickSort
    {
        public enum Property
        {
            Weight,
            Name,
            Price
        }

        public void Sort(List<Goods> goods, int left, int right, Property property)
        {
            var i = left;
            var j = right;
            var middle = goods[(left + right) / 2];
            do
            {
                while (Compare(goods[i], middle, property) == 1) i++;
                while (Compare(goods[j], middle, property) == -1) j--;
                if (i <= j)
                {
                    var temp = goods[i];
                    goods[i] = goods[j];
                    goods[j] = temp;
                    ++i;
                    --j;
                }
            } while (j > i);

            if (j > left) Sort(goods, left, j, property);
            if (i < right) Sort(goods, i, right, property);
        }

        private int Compare(Goods a, Goods b, Property property)
        {
            switch (property)
            {
                case Property.Weight:
                    if (a.weight < b.weight) return 1;
                    else if (a.weight > b.weight) return -1;
                    else return 0;
                case Property.Name:
                    return string.Compare(b.name, a.name);
                case Property.Price:
                    if (a.price < b.price) return 1;
                    else if (a.price > b.price) return -1;
                    else return 0;
                default:
                    return 0;
            }
        }
    }
}