namespace sistemaControleVendas
{
    partial class frmNovoCadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btn_CadastroCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Controls.Add(this.btnCadastroProduto);
            this.panel1.Controls.Add(this.btn_CadastroCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 780);
            this.panel1.TabIndex = 0;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(815, 308);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(208, 152);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair - ESC";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroProduto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.Location = new System.Drawing.Point(566, 308);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(243, 152);
            this.btnCadastroProduto.TabIndex = 2;
            this.btnCadastroProduto.Text = "Cadastrar novo produto - [P]";
            this.btnCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btn_CadastroCliente
            // 
            this.btn_CadastroCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CadastroCliente.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadastroCliente.Location = new System.Drawing.Point(251, 308);
            this.btn_CadastroCliente.Name = "btn_CadastroCliente";
            this.btn_CadastroCliente.Size = new System.Drawing.Size(309, 152);
            this.btn_CadastroCliente.TabIndex = 1;
            this.btn_CadastroCliente.Text = "Cadastrar novo cliente - [C]";
            this.btn_CadastroCliente.UseVisualStyleBackColor = false;
            this.btn_CadastroCliente.Click += new System.EventHandler(this.btn_CadastroCliente_Click);
            // 
            // frmNovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmNovoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cadastro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNovoCadastro_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btn_CadastroCliente;
        private System.Windows.Forms.Button btn_Sair;
    }
}