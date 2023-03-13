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
        public int cena;
        public Form1()
        {
            InitializeComponent();
        }
        public int getcena()
        {
           return this.cena; 
        }

        public void setcena(int cena) 
        {
            this.cena = cena;       
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
    }
}
