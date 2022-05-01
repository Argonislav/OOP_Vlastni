using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool sklopnaPazba = false;
            string nazev = textBox2.Text;
            int serioveCislo = Convert.ToInt32(textBox1.Text);
            Zbran nova = new Zbran(serioveCislo, nazev);
            MessageBox.Show(nova.ToString());
            if (checkBox1.Checked)
            {
                sklopnaPazba = true;
            }
            else sklopnaPazba = false;
            Samopal novy = new Samopal(serioveCislo, nazev, sklopnaPazba);
            MessageBox.Show(novy.ToString());
        }
    }
}
