namespace sistemaControleVendas
{
    partial class FrmContasPagar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnPesquisar = new System.Windows.Forms.TabPage();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Referente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_ValorDocumento = new System.Windows.Forms.TextBox();
            this.txt_NumeroDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Beneficiario = new System.Windows.Forms.TextBox();
            this.mask_Vencimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Consulta = new System.Windows.Forms.DataGridView();
            this.beneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbControleVendaDataSet = new sistemaControleVendas.DbControleVendaDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_LimparQuitar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ReferenteQuitar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Multa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DescontoQuitar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_PesquisarQuitar = new System.Windows.Forms.Button();
            this.txt_ValorDocumentoQuitar = new System.Windows.Forms.TextBox();
            this.txt_NumeroDocumentoQuitar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_BeneficiarioQuitar = new System.Windows.Forms.TextBox();
            this.mask_VencimentoQuitar = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contasPagarTableAdapter = new sistemaControleVendas.DbControleVendaDataSetTableAdapters.ContasPagarTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.btnPesquisar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 478);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.btnPesquisar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPesquisar.Controls.Add(this.btn_Limpar);
            this.btnPesquisar.Controls.Add(this.txt_Desconto);
            this.btnPesquisar.Controls.Add(this.label8);
            this.btnPesquisar.Controls.Add(this.txt_Referente);
            this.btnPesquisar.Controls.Add(this.label9);
            this.btnPesquisar.Controls.Add(this.btn_Gravar);
            this.btnPesquisar.Controls.Add(this.btn_Pesquisar);
            this.btnPesquisar.Controls.Add(this.txt_ValorDocumento);
            this.btnPesquisar.Controls.Add(this.txt_NumeroDocumento);
            this.btnPesquisar.Controls.Add(this.label7);
            this.btnPesquisar.Controls.Add(this.label6);
            this.btnPesquisar.Controls.Add(this.label5);
            this.btnPesquisar.Controls.Add(this.txt_Beneficiario);
            this.btnPesquisar.Controls.Add(this.mask_Vencimento);
            this.btnPesquisar.Controls.Add(this.label3);
            this.btnPesquisar.Location = new System.Drawing.Point(4, 28);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Size = new System.Drawing.Size(697, 344);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Inserir Boletos a pagar";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::sistemaControleVendas.Properties.Resources.CleanMyMac_1_icon;
            this.btn_Limpar.Location = new System.Drawing.Point(392, 262);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(110, 69);
            this.btn_Limpar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btn_Limpar, "Gravar");
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Desconto.Location = new System.Drawing.Point(428, 184);
            this.txt_Desconto.MaxLength = 10;
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.Size = new System.Drawing.Size(100, 26);
            this.txt_Desconto.TabIndex = 5;
            this.txt_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Desconto.TextChanged += new System.EventHandler(this.txt_Desconto_TextChanged);
            this.txt_Desconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Desconto_KeyDown);
            this.txt_Desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Desconto_KeyPress);
            this.txt_Desconto.Leave += new System.EventHandler(this.txt_Desconto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Desconto (R$):";
            // 
            // txt_Referente
            // 
            this.txt_Referente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Referente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Referente.Location = new System.Drawing.Point(158, 67);
            this.txt_Referente.MaxLength = 200;
            this.txt_Referente.Multiline = true;
            this.txt_Referente.Name = "txt_Referente";
            this.txt_Referente.Size = new System.Drawing.Size(344, 55);
            this.txt_Referente.TabIndex = 1;
            this.txt_Referente.TextChanged += new System.EventHandler(this.txt_Referente_TextChanged);
            this.txt_Referente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Referente_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Referente:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Gravar.Image = global::sistemaControleVendas.Properties.Resources.Actions_media_record_icon;
            this.btn_Gravar.Location = new System.Drawing.Point(508, 262);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(110, 69);
            this.btn_Gravar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Gravar, "Gravar");
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(508, 16);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(110, 41);
            this.btn_Pesquisar.TabIndex = 10;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_ValorDocumento
            // 
            this.txt_ValorDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorDocumento.Location = new System.Drawing.Point(205, 183);
            this.txt_ValorDocumento.MaxLength = 10;
            this.txt_ValorDocumento.Name = "txt_ValorDocumento";
            this.txt_ValorDocumento.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorDocumento.TabIndex = 4;
            this.txt_ValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorDocumento.TextChanged += new System.EventHandler(this.txt_ValorDocumento_TextChanged);
            this.txt_ValorDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ValorDocumento_KeyDown);
            this.txt_ValorDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorDocumento_KeyPress);
            this.txt_ValorDocumento.Leave += new System.EventHandler(this.txt_ValorDocumento_Leave);
            // 
            // txt_NumeroDocumento
            // 
            this.txt_NumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumeroDocumento.Location = new System.Drawing.Point(231, 138);
            this.txt_NumeroDocumento.Name = "txt_NumeroDocumento";
            this.txt_NumeroDocumento.Size = new System.Drawing.Size(141, 26);
            this.txt_NumeroDocumento.TabIndex = 2;
            this.txt_NumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NumeroDocumento.TextChanged += new System.EventHandler(this.txt_NumeroDocumento_TextChanged);
            this.txt_NumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroDocumento_KeyDown);
            this.txt_NumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroDocumento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(378, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vencimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor do documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Número do documento:";
            // 
            // txt_Beneficiario
            // 
            this.txt_Beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Beneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Beneficiario.Location = new System.Drawing.Point(158, 24);
            this.txt_Beneficiario.MaxLength = 100;
            this.txt_Beneficiario.Name = "txt_Beneficiario";
            this.txt_Beneficiario.Size = new System.Drawing.Size(344, 26);
            this.txt_Beneficiario.TabIndex = 0;
            this.txt_Beneficiario.TextChanged += new System.EventHandler(this.txt_Beneficiario_TextChanged);
            this.txt_Beneficiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Beneficiario_KeyDown);
            // 
            // mask_Vencimento
            // 
            this.mask_Vencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_Vencimento.Location = new System.Drawing.Point(476, 138);
            this.mask_Vencimento.Mask = "00/00/0000";
            this.mask_Vencimento.Name = "mask_Vencimento";
            this.mask_Vencimento.Size = new System.Drawing.Size(90, 26);
            this.mask_Vencimento.TabIndex = 3;
            this.mask_Vencimento.ValidatingType = typeof(System.DateTime);
            this.mask_Vencimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_Vencimento_MaskInputRejected);
            this.mask_Vencimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mask_Vencimento_KeyDown);
            this.mask_Vencimento.Leave += new System.EventHandler(this.mask_Vencimento_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Beneficiário:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dataGridView_Consulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(697, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Boletos a vencer ou vencidos";
            // 
            // dataGridView_Consulta
            // 
            this.dataGridView_Consulta.AllowUserToAddRows = false;
            this.dataGridView_Consulta.AllowUserToDeleteRows = false;
            this.dataGridView_Consulta.AutoGenerateColumns = false;
            this.dataGridView_Consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Consulta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beneficiarioDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.vencimentoDataGridViewTextBoxColumn,
            this.valorDocumentoDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn});
            this.dataGridView_Consulta.DataSource = this.contasPagarBindingSource;
            this.dataGridView_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Consulta.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_Consulta.Name = "dataGridView_Consulta";
            this.dataGridView_Consulta.ReadOnly = true;
            this.dataGridView_Consulta.Size = new System.Drawing.Size(687, 334);
            this.dataGridView_Consulta.TabIndex = 2;
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
            this.numeroDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nº Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 125;
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
            this.valorDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorDocumentoDataGridViewTextBoxColumn.DataPropertyName = "ValorDocumento";
            this.valorDocumentoDataGridViewTextBoxColumn.HeaderText = "V. Documento";
            this.valorDocumentoDataGridViewTextBoxColumn.Name = "valorDocumentoDataGridViewTextBoxColumn";
            this.valorDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDocumentoDataGridViewTextBoxColumn.Width = 121;
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.btn_LimparQuitar);
            this.tabPage3.Controls.Add(this.btn_Quitar);
            this.tabPage3.Controls.Add(this.txt_ValorPago);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txt_ReferenteQuitar);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_Multa);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_DescontoQuitar);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_PesquisarQuitar);
            this.tabPage3.Controls.Add(this.txt_ValorDocumentoQuitar);
            this.tabPage3.Controls.Add(this.txt_NumeroDocumentoQuitar);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txt_BeneficiarioQuitar);
            this.tabPage3.Controls.Add(this.mask_VencimentoQuitar);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(697, 344);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quitar Boletos";
            // 
            // btn_LimparQuitar
            // 
            this.btn_LimparQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LimparQuitar.Image = global::sistemaControleVendas.Properties.Resources.CleanMyMac_1_icon;
            this.btn_LimparQuitar.Location = new System.Drawing.Point(393, 266);
            this.btn_LimparQuitar.Name = "btn_LimparQuitar";
            this.btn_LimparQuitar.Size = new System.Drawing.Size(110, 69);
            this.btn_LimparQuitar.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btn_LimparQuitar, "Gravar");
            this.btn_LimparQuitar.UseVisualStyleBackColor = true;
            this.btn_LimparQuitar.Click += new System.EventHandler(this.btn_LimparQuitar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Quitar.Image = global::sistemaControleVendas.Properties.Resources.Actions_media_record_icon;
            this.btn_Quitar.Location = new System.Drawing.Point(509, 266);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(110, 69);
            this.btn_Quitar.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_Quitar, "Gravar");
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorPago.Location = new System.Drawing.Point(337, 229);
            this.txt_ValorPago.MaxLength = 10;
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorPago.TabIndex = 7;
            this.txt_ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorPago.TextChanged += new System.EventHandler(this.txt_ValorPago_TextChanged);
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            this.txt_ValorPago.Leave += new System.EventHandler(this.txt_ValorPago_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor Pago:";
            // 
            // txt_ReferenteQuitar
            // 
            this.txt_ReferenteQuitar.BackColor = System.Drawing.Color.White;
            this.txt_ReferenteQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ReferenteQuitar.Location = new System.Drawing.Point(159, 68);
            this.txt_ReferenteQuitar.Multiline = true;
            this.txt_ReferenteQuitar.Name = "txt_ReferenteQuitar";
            this.txt_ReferenteQuitar.ReadOnly = true;
            this.txt_ReferenteQuitar.Size = new System.Drawing.Size(344, 55);
            this.txt_ReferenteQuitar.TabIndex = 1;
            this.txt_ReferenteQuitar.TextChanged += new System.EventHandler(this.txt_ReferenteQuitar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Referente:";
            // 
            // txt_Multa
            // 
            this.txt_Multa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Multa.Location = new System.Drawing.Point(126, 229);
            this.txt_Multa.MaxLength = 10;
            this.txt_Multa.Name = "txt_Multa";
            this.txt_Multa.Size = new System.Drawing.Size(100, 26);
            this.txt_Multa.TabIndex = 6;
            this.txt_Multa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Multa.TextChanged += new System.EventHandler(this.txt_Multa_TextChanged);
            this.txt_Multa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Multa_KeyPress);
            this.txt_Multa.Leave += new System.EventHandler(this.txt_Multa_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Multa:";
            // 
            // txt_DescontoQuitar
            // 
            this.txt_DescontoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_DescontoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DescontoQuitar.Location = new System.Drawing.Point(429, 184);
            this.txt_DescontoQuitar.Name = "txt_DescontoQuitar";
            this.txt_DescontoQuitar.ReadOnly = true;
            this.txt_DescontoQuitar.Size = new System.Drawing.Size(100, 26);
            this.txt_DescontoQuitar.TabIndex = 5;
            this.txt_DescontoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DescontoQuitar.TextChanged += new System.EventHandler(this.txt_DescontoQuitar_TextChanged);
            this.txt_DescontoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescontoQuitar_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Desconto (R$):";
            // 
            // btn_PesquisarQuitar
            // 
            this.btn_PesquisarQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PesquisarQuitar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_PesquisarQuitar.Location = new System.Drawing.Point(509, 17);
            this.btn_PesquisarQuitar.Name = "btn_PesquisarQuitar";
            this.btn_PesquisarQuitar.Size = new System.Drawing.Size(110, 41);
            this.btn_PesquisarQuitar.TabIndex = 26;
            this.btn_PesquisarQuitar.UseVisualStyleBackColor = true;
            this.btn_PesquisarQuitar.Click += new System.EventHandler(this.btn_PesquisarQuitar_Click);
            // 
            // txt_ValorDocumentoQuitar
            // 
            this.txt_ValorDocumentoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_ValorDocumentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorDocumentoQuitar.Location = new System.Drawing.Point(206, 184);
            this.txt_ValorDocumentoQuitar.Name = "txt_ValorDocumentoQuitar";
            this.txt_ValorDocumentoQuitar.ReadOnly = true;
            this.txt_ValorDocumentoQuitar.Size = new System.Drawing.Size(100, 26);
            this.txt_ValorDocumentoQuitar.TabIndex = 4;
            this.txt_ValorDocumentoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorDocumentoQuitar.TextChanged += new System.EventHandler(this.txt_ValorDocumentoQuitar_TextChanged);
            this.txt_ValorDocumentoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorDocumentoQuitar_KeyPress);
            // 
            // txt_NumeroDocumentoQuitar
            // 
            this.txt_NumeroDocumentoQuitar.BackColor = System.Drawing.Color.White;
            this.txt_NumeroDocumentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NumeroDocumentoQuitar.Location = new System.Drawing.Point(232, 140);
            this.txt_NumeroDocumentoQuitar.Name = "txt_NumeroDocumentoQuitar";
            this.txt_NumeroDocumentoQuitar.ReadOnly = true;
            this.txt_NumeroDocumentoQuitar.Size = new System.Drawing.Size(141, 26);
            this.txt_NumeroDocumentoQuitar.TabIndex = 2;
            this.txt_NumeroDocumentoQuitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NumeroDocumentoQuitar.TextChanged += new System.EventHandler(this.txt_NumeroDocumentoQuitar_TextChanged);
            this.txt_NumeroDocumentoQuitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroDocumentoQuitar_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(379, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "Vencimento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(62, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Valor do documento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(62, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Número do documento:";
            // 
            // txt_BeneficiarioQuitar
            // 
            this.txt_BeneficiarioQuitar.BackColor = System.Drawing.Color.White;
            this.txt_BeneficiarioQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BeneficiarioQuitar.Location = new System.Drawing.Point(159, 25);
            this.txt_BeneficiarioQuitar.Name = "txt_BeneficiarioQuitar";
            this.txt_BeneficiarioQuitar.ReadOnly = true;
            this.txt_BeneficiarioQuitar.Size = new System.Drawing.Size(344, 26);
            this.txt_BeneficiarioQuitar.TabIndex = 0;
            this.txt_BeneficiarioQuitar.TextChanged += new System.EventHandler(this.txt_BeneficiarioQuitar_TextChanged);
            // 
            // mask_VencimentoQuitar
            // 
            this.mask_VencimentoQuitar.BackColor = System.Drawing.Color.White;
            this.mask_VencimentoQuitar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mask_VencimentoQuitar.Location = new System.Drawing.Point(477, 140);
            this.mask_VencimentoQuitar.Mask = "00/00/0000";
            this.mask_VencimentoQuitar.Name = "mask_VencimentoQuitar";
            this.mask_VencimentoQuitar.ReadOnly = true;
            this.mask_VencimentoQuitar.Size = new System.Drawing.Size(90, 26);
            this.mask_VencimentoQuitar.TabIndex = 3;
            this.mask_VencimentoQuitar.ValidatingType = typeof(System.DateTime);
            this.mask_VencimentoQuitar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_VencimentoQuitar_MaskInputRejected);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 19);
            this.label16.TabIndex = 18;
            this.label16.Text = "Beneficiário:";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCabecalho.BackColor = System.Drawing.Color.Gold;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Controls.Add(this.btn_Minimizar);
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Location = new System.Drawing.Point(-1, -1);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(714, 89);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Gold;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(671, 4);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 38);
            this.btn_Fechar.TabIndex = 563;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Gold;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimizar.Location = new System.Drawing.Point(625, 4);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 38);
            this.btn_Minimizar.TabIndex = 562;
            this.btn_Minimizar.Text = "__";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            this.btn_Minimizar.MouseEnter += new System.EventHandler(this.btn_Minimizar_MouseEnter);
            this.btn_Minimizar.MouseLeave += new System.EventHandler(this.btn_Minimizar_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema: Contas a pagar";
            // 
            // label1
            // 
            this.label1.Image = global::sistemaControleVendas.Properties.Resources.Contas_a_pagar_e_receber_300x227;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 64);
            this.label1.TabIndex = 0;
            // 
            // contasPagarTableAdapter
            // 
            this.contasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 478);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.FrmContasPagar_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.btnPesquisar.ResumeLayout(false);
            this.btnPesquisar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleVendaDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage btnPesquisar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_ValorDocumento;
        private System.Windows.Forms.TextBox txt_NumeroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Beneficiario;
        private System.Windows.Forms.MaskedTextBox mask_Vencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox txt_Referente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txt_ReferenteQuitar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Multa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_DescontoQuitar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_PesquisarQuitar;
        private System.Windows.Forms.TextBox txt_ValorDocumentoQuitar;
        private System.Windows.Forms.TextBox txt_NumeroDocumentoQuitar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_BeneficiarioQuitar;
        private System.Windows.Forms.MaskedTextBox mask_VencimentoQuitar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_LimparQuitar;
        private System.Windows.Forms.DataGridView dataGridView_Consulta;
        private DbControleVendaDataSet dbControleVendaDataSet;
        private System.Windows.Forms.BindingSource contasPagarBindingSource;
        private DbControleVendaDataSetTableAdapters.ContasPagarTableAdapter contasPagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn beneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
    }
}