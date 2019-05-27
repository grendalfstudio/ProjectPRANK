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
        private int goodsCount = 0;
        private int[] numberOfPlaces;

        private int[,] _roadMap;
        private int _srcVertex;
        private int _numberOfCities;
        private int _row;
        private int _cell;
        private int _rowPlaces;
        private int _cellPlaces;
        private float[,] cityPlan;
        private HashTable goods;
        private List<Goods> sortedGoods;
        private QuickSort sort;

        public FormMain()
        {
            InitializeComponent();
            goods = new HashTable(100);
            sort = new QuickSort();
        }

        private void ButtonAcceptCity_Click(object sender, EventArgs e)
        {
            try
            {
                _numberOfCities = int.Parse(textBoxNumberOfCities.Text);
                _srcVertex = int.Parse(tbSrc.Text) - 1;
                if (_srcVertex < 0 || _srcVertex > _numberOfCities - 1)
                    throw new ArgumentOutOfRangeException("Start city num must be less than or equal to number of cities ");
                dataGridViewCities.RowCount = _numberOfCities;
                dataGridViewCities.ColumnCount = _numberOfCities;
                _roadMap = new int[_numberOfCities, _numberOfCities];

                for (var i = 0; i < _numberOfCities; i++)
                {
                    for (var j = 0; j < _numberOfCities; j++)
                    {
                        if (i == j)
                        {
                            dataGridViewCities[i, j].Value = 0;
                            dataGridViewCities[i, j].ReadOnly = true;
                        }
                    }
                }

                buttonAcceptCity.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetRoads_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < _numberOfCities; i++)
            {
                for (var j = 0; j < _numberOfCities; j++)
                {
                    _roadMap[i, j] = Convert.ToInt32(dataGridViewCities[i, j].Value);
                }
            }
            btnRes.Enabled = true;
            MessageBox.Show("Setted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            var gfg = new GFG();
            var distances = new int[_numberOfCities];
            distances = gfg.GetSolution(_roadMap, _srcVertex);
            ;
            var result = new Result(distances);
            result.Show();
        }

        private void ButtonAcceptPlace_Click(object sender, EventArgs e)
        {
            CreateCity();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var current = new Goods(textBoxName.Text, int.Parse(textBoxWeight.Text), int.Parse(textBoxPrice.Text));
                goods.Add(current);
                goodsCount++;
                textBoxName.Clear();
                textBoxWeight.Clear();
                textBoxPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSortName_Click(object sender, EventArgs e)
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count - 1, Property.Name);
            Output(sortedGoods);
        }


        private void ButtonSortWeight_Click(object sender, EventArgs e)
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count - 1, Property.Weight);
            Output(sortedGoods);
        }

        private void ButtonSortPrice_Click(object sender, EventArgs e)
        {
            sortedGoods = goods.GetAll();
            sort.Sort(sortedGoods, 0, sortedGoods.Count - 1, Property.Price);
            Output(sortedGoods);
        }

        private void btnShowGoods_Click(object sender, EventArgs e)
        {
            dataGridViewGoods.RowCount = goodsCount;
            var listGoods = new List<Goods>();
            listGoods = goods.GetAll();
            Output(listGoods);
        }

        private void Output(List<Goods> goods)
        {
            var i = 0;
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
            try
            {
                for (var i = 0; i < int.Parse(textBoxNumberOfPlaces.Text); i++)
                {
                    var column = new DataGridViewCheckBoxColumn();
                    {
                        column.ReadOnly = false;
                        column.Width = 22;
                        column.CellTemplate = new DataGridViewCheckBoxCell();
                    }

                    dataGridViewPlaces.Columns.Insert(i, column);
                }

                dataGridViewPlaces.RowCount = int.Parse(textBoxNumberOfPlaces.Text) + 1;
                dataGridViewPlaces.AllowUserToAddRows = false;

                for (var i = 0; i < dataGridViewPlaces.RowCount; i++)
                {
                    for (var j = 0; j < dataGridViewPlaces.ColumnCount; j++)
                    {
                        dataGridViewPlaces.Columns[j].Name = j.ToString();
                        dataGridViewPlaces.Rows[i].HeaderCell.Value = string.Format(i.ToString(), "0");
                        dataGridViewPlaces[j, i].Value = false;

                        if (i == j)
                        {
                            dataGridViewPlaces[i, j].ReadOnly = true;
                        }
                    }
                }

                buttonAcceptPlace.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadCity()
        {
            cityPlan = new float[dataGridViewPlaces.ColumnCount, dataGridViewPlaces.RowCount];
            for (var i = 0; i < dataGridViewPlaces.RowCount; i++)
            for (var j = 0; j < dataGridViewPlaces.ColumnCount; j++)
                if (dataGridViewPlaces[j, i].Value.Equals(true))
                    cityPlan[i, j] = 1;
                else
                    cityPlan[i, j] = 0;
        }

        private void btn_bfs_Click(object sender, EventArgs e)
        {
            ReadCity();
            var breadthFirstSearch = new BreadthFirstSearch(dataGridViewPlaces.RowCount, cityPlan);
            breadthFirstSearch.bfs();
            FormBFS formBFS = new FormBFS(breadthFirstSearch.bfs_search);
            formBFS.Show();
        }

        private void dataGridViewCities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _row = dataGridViewCities.SelectedCells[0].RowIndex;
            _cell = dataGridViewCities.SelectedCells[0].ColumnIndex;
        }

        private void dataGridViewCities_CurrentCellChanged(object sender, EventArgs e)
        {
            dataGridViewCities[_row, _cell].Value = dataGridViewCities[_cell, _row].Value;
        }

        private void dataGridViewPlaces_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPlaces[_rowPlaces, _cellPlaces].Value = dataGridViewPlaces[_cellPlaces, _rowPlaces].Value;
        }

        private void dataGridViewPlaces_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _rowPlaces = dataGridViewPlaces.SelectedCells[0].RowIndex;
            _cellPlaces = dataGridViewPlaces.SelectedCells[0].ColumnIndex;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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