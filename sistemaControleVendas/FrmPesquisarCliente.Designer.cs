namespace sistemaControleVendas
{
    partial class FrmPesquisarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_Fechar);
            this.panel3.Location = new System.Drawing.Point(4, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 89);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Pesquisar Clientes";
            // 
            // label3
            // 
            this.label3.Image = global::sistemaControleVendas.Properties.Resources.User_Clients_icon;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 89);
            this.label3.TabIndex = 58;
            this.label3.Text = "     ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(1002, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 38);
            this.btn_Fechar.TabIndex = 57;
            this.btn_Fechar.Text = "X";
            this.toolTip1.SetToolTip(this.btn_Fechar, "Fechar");
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Nome);
            this.panel2.Controls.Add(this.dgv_Busca);
            this.panel2.Location = new System.Drawing.Point(5, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 511);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(297, 17);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(437, 26);
            this.txt_Nome.TabIndex = 2;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Busca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Busca.ColumnHeadersHeight = 27;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnDataNascimento,
            this.ColumnCPF,
            this.ColumnRG,
            this.ColumnCEP,
            this.ColumnBairro,
            this.ColumnEndereco,
            this.ColumnNumero,
            this.ColumnCidade,
            this.ColumnEstado,
            this.ColumnTelefone,
            this.ColumnCelular,
            this.ColumnEmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Busca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Busca.Location = new System.Drawing.Point(6, 57);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Busca.Size = new System.Drawing.Size(1025, 424);
            this.dgv_Busca.TabIndex = 0;
            this.dgv_Busca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Busca_CellClick);
            this.dgv_Busca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_Busca_DataBindingComplete);
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnID.DataPropertyName = "Id_Cliente";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 49;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "NOME";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 73;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDataNascimento.DataPropertyName = "DataNascimento";
            this.ColumnDataNascimento.HeaderText = "DATA DE NASCIMENTO";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            this.ColumnDataNascimento.Width = 185;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCPF.DataPropertyName = "CPF";
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            this.ColumnCPF.Width = 59;
            // 
            // ColumnRG
            // 
            this.ColumnRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRG.DataPropertyName = "RG";
            this.ColumnRG.HeaderText = "RG";
            this.ColumnRG.Name = "ColumnRG";
            this.ColumnRG.ReadOnly = true;
            this.ColumnRG.Width = 53;
            // 
            // ColumnCEP
            // 
            this.ColumnCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCEP.DataPropertyName = "CEP";
            this.ColumnCEP.HeaderText = "CEP";
            this.ColumnCEP.Name = "ColumnCEP";
            this.ColumnCEP.ReadOnly = true;
            this.ColumnCEP.Width = 59;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnBairro.DataPropertyName = "Bairro";
            this.ColumnBairro.HeaderText = "BAIRRO";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            this.ColumnBairro.Width = 89;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEndereco.DataPropertyName = "Endereco";
            this.ColumnEndereco.HeaderText = "ENDEREÇO";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.ReadOnly = true;
            this.ColumnEndereco.Width = 107;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNumero.DataPropertyName = "Numero";
            this.ColumnNumero.HeaderText = "NÚMERO";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            this.ColumnNumero.Width = 93;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCidade.DataPropertyName = "Cidade";
            this.ColumnCidade.HeaderText = "CIDADE";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            this.ColumnCidade.Width = 87;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEstado.DataPropertyName = "Estado";
            this.ColumnEstado.HeaderText = "ESTADO";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Width = 87;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTelefone.DataPropertyName = "Telefone";
            this.ColumnTelefone.HeaderText = "TELEFONE";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            this.ColumnTelefone.Width = 102;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCelular.DataPropertyName = "Celular";
            this.ColumnCelular.HeaderText = "CELULAR";
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            this.ColumnCelular.Width = 98;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEmail.DataPropertyName = "Email";
            this.ColumnEmail.HeaderText = "E-MAIL";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 83;
            // 
            // FrmPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.Load += new System.EventHandler(this.FrmPesquisarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
    }
}