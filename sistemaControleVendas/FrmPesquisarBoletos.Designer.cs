namespace sistemaControleVendas
{
    partial class FrmPesquisarBoletos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Beneficiario = new System.Windows.Forms.TextBox();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbControleVendaDataSet = new sistemaControleVendas.DbControleVendaDataSet();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.contasPagarTableAdapter = new sistemaControleVendas.DbControleVendaDataSetTableAdapters.ContasPagarTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Beneficiario);
            this.panel1.Controls.Add(this.dgv_Busca);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 501);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Beneficiário:";
            // 
            // txt_Beneficiario
            // 
            this.txt_Beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Beneficiario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Beneficiario.Location = new System.Drawing.Point(443, 91);
            this.txt_Beneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Beneficiario.Name = "txt_Beneficiario";
            this.txt_Beneficiario.Size = new System.Drawing.Size(452, 26);
            this.txt_Beneficiario.TabIndex = 20;
            this.txt_Beneficiario.TextChanged += new System.EventHandler(this.txt_Beneficiario_TextChanged);
            this.txt_Beneficiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Beneficiario_KeyDown);
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.AutoGenerateColumns = false;
            this.dgv_Busca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Busca.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Busca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.beneficiarioDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.vencimentoDataGridViewTextBoxColumn,
            this.valorDocumentoDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn});
            this.dgv_Busca.DataSource = this.contasPagarBindingSource;
            this.dgv_Busca.Location = new System.Drawing.Point(11, 137);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(1240, 357);
            this.dgv_Busca.TabIndex = 1;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Busca_CellClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Busca_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beneficiarioDataGridViewTextBoxColumn
            // 
            this.beneficiarioDataGridViewTextBoxColumn.DataPropertyName = "Beneficiario";
            this.beneficiarioDataGridViewTextBoxColumn.HeaderText = "Beneficiário";
            this.beneficiarioDataGridViewTextBoxColumn.Name = "beneficiarioDataGridViewTextBoxColumn";
            this.beneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nº do documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            this.vencimentoDataGridViewTextBoxColumn.DataPropertyName = "Vencimento";
            this.vencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento";
            this.vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            this.vencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDocumentoDataGridViewTextBoxColumn
            // 
            this.valorDocumentoDataGridViewTextBoxColumn.DataPropertyName = "ValorDocumento";
            this.valorDocumentoDataGridViewTextBoxColumn.HeaderText = "Valor do documento";
            this.valorDocumentoDataGridViewTextBoxColumn.Name = "valorDocumentoDataGridViewTextBoxColumn";
            this.valorDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referência";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contasPagarBindingSource
            // 
            this.contasPagarBindingSource.DataMember = "ContasPagar";
            this.contasPagarBindingSource.DataSource = this.dbControleVendaDataSet;
            // 
            // dbControleVendaDataSet
            // 
            this.dbControleVendaDataSet.DataSetName = "DbControleVendaDataSet";
            this.dbControleVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkOrange;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label3);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(0, 3);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1255, 69);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Pesquisar Empresa";
            // 
            // label3
            // 
            this.label3.Image = global::sistemaControleVendas.Properties.Resources.Company_icon;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 63);
            this.label3.TabIndex = 61;
            this.label3.Text = "     ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(1209, 5);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(40, 42);
            this.btn_Fechar.TabIndex = 60;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // contasPagarTableAdapter
            // 
            this.contasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPesquisarBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 501);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPesquisarBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Boletos";
            this.Load += new System.EventHandler(this.FrmPesquisarBoletos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Beneficiario;
        private DbControleVendaDataSet dbControleVendaDataSet;
        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private DbControleVendaDataSetTableAdapters.ContasPagarTableAdapter contasPagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
    }
}