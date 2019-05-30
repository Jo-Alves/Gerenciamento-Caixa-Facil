namespace sistemaControleVendas
{
    partial class FrmListaVendaData
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
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTP_Final = new System.Windows.Forms.DateTimePicker();
            this.dTP_Inicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.cb_Selecao = new System.Windows.Forms.ComboBox();
            this.panelCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCorpo
            // 
            this.panelCorpo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCorpo.Controls.Add(this.label3);
            this.panelCorpo.Controls.Add(this.label2);
            this.panelCorpo.Controls.Add(this.dTP_Final);
            this.panelCorpo.Controls.Add(this.dTP_Inicial);
            this.panelCorpo.Controls.Add(this.lbl_Fechar);
            this.panelCorpo.Controls.Add(this.btn_Pesquisar);
            this.panelCorpo.Controls.Add(this.cb_Selecao);
            this.panelCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorpo.Location = new System.Drawing.Point(0, 0);
            this.panelCorpo.Margin = new System.Windows.Forms.Padding(4);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(719, 95);
            this.panelCorpo.TabIndex = 2;
            this.panelCorpo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCorpo_MouseDown);
            this.panelCorpo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCorpo_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Inicial:";
            // 
            // dTP_Final
            // 
            this.dTP_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_Final.Location = new System.Drawing.Point(141, 45);
            this.dTP_Final.Name = "dTP_Final";
            this.dTP_Final.Size = new System.Drawing.Size(109, 26);
            this.dTP_Final.TabIndex = 5;
            // 
            // dTP_Inicial
            // 
            this.dTP_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_Inicial.Location = new System.Drawing.Point(17, 45);
            this.dTP_Inicial.Name = "dTP_Inicial";
            this.dTP_Inicial.Size = new System.Drawing.Size(109, 26);
            this.dTP_Inicial.TabIndex = 4;
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(698, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 3;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(574, 39);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(135, 42);
            this.btn_Pesquisar.TabIndex = 2;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // cb_Selecao
            // 
            this.cb_Selecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Selecao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Selecao.FormattingEnabled = true;
            this.cb_Selecao.Items.AddRange(new object[] {
            "TODAS AS VENDAS",
            "PRAZO",
            "PARCELADO",
            "PAGAMENTO PARCIAL",
            "VISTA"});
            this.cb_Selecao.Location = new System.Drawing.Point(257, 45);
            this.cb_Selecao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Selecao.Name = "cb_Selecao";
            this.cb_Selecao.Size = new System.Drawing.Size(310, 27);
            this.cb_Selecao.TabIndex = 0;
            // 
            // FrmListaVendaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 95);
            this.Controls.Add(this.panelCorpo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListaVendaData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleciona opção de lista de venda por data";
            this.panelCorpo.ResumeLayout(false);
            this.panelCorpo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_Final;
        private System.Windows.Forms.DateTimePicker dTP_Inicial;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.ComboBox cb_Selecao;
    }
}