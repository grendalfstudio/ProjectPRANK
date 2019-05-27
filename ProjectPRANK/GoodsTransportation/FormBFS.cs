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
    public partial class FormBFS : Form
    {
        public FormBFS()
        {
            InitializeComponent();
        }
        public FormBFS(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }
    }
}
