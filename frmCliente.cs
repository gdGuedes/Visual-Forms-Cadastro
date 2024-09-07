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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void HabilitaEdicao()
        {
            id_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            ds_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
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
            id_clienteTextBox.Enabled = true;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            ds_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.cadastroDataSet.tbCliente);
            DesabilitaEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.RemoveCurrent();
            tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validação do CPF:
            double dig1 = 0, dig2 = 0;

            if(cd_cpfMaskedTextBox.Text.Length == 14)
            {
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
                dig1 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
                dig1 = dig1 % 11;

                if(dig1 <= 1)
                {
                    dig1 = 0;
                }

                else
                {
                    dig1 = 11 - dig1;
                }

                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
                dig2 += double.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
                dig2 = dig2 % 11;

                if(dig2 <= 1)
                {
                    dig2 = 0;
                }

                else
                {
                    dig2 = 11 - dig2;
                }

                if(cd_cpfMaskedTextBox.Text.Substring(12, 1) == dig1.ToString() && cd_cpfMaskedTextBox.Text.Substring(13, 1) == dig2.ToString())
                {
                    cd_cpfMaskedTextBox.ForeColor = Color.Green;
                    cd_cpfMaskedTextBox.BackColor = Color.LightGreen;
                    Validate();
                    tbClienteBindingSource.EndEdit();
                    tbClienteTableAdapter.Update(cadastroDataSet.tbCliente);
                    DesabilitaEdicao();
                }

                else
                {
                    cd_cpfMaskedTextBox.ForeColor = Color.Red;
                    cd_cpfMaskedTextBox.BackColor = Color.LightSalmon;
                    MessageBox.Show("CPF inválido!","CPF",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            else
            {
                cd_cpfMaskedTextBox.ForeColor = Color.Red;
                cd_cpfMaskedTextBox.BackColor = Color.LightSalmon;
                MessageBox.Show("Quantidade incorreta de dígitos!","CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.CancelEdit();
            DesabilitaEdicao();
        }

        private void nm_clienteTextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).BackColor = Color.LightBlue;
        }

        private void nm_clienteTextBox_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;

            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();

            cod = fpc.getCodigo();

            if (cod > 0)
            {
                reg = tbClienteBindingSource.Find("id_cliente", cod);
                tbClienteBindingSource.Position = reg;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE ClIENTE" + (char)10 + (char)10;
            strDados += "Código: " + id_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "Nome: " + nm_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "Email: " + ds_emailTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
