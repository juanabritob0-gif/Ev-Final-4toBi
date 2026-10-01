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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Noemi" && TextContraseña.Text == "7")
            {
                this.Hide();
                Form1 app = new Form1();
                app.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorectos");
            }
        }
    }
}
