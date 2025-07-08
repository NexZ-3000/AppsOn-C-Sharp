using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodCounter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count1 = tb1.Text;
            string count2 = tb2.Text;
            int count3 = int.Parse(count2);
            count3++;
            string count4 = count3.ToString();
            tb3.Text = count4;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
