namespace sistemaControleVendas
{
    partial class FrmRelatorioSaldoFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_Opcao = new System.Windows.Forms.ComboBox();
            this.dgvDadosSaldoFinal = new System.Windows.Forms.DataGridView();
            this.PanelCabecalho = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Icone = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSaldoPositivo = new System.Windows.Forms.CheckBox();
            this.cbxSaldoNegativo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblValorTotalCaixa = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblValorTotalRecebido = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblValorTotalSaldo = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosSaldoFinal)).BeginInit();
            this.PanelCabecalho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Opcao
            // 
            this.cb_Opcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opcao.FormattingEnabled = true;
            this.cb_Opcao.Items.AddRange(new object[] {
            "DATA DE ENTRADA",
            "OPERADOR"});
            this.cb_Opcao.Location = new System.Drawing.Point(572, 151);
            this.cb_Opcao.Name = "cb_Opcao";
            this.cb_Opcao.Size = new System.Drawing.Size(185, 27);
            this.cb_Opcao.TabIndex = 9;
            // 
            // dgvDadosSaldoFinal
            // 
            this.dgvDadosSaldoFinal.AllowUserToAddRows = false;
            this.dgvDadosSaldoFinal.AllowUserToDeleteRows = false;
            this.dgvDadosSaldoFinal.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosSaldoFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosSaldoFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosSaldoFinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDadosSaldoFinal.Location = new System.Drawing.Point(12, 202);
            this.dgvDadosSaldoFinal.Name = "dgvDadosSaldoFinal";
            this.dgvDadosSaldoFinal.ReadOnly = true;
            this.dgvDadosSaldoFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosSaldoFinal.Size = new System.Drawing.Size(746, 397);
            this.dgvDadosSaldoFinal.TabIndex = 8;
            this.dgvDadosSaldoFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosSaldoFinal_CellClick);
            // 
            // PanelCabecalho
            // 
            this.PanelCabecalho.BackColor = System.Drawing.Color.Green;
            this.PanelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecalho.Controls.Add(this.Lbl_Titulo);
            this.PanelCabecalho.Controls.Add(this.Lbl_Icone);
            this.PanelCabecalho.Controls.Add(this.btn_Fechar);
            this.PanelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCabecalho.Name = "PanelCabecalho";
            this.PanelCabecalho.Size = new System.Drawing.Size(770, 64);
            this.PanelCabecalho.TabIndex = 7;
            this.PanelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseDown);
            this.PanelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecalho_MouseMove);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(94, 17);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(223, 19);
            this.Lbl_Titulo.TabIndex = 65;
            this.Lbl_Titulo.Text = "Relatório de saldo final do caixa";
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
            this.btn_Fechar.Location = new System.Drawing.Point(726, 4);
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
            // txt_Descricao
            // 
            this.txt_Descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Descricao.Location = new System.Drawing.Point(16, 152);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(550, 26);
            this.txt_Descricao.TabIndex = 10;
            this.txt_Descricao.TextChanged += new System.EventHandler(this.txt_Descricao_TextChanged);
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(11, 28);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(112, 26);
            this.dtDataInicial.TabIndex = 11;
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(151, 28);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(112, 26);
            this.dtDataFinal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "à";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dtDataInicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDataFinal);
            this.groupBox1.Location = new System.Drawing.Point(16, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por data";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(269, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSaldoPositivo);
            this.groupBox2.Controls.Add(this.cbxSaldoNegativo);
            this.groupBox2.Location = new System.Drawing.Point(385, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 67);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por";
            // 
            // cbxSaldoPositivo
            // 
            this.cbxSaldoPositivo.AutoSize = true;
            this.cbxSaldoPositivo.Location = new System.Drawing.Point(42, 25);
            this.cbxSaldoPositivo.Name = "cbxSaldoPositivo";
            this.cbxSaldoPositivo.Size = new System.Drawing.Size(115, 23);
            this.cbxSaldoPositivo.TabIndex = 15;
            this.cbxSaldoPositivo.Text = "Saldo Positivo";
            this.cbxSaldoPositivo.UseVisualStyleBackColor = true;
            this.cbxSaldoPositivo.CheckedChanged += new System.EventHandler(this.cbxSaldoPositivo_CheckedChanged);
            // 
            // cbxSaldoNegativo
            // 
            this.cbxSaldoNegativo.AutoSize = true;
            this.cbxSaldoNegativo.Location = new System.Drawing.Point(163, 25);
            this.cbxSaldoNegativo.Name = "cbxSaldoNegativo";
            this.cbxSaldoNegativo.Size = new System.Drawing.Size(122, 23);
            this.cbxSaldoNegativo.TabIndex = 16;
            this.cbxSaldoNegativo.Text = "Saldo Negativo";
            this.cbxSaldoNegativo.UseVisualStyleBackColor = true;
            this.cbxSaldoNegativo.CheckedChanged += new System.EventHandler(this.cbxSaldoNegativo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblValorTotalCaixa);
            this.groupBox3.Location = new System.Drawing.Point(12, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 77);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Valor em Caixa";
            // 
            // lblValorTotalCaixa
            // 
            this.lblValorTotalCaixa.AutoSize = true;
            this.lblValorTotalCaixa.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblValorTotalCaixa.Location = new System.Drawing.Point(6, 31);
            this.lblValorTotalCaixa.Name = "lblValorTotalCaixa";
            this.lblValorTotalCaixa.Size = new System.Drawing.Size(45, 31);
            this.lblValorTotalCaixa.TabIndex = 0;
            this.lblValorTotalCaixa.Text = "R$";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblValorTotalRecebido);
            this.groupBox4.Location = new System.Drawing.Point(264, 605);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 77);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Valor Recebido";
            // 
            // lblValorTotalRecebido
            // 
            this.lblValorTotalRecebido.AutoSize = true;
            this.lblValorTotalRecebido.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblValorTotalRecebido.Location = new System.Drawing.Point(9, 31);
            this.lblValorTotalRecebido.Name = "lblValorTotalRecebido";
            this.lblValorTotalRecebido.Size = new System.Drawing.Size(45, 31);
            this.lblValorTotalRecebido.TabIndex = 1;
            this.lblValorTotalRecebido.Text = "R$";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblValorTotalSaldo);
            this.groupBox5.Location = new System.Drawing.Point(513, 605);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 77);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Valor Saldo";
            // 
            // lblValorTotalSaldo
            // 
            this.lblValorTotalSaldo.AutoSize = true;
            this.lblValorTotalSaldo.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblValorTotalSaldo.Location = new System.Drawing.Point(9, 31);
            this.lblValorTotalSaldo.Name = "lblValorTotalSaldo";
            this.lblValorTotalSaldo.Size = new System.Drawing.Size(45, 31);
            this.lblValorTotalSaldo.TabIndex = 1;
            this.lblValorTotalSaldo.Text = "R$";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "DataEntrada";
            dataGridViewCellStyle1.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "Data";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 44;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "ValorCaixa";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Valor do Caixa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 106;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "ValorRecebido";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "Valor Recebido";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 109;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "SaldoCaixa";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Saldo Final";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 83;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Nome";
            this.Column3.HeaderText = "Operador";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 75;
            // 
            // FrmRelatorioSaldoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 687);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.cb_Opcao);
            this.Controls.Add(this.dgvDadosSaldoFinal);
            this.Controls.Add(this.PanelCabecalho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRelatorioSaldoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioSaldoFinal";
            this.Load += new System.EventHandler(this.FrmRelatorioSaldoFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosSaldoFinal)).EndInit();
            this.PanelCabecalho.ResumeLayout(false);
            this.PanelCabecalho.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Opcao;
        private System.Windows.Forms.DataGridView dgvDadosSaldoFinal;
        private System.Windows.Forms.Panel PanelCabecalho;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Icone;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxSaldoPositivo;
        private System.Windows.Forms.CheckBox cbxSaldoNegativo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValorTotalCaixa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblValorTotalRecebido;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblValorTotalSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}