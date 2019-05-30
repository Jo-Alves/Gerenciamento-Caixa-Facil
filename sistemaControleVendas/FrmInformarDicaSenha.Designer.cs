namespace sistemaControleVendas
{
    partial class FrmInformarDicaSenha
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
            this.panelTela = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_DicaSenha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.lbl_PerguntaSeguranca = new System.Windows.Forms.Label();
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTela.Controls.Add(this.lbl_PerguntaSeguranca);
            this.panelTela.Controls.Add(this.lbl_Fechar);
            this.panelTela.Controls.Add(this.btn_Confirmar);
            this.panelTela.Controls.Add(this.txt_DicaSenha);
            this.panelTela.Controls.Add(this.Usuario);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Margin = new System.Windows.Forms.Padding(4);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(452, 158);
            this.panelTela.TabIndex = 0;
            this.panelTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseDown);
            this.panelTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(429, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 8;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Confirmar.Location = new System.Drawing.Point(302, 103);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(133, 41);
            this.btn_Confirmar.TabIndex = 7;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_DicaSenha
            // 
            this.txt_DicaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DicaSenha.Location = new System.Drawing.Point(19, 70);
            this.txt_DicaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DicaSenha.Name = "txt_DicaSenha";
            this.txt_DicaSenha.Size = new System.Drawing.Size(415, 26);
            this.txt_DicaSenha.TabIndex = 4;
            this.txt_DicaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(15, 47);
            this.Usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(224, 19);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Digite a  resposta de segurança:";
            // 
            // lbl_PerguntaSeguranca
            // 
            this.lbl_PerguntaSeguranca.AutoSize = true;
            this.lbl_PerguntaSeguranca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerguntaSeguranca.ForeColor = System.Drawing.Color.White;
            this.lbl_PerguntaSeguranca.Location = new System.Drawing.Point(15, 19);
            this.lbl_PerguntaSeguranca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_PerguntaSeguranca.Name = "lbl_PerguntaSeguranca";
            this.lbl_PerguntaSeguranca.Size = new System.Drawing.Size(0, 19);
            this.lbl_PerguntaSeguranca.TabIndex = 9;
            // 
            // FrmInformarDicaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 158);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInformarDicaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informar Dica de Senha";
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.TextBox txt_DicaSenha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Label lbl_PerguntaSeguranca;
    }
}