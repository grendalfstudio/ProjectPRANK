using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTAProgect;
using static GoodsTransportation.QuickSort;

namespace GoodsTransportation
{
    public partial class Form1 : Form
    {
        int goodsCount = 0;
        private int numberOfCities;
        private int[] numberOfPlaces;
        HashTable goods;  // Hash table
        private List <Goods> sortedGoods;
        QuickSort sort;
        public Form1()
        {
            InitializeComponent();
            numberOfCities = 0;
            for (int i = 0; i < numberOfCities; i++)
            {
                numberOfPlaces[i] = 0;
            }
        }

        private void ButtonAcceptCity_Click(object sender, EventArgs e)
        {
            numberOfCities = int.Parse(textBoxNumberOfCities.Text);
        }

        private void ButtonAcceptPlace_Click(object sender, EventArgs e)
        {
            numberOfPlaces[(int)numericUpDownCity.Value] = int.Parse(textBoxNumberOfPlaces.Text);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)// TODO
        {
            Goods current = new Goods(textBoxName.Text, int.Parse(textBoxWeight.Text), int.Parse(textBoxPrice.Text));
            goods.Add(current);
            goodsCount++;
            textBoxName.Clear();
            textBoxWeight.Clear();
            textBoxPrice.Clear();
            // Hash table pushes the 'current'
            // dataGrid gets data from the hash table

        }

        private void ButtonSortName_Click(object sender, EventArgs e)// TODO
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count-1, Property.Name);
            Output(sortedGoods);
            //    // sortedGoods gets data from the hash table
            //    Array.Sort(sortedGoods, NameComparison());
            //    dataGridViewGoods.DataSource = sortedGoods;
        }


        private void ButtonSortWeight_Click(object sender, EventArgs e)// TODO
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count - 1, Property.Weight);
            Output(sortedGoods);
        //    // sortedGoods gets data from the hash table
        //    Array.Sort(sortedGoods, WeightComparison());
        //    dataGridViewGoods.DataSource = sortedGoods;
        }

        private void ButtonSortPrice_Click(object sender, EventArgs e)// TODO
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count - 1, Property.Price);
            Output(sortedGoods);
            //    // sortedGoods gets data from the hash table
            //    Array.Sort(sortedGoods, PriceComparison());
            //    dataGridViewGoods.DataSource = sortedGoods;
        }
        //private Comparison<Goods> NameComparison()// TODO
        //{

        //}
        //private Comparison<Goods> WeightComparison()// TODO
        //{

        //}
        //private Comparison<Goods> PriceComparison()// TODO
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            goods = new HashTable(100);
            sort = new QuickSort();
            
            //List<Goods> listGoods = new List<Goods>();
            //listGoods = goods.GetAll();
            //foreach (Goods good in listGoods)
            //{
            //    Console.WriteLine(good);
            //}
        }

        private void btnShowGoods_Click(object sender, EventArgs e)
        {
            dataGridViewGoods.RowCount = goodsCount;
            List<Goods> listGoods = new List<Goods>();
            listGoods = goods.GetAll();
            Output(listGoods);
        }

        private void Output(List<Goods> goods)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridViewGoods.Rows)
            {
                row.Cells[0].Value = goods.ElementAt(i).name;
                row.Cells[1].Value = goods.ElementAt(i).weight;
                row.Cells[2].Value = goods.ElementAt(i).price;
                i++;
            }
        }
    }

    /// <summary>
    /// Struct of a good that has parameters name, weight and price
    /// </summary>
    public struct Goods
    {
        public string name;
        public int weight;
        public int price;
        public Goods(string name, int weight, int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }
    }
}
