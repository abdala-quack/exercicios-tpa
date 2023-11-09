using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JReNA
{
    public partial class frmcelsius : Form
    {
        public frmcelsius()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtfahrenheit.Clear();
            txtcelsius.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double C, F, I;

            C = Convert.ToDouble(txtcelsius.Text);

            F = (C * 1.8) + 32;

            I = 10;

            while (I <= 100)
            {

                txtfahrenheit.Text += "Os graus somados 10 somados são: " + (F + I) + "°F" + Environment.NewLine;
                I = I + 10;


            }
            
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double C, F, I;

            C = Convert.ToDouble(txtcelsius.Text);

            F = (C * 1.8) + 32;

            I = 10;

            do
            {

                txtfahrenheit.Text += "Os graus somados 10 somados são: " + (F + I) + "°F" + Environment.NewLine;
                I = I + 10;
                

            }
            while (I <= 100);
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double C, F;
            int I;
            C = Convert.ToDouble(txtcelsius.Text);

            F = (C * 1.8) + 32;

            for (I = 10; I <= 100; I+=10)
            {

                txtfahrenheit.Text += "Os graus somados 10 são: " + (F + I) + " °F" + Environment.NewLine;
                

            }
        }

        private void frmcelsius_Load(object sender, EventArgs e)
        {

        }
    }
}
