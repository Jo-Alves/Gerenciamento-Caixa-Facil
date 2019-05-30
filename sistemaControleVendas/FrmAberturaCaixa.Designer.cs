namespace sistemaControleVendas
{
    partial class FrmAberturaCaixa
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
            this.PanelCabecalho = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Icone = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ValorInicial = new System.Windows.Forms.TextBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PanelCabecalho);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ValorInicial);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 180);
            this.panel1.TabIndex = 0;
            // 
            // PanelCabecalho
            // 
            this.PanelCabecalho.BackColor = System.Drawing.Color.Green;
            this.PanelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecalho.Controls.Add(this.Lbl_Titulo);
            this.PanelCabecalho.Controls.Add(this.Lbl_Icone);
            this.PanelCabecalho.Controls.Add(this.btn_Fechar);
            this.PanelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCabecalho.Name = "PanelCabecalho";
            this.PanelCabecalho.Size = new System.Drawing.Size(430, 60);
            this.PanelCabecalho.TabIndex = 8;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(89, 17);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(128, 19);
            this.Lbl_Titulo.TabIndex = 65;
            this.Lbl_Titulo.Text = "Abertura de caixa";
            // 
            // Lbl_Icone
            // 
            this.Lbl_Icone.Image = global::sistemaControleVendas.Properties.Resources.Cash_register_icon11;
            this.Lbl_Icone.Location = new System.Drawing.Point(1, 4);
            this.Lbl_Icone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Icone.Name = "Lbl_Icone";
            this.Lbl_Icone.Size = new System.Drawing.Size(88, 53);
            this.Lbl_Icone.TabIndex = 64;
            this.Lbl_Icone.Text = "    ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Green;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(391, 4);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(33, 32);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(40, 119);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(140, 48);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor inicial:";
            // 
            // txt_ValorInicial
            // 
            this.txt_ValorInicial.Location = new System.Drawing.Point(174, 79);
            this.txt_ValorInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorInicial.Name = "txt_ValorInicial";
            this.txt_ValorInicial.Size = new System.Drawing.Size(148, 26);
            this.txt_ValorInicial.TabIndex = 0;
            this.txt_ValorInicial.TextChanged += new System.EventHandler(this.txt_ValorInicial_TextChanged);
            this.txt_ValorInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ValorInicial_KeyDown);
            this.txt_ValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorInicial_KeyPress);
            this.txt_ValorInicial.Leave += new System.EventHandler(this.txt_ValorInicial_Leave);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirmar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.Image = global::sistemaControleVendas.Properties.Resources.Ok_icon;
            this.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirmar.Location = new System.Drawing.Point(188, 119);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(215, 48);
            this.btn_Confirmar.TabIndex = 2;
            this.btn_Confirmar.Text = "Confirmar - [ENTER]";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // FrmAberturaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 180);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAberturaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de Caixa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelCabecalho.ResumeLayout(false);
            this.PanelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ValorInicial;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel PanelCabecalho;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Icone;
        private System.Windows.Forms.Button btn_Fechar;
    }
}