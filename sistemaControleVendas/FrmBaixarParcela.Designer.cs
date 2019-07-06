namespace sistemaControleVendas
{
    partial class FrmBaixarParcela
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
            this.panelPagamentoParcela = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NParcelas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CodigoVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_valorParcela = new System.Windows.Forms.TextBox();
            this.txt_Vencimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.btn_Baixa = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaAbatimento = new System.Windows.Forms.ComboBox();
            this.panelPagamentoParcela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPagamentoParcela
            // 
            this.panelPagamentoParcela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelPagamentoParcela.Controls.Add(this.label2);
            this.panelPagamentoParcela.Controls.Add(this.cbFormaAbatimento);
            this.panelPagamentoParcela.Controls.Add(this.lbl_Fechar);
            this.panelPagamentoParcela.Controls.Add(this.label9);
            this.panelPagamentoParcela.Controls.Add(this.txt_NParcelas);
            this.panelPagamentoParcela.Controls.Add(this.label8);
            this.panelPagamentoParcela.Controls.Add(this.txt_CodigoVenda);
            this.panelPagamentoParcela.Controls.Add(this.label7);
            this.panelPagamentoParcela.Controls.Add(this.txt_valorParcela);
            this.panelPagamentoParcela.Controls.Add(this.txt_Vencimento);
            this.panelPagamentoParcela.Controls.Add(this.label6);
            this.panelPagamentoParcela.Controls.Add(this.label5);
            this.panelPagamentoParcela.Controls.Add(this.txt_Nome);
            this.panelPagamentoParcela.Controls.Add(this.label4);
            this.panelPagamentoParcela.Controls.Add(this.txt_CodigoCliente);
            this.panelPagamentoParcela.Controls.Add(this.btn_Baixa);
            this.panelPagamentoParcela.Controls.Add(this.btn_Cancelar);
            this.panelPagamentoParcela.Controls.Add(this.label3);
            this.panelPagamentoParcela.Controls.Add(this.txt_Troco);
            this.panelPagamentoParcela.Controls.Add(this.label1);
            this.panelPagamentoParcela.Controls.Add(this.txt_ValorPago);
            this.panelPagamentoParcela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPagamentoParcela.Location = new System.Drawing.Point(0, 0);
            this.panelPagamentoParcela.Margin = new System.Windows.Forms.Padding(4);
            this.panelPagamentoParcela.Name = "panelPagamentoParcela";
            this.panelPagamentoParcela.Size = new System.Drawing.Size(534, 291);
            this.panelPagamentoParcela.TabIndex = 0;
            this.panelPagamentoParcela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPagamentoParcela_MouseDown);
            this.panelPagamentoParcela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPagamentoParcela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(511, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 42;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(361, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nº Parcela:";
            // 
            // txt_NParcelas
            // 
            this.txt_NParcelas.Location = new System.Drawing.Point(365, 94);
            this.txt_NParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NParcelas.Name = "txt_NParcelas";
            this.txt_NParcelas.ReadOnly = true;
            this.txt_NParcelas.Size = new System.Drawing.Size(81, 26);
            this.txt_NParcelas.TabIndex = 40;
            this.txt_NParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(272, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cód Venda:";
            // 
            // txt_CodigoVenda
            // 
            this.txt_CodigoVenda.Location = new System.Drawing.Point(276, 94);
            this.txt_CodigoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoVenda.Name = "txt_CodigoVenda";
            this.txt_CodigoVenda.ReadOnly = true;
            this.txt_CodigoVenda.Size = new System.Drawing.Size(81, 26);
            this.txt_CodigoVenda.TabIndex = 38;
            this.txt_CodigoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(140, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Valor da parcela:";
            // 
            // txt_valorParcela
            // 
            this.txt_valorParcela.Location = new System.Drawing.Point(147, 94);
            this.txt_valorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valorParcela.Name = "txt_valorParcela";
            this.txt_valorParcela.ReadOnly = true;
            this.txt_valorParcela.Size = new System.Drawing.Size(122, 26);
            this.txt_valorParcela.TabIndex = 36;
            this.txt_valorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Vencimento
            // 
            this.txt_Vencimento.Location = new System.Drawing.Point(59, 94);
            this.txt_Vencimento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Vencimento.Name = "txt_Vencimento";
            this.txt_Vencimento.ReadOnly = true;
            this.txt_Vencimento.Size = new System.Drawing.Size(83, 26);
            this.txt_Vencimento.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Vencimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(150, 35);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(371, 26);
            this.txt_Nome.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cód Cliente:";
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Location = new System.Drawing.Point(13, 35);
            this.txt_CodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.ReadOnly = true;
            this.txt_CodigoCliente.Size = new System.Drawing.Size(121, 26);
            this.txt_CodigoCliente.TabIndex = 30;
            this.txt_CodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Baixa
            // 
            this.btn_Baixa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baixa.ForeColor = System.Drawing.Color.Black;
            this.btn_Baixa.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Baixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Baixa.Location = new System.Drawing.Point(248, 208);
            this.btn_Baixa.Name = "btn_Baixa";
            this.btn_Baixa.Size = new System.Drawing.Size(164, 60);
            this.btn_Baixa.TabIndex = 27;
            this.btn_Baixa.Text = "Dar Baixa- [F10]";
            this.btn_Baixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Baixa.UseVisualStyleBackColor = true;
            this.btn_Baixa.Click += new System.EventHandler(this.btn_Baixa_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(86, 208);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(162, 60);
            this.btn_Cancelar.TabIndex = 28;
            this.btn_Cancelar.Text = "Cancelar - [ESC]";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Troco:";
            // 
            // txt_Troco
            // 
            this.txt_Troco.Location = new System.Drawing.Point(179, 150);
            this.txt_Troco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.ReadOnly = true;
            this.txt_Troco.Size = new System.Drawing.Size(148, 26);
            this.txt_Troco.TabIndex = 24;
            this.txt_Troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor Pago:";
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Location = new System.Drawing.Point(23, 150);
            this.txt_ValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(148, 26);
            this.txt_ValorPago.TabIndex = 20;
            this.txt_ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            this.txt_ValorPago.Leave += new System.EventHandler(this.txt_ValorPago_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Forma de abatimento:";
            // 
            // cbFormaAbatimento
            // 
            this.cbFormaAbatimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaAbatimento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFormaAbatimento.FormattingEnabled = true;
            this.cbFormaAbatimento.Items.AddRange(new object[] {
            "CRÉDITO",
            "DÉBITO",
            "DINHEIRO"});
            this.cbFormaAbatimento.Location = new System.Drawing.Point(334, 150);
            this.cbFormaAbatimento.Name = "cbFormaAbatimento";
            this.cbFormaAbatimento.Size = new System.Drawing.Size(174, 27);
            this.cbFormaAbatimento.TabIndex = 71;
            // 
            // FrmBaixarParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.panelPagamentoParcela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBaixarParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar Pagamento Parcela";
            this.Load += new System.EventHandler(this.FrmBaixarParcela_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaixarParcela_KeyDown);
            this.panelPagamentoParcela.ResumeLayout(false);
            this.panelPagamentoParcela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPagamentoParcela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NParcelas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CodigoVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_valorParcela;
        private System.Windows.Forms.TextBox txt_Vencimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CodigoCliente;
        private System.Windows.Forms.Button btn_Baixa;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaAbatimento;
    }
}