using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_chicharronera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validamos entradas
            if (txtA.Text== "")
            {
                MessageBox.Show("Debe de ingresar un valor en a","Error");
                txtA.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txtA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de ingresar un valor numerico en a", "Error");
                txtA.Text = "";
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Debe de ingresar un valor en b", "Error");
                txtB.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(txtB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de ingresar un valor numerico en b", "Error");
                txtB.Text = "";
                txtB.Focus();
                return;
            }
            if (txtC.Text == "")
            {
                MessageBox.Show("Debe de ingresar un valor en c", "Error");
                txtC.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txtC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe de ingresar un valor numerico en c", "Error");
                txtC.Text = "";
                txtC.Focus();
                return;
            }

            //Hacemos los cálculos
            double x1, x2,D;
            //Ecuacioncuadratica(a, b, c, D, out x1, out x2);
            D = (b * b) - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
            if (D == 0)
            {
                x1 = -b;
                txtX1.Text = x1.ToString();
                MessageBox.Show("Ecuacion con solo un resultado (la raíz es igual a cero)", caption: "Alerta");
                txtX2.Text = "";
            }
            if (D < 0)
            {
                MessageBox.Show("No tiene solución en números reales", caption: "Alerta");
                txtX1.Text = "";
                txtX2.Text = "";
            }
            
            
        }

       /* private void Ecuacioncuadratica(double a, double b, double c, double D, out double x1, out double x2)
        {
            
            

           /* x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
        }*/

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtA.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
