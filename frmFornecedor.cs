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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void HabilitaEdicao()
        {
            id_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            ds_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            nm_contatoTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
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
            id_fornecedorTextBox.Enabled = true;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            ds_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            nm_contatoTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
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

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.cadastroDataSet.tbFornecedor);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.RemoveCurrent();
            tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validação do CNPJ:
            double dig1 = 0, dig2 = 0;

            if (cd_cnpjMaskedTextBox.Text.Length == 18)
            {
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
                dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;
                dig1 = dig1 % 11;

                if (dig1 == 0 || dig1 == 1)
                {
                    dig1 = 0;
                }

                else
                {
                    dig1 = 11 - dig1;
                }

                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
                dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;
                dig2 = dig2 % 11;

                if (dig2 == 0 || dig2 == 1)
                {
                    dig2 = 0;
                }

                else
                {
                    dig2 = 11 - dig2;
                }

                if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) == dig1.ToString()
                && cd_cnpjMaskedTextBox.Text.Substring(17, 1) == dig2.ToString())
                {
                    cd_cnpjMaskedTextBox.ForeColor = Color.Green;
                    cd_cnpjMaskedTextBox.BackColor = Color.LightGreen;
                    Validate();
                    tbFornecedorBindingSource.EndEdit();
                    tbFornecedorTableAdapter.Update(cadastroDataSet.tbFornecedor);
                    DesabilitaEdicao();
                }

                else
                {
                    cd_cnpjMaskedTextBox.ForeColor = Color.Red;
                    cd_cnpjMaskedTextBox.BackColor = Color.LightSalmon;
                    MessageBox.Show("CNPJ inválido!", "CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                cd_cnpjMaskedTextBox.ForeColor = Color.Red;
                cd_cnpjMaskedTextBox.BackColor = Color.LightSalmon;
                MessageBox.Show("Quantidade incorreta de dígitos!", "CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void nm_fornecedorTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.LightBlue;
        }

        private void nm_fornecedorTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.LightBlue;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;

            frmPesquisaFornecedor fpf = new frmPesquisaFornecedor();
            fpf.ShowDialog();

            cod = fpf.getCodigo();

            if (cod > 0)
            {
                reg = tbFornecedorBindingSource.Find("id_fornecedor", cod);
                tbFornecedorBindingSource.Position = reg;
            }
        }

        private void cd_ieMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cd_ieMaskedTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE FORNECEDOR" + (char)10 + (char)10;
            strDados += "Código: " + id_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "Nome: " + nm_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "Nome de contato: " + nm_contatoTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
