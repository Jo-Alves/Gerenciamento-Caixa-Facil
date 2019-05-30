namespace sistemaControleVendas
{
    partial class FrmPagamentoCartao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_DescontoPorcento = new System.Windows.Forms.TextBox();
            this.lblDescontoPorcento = new System.Windows.Forms.Label();
            this.txt_DescontoDinheiro = new System.Windows.Forms.TextBox();
            this.txt_ValorDesconto = new System.Windows.Forms.TextBox();
            this.lblValorDesconto = new System.Windows.Forms.Label();
            this.lblDescontoDinheiro = new System.Windows.Forms.Label();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNParcelas = new System.Windows.Forms.TextBox();
            this.dgv_Parcelas = new System.Windows.Forms.DataGridView();
            this.ColumnNParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbValorParcela = new System.Windows.Forms.GroupBox();
            this.txt_ValorTotalParcelas = new System.Windows.Forms.TextBox();
            this.btn_NotaPromissoria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).BeginInit();
            this.gbValorParcela.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(590, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(33, 31);
            this.lbl_Fechar.TabIndex = 309;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Finalizar.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Finalizar.Location = new System.Drawing.Point(413, 618);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(164, 60);
            this.btn_Finalizar.TabIndex = 311;
            this.btn_Finalizar.Text = "Finalizar - [F10]";
            this.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(33, 618);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(162, 60);
            this.btn_Cancelar.TabIndex = 312;
            this.btn_Cancelar.Text = "Cancelar - [ESC]";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_DescontoPorcento);
            this.groupBox1.Controls.Add(this.lblDescontoPorcento);
            this.groupBox1.Controls.Add(this.txt_DescontoDinheiro);
            this.groupBox1.Controls.Add(this.txt_ValorDesconto);
            this.groupBox1.Controls.Add(this.lblValorDesconto);
            this.groupBox1.Controls.Add(this.lblDescontoDinheiro);
            this.groupBox1.Controls.Add(this.lbl_ValorTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 165);
            this.groupBox1.TabIndex = 314;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor da venda";
            // 
            // txt_DescontoPorcento
            // 
            this.txt_DescontoPorcento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescontoPorcento.Location = new System.Drawing.Point(28, 114);
            this.txt_DescontoPorcento.Name = "txt_DescontoPorcento";
            this.txt_DescontoPorcento.Size = new System.Drawing.Size(147, 26);
            this.txt_DescontoPorcento.TabIndex = 313;
            this.txt_DescontoPorcento.Text = "0,00";
            this.txt_DescontoPorcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DescontoPorcento.TextChanged += new System.EventHandler(this.txt_DescontoPorcento_TextChanged);
            this.txt_DescontoPorcento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescontoPorcento_KeyPress);
            this.txt_DescontoPorcento.Leave += new System.EventHandler(this.txt_DescontoPorcento_Leave);
            // 
            // lblDescontoPorcento
            // 
            this.lblDescontoPorcento.AutoSize = true;
            this.lblDescontoPorcento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoPorcento.ForeColor = System.Drawing.Color.White;
            this.lblDescontoPorcento.Location = new System.Drawing.Point(29, 89);
            this.lblDescontoPorcento.Name = "lblDescontoPorcento";
            this.lblDescontoPorcento.Size = new System.Drawing.Size(97, 19);
            this.lblDescontoPorcento.TabIndex = 315;
            this.lblDescontoPorcento.Text = "Desconto -%";
            // 
            // txt_DescontoDinheiro
            // 
            this.txt_DescontoDinheiro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescontoDinheiro.Location = new System.Drawing.Point(184, 114);
            this.txt_DescontoDinheiro.Name = "txt_DescontoDinheiro";
            this.txt_DescontoDinheiro.Size = new System.Drawing.Size(147, 26);
            this.txt_DescontoDinheiro.TabIndex = 314;
            this.txt_DescontoDinheiro.Text = "0,00";
            this.txt_DescontoDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DescontoDinheiro.TextChanged += new System.EventHandler(this.txt_DescontoDinheiro_TextChanged);
            this.txt_DescontoDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DescontoDinheiro_KeyPress);
            this.txt_DescontoDinheiro.Leave += new System.EventHandler(this.txt_DescontoDinheiro_Leave);
            // 
            // txt_ValorDesconto
            // 
            this.txt_ValorDesconto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorDesconto.Location = new System.Drawing.Point(349, 114);
            this.txt_ValorDesconto.Name = "txt_ValorDesconto";
            this.txt_ValorDesconto.ReadOnly = true;
            this.txt_ValorDesconto.Size = new System.Drawing.Size(144, 26);
            this.txt_ValorDesconto.TabIndex = 316;
            this.txt_ValorDesconto.Text = "0,00";
            this.txt_ValorDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.AutoSize = true;
            this.lblValorDesconto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDesconto.ForeColor = System.Drawing.Color.White;
            this.lblValorDesconto.Location = new System.Drawing.Point(333, 92);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(172, 19);
            this.lblValorDesconto.TabIndex = 312;
            this.lblValorDesconto.Text = "Valor com desconto - R$";
            // 
            // lblDescontoDinheiro
            // 
            this.lblDescontoDinheiro.AutoSize = true;
            this.lblDescontoDinheiro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoDinheiro.ForeColor = System.Drawing.Color.White;
            this.lblDescontoDinheiro.Location = new System.Drawing.Point(185, 89);
            this.lblDescontoDinheiro.Name = "lblDescontoDinheiro";
            this.lblDescontoDinheiro.Size = new System.Drawing.Size(105, 19);
            this.lblDescontoDinheiro.TabIndex = 311;
            this.lblDescontoDinheiro.Text = "Desconto - R$";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.BackColor = System.Drawing.Color.White;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(123, 49);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(155, 31);
            this.lbl_ValorTotal.TabIndex = 310;
            this.lbl_ValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(124, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 309;
            this.label10.Text = "Valor Total da Venda:";
            // 
            // gbParcelas
            // 
            this.gbParcelas.Controls.Add(this.btnGerarParcelas);
            this.gbParcelas.Controls.Add(this.label1);
            this.gbParcelas.Controls.Add(this.txtNParcelas);
            this.gbParcelas.Controls.Add(this.dgv_Parcelas);
            this.gbParcelas.Controls.Add(this.gbValorParcela);
            this.gbParcelas.ForeColor = System.Drawing.Color.White;
            this.gbParcelas.Location = new System.Drawing.Point(41, 216);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(536, 396);
            this.gbParcelas.TabIndex = 315;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.ForeColor = System.Drawing.Color.Black;
            this.btnGerarParcelas.Location = new System.Drawing.Point(84, 334);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(370, 45);
            this.btnGerarParcelas.TabIndex = 317;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 316;
            this.label1.Text = "Nº Parcela:";
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNParcelas.Location = new System.Drawing.Point(52, 41);
            this.txtNParcelas.MaxLength = 2;
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(122, 26);
            this.txtNParcelas.TabIndex = 14;
            this.txtNParcelas.Text = "1";
            this.txtNParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNParcelas.TextChanged += new System.EventHandler(this.txtNParcelas_TextChanged);
            this.txtNParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNParcelas_KeyPress);
            // 
            // dgv_Parcelas
            // 
            this.dgv_Parcelas.AllowUserToDeleteRows = false;
            this.dgv_Parcelas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Parcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Parcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_Parcelas.ColumnHeadersHeight = 30;
            this.dgv_Parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNParcelas,
            this.ColumnVencimento,
            this.ColumnValorParcela});
            this.dgv_Parcelas.Location = new System.Drawing.Point(52, 73);
            this.dgv_Parcelas.Name = "dgv_Parcelas";
            this.dgv_Parcelas.ReadOnly = true;
            this.dgv_Parcelas.Size = new System.Drawing.Size(413, 184);
            this.dgv_Parcelas.TabIndex = 315;
            // 
            // ColumnNParcelas
            // 
            this.ColumnNParcelas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.ColumnNParcelas.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnNParcelas.HeaderText = "Nº da parcela";
            this.ColumnNParcelas.Name = "ColumnNParcelas";
            this.ColumnNParcelas.ReadOnly = true;
            this.ColumnNParcelas.Width = 124;
            // 
            // ColumnVencimento
            // 
            this.ColumnVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.ColumnVencimento.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumnVencimento.HeaderText = "Vencimento";
            this.ColumnVencimento.Name = "ColumnVencimento";
            this.ColumnVencimento.ReadOnly = true;
            this.ColumnVencimento.Width = 112;
            // 
            // ColumnValorParcela
            // 
            this.ColumnValorParcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.ColumnValorParcela.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColumnValorParcela.HeaderText = "Valor da Parcela";
            this.ColumnValorParcela.Name = "ColumnValorParcela";
            this.ColumnValorParcela.ReadOnly = true;
            // 
            // gbValorParcela
            // 
            this.gbValorParcela.Controls.Add(this.txt_ValorTotalParcelas);
            this.gbValorParcela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValorParcela.ForeColor = System.Drawing.Color.White;
            this.gbValorParcela.Location = new System.Drawing.Point(184, 273);
            this.gbValorParcela.Name = "gbValorParcela";
            this.gbValorParcela.Size = new System.Drawing.Size(178, 55);
            this.gbValorParcela.TabIndex = 314;
            this.gbValorParcela.TabStop = false;
            this.gbValorParcela.Text = "Valor do Parcelamento";
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
            // btn_NotaPromissoria
            // 
            this.btn_NotaPromissoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NotaPromissoria.ForeColor = System.Drawing.Color.Black;
            this.btn_NotaPromissoria.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_NotaPromissoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NotaPromissoria.Location = new System.Drawing.Point(201, 618);
            this.btn_NotaPromissoria.Name = "btn_NotaPromissoria";
            this.btn_NotaPromissoria.Size = new System.Drawing.Size(206, 60);
            this.btn_NotaPromissoria.TabIndex = 316;
            this.btn_NotaPromissoria.Text = "Nota Promissória - [F9]";
            this.btn_NotaPromissoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NotaPromissoria.UseVisualStyleBackColor = true;
            this.btn_NotaPromissoria.Click += new System.EventHandler(this.btn_NotaPromissoria_Click);
            // 
            // FrmPagamentoCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(625, 690);
            this.Controls.Add(this.btn_NotaPromissoria);
            this.Controls.Add(this.gbParcelas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Fechar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagamentoCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor da venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagamentoCartao_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).EndInit();
            this.gbValorParcela.ResumeLayout(false);
            this.gbValorParcela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_DescontoPorcento;
        private System.Windows.Forms.Label lblDescontoPorcento;
        private System.Windows.Forms.TextBox txt_DescontoDinheiro;
        private System.Windows.Forms.TextBox txt_ValorDesconto;
        private System.Windows.Forms.Label lblValorDesconto;
        private System.Windows.Forms.Label lblDescontoDinheiro;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNParcelas;
        private System.Windows.Forms.DataGridView dgv_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorParcela;
        private System.Windows.Forms.GroupBox gbValorParcela;
        private System.Windows.Forms.TextBox txt_ValorTotalParcelas;
        private System.Windows.Forms.Button btn_NotaPromissoria;
    }
}