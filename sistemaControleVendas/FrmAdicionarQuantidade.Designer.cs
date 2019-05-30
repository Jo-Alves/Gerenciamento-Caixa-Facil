namespace sistemaControleVendas
{
    partial class FrmAdicionarQuantidade
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.num_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Adicionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_Adicionar.Image = global::sistemaControleVendas.Properties.Resources.Actions_list_add_icon;
            this.btn_Adicionar.Location = new System.Drawing.Point(10, 60);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(141, 41);
            this.btn_Adicionar.TabIndex = 86;
            this.btn_Adicionar.Text = "__";
            this.toolTip1.SetToolTip(this.btn_Adicionar, "Adicionar");
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Fechar);
            this.panel1.Controls.Add(this.lbl_Quantidade);
            this.panel1.Controls.Add(this.btn_Adicionar);
            this.panel1.Controls.Add(this.num_Quantidade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 145);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.Location = new System.Drawing.Point(142, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 88;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(9, 108);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(0, 19);
            this.lbl_Quantidade.TabIndex = 87;
            // 
            // num_Quantidade
            // 
            this.num_Quantidade.Location = new System.Drawing.Point(10, 23);
            this.num_Quantidade.Margin = new System.Windows.Forms.Padding(4);
            this.num_Quantidade.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.num_Quantidade.Name = "num_Quantidade";
            this.num_Quantidade.Size = new System.Drawing.Size(141, 26);
            this.num_Quantidade.TabIndex = 85;
            this.num_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Quantidade.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.num_Quantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Quantidade_KeyDown);
            // 
            // FrmAdicionarQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 145);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdicionarQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Quantidade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.NumericUpDown num_Quantidade;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label lbl_Fechar;
    }
}