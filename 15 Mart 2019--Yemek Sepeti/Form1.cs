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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void burgerKingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burger gec = new Burger();
            gec.Show();
            this.Hide();
        }
    }
}
