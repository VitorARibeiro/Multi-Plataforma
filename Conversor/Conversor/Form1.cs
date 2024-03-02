using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "Metro";
                label2.Text = "Centimetros";
            }else if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "Metro";
                label2.Text = "Kilometros";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = "Kg";
                label2.Text = "Lb";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label1.Text = "Lb";
                label2.Text = "Kg";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1) {
            //Nao é possivel fazer nada
            }else if (comboBox1.SelectedIndex == 0) {
                double valor = double.Parse(textBox1.Text) * 100;
                textBox2.Text = valor.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double valor = double.Parse(textBox1.Text) / 100;
                textBox2.Text = valor.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double valor = double.Parse(textBox1.Text) * 2.20;
                textBox2.Text = valor.ToString();

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double valor = double.Parse(textBox1.Text) * 0.45;
                textBox2.Text = valor.ToString();
            }
        }
    }
}
