namespace sistemaControleVendas
{
    partial class FrmAnaliseProdutoMaisVendidosPorData
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
            this.panelTela = new System.Windows.Forms.Panel();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.cb_Opcao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_DataInicial = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTela.Controls.Add(this.lbl_Fechar);
            this.panelTela.Controls.Add(this.btn_Pesquisar);
            this.panelTela.Controls.Add(this.cb_Opcao);
            this.panelTela.Controls.Add(this.label2);
            this.panelTela.Controls.Add(this.label1);
            this.panelTela.Controls.Add(this.dtp_DataFinal);
            this.panelTela.Controls.Add(this.dtp_DataInicial);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Margin = new System.Windows.Forms.Padding(4);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(595, 82);
            this.panelTela.TabIndex = 0;
            this.panelTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseDown);
            this.panelTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(575, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 6;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(466, 34);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(101, 40);
            this.btn_Pesquisar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_Pesquisar, "Pesquisar");
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // cb_Opcao
            // 
            this.cb_Opcao.BackColor = System.Drawing.Color.White;
            this.cb_Opcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Opcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Opcao.FormattingEnabled = true;
            this.cb_Opcao.Location = new System.Drawing.Point(219, 42);
            this.cb_Opcao.Name = "cb_Opcao";
            this.cb_Opcao.Size = new System.Drawing.Size(240, 27);
            this.cb_Opcao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial:";
            // 
            // dtp_DataFinal
            // 
            this.dtp_DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataFinal.Location = new System.Drawing.Point(112, 43);
            this.dtp_DataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DataFinal.Name = "dtp_DataFinal";
            this.dtp_DataFinal.Size = new System.Drawing.Size(100, 26);
            this.dtp_DataFinal.TabIndex = 1;
            // 
            // dtp_DataInicial
            // 
            this.dtp_DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataInicial.Location = new System.Drawing.Point(4, 43);
            this.dtp_DataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DataInicial.Name = "dtp_DataInicial";
            this.dtp_DataInicial.Size = new System.Drawing.Size(100, 26);
            this.dtp_DataInicial.TabIndex = 0;
            // 
            // FrmAnaliseProdutoMaisVendidosPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 82);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaliseProdutoMaisVendidosPorData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analise Produto Mais Vendidos Por Data";
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.ComboBox cb_Opcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DataFinal;
        private System.Windows.Forms.DateTimePicker dtp_DataInicial;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Fechar;
    }
}