namespace sistemaControleVendas
{
    partial class FrmBaixarPagamentoPrazo
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
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Troco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Baixa = new System.Windows.Forms.Button();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.txt_CodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelPagamentoPrazo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFormaAbatimento = new System.Windows.Forms.ComboBox();
            this.panelPagamentoPrazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.Location = new System.Drawing.Point(19, 111);
            this.txt_ValorPago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.Size = new System.Drawing.Size(148, 26);
            this.txt_ValorPago.TabIndex = 2;
            this.txt_ValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorPago_KeyPress);
            this.txt_ValorPago.Leave += new System.EventHandler(this.txt_ValorPago_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Pago:";
            // 
            // Txt_ValorTotal
            // 
            this.Txt_ValorTotal.Location = new System.Drawing.Point(175, 111);
            this.Txt_ValorTotal.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ValorTotal.Name = "Txt_ValorTotal";
            this.Txt_ValorTotal.ReadOnly = true;
            this.Txt_ValorTotal.Size = new System.Drawing.Size(148, 26);
            this.Txt_ValorTotal.TabIndex = 4;
            this.Txt_ValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor total da Conta:";
            // 
            // txt_Troco
            // 
            this.txt_Troco.Location = new System.Drawing.Point(331, 111);
            this.txt_Troco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Troco.Name = "txt_Troco";
            this.txt_Troco.ReadOnly = true;
            this.txt_Troco.Size = new System.Drawing.Size(148, 26);
            this.txt_Troco.TabIndex = 6;
            this.txt_Troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Troco:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(169, 155);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(162, 60);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar - [ESC]";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Baixa
            // 
            this.btn_Baixa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baixa.ForeColor = System.Drawing.Color.Black;
            this.btn_Baixa.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Baixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Baixa.Location = new System.Drawing.Point(331, 155);
            this.btn_Baixa.Name = "btn_Baixa";
            this.btn_Baixa.Size = new System.Drawing.Size(164, 60);
            this.btn_Baixa.TabIndex = 17;
            this.btn_Baixa.Text = "Dar Baixa- [F10]";
            this.btn_Baixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Baixa.UseVisualStyleBackColor = true;
            this.btn_Baixa.Click += new System.EventHandler(this.btn_Baixa_Click);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(645, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 20;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // txt_CodigoCliente
            // 
            this.txt_CodigoCliente.Location = new System.Drawing.Point(13, 42);
            this.txt_CodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoCliente.Name = "txt_CodigoCliente";
            this.txt_CodigoCliente.ReadOnly = true;
            this.txt_CodigoCliente.Size = new System.Drawing.Size(121, 26);
            this.txt_CodigoCliente.TabIndex = 34;
            this.txt_CodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cód Cliente:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(150, 42);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.ReadOnly = true;
            this.txt_Nome.Size = new System.Drawing.Size(502, 26);
            this.txt_Nome.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nome:";
            // 
            // panelPagamentoPrazo
            // 
            this.panelPagamentoPrazo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelPagamentoPrazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPagamentoPrazo.Controls.Add(this.label6);
            this.panelPagamentoPrazo.Controls.Add(this.cbFormaAbatimento);
            this.panelPagamentoPrazo.Controls.Add(this.label5);
            this.panelPagamentoPrazo.Controls.Add(this.txt_Nome);
            this.panelPagamentoPrazo.Controls.Add(this.label4);
            this.panelPagamentoPrazo.Controls.Add(this.txt_CodigoCliente);
            this.panelPagamentoPrazo.Controls.Add(this.lbl_Fechar);
            this.panelPagamentoPrazo.Controls.Add(this.btn_Baixa);
            this.panelPagamentoPrazo.Controls.Add(this.btn_Cancelar);
            this.panelPagamentoPrazo.Controls.Add(this.label3);
            this.panelPagamentoPrazo.Controls.Add(this.txt_Troco);
            this.panelPagamentoPrazo.Controls.Add(this.label2);
            this.panelPagamentoPrazo.Controls.Add(this.Txt_ValorTotal);
            this.panelPagamentoPrazo.Controls.Add(this.label1);
            this.panelPagamentoPrazo.Controls.Add(this.txt_ValorPago);
            this.panelPagamentoPrazo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPagamentoPrazo.Location = new System.Drawing.Point(0, 0);
            this.panelPagamentoPrazo.Margin = new System.Windows.Forms.Padding(4);
            this.panelPagamentoPrazo.Name = "panelPagamentoPrazo";
            this.panelPagamentoPrazo.Size = new System.Drawing.Size(666, 241);
            this.panelPagamentoPrazo.TabIndex = 0;
            this.panelPagamentoPrazo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPagamentoPrazo_MouseDown);
            this.panelPagamentoPrazo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPagamentoPrazo_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(482, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 72;
            this.label6.Text = "Forma de abatimento:";
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
            this.cbFormaAbatimento.Location = new System.Drawing.Point(486, 110);
            this.cbFormaAbatimento.Name = "cbFormaAbatimento";
            this.cbFormaAbatimento.Size = new System.Drawing.Size(174, 27);
            this.cbFormaAbatimento.TabIndex = 71;
            // 
            // FrmBaixarPagamentoPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 241);
            this.Controls.Add(this.panelPagamentoPrazo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBaixarPagamentoPrazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixar Pagamento Prazo";
            this.Load += new System.EventHandler(this.FrmBaixarPagamentoPrazo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBaixarPagamentoPrazo_KeyDown);
            this.panelPagamentoPrazo.ResumeLayout(false);
            this.panelPagamentoPrazo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Troco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Baixa;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.TextBox txt_CodigoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelPagamentoPrazo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFormaAbatimento;
    }
}