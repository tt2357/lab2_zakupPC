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
        int cena;

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
                cena += 100;
            }
            else if (checkBox2.Checked)
            {
                cena += 130;
            }
            else if(checkBox3.Checked)
            {
                cena += 150;
            }

            //combo
            object index;
            index = comboBox1.SelectedItem;
            //Convert.ToInt32(index);

            if(index.Equals(0))
            {
                cena += 1000;
            }
            else if(index.Equals(1))
            {
                cena += 1500;
            }
            else if(index.Equals(2))
            {
                cena += 2000;
            }
            else if(index.Equals (3))
            {
                cena += 2200;
            }

            label3.Text=String.Format("{0:00}", cena);

        }
        public Form2()
        {
            InitializeComponent();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            //cena += getcena();
            //setcena(cena);
        }
    }
}
