using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    public partial class Group5 : Form
    {
        public double sum5;
        public Group5()
        {
            InitializeComponent();
        }

        private void Group5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum5 = 0;
            sum5 = sum5 + Convert.ToInt32(numericUpDown7.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown1.Value);
            double a = Convert.ToInt32(numericUpDown2.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown3.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown5.Value);
            double b = Convert.ToInt32(numericUpDown6.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown9.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown10.Value);
            sum5 = sum5 + Convert.ToInt32(numericUpDown8.Value);
            double tmp = a + b;
            if (tmp > 20000)
            {
                tmp = 20000;
            }
            sum5 = sum5 + tmp;
            Total total = new Total();
            Program.sum5 = sum5;
            this.Hide();
            total.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group4 G4 = new Group4();
            this.Hide();
            G4.ShowDialog();
        }
    }
}
