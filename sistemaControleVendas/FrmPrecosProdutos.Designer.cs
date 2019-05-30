namespace sistemaControleVendas
{
    partial class FrmPrecosProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePrecosProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbControleVendaDataSet = new sistemaControleVendas.DbControleVendaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePrecosProdutoTableAdapter = new sistemaControleVendas.DbControleVendaDataSetTableAdapters.TablePrecosProdutoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePrecosProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_Busca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 485);
            this.panel1.TabIndex = 1;
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
            this.Descricao,
            this.valorVendaDataGridViewTextBoxColumn,
            this.codigoBarraDataGridViewTextBoxColumn});
            this.dgv_Busca.DataSource = this.tablePrecosProdutoBindingSource;
            this.dgv_Busca.Location = new System.Drawing.Point(12, 164);
            this.dgv_Busca.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(776, 309);
            this.dgv_Busca.TabIndex = 16;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Busca_DataBindingComplete);
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "Id_Produto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // valorVendaDataGridViewTextBoxColumn
            // 
            this.valorVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorVendaDataGridViewTextBoxColumn.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorVendaDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.valorVendaDataGridViewTextBoxColumn.Name = "valorVendaDataGridViewTextBoxColumn";
            this.valorVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorVendaDataGridViewTextBoxColumn.Width = 70;
            // 
            // codigoBarraDataGridViewTextBoxColumn
            // 
            this.codigoBarraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra";
            this.codigoBarraDataGridViewTextBoxColumn.HeaderText = "Codigo de Barra";
            this.codigoBarraDataGridViewTextBoxColumn.Name = "codigoBarraDataGridViewTextBoxColumn";
            this.codigoBarraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablePrecosProdutoBindingSource
            // 
            this.tablePrecosProdutoBindingSource.DataMember = "TablePrecosProduto";
            this.tablePrecosProdutoBindingSource.DataSource = this.dbControleVendaDataSet;
            // 
            // dbControleVendaDataSet
            // 
            this.dbControleVendaDataSet.DataSetName = "DbControleVendaDataSet";
            this.dbControleVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome do produto:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(288, 118);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(312, 26);
            this.txt_Nome.TabIndex = 14;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Controls.Add(this.btn_Minimizar);
            this.panelCabecalho.Controls.Add(this.btn_BuscarCliente);
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Location = new System.Drawing.Point(3, -1);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(796, 92);
            this.panelCabecalho.TabIndex = 1;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(744, 17);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 65;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimizar.Location = new System.Drawing.Point(698, 17);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 41);
            this.btn_Minimizar.TabIndex = 64;
            this.btn_Minimizar.Text = "__";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            this.btn_Minimizar.MouseEnter += new System.EventHandler(this.btn_Minimizar_MouseEnter);
            this.btn_Minimizar.MouseLeave += new System.EventHandler(this.btn_Minimizar_MouseLeave);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(-193, 42);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(142, 60);
            this.btn_BuscarCliente.TabIndex = 63;
            this.btn_BuscarCliente.Text = "Clientes - F1";
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de preços de cada produto";
            // 
            // label1
            // 
            this.label1.Image = global::sistemaControleVendas.Properties.Resources.Ecommerce_Price_Tag_icon;
            this.label1.Location = new System.Drawing.Point(3, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 88);
            this.label1.TabIndex = 0;
            // 
            // tablePrecosProdutoTableAdapter
            // 
            this.tablePrecosProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPrecosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrecosProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precos Produtos";
            this.Load += new System.EventHandler(this.FrmPrecosProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePrecosProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private DbControleVendaDataSet dbControleVendaDataSet;
        private System.Windows.Forms.BindingSource tablePrecosProdutoBindingSource;
        private DbControleVendaDataSetTableAdapters.TablePrecosProdutoTableAdapter tablePrecosProdutoTableAdapter;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
    }
}