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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercício11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();    
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcelsius celsius = new frmcelsius();
            celsius.Show();
        }

        private void exercício13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcasa casa = new frmcasa();
            casa.Show();
        }
    }
}
