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
    public partial class FormHello : Form
    {
        Timer timer = new Timer();
        public FormHello()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            Hide();
            formMain.Show();
            timer.Stop();
        }
    }
}
