namespace sistemaControleVendas
{
    partial class FrmRedefinicaoSenha
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
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTela.Controls.Add(this.lbl_Fechar);
            this.panelTela.Controls.Add(this.lbl_Usuario);
            this.panelTela.Controls.Add(this.btn_Cancelar);
            this.panelTela.Controls.Add(this.btn_Confirmar);
            this.panelTela.Controls.Add(this.label3);
            this.panelTela.Controls.Add(this.label2);
            this.panelTela.Controls.Add(this.txt_ConfirmarSenha);
            this.panelTela.Controls.Add(this.txt_Senha);
            this.panelTela.Controls.Add(this.Usuario);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Margin = new System.Windows.Forms.Padding(4);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(391, 231);
            this.panelTela.TabIndex = 0;
            this.panelTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseDown);
            this.panelTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(367, 0);
            this.lbl_Fechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 9;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.BackColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(39, 48);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(309, 26);
            this.lbl_Usuario.TabIndex = 8;
            this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.Location = new System.Drawing.Point(63, 178);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(133, 41);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Confirmar.Location = new System.Drawing.Point(202, 178);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(133, 41);
            this.btn_Confirmar.TabIndex = 6;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirma a sua senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // txt_ConfirmarSenha
            // 
            this.txt_ConfirmarSenha.Location = new System.Drawing.Point(39, 148);
            this.txt_ConfirmarSenha.MaxLength = 15;
            this.txt_ConfirmarSenha.Name = "txt_ConfirmarSenha";
            this.txt_ConfirmarSenha.Size = new System.Drawing.Size(309, 26);
            this.txt_ConfirmarSenha.TabIndex = 3;
            this.txt_ConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ConfirmarSenha.UseSystemPasswordChar = true;
            this.txt_ConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmarSenha_KeyDown);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(39, 96);
            this.txt_Senha.MaxLength = 15;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(309, 26);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.White;
            this.Usuario.Location = new System.Drawing.Point(35, 29);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(66, 19);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuário:";
            // 
            // FrmRedefinicaoSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 231);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRedefinicaoSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinição Senha";
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ConfirmarSenha;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label lbl_Fechar;
    }
}