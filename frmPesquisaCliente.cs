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
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;

        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbClienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);
            }

            else
            {
                this.tbClienteTableAdapter.FillByNome(this.cadastroDataSet.tbCliente, "%" + txtNome.Text + "%");
            }
        }

        private void tbClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
