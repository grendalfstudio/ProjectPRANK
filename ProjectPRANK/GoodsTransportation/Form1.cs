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

namespace GoodsTransportation
{
    public partial class Form1 : Form
    {
        private int numberOfCities;
        private int[] numberOfPlaces;
        HashTable goods;  // Hash table
        private Goods[] sortedGoods;
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
            goods = new HashTable(100);
            goods.Add(current);
            dataGridViewGoods.RowCount = 10;
            foreach (DataGridViewRow row in dataGridViewGoods.Rows)
            {
                row.Cells[0] = 
            }
            // Hash table pushes the 'current'
            // dataGrid gets data from the hash table

        }

        private void ButtonSortName_Click(object sender, EventArgs e)// TODO
        {
            // sortedGoods gets data from the hash table
            Array.Sort(sortedGoods, NameComparison());
            dataGridViewGoods.DataSource = sortedGoods;
        }


        private void ButtonSortWeight_Click(object sender, EventArgs e)// TODO
        {
            // sortedGoods gets data from the hash table
            Array.Sort(sortedGoods, WeightComparison());
            dataGridViewGoods.DataSource = sortedGoods;
        }

        private void ButtonSortPrice_Click(object sender, EventArgs e)// TODO
        {
            // sortedGoods gets data from the hash table
            Array.Sort(sortedGoods, PriceComparison());
            dataGridViewGoods.DataSource = sortedGoods;
        }
        private Comparison<Goods> NameComparison()// TODO
        {
            
        }
        private Comparison<Goods> WeightComparison()// TODO
        {

        }
        private Comparison<Goods> PriceComparison()// TODO
        {

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
