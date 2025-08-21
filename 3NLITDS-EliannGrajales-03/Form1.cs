using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLITDS_EliannGrajales_03
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa valores para el calculo");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresa valores para el limpiar");
        }  
    }
}
