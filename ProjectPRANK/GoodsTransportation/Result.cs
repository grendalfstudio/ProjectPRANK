using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsTransportation
{
    public partial class Result : Form
    {
        private int[] _distances;

        public Result()
        {
            InitializeComponent();
        }

        public Result(int[] _dist)
        {
            InitializeComponent();
            _distances = _dist;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            dgridDistances.RowCount = 2;
            dgridDistances.ColumnCount = _distances.Length;
            dgridDistances.Rows[0].HeaderCell.Value = "Vertex";
            dgridDistances.Rows[1].HeaderCell.Value = "Distance from source";
            for (var i = 0; i < _distances.Length; i++)
            {
                dgridDistances.Rows[0].Cells[i].Value = i + 1;
                dgridDistances.Rows[1].Cells[i].Value = _distances[i];
            }
        }
    }
}