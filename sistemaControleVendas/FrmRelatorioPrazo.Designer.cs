namespace sistemaControleVendas
{
    partial class FrmRelatorioPrazo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TabelaPrazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetParcelas = new sistemaControleVendas.DataSetParcelas();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.TabelaPrazoTableAdapter = new sistemaControleVendas.DataSetParcelasTableAdapters.TabelaPrazoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPrazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParcelas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaPrazoBindingSource
            // 
            this.TabelaPrazoBindingSource.DataMember = "TabelaPrazo";
            this.TabelaPrazoBindingSource.DataSource = this.DataSetParcelas;
            // 
            // DataSetParcelas
            // 
            this.DataSetParcelas.DataSetName = "DataSetParcelas";
            this.DataSetParcelas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 662);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TabelaPrazoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.RelatorioPrazoPagamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 609);
            this.reportViewer1.TabIndex = 3;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Coral;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(-1, -1);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 56);
            this.panelCabecalho.TabIndex = 2;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Coral;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(757, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 61;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // TabelaPrazoTableAdapter
            // 
            this.TabelaPrazoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioPrazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Prazo";
            this.Load += new System.EventHandler(this.FrmRelatorioPrazo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPrazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParcelas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.BindingSource TabelaPrazoBindingSource;
        private DataSetParcelas DataSetParcelas;
        private DataSetParcelasTableAdapters.TabelaPrazoTableAdapter TabelaPrazoTableAdapter;
    }
}