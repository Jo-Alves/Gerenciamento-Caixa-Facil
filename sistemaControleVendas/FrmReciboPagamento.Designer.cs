namespace sistemaControleVendas
{
    partial class FrmReciboPagamento
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
            this.vendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorio = new sistemaControleVendas.DataSetRelatorio();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendaTableAdapter = new sistemaControleVendas.DataSetRelatorioTableAdapters.VendaTableAdapter();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_InserirNome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rv_Recibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorio)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendaBindingSource2
            // 
            this.vendaBindingSource2.DataMember = "Venda";
            this.vendaBindingSource2.DataSource = this.DataSetRelatorio;
            // 
            // DataSetRelatorio
            // 
            this.DataSetRelatorio.DataSetName = "DataSetRelatorio";
            this.DataSetRelatorio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(1330, 5);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 64;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // label1
            // 
            this.label1.Image = global::sistemaControleVendas.Properties.Resources.Sales_report_icon;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 73);
            this.label1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Recibo de pagamento";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1376, 90);
            this.panelCabecalho.TabIndex = 6;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.DataSetRelatorio;
            // 
            // VendaTableAdapter
            // 
            this.VendaTableAdapter.ClearBeforeFill = true;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.DataSetRelatorio;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.btn_InserirNome);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 607);
            this.panel1.TabIndex = 7;
            // 
            // txt_Nome
            // 
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(480, 7);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(287, 26);
            this.txt_Nome.TabIndex = 14;
            // 
            // btn_InserirNome
            // 
            this.btn_InserirNome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_InserirNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InserirNome.Location = new System.Drawing.Point(773, 6);
            this.btn_InserirNome.Name = "btn_InserirNome";
            this.btn_InserirNome.Size = new System.Drawing.Size(202, 29);
            this.btn_InserirNome.TabIndex = 13;
            this.btn_InserirNome.Text = "Inserir nome no recibo";
            this.btn_InserirNome.UseVisualStyleBackColor = true;
            this.btn_InserirNome.Click += new System.EventHandler(this.btn_InserirNome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rv_Recibo);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 561);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rv_Recibo
            // 
            this.rv_Recibo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendaBindingSource2;
            this.rv_Recibo.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_Recibo.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.NotaPromissoria.rdlc";
            this.rv_Recibo.Location = new System.Drawing.Point(3, 16);
            this.rv_Recibo.Name = "rv_Recibo";
            this.rv_Recibo.ServerReport.BearerToken = null;
            this.rv_Recibo.Size = new System.Drawing.Size(1346, 542);
            this.rv_Recibo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome complete do cliente:";
            // 
            // FrmReciboPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReciboPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibo Pagamento";
            this.Load += new System.EventHandler(this.ReciboPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorio)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.BindingSource VendaBindingSource;
        private DataSetRelatorio DataSetRelatorio;
        private DataSetRelatorioTableAdapters.VendaTableAdapter VendaTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.BindingSource vendaBindingSource2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_InserirNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Recibo;
        private System.Windows.Forms.Label label3;
    }
}