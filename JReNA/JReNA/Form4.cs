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
    public partial class frmcasa : Form
    {
        public frmcasa()
        {
            InitializeComponent();
        }
        double AT;
        private void frmcasa_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double L, C, A;
            string name;

            L = Convert.ToDouble(txtLargura.Text);
            C = Convert.ToDouble(txtComprimento.Text);
            name = txtNome.Text;
            A = L * C;
            AT += A;

            var Continuar = MessageBox.Show("a area do comodo: " + name + " é de: " + A + "M²" + "\r\n" + "Deseja continuar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Continuar == DialogResult.Yes)
            {
                txtLargura.Clear();
                txtComprimento.Clear();
                txtNome.Clear();
                txtLargura.Focus();
            }

            else
            {
                MessageBox.Show("A area total do imovel é de: " + Convert.ToString(AT) + "M²", "Área Total" );
            }





        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComprimento.Clear();
            txtLargura.Clear();
            txtNome.Clear();
            txtComprimento.Clear();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();
            principal.Show();
        }
    }
}
