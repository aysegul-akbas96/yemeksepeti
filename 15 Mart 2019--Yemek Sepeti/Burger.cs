using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Mart_2019__Yemek_Sepeti
{
    public partial class Burger : Form
    {
        public Burger()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible =false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Burgerler")
            {
                groupBox2.Visible = true;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Location=new Point(24,83);
            }
          if(comboBox2.SelectedItem.ToString()== "ÇıtırLezzetler")
            {
                groupBox4.Visible = true;
                groupBox2.Visible = false;
                groupBox6.Visible = false;
                groupBox5.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Location = new Point(24, 83);
            }
           if (comboBox2.SelectedItem.ToString() == "Soslar")
            {
                groupBox6.Visible = true;
                groupBox5.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox2.Visible = false;
                groupBox6.Location = new Point(24, 83);
            }
            if (comboBox2.SelectedItem.ToString() == "Tatlılar")
            {
                groupBox5.Visible = true;
                groupBox4.Visible = false;
                groupBox6.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = false;
                groupBox5.Location = new Point(24, 83);
            }
           if (comboBox2.SelectedItem.ToString() == "KidsMenüler")
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox3.Location = new Point(24, 83);

            }

          

        }

        private void Burger_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "evet")
            {
                groupBox7.Visible = true;
                groupBox7.Location = new Point(24, 83);
            }
            if (comboBox2.SelectedItem.ToString() == "hayır")
            {
                MessageBox.Show("İçecek seçmediniz..");
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
