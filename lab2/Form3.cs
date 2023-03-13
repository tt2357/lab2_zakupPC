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
    public partial class Form3 : Form
    {
        int cena;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
 
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cena = 0;
            if(listBox1.SelectedIndex.Equals(0))
            {
                cena += 900;
            }
            else if(listBox1.SelectedIndex.Equals(1))
            {
                cena += 3000;
            }
            else if (listBox1.SelectedIndex.Equals(2))
            {
                cena += 2000;
            }
            else if (listBox1.SelectedIndex.Equals(3))
            {
                cena += 200;
            }
            label1.Text = String.Format("{0:00}", cena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.form1instance.cena -= Form1.form1instance.p_cena;
            Form1.form1instance.cena += cena;
            Form1.form1instance.p_cena = cena;
            Form1.form1instance.l1.Text = String.Format("{0:00}", Form1.form1instance.cena);
            Close();
        }
    }
}
