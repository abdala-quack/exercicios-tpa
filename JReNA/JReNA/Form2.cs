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
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void frmtabuada_Load(object sender, EventArgs e)
        {

        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabuada.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double num, I, R;

            num = Convert.ToDouble(txtnum.Text);


            I = 1;
            while(I <= 10)
            {
                R = num * I;
                txttabuada.AppendText($"{num} X {I} ={R}\r\n");
                I++;
            }
       
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {


                  double num, I, R;

            num = Convert.ToDouble(txtnum.Text); 

            I = 1;

            do
            {
                R = num * I;
                txttabuada.AppendText($"{num} X {I} ={R}\r\n");
                I++;
            }
            while (I <= 10);
            
         }

        private void btnpara_Click(object sender, EventArgs e)
        {

            double num, I, R;
            num = Convert.ToDouble(txtnum.Text);

            for (I = 0; I<=10; I++) {

                R = num * I;
                txttabuada.AppendText($"{num} X {I} ={R}\r\n");
            }
        }
    }
}
