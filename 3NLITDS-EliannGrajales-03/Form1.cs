using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            if (txtcelcius.Text != "" || txtfarenheit.Text != "" || txtkelvin.Text != "")
            {
                MessageBox.Show("calculando");

                if (!string.IsNullOrEmpty(txtcelcius.Text))
                {
                    //celcius a faregeint
                    float ce2 = float.Parse(txtcelcius.Text);
                    float fa2 = (ce2 * 9f / 5f) + 32;
                    txtfarenheit.Text = fa2.ToString();


                    // celcius a kelvin
                    float ke = ce2 + 273;
                    txtkelvin.Text = ke.ToString();
                }
                else if (!string.IsNullOrEmpty(txtfarenheit.Text))
                {
                    //farenheit a celcius
                    float fa = float.Parse(txtfarenheit.Text);
                    float ca = (fa - 32) * 5.0f / 9.0f;
                    txtcelcius.Text = ca.ToString();

                    // farenheit a kelvin
                    float ke = ca + 273;
                    txtkelvin.Text = ke.ToString();
                } else if (string.IsNullOrEmpty(txtkelvin.Text))
                {
                    // Kelvin a Celsius
                    float ke = float.Parse(txtkelvin.Text);
                    float ca = ke - 273.15f;
                    txtcelcius.Text = ca.ToString();

                    // Kelvin a Fahrenheit
                    float fa = (ca * 9f / 5f) + 32;
                    txtfarenheit.Text = fa.ToString();
                }

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
               txtfarenheit.Text = "";
               txtkelvin.Text = "";
               txtcelcius.Text = "";
                //txtfarenheit.Clear();
                //txtkelvin.Clear();
                //txtcelcius.Clear();
            

        }

        private void txtfarenheit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
