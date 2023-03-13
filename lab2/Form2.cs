using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public static Form2 form2instance;
        public int cena;
        public Form2()
        {
            InitializeComponent();
            form2instance = this;
        }

        //private void Form2_load(object sender, EventArgs e)
        //{
        //    cena = new cena;
        //}
        public void update_ceny()
        {
            cena = 0;
            //radio
            if (radioButton1.Checked)
            {
                cena += 100;
            }
            else if(radioButton2.Checked)
            {
                cena += 150;
            }
            else if(radioButton3.Checked)
            {
                cena += 200;
            }

            //check
            if(checkBox1.Checked)
            {
                cena += 110;
            }
            if (checkBox2.Checked)
            {
                cena += 130;
            }
            if(checkBox3.Checked)
            {
                cena += 150;
            }
            if (checkBox4.Checked)
            {
                cena += 200;
            }

            //combo
            //Convert.ToInt32(index);

            if (comboBox1.SelectedIndex.Equals(0))
            {
                cena += 1000;
            }
            else if(comboBox1.SelectedIndex.Equals(1))
            {
                cena += 1500;
            }
            else if(comboBox1.SelectedIndex.Equals(2))
            {
                cena += 2000;
            }
            else if(comboBox1.SelectedIndex.Equals (3))
            {
                cena += 2200;
            }

            label3.Text=String.Format("{0:00}", cena);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            update_ceny();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.form1instance.cena -= Form1.form1instance.p_cena_k;
            Form1.form1instance.cena += cena;
            Form1.form1instance.p_cena_k = cena;
            Form1.form1instance.l1.Text = String.Format("{0:00}", Form1.form1instance.cena);
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
