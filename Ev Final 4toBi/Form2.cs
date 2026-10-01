using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int producto = num1 * num2;
            MessageBox.Show("el resultado del producto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("el resultado de la suma es" + suma);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextVar1.Text);
            int n2 = int.Parse(TextVar2.Text);
            int n3 = 1;
            int potencia = 1;

            while (n3 != n2)
            {
                potencia = potencia * n1;
                n3 = n3 + 1;
                MessageBox.Show("el resultado de la potencia es" + potencia);
            }
        }

        private void BtnDIvision_Click(object sender, EventArgs e)
        {
            float num1 = int.Parse(TextVar1.Text);
            float num2 = int.Parse(TextVar2.Text);

            if (num2 > 0) ;
            {
                float division = num1 / num2;

            }
            else
            {
                MessageBox.Show("la division es indefinida");
            }

        }
    }
}