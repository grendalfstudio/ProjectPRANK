using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTAProgect;
using static GoodsTransportation.QuickSort;

namespace GoodsTransportation
{
    public partial class FormMain : Form
    {
        int goodsCount = 0;
        private int _numberOfCities;
        private int[] numberOfPlaces;
        private int[,] _roadMap;
        private int _srcVertex;
        private float[,] cityPlan;
        HashTable goods;  // Hash table
        private List <Goods> sortedGoods;
        QuickSort sort;
        public FormMain()
        {
            InitializeComponent();            
        }

        private void ButtonAcceptCity_Click(object sender, EventArgs e)
        {
            _numberOfCities = int.Parse(textBoxNumberOfCities.Text);
            _srcVertex = int.Parse(tbSrc.Text);
            dataGridViewCities.RowCount = _numberOfCities;
            dataGridViewCities.ColumnCount = _numberOfCities;
            _roadMap = new int[_numberOfCities, _numberOfCities];
            buttonAcceptCity.Enabled = false;
        }

        private void btnSetRoads_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _numberOfCities; i++)
            {
                for (int j = 0; j < _numberOfCities; j++)
                {
                    _roadMap[i,j] = Convert.ToInt32(dataGridViewCities[i, j].Value);
                }
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            GFG gfg = new GFG();
            int[] distances = new int[_numberOfCities];
            distances = gfg.GetSolution(_roadMap, _srcVertex);;
            Result result = new Result(distances);
            result.Show();
        }

        private void ButtonAcceptPlace_Click(object sender, EventArgs e)
        {
            CreateCity();

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

        private void CreateCity()
        {
            //numberOfPlaces[(int)numericUpDownCity.Value] = int.Parse(textBoxNumberOfPlaces.Text);
            for (int i = 0; i < int.Parse(textBoxNumberOfPlaces.Text); i++)
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                {
                    column.ReadOnly = false;
                    column.Width = 22;
                    column.CellTemplate = new DataGridViewCheckBoxCell();
                }

                dataGridViewPlaces.Columns.Insert(i, column);
            }
            dataGridViewPlaces.RowCount = int.Parse(textBoxNumberOfPlaces.Text) + 1;
            dataGridViewPlaces.AllowUserToAddRows = false;
            //dataGridViewPlaces.ColumnCount = int.Parse(textBoxNumberOfPlaces.Text); 

            for (int i = 0; i < dataGridViewPlaces.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewPlaces.ColumnCount; j++)
                {
                    dataGridViewPlaces.Columns[j].Name = j.ToString();
                    dataGridViewPlaces.Rows[i].HeaderCell.Value = string.Format(i.ToString(), "0");
                    dataGridViewPlaces[j, i].Value = false;
                }
            }
            //foreach (DataGridViewColumn coll in dataGridViewPlaces.Columns)
            //{
            //    coll.ReadOnly = false;
            //    coll.Width = 22;
            //    coll.CellTemplate = new DataGridViewCheckBoxCell(false);
            //}
        }

        private void ReadCity()
        {
            cityPlan = new float[dataGridViewPlaces.ColumnCount, dataGridViewPlaces.RowCount];
            for (int i = 0; i < dataGridViewPlaces.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewPlaces.ColumnCount; j++)
                {
                    if (dataGridViewPlaces[j, i].Value.Equals(true))
                    {
                        cityPlan[i, j] = 1;
                    }
                    else
                    {
                        cityPlan[i, j] = 0;
                    }
                }
            }
        }

        private void btn_bfs_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dataGridViewPlaces[1, 1].Value.ToString();
            ReadCity();
            BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch(dataGridViewPlaces.RowCount, cityPlan);
            breadthFirstSearch.bfs();
            //textBox1.Text = cityPlan[0, 0].ToString();
            textBox1.Text = breadthFirstSearch.bfs_search;
        }

        private void btnSetSrc_Click(object sender, EventArgs e)
        {
            _srcVertex = int.Parse(tbSrc.Text);
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
