using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public static Form1 form1instance;
        public int cena;
        public int p_cena;
        public int p_cena_k;
        public Label l1;
        public Form1()
        {
            InitializeComponent();
            form1instance = this;
            l1 = label1;
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0:00}", cena);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
