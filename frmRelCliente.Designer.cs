namespace ProjetoCadastro
{
    partial class frmRelCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CadastroDataSet = new ProjetoCadastro.CadastroDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoCadastro.CadastroDataSetTableAdapters.tbClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoCadastro.RelatorioCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // CadastroDataSet
            // 
            this.CadastroDataSet.DataSetName = "CadastroDataSet";
            this.CadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.CadastroDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelCliente";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.frmRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private CadastroDataSet CadastroDataSet;
        private CadastroDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
    }
}