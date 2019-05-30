namespace sistemaControleVendas
{
    partial class FrmSobre
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTela.Controls.Add(this.lbl_Fechar);
            this.panelTela.Controls.Add(this.label2);
            this.panelTela.Controls.Add(this.pictureBox1);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(610, 264);
            this.panelTela.TabIndex = 0;
            this.panelTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseDown);
            this.panelTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(590, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 3;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 214);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aplicativo: Gerencimento Caixa Fácil\r\n\r\nVersão: 1.0\r\n\r\nDesenvolvida pela LAS Tech" +
    "nology\r\n       Joelmir Rogério Carvalho\r\n\r\nEmail: lastechnology2018@gmail.com\r\nT" +
    "elefone: (38) 998999737";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaControleVendas.Properties.Resources.Sem_título2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 264);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Label label2;
    }
}