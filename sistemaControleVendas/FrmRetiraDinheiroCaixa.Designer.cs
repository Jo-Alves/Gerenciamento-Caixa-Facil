namespace sistemaControleVendas
{
    partial class FrmRetiraDinheiroCaixa
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
            this.PanelCabecalho = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Icone = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTB_Motivo = new System.Windows.Forms.RichTextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Retirar = new System.Windows.Forms.Button();
            this.PanelCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCabecalho
            // 
            this.PanelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCabecalho.BackColor = System.Drawing.Color.LightCoral;
            this.PanelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecalho.Controls.Add(this.Lbl_Titulo);
            this.PanelCabecalho.Controls.Add(this.Lbl_Icone);
            this.PanelCabecalho.Controls.Add(this.btn_Fechar);
            this.PanelCabecalho.Location = new System.Drawing.Point(-1, 0);
            this.PanelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCabecalho.Name = "PanelCabecalho";
            this.PanelCabecalho.Size = new System.Drawing.Size(414, 72);
            this.PanelCabecalho.TabIndex = 2;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(98, 17);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(120, 19);
            this.Lbl_Titulo.TabIndex = 65;
            this.Lbl_Titulo.Text = "Retirar Dinheiro";
            // 
            // Lbl_Icone
            // 
            this.Lbl_Icone.Image = global::sistemaControleVendas.Properties.Resources.Cash_register_icon11;
            this.Lbl_Icone.Location = new System.Drawing.Point(11, 4);
            this.Lbl_Icone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Icone.Name = "Lbl_Icone";
            this.Lbl_Icone.Size = new System.Drawing.Size(88, 53);
            this.Lbl_Icone.TabIndex = 64;
            this.Lbl_Icone.Text = "    ";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(370, 4);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 62;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_Valor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Retirar);
            this.panel1.Controls.Add(this.PanelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 320);
            this.panel1.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(86, 263);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(161, 45);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar - [ESC]";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTB_Motivo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motivo:";
            // 
            // rTB_Motivo
            // 
            this.rTB_Motivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTB_Motivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB_Motivo.Location = new System.Drawing.Point(3, 22);
            this.rTB_Motivo.Name = "rTB_Motivo";
            this.rTB_Motivo.Size = new System.Drawing.Size(314, 113);
            this.rTB_Motivo.TabIndex = 2;
            this.rTB_Motivo.Text = "";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(110, 90);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(116, 26);
            this.txt_Valor.TabIndex = 0;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            this.txt_Valor.Leave += new System.EventHandler(this.txt_Valor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor:";
            // 
            // btn_Retirar
            // 
            this.btn_Retirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Retirar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retirar.Location = new System.Drawing.Point(253, 266);
            this.btn_Retirar.Name = "btn_Retirar";
            this.btn_Retirar.Size = new System.Drawing.Size(143, 45);
            this.btn_Retirar.TabIndex = 3;
            this.btn_Retirar.Text = "Retirar - [F1]";
            this.btn_Retirar.UseVisualStyleBackColor = true;
            this.btn_Retirar.Click += new System.EventHandler(this.btn_Retirar_Click);
            // 
            // FrmRetiraDinheiroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 320);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRetiraDinheiroCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirar dinheiro do caixa";
            this.Load += new System.EventHandler(this.FrmRetiraDinheiroCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRetiraDinheiroCaixa_KeyDown);
            this.PanelCabecalho.ResumeLayout(false);
            this.PanelCabecalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCabecalho;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Icone;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Retirar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rTB_Motivo;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}