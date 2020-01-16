namespace sistemaControleVendas
{
    partial class FrmVendaParcelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gropobox7 = new System.Windows.Forms.GroupBox();
            this.btn_GerarRepasse = new System.Windows.Forms.Button();
            this.dgv_Parcelas = new System.Windows.Forms.DataGridView();
            this.ColumnNParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_FinalizarParcelamento = new System.Windows.Forms.Button();
            this.btn_CancelarParcelamento = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_ValorTotalParcelas = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_GerarParcelamento = new System.Windows.Forms.Button();
            this.txt_ValorParcela = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Juros = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_NumeroParcelas = new System.Windows.Forms.TextBox();
            this.txt_ValorVenda = new System.Windows.Forms.TextBox();
            this.txt_ValorEntrada = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_Separador = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.lbl_FecharParcelamento = new System.Windows.Forms.Label();
            this.gropobox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gropobox7
            // 
            this.gropobox7.BackColor = System.Drawing.Color.Transparent;
            this.gropobox7.Controls.Add(this.btn_GerarRepasse);
            this.gropobox7.Controls.Add(this.dgv_Parcelas);
            this.gropobox7.Controls.Add(this.btn_FinalizarParcelamento);
            this.gropobox7.Controls.Add(this.btn_CancelarParcelamento);
            this.gropobox7.Controls.Add(this.groupBox9);
            this.gropobox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropobox7.ForeColor = System.Drawing.Color.White;
            this.gropobox7.Location = new System.Drawing.Point(510, 33);
            this.gropobox7.Name = "gropobox7";
            this.gropobox7.Size = new System.Drawing.Size(532, 361);
            this.gropobox7.TabIndex = 16;
            this.gropobox7.TabStop = false;
            this.gropobox7.Text = "Parcelas";
            // 
            // btn_GerarRepasse
            // 
            this.btn_GerarRepasse.Enabled = false;
            this.btn_GerarRepasse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarRepasse.ForeColor = System.Drawing.Color.Black;
            this.btn_GerarRepasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GerarRepasse.Location = new System.Drawing.Point(13, 292);
            this.btn_GerarRepasse.Name = "btn_GerarRepasse";
            this.btn_GerarRepasse.Size = new System.Drawing.Size(162, 60);
            this.btn_GerarRepasse.TabIndex = 17;
            this.btn_GerarRepasse.Text = "Gerar Repasse - [F9]";
            this.btn_GerarRepasse.UseVisualStyleBackColor = true;
            // 
            // dgv_Parcelas
            // 
            this.dgv_Parcelas.AllowUserToAddRows = false;
            this.dgv_Parcelas.AllowUserToDeleteRows = false;
            this.dgv_Parcelas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Parcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Parcelas.ColumnHeadersHeight = 30;
            this.dgv_Parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNParcelas,
            this.ColumnVencimento,
            this.ColumnValorParcela});
            this.dgv_Parcelas.Location = new System.Drawing.Point(61, 32);
            this.dgv_Parcelas.Name = "dgv_Parcelas";
            this.dgv_Parcelas.ReadOnly = true;
            this.dgv_Parcelas.Size = new System.Drawing.Size(413, 184);
            this.dgv_Parcelas.TabIndex = 15;
            // 
            // ColumnNParcelas
            // 
            this.ColumnNParcelas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            this.ColumnNParcelas.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColumnNParcelas.HeaderText = "Nº da parcela";
            this.ColumnNParcelas.Name = "ColumnNParcelas";
            this.ColumnNParcelas.ReadOnly = true;
            this.ColumnNParcelas.Width = 124;
            // 
            // ColumnVencimento
            // 
            this.ColumnVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.ColumnVencimento.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColumnVencimento.HeaderText = "Vencimento";
            this.ColumnVencimento.Name = "ColumnVencimento";
            this.ColumnVencimento.ReadOnly = true;
            this.ColumnVencimento.Width = 112;
            // 
            // ColumnValorParcela
            // 
            this.ColumnValorParcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = null;
            this.ColumnValorParcela.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColumnValorParcela.HeaderText = "Valor da Parcela";
            this.ColumnValorParcela.Name = "ColumnValorParcela";
            this.ColumnValorParcela.ReadOnly = true;
            // 
            // btn_FinalizarParcelamento
            // 
            this.btn_FinalizarParcelamento.Enabled = false;
            this.btn_FinalizarParcelamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinalizarParcelamento.ForeColor = System.Drawing.Color.Black;
            this.btn_FinalizarParcelamento.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_FinalizarParcelamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FinalizarParcelamento.Location = new System.Drawing.Point(343, 292);
            this.btn_FinalizarParcelamento.Name = "btn_FinalizarParcelamento";
            this.btn_FinalizarParcelamento.Size = new System.Drawing.Size(164, 60);
            this.btn_FinalizarParcelamento.TabIndex = 13;
            this.btn_FinalizarParcelamento.Text = "Finalizar - [F10]";
            this.btn_FinalizarParcelamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_FinalizarParcelamento.UseVisualStyleBackColor = true;
            this.btn_FinalizarParcelamento.Click += new System.EventHandler(this.btn_FinalizarParcelamento_Click);
            // 
            // btn_CancelarParcelamento
            // 
            this.btn_CancelarParcelamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarParcelamento.ForeColor = System.Drawing.Color.Black;
            this.btn_CancelarParcelamento.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_CancelarParcelamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarParcelamento.Location = new System.Drawing.Point(175, 292);
            this.btn_CancelarParcelamento.Name = "btn_CancelarParcelamento";
            this.btn_CancelarParcelamento.Size = new System.Drawing.Size(162, 60);
            this.btn_CancelarParcelamento.TabIndex = 14;
            this.btn_CancelarParcelamento.Text = "Cancelar - [ESC]";
            this.btn_CancelarParcelamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarParcelamento.UseVisualStyleBackColor = true;
            this.btn_CancelarParcelamento.Click += new System.EventHandler(this.btn_CancelarParcelamento_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_ValorTotalParcelas);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(202, 222);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(178, 55);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Valor do Parcelamento";
            // 
            // txt_ValorTotalParcelas
            // 
            this.txt_ValorTotalParcelas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorTotalParcelas.Location = new System.Drawing.Point(27, 23);
            this.txt_ValorTotalParcelas.Name = "txt_ValorTotalParcelas";
            this.txt_ValorTotalParcelas.ReadOnly = true;
            this.txt_ValorTotalParcelas.Size = new System.Drawing.Size(122, 26);
            this.txt_ValorTotalParcelas.TabIndex = 13;
            this.txt_ValorTotalParcelas.Text = "R$ 0,00";
            this.txt_ValorTotalParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_GerarParcelamento);
            this.groupBox7.Controls.Add(this.txt_ValorParcela);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txt_Juros);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txt_NumeroParcelas);
            this.groupBox7.Controls.Add(this.txt_ValorVenda);
            this.groupBox7.Controls.Add(this.txt_ValorEntrada);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(8, 157);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(485, 237);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Parcelamentos";
            // 
            // btn_GerarParcelamento
            // 
            this.btn_GerarParcelamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarParcelamento.ForeColor = System.Drawing.Color.Black;
            this.btn_GerarParcelamento.Image = global::sistemaControleVendas.Properties.Resources.parcelas1;
            this.btn_GerarParcelamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GerarParcelamento.Location = new System.Drawing.Point(74, 184);
            this.btn_GerarParcelamento.Name = "btn_GerarParcelamento";
            this.btn_GerarParcelamento.Size = new System.Drawing.Size(299, 42);
            this.btn_GerarParcelamento.TabIndex = 12;
            this.btn_GerarParcelamento.Text = "Gerar Parcelamento";
            this.btn_GerarParcelamento.UseVisualStyleBackColor = true;
            this.btn_GerarParcelamento.Click += new System.EventHandler(this.btn_GerarParcelamento_Click);
            // 
            // txt_ValorParcela
            // 
            this.txt_ValorParcela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorParcela.Location = new System.Drawing.Point(251, 97);
            this.txt_ValorParcela.Name = "txt_ValorParcela";
            this.txt_ValorParcela.ReadOnly = true;
            this.txt_ValorParcela.Size = new System.Drawing.Size(122, 26);
            this.txt_ValorParcela.TabIndex = 11;
            this.txt_ValorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(247, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 19);
            this.label18.TabIndex = 10;
            this.label18.Text = "Valor da Parcela:";
            // 
            // txt_Juros
            // 
            this.txt_Juros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Juros.Location = new System.Drawing.Point(77, 95);
            this.txt_Juros.Name = "txt_Juros";
            this.txt_Juros.Size = new System.Drawing.Size(122, 26);
            this.txt_Juros.TabIndex = 7;
            this.txt_Juros.Text = "0,00";
            this.txt_Juros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Juros.TextChanged += new System.EventHandler(this.txt_Juros_TextChanged);
            this.txt_Juros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Juros_KeyPress);
            this.txt_Juros.Leave += new System.EventHandler(this.txt_Juros_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(73, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "Juros:";
            // 
            // txt_NumeroParcelas
            // 
            this.txt_NumeroParcelas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroParcelas.Location = new System.Drawing.Point(251, 47);
            this.txt_NumeroParcelas.Name = "txt_NumeroParcelas";
            this.txt_NumeroParcelas.Size = new System.Drawing.Size(122, 26);
            this.txt_NumeroParcelas.TabIndex = 5;
            this.txt_NumeroParcelas.Text = "1";
            this.txt_NumeroParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NumeroParcelas.TextChanged += new System.EventHandler(this.txt_NumeroParcelas_TextChanged);
            this.txt_NumeroParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumeroParcelas_KeyPress);
            this.txt_NumeroParcelas.Leave += new System.EventHandler(this.txt_NumeroParcelas_Leave);
            // 
            // txt_ValorVenda
            // 
            this.txt_ValorVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorVenda.Location = new System.Drawing.Point(78, 146);
            this.txt_ValorVenda.Name = "txt_ValorVenda";
            this.txt_ValorVenda.ReadOnly = true;
            this.txt_ValorVenda.Size = new System.Drawing.Size(122, 26);
            this.txt_ValorVenda.TabIndex = 4;
            this.txt_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ValorEntrada
            // 
            this.txt_ValorEntrada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorEntrada.Location = new System.Drawing.Point(77, 47);
            this.txt_ValorEntrada.Name = "txt_ValorEntrada";
            this.txt_ValorEntrada.Size = new System.Drawing.Size(123, 26);
            this.txt_ValorEntrada.TabIndex = 3;
            this.txt_ValorEntrada.Text = "0,00";
            this.txt_ValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorEntrada.TextChanged += new System.EventHandler(this.txt_ValorEntrada_TextChanged);
            this.txt_ValorEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorEntrada_KeyPress);
            this.txt_ValorEntrada.Leave += new System.EventHandler(this.txt_ValorEntrada_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(247, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nº Parcelas:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(74, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Valor Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(73, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Valor de Entrada:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_Separador);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.lbl_Codigo);
            this.groupBox6.Controls.Add(this.lbl_Nome);
            this.groupBox6.Location = new System.Drawing.Point(7, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(486, 68);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // lbl_Separador
            // 
            this.lbl_Separador.AutoSize = true;
            this.lbl_Separador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Separador.ForeColor = System.Drawing.Color.White;
            this.lbl_Separador.Location = new System.Drawing.Point(59, 37);
            this.lbl_Separador.Name = "lbl_Separador";
            this.lbl_Separador.Size = new System.Drawing.Size(12, 19);
            this.lbl_Separador.TabIndex = 13;
            this.lbl_Separador.Text = "|";
            this.lbl_Separador.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(59, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 19);
            this.label21.TabIndex = 12;
            this.label21.Text = "|";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 19);
            this.label19.TabIndex = 11;
            this.label19.Text = "Código";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(71, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 19);
            this.label20.TabIndex = 10;
            this.label20.Text = "Nome";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.ForeColor = System.Drawing.Color.White;
            this.lbl_Codigo.Location = new System.Drawing.Point(6, 37);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(0, 19);
            this.lbl_Codigo.TabIndex = 9;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome.Location = new System.Drawing.Point(74, 37);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(0, 19);
            this.lbl_Nome.TabIndex = 8;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(399, 38);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(105, 43);
            this.btn_Pesquisar.TabIndex = 13;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nome do cliente";
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(7, 47);
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.ReadOnly = true;
            this.txt_Busca.Size = new System.Drawing.Size(386, 26);
            this.txt_Busca.TabIndex = 11;
            this.txt_Busca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Busca_KeyDown);
            // 
            // lbl_FecharParcelamento
            // 
            this.lbl_FecharParcelamento.AutoSize = true;
            this.lbl_FecharParcelamento.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FecharParcelamento.ForeColor = System.Drawing.Color.White;
            this.lbl_FecharParcelamento.Location = new System.Drawing.Point(1030, 3);
            this.lbl_FecharParcelamento.Name = "lbl_FecharParcelamento";
            this.lbl_FecharParcelamento.Size = new System.Drawing.Size(33, 31);
            this.lbl_FecharParcelamento.TabIndex = 10;
            this.lbl_FecharParcelamento.Text = "X";
            this.lbl_FecharParcelamento.Click += new System.EventHandler(this.lbl_FecharParcelamento_Click);
            this.lbl_FecharParcelamento.MouseEnter += new System.EventHandler(this.lbl_FecharParcelamento_MouseEnter);
            this.lbl_FecharParcelamento.MouseLeave += new System.EventHandler(this.lbl_FecharParcelamento_MouseLeave);
            // 
            // FrmVendaParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1066, 396);
            this.Controls.Add(this.gropobox7);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_Busca);
            this.Controls.Add(this.lbl_FecharParcelamento);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVendaParcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVendaParcelas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVendaParcelas_KeyDown);
            this.gropobox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gropobox7;
        private System.Windows.Forms.Button btn_GerarRepasse;
        private System.Windows.Forms.DataGridView dgv_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorParcela;
        private System.Windows.Forms.Button btn_FinalizarParcelamento;
        private System.Windows.Forms.Button btn_CancelarParcelamento;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txt_ValorTotalParcelas;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_GerarParcelamento;
        private System.Windows.Forms.TextBox txt_ValorParcela;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Juros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_NumeroParcelas;
        private System.Windows.Forms.TextBox txt_ValorVenda;
        private System.Windows.Forms.TextBox txt_ValorEntrada;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_Separador;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Busca;
        private System.Windows.Forms.Label lbl_FecharParcelamento;
    }
}