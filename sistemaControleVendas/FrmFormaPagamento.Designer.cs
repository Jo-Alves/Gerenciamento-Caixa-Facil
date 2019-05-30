namespace sistemaControleVendas
{
    partial class FrmFormaPagamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_FormasPagamento = new System.Windows.Forms.ComboBox();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 318;
            this.label2.Text = "Forma de pagamento:";
            // 
            // cb_FormasPagamento
            // 
            this.cb_FormasPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FormasPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_FormasPagamento.FormattingEnabled = true;
            this.cb_FormasPagamento.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Débito"});
            this.cb_FormasPagamento.Location = new System.Drawing.Point(32, 54);
            this.cb_FormasPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.cb_FormasPagamento.Name = "cb_FormasPagamento";
            this.cb_FormasPagamento.Size = new System.Drawing.Size(272, 27);
            this.cb_FormasPagamento.TabIndex = 1;
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(302, 0);
            this.lbl_Fechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 316;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(168, 88);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(136, 40);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(322, 145);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_FormasPagamento);
            this.Controls.Add(this.lbl_Fechar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFormaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FormasPagamento;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}