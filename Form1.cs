using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX5GROUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sum = (int.Parse(textBox1.Text) * 12) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text);
           
            Group1 gp1 = new Group1();
            Program.money = (int.Parse(textBox1.Text) * 12) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text);
            

            //Group1 G = new Group1();
            gp1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group1 G = new Group1();
            G.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Group2 G2 = new Group2();
            G2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Group3 G3 = new Group3();
            G3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Group4 G4 = new Group4();
            G4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Group5 G5 = new Group5();
            G5.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           Program.name = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Group1 G1 = new Group1();
           
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
