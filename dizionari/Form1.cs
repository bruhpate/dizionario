using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizionari
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> noncista = new Dictionary<string, decimal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noncista[textBox1.Text] = Convert.ToDecimal(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noncista.Remove(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string noncista2 = null;
            foreach(KeyValuePair<string,decimal> s in noncista)
            {
                noncista2 += "Key: " + Convert.ToString(s.Key) + "\tValue: " + Convert.ToString(s.Value) + "\n";
            }
            MessageBox.Show(noncista2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal noncista2 = 0;
            foreach (KeyValuePair<string, decimal> s in noncista)
            {
                noncista2 += s.Value;
            }
            MessageBox.Show(Convert.ToString(noncista2));
        }
    }
}
