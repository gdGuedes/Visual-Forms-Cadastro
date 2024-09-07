namespace ProjetoCadastro
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label ds_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label ds_emailLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbClienteTableAdapter();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.ds_numeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.ds_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableAdapterManager = new ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager();
            this.cd_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            ds_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(32, 26);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(63, 20);
            id_clienteLabel.TabIndex = 31;
            id_clienteLabel.Text = "Código:";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_clienteLabel.Location = new System.Drawing.Point(33, 65);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(55, 20);
            nm_clienteLabel.TabIndex = 33;
            nm_clienteLabel.Text = "Nome:";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(13, 106);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(82, 20);
            ds_enderecoLabel.TabIndex = 35;
            ds_enderecoLabel.Text = "Endereço:";
            // 
            // ds_numeroLabel
            // 
            ds_numeroLabel.AutoSize = true;
            ds_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_numeroLabel.Location = new System.Drawing.Point(25, 149);
            ds_numeroLabel.Name = "ds_numeroLabel";
            ds_numeroLabel.Size = new System.Drawing.Size(69, 20);
            ds_numeroLabel.TabIndex = 37;
            ds_numeroLabel.Text = "Número:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(39, 191);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_bairroLabel.TabIndex = 39;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(32, 234);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_cidadeLabel.TabIndex = 41;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Location = new System.Drawing.Point(516, 152);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(57, 20);
            ds_emailLabel.TabIndex = 51;
            ds_emailLabel.Text = "E-mail:";
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(504, 195);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(75, 20);
            ds_telefoneLabel.TabIndex = 53;
            ds_telefoneLabel.Text = "Telefone:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Location = new System.Drawing.Point(529, 67);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(44, 20);
            cd_cpfLabel.TabIndex = 54;
            cd_cpfLabel.Text = "CPF:";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_rgLabel.Location = new System.Drawing.Point(535, 110);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(38, 20);
            cd_rgLabel.TabIndex = 55;
            cd_rgLabel.Text = "RG:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(528, 26);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 56;
            cd_cepLabel.Text = "CEP:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(30, 277);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_estadoLabel.TabIndex = 57;
            sg_estadoLabel.Text = "Estado:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(730, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 63);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(574, 414);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 63);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(412, 414);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 63);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 63);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.Location = new System.Drawing.Point(69, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 63);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(730, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 63);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(574, 320);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 63);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(412, 320);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 63);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(240, 320);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(99, 63);
            this.btnProximo.TabIndex = 22;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(69, 320);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(99, 63);
            this.btnAnterior.TabIndex = 21;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_clienteTextBox.Location = new System.Drawing.Point(101, 23);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(99, 26);
            this.id_clienteTextBox.TabIndex = 32;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_clienteTextBox.Location = new System.Drawing.Point(101, 62);
            this.nm_clienteTextBox.MaxLength = 40;
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(410, 26);
            this.nm_clienteTextBox.TabIndex = 34;
            this.nm_clienteTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_clienteTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(101, 103);
            this.ds_enderecoTextBox.MaxLength = 40;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(410, 26);
            this.ds_enderecoTextBox.TabIndex = 36;
            this.ds_enderecoTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.ds_enderecoTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // ds_numeroTextBox
            // 
            this.ds_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_numero", true));
            this.ds_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_numeroTextBox.Location = new System.Drawing.Point(100, 146);
            this.ds_numeroTextBox.MaxLength = 6;
            this.ds_numeroTextBox.Name = "ds_numeroTextBox";
            this.ds_numeroTextBox.Size = new System.Drawing.Size(68, 26);
            this.ds_numeroTextBox.TabIndex = 38;
            this.ds_numeroTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.ds_numeroTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(100, 188);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(349, 26);
            this.nm_bairroTextBox.TabIndex = 40;
            this.nm_bairroTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_bairroTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(101, 231);
            this.nm_cidadeTextBox.MaxLength = 35;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(367, 26);
            this.nm_cidadeTextBox.TabIndex = 42;
            this.nm_cidadeTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.nm_cidadeTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_email", true));
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_emailTextBox.Location = new System.Drawing.Point(585, 149);
            this.ds_emailTextBox.MaxLength = 100;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(298, 26);
            this.ds_emailTextBox.TabIndex = 52;
            this.ds_emailTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.ds_emailTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_telefone", true));
            this.ds_telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(585, 192);
            this.ds_telefoneTextBox.MaxLength = 15;
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(233, 26);
            this.ds_telefoneTextBox.TabIndex = 54;
            this.ds_telefoneTextBox.Enter += new System.EventHandler(this.nm_clienteTextBox_Enter);
            this.ds_telefoneTextBox.Leave += new System.EventHandler(this.nm_clienteTextBox_Leave);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoCadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_cpfMaskedTextBox
            // 
            this.cd_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cpf", true));
            this.cd_cpfMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cpfMaskedTextBox.Location = new System.Drawing.Point(585, 64);
            this.cd_cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cd_cpfMaskedTextBox.Name = "cd_cpfMaskedTextBox";
            this.cd_cpfMaskedTextBox.Size = new System.Drawing.Size(123, 26);
            this.cd_cpfMaskedTextBox.TabIndex = 55;
            // 
            // cd_rgMaskedTextBox
            // 
            this.cd_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_rg", true));
            this.cd_rgMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_rgMaskedTextBox.Location = new System.Drawing.Point(585, 107);
            this.cd_rgMaskedTextBox.Mask = "00,000,000-0";
            this.cd_rgMaskedTextBox.Name = "cd_rgMaskedTextBox";
            this.cd_rgMaskedTextBox.Size = new System.Drawing.Size(108, 26);
            this.cd_rgMaskedTextBox.TabIndex = 56;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(585, 23);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(88, 26);
            this.cd_cepMaskedTextBox.TabIndex = 57;
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sg_estado", true));
            this.sg_estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_estadoComboBox.FormattingEnabled = true;
            this.sg_estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(101, 274);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(99, 28);
            this.sg_estadoComboBox.TabIndex = 58;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgMaskedTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfMaskedTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(ds_numeroLabel);
            this.Controls.Add(this.ds_numeroTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(this.ds_telefoneTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private CadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox ds_numeroTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.TextBox ds_telefoneTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private CadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox cd_cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_rgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
    }
}