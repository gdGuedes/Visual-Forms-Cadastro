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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void HabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            cd_senhaTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void DesabilitaEdicao()
        {
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            cd_senhaTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.cadastroDataSet.tbUsuario);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.RemoveCurrent();
            tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarioBindingSource.EndEdit();
            tbUsuarioTableAdapter.Update(cadastroDataSet.tbUsuario);
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void nm_usuarioTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.LightBlue;
        }

        private void nm_usuarioTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.LightBlue;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;

            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();

            cod = fpu.getCodigo();

            if(cod > 0)
            {
                reg = tbUsuarioBindingSource.Find("id_usuario", cod);
                tbUsuarioBindingSource.Position = reg;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados += "Código: " + id_usuarioTextBox.Text + (char)10 + (char)10;
            strDados += "Nome: " + nm_usuarioTextBox.Text + (char)10 + (char)10;
            strDados += "Nível: " + sg_nivelTextBox.Text + (char)10 + (char)10;
            strDados += "Login: " + nm_loginTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
