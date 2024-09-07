using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt.Text = DateTime.Now.ToString("dd/MM/yyyy");
            hr.Text = DateTime.Now.ToString("HH:mm");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.ShowDialog();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelUsuario fru = new frmRelUsuario();
            fru.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelCliente frc = new frmRelCliente();
            frc.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelFornecedor frf = new frmRelFornecedor();
            frf.ShowDialog();
        }
    }
}
