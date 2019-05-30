namespace sistemaControleVendas
{
    partial class FrmPesquisarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbControleVendaDataSet = new sistemaControleVendas.DbControleVendaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.valorCusto1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaProdutoTableAdapter = new sistemaControleVendas.DbControleVendaDataSetTableAdapters.TabelaProdutoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_Busca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 465);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.AllowUserToOrderColumns = true;
            this.dgv_Busca.AutoGenerateColumns = false;
            this.dgv_Busca.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.codigoBarraDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.valorCustoDataGridViewTextBoxColumn,
            this.valorVendaDataGridViewTextBoxColumn,
            this.lucroDataGridViewTextBoxColumn1,
            this.estoqueAtualDataGridViewTextBoxColumn,
            this.estoqueMinimoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.NomeCategoria,
            this.nomeDataGridViewTextBoxColumn});
            this.dgv_Busca.DataSource = this.tabelaProdutoBindingSource;
            this.dgv_Busca.Location = new System.Drawing.Point(14, 144);
            this.dgv_Busca.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(1060, 309);
            this.dgv_Busca.TabIndex = 12;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Busca_DataBindingComplete);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "Id_Produto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Width = 79;
            // 
            // codigoBarraDataGridViewTextBoxColumn
            // 
            this.codigoBarraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra";
            this.codigoBarraDataGridViewTextBoxColumn.HeaderText = "Codigo de Barra";
            this.codigoBarraDataGridViewTextBoxColumn.Name = "codigoBarraDataGridViewTextBoxColumn";
            this.codigoBarraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoBarraDataGridViewTextBoxColumn.Width = 136;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoNome";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 95;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 74;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "Data da Validade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataValidadeDataGridViewTextBoxColumn.Width = 138;
            // 
            // valorCustoDataGridViewTextBoxColumn
            // 
            this.valorCustoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorCustoDataGridViewTextBoxColumn.DataPropertyName = "ValorCusto";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.valorCustoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.valorCustoDataGridViewTextBoxColumn.HeaderText = "Valor de Custo";
            this.valorCustoDataGridViewTextBoxColumn.Name = "valorCustoDataGridViewTextBoxColumn";
            this.valorCustoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCustoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            this.valorVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.valorVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.valorVendaDataGridViewTextBoxColumn.HeaderText = "Valor de Venda";
            this.valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            this.valorVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorVendaDataGridViewTextBoxColumn.Width = 127;
            // 
            // lucroDataGridViewTextBoxColumn1
            // 
            this.lucroDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lucroDataGridViewTextBoxColumn1.DataPropertyName = "Lucro";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.lucroDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.lucroDataGridViewTextBoxColumn1.HeaderText = "Lucro";
            this.lucroDataGridViewTextBoxColumn1.Name = "lucroDataGridViewTextBoxColumn1";
            this.lucroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lucroDataGridViewTextBoxColumn1.Width = 70;
            // 
            // estoqueAtualDataGridViewTextBoxColumn
            // 
            this.estoqueAtualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estoqueAtualDataGridViewTextBoxColumn.DataPropertyName = "EstoqueAtual";
            this.estoqueAtualDataGridViewTextBoxColumn.HeaderText = "Estoque Atual";
            this.estoqueAtualDataGridViewTextBoxColumn.Name = "estoqueAtualDataGridViewTextBoxColumn";
            this.estoqueAtualDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueAtualDataGridViewTextBoxColumn.Width = 118;
            // 
            // estoqueMinimoDataGridViewTextBoxColumn
            // 
            this.estoqueMinimoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estoqueMinimoDataGridViewTextBoxColumn.DataPropertyName = "EstoqueMinimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.HeaderText = "Estoque Mínimo";
            this.estoqueMinimoDataGridViewTextBoxColumn.Name = "estoqueMinimoDataGridViewTextBoxColumn";
            this.estoqueMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueMinimoDataGridViewTextBoxColumn.Width = 133;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 85;
            // 
            // NomeCategoria
            // 
            this.NomeCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NomeCategoria.DataPropertyName = "Descricao";
            this.NomeCategoria.HeaderText = "Categoria";
            this.NomeCategoria.Name = "NomeCategoria";
            this.NomeCategoria.ReadOnly = true;
            this.NomeCategoria.Width = 93;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 105;
            // 
            // tabelaProdutoBindingSource
            // 
            this.tabelaProdutoBindingSource.DataMember = "TabelaProduto";
            this.tabelaProdutoBindingSource.DataSource = this.dbControleVendaDataSet;
            // 
            // dbControleVendaDataSet
            // 
            this.dbControleVendaDataSet.DataSetName = "DbControleVendaDataSet";
            this.dbControleVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do produto:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(375, 95);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(408, 26);
            this.txt_Nome.TabIndex = 10;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DarkOrange;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label3);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(2, 2);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(2);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1075, 69);
            this.panelCabecalho.TabIndex = 9;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Pesquisar Produtos";
            // 
            // label3
            // 
            this.label3.Image = global::sistemaControleVendas.Properties.Resources.Preppy_icon;
            this.label3.Location = new System.Drawing.Point(6, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 63);
            this.label3.TabIndex = 58;
            this.label3.Text = "     ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(1022, 6);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(40, 42);
            this.btn_Fechar.TabIndex = 57;
            this.btn_Fechar.Text = "X";
            this.toolTip1.SetToolTip(this.btn_Fechar, "Fechar");
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // valorCusto1DataGridViewTextBoxColumn
            // 
            this.valorCusto1DataGridViewTextBoxColumn.DataPropertyName = "ValorCusto1";
            this.valorCusto1DataGridViewTextBoxColumn.HeaderText = "ValorCusto1";
            this.valorCusto1DataGridViewTextBoxColumn.Name = "valorCusto1DataGridViewTextBoxColumn";
            // 
            // valorVenda1DataGridViewTextBoxColumn
            // 
            this.valorVenda1DataGridViewTextBoxColumn.DataPropertyName = "ValorVenda1";
            this.valorVenda1DataGridViewTextBoxColumn.HeaderText = "ValorVenda1";
            this.valorVenda1DataGridViewTextBoxColumn.Name = "valorVenda1DataGridViewTextBoxColumn";
            // 
            // lucroDataGridViewTextBoxColumn
            // 
            this.lucroDataGridViewTextBoxColumn.DataPropertyName = "Lucro";
            this.lucroDataGridViewTextBoxColumn.HeaderText = "Lucro";
            this.lucroDataGridViewTextBoxColumn.Name = "lucroDataGridViewTextBoxColumn";
            // 
            // tabelaProdutoTableAdapter
            // 
            this.tabelaProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPesquisarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 465);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPesquisarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Produtos";
            this.Load += new System.EventHandler(this.FrmPesquisarProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCusto1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private DbControleVendaDataSet dbControleVendaDataSet;
        private System.Windows.Forms.BindingSource tabelaProdutoBindingSource;
        private DbControleVendaDataSetTableAdapters.TabelaProdutoTableAdapter tabelaProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}