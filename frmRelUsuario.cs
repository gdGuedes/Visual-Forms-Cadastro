﻿using System;
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
    public partial class frmRelUsuario : Form
    {
        public frmRelUsuario()
        {
            InitializeComponent();
        }

        private void frmRelUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'CadastroDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.CadastroDataSet.tbUsuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
