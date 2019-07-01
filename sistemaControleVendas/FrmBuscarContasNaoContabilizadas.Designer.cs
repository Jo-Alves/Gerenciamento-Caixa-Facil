namespace sistemaControleVendas
{
    partial class FrmBuscarContasNaoContabilizadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarContasNaoContabilizadas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 427);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Sistema Contas não contabilzadas";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(627, 11);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 38);
            this.btn_Fechar.TabIndex = 59;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_Minimizar.Location = new System.Drawing.Point(587, 11);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 38);
            this.btn_Minimizar.TabIndex = 58;
            this.btn_Minimizar.Text = "__";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            this.btn_Minimizar.MouseEnter += new System.EventHandler(this.btn_Minimizar_MouseEnter);
            this.btn_Minimizar.MouseLeave += new System.EventHandler(this.btn_Minimizar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvContas);
            this.panel2.Location = new System.Drawing.Point(-1, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 441);
            this.panel2.TabIndex = 0;
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.BackgroundColor = System.Drawing.Color.White;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColBairro,
            this.ColEndereco,
            this.ColNumero,
            this.ColValorConta,
            this.ColDataConta});
            this.dgvContas.Location = new System.Drawing.Point(3, 54);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(675, 290);
            this.dgvContas.TabIndex = 0;
            this.dgvContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellClick);
            this.dgvContas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvContas_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(190, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(335, 26);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColId.DataPropertyName = "id";
            this.ColId.HeaderText = "";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 19;
            // 
            // ColNome
            // 
            this.ColNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNome.DataPropertyName = "Nome_Cliente";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 72;
            // 
            // ColBairro
            // 
            this.ColBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBairro.DataPropertyName = "Bairro_Cliente";
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Width = 72;
            // 
            // ColEndereco
            // 
            this.ColEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEndereco.DataPropertyName = "Endereco_Cliente";
            this.ColEndereco.HeaderText = "Endereço";
            this.ColEndereco.Name = "ColEndereco";
            this.ColEndereco.ReadOnly = true;
            this.ColEndereco.Width = 92;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumero.DataPropertyName = "Numero_Cliente";
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 84;
            // 
            // ColValorConta
            // 
            this.ColValorConta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValorConta.DataPropertyName = "Valor_Conta";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ColValorConta.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColValorConta.HeaderText = "Valor da Conta";
            this.ColValorConta.Name = "ColValorConta";
            this.ColValorConta.ReadOnly = true;
            this.ColValorConta.Width = 126;
            // 
            // ColDataConta
            // 
            this.ColDataConta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataConta.DataPropertyName = "Data_Conta";
            this.ColDataConta.HeaderText = "Data da Conta";
            this.ColDataConta.Name = "ColDataConta";
            this.ColDataConta.ReadOnly = true;
            this.ColDataConta.Width = 123;
            // 
            // FrmBuscarContasNaoContabilizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 427);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarContasNaoContabilizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Contas não contabilzadas";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataConta;
    }
}