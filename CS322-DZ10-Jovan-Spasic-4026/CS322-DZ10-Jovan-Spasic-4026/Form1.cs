using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ10_Jovan_Spasic_4026
{
    public partial class Form1 : Form
    {
        private ArrayList arr;
        private Random rand;
        public Form1()
        {
            InitializeComponent();
            this.arr = new ArrayList();
            rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                arr.Add(rand.Next(5));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(arr.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Input a number");
            }
            else
            {
                arr.Add(textBox1.Text);
                this.Form1_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                arr.RemoveAt(listBox1.SelectedIndex);
                this.Form1_Load(sender, e);
            }
        }
    }
}
