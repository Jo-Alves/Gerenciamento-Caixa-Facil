namespace sistemaControleVendas
{
    partial class FrmRelatorioAnaliseVenda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AnaliseProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorio = new sistemaControleVendas.DataSetRelatorio();
            this.AnaliseServicoPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rv_analiseServicosPrestados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_AnaliseProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PanelCabecalho = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Icone = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.AnaliseProdutoTableAdapter = new sistemaControleVendas.DataSetRelatorioTableAdapters.AnaliseProdutoTableAdapter();
            this.AnaliseServicoPrestadosTableAdapter = new sistemaControleVendas.DataSetRelatorioTableAdapters.AnaliseServicoPrestadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseServicoPrestadosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaliseProdutoBindingSource
            // 
            this.AnaliseProdutoBindingSource.DataMember = "AnaliseProduto";
            this.AnaliseProdutoBindingSource.DataSource = this.DataSetRelatorio;
            // 
            // DataSetRelatorio
            // 
            this.DataSetRelatorio.DataSetName = "DataSetRelatorio";
            this.DataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AnaliseServicoPrestadosBindingSource
            // 
            this.AnaliseServicoPrestadosBindingSource.DataMember = "AnaliseServicoPrestados";
            this.AnaliseServicoPrestadosBindingSource.DataSource = this.DataSetRelatorio;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rv_analiseServicosPrestados);
            this.panel1.Controls.Add(this.rv_AnaliseProduto);
            this.panel1.Controls.Add(this.PanelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 700);
            this.panel1.TabIndex = 0;
            // 
            // rv_analiseServicosPrestados
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AnaliseServicoPrestadosBindingSource;
            this.rv_analiseServicosPrestados.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_analiseServicosPrestados.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.RelatorioServicosMaisPrestados_Analise.rdlc";
            this.rv_analiseServicosPrestados.Location = new System.Drawing.Point(-1, 60);
            this.rv_analiseServicosPrestados.Name = "rv_analiseServicosPrestados";
            this.rv_analiseServicosPrestados.ServerReport.BearerToken = null;
            this.rv_analiseServicosPrestados.Size = new System.Drawing.Size(998, 639);
            this.rv_analiseServicosPrestados.TabIndex = 6;
            this.rv_analiseServicosPrestados.Visible = false;
            // 
            // rv_AnaliseProduto
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AnaliseProdutoBindingSource;
            this.rv_AnaliseProduto.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_AnaliseProduto.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.RelatorioAnaliseProdutoMaisVendido.rdlc";
            this.rv_AnaliseProduto.Location = new System.Drawing.Point(-1, 60);
            this.rv_AnaliseProduto.Name = "rv_AnaliseProduto";
            this.rv_AnaliseProduto.ServerReport.BearerToken = null;
            this.rv_AnaliseProduto.Size = new System.Drawing.Size(998, 639);
            this.rv_AnaliseProduto.TabIndex = 5;
            this.rv_AnaliseProduto.Visible = false;
            // 
            // PanelCabecalho
            // 
            this.PanelCabecalho.BackColor = System.Drawing.Color.Green;
            this.PanelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecalho.Controls.Add(this.Lbl_Titulo);
            this.PanelCabecalho.Controls.Add(this.Lbl_Icone);
            this.PanelCabecalho.Controls.Add(this.btn_Fechar);
            this.PanelCabecalho.Location = new System.Drawing.Point(-1, -1);
            this.PanelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCabecalho.Name = "PanelCabecalho";
            this.PanelCabecalho.Size = new System.Drawing.Size(998, 63);
            this.PanelCabecalho.TabIndex = 4;
            this.PanelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseDown);
            this.PanelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseMove);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(93, 17);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(239, 19);
            this.Lbl_Titulo.TabIndex = 65;
            this.Lbl_Titulo.Text = "Extrato de produtos mais vendidos";
            // 
            // Lbl_Icone
            // 
            this.Lbl_Icone.Image = global::sistemaControleVendas.Properties.Resources.Cash_register_icon11;
            this.Lbl_Icone.Location = new System.Drawing.Point(11, 4);
            this.Lbl_Icone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Icone.Name = "Lbl_Icone";
            this.Lbl_Icone.Size = new System.Drawing.Size(88, 53);
            this.Lbl_Icone.TabIndex = 64;
            this.Lbl_Icone.Text = "    ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(954, 4);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 62;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // AnaliseProdutoTableAdapter
            // 
            this.AnaliseProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // AnaliseServicoPrestadosTableAdapter
            // 
            this.AnaliseServicoPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAnaliseVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioAnaliseVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioAnaliseVenda";
            this.Load += new System.EventHandler(this.FrmRelatorioAnaliseVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnaliseServicoPrestadosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelCabecalho.ResumeLayout(false);
            this.PanelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelCabecalho;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Icone;
        private System.Windows.Forms.Button btn_Fechar;
        private Microsoft.Reporting.WinForms.ReportViewer rv_AnaliseProduto;
        private System.Windows.Forms.BindingSource AnaliseProdutoBindingSource;
        private DataSetRelatorio DataSetRelatorio;
        private DataSetRelatorioTableAdapters.AnaliseProdutoTableAdapter AnaliseProdutoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_analiseServicosPrestados;
        private System.Windows.Forms.BindingSource AnaliseServicoPrestadosBindingSource;
        private DataSetRelatorioTableAdapters.AnaliseServicoPrestadosTableAdapter AnaliseServicoPrestadosTableAdapter;
    }
}