namespace sistemaControleVendas
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDisco = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTempoFechamentoCaixa = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTempoPagamentoPrazo = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDisco);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(481, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe aqui o diretório para armazenamento do arquivo de segurança (BACKUP)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disco";
            // 
            // cbDisco
            // 
            this.cbDisco.BackColor = System.Drawing.Color.Silver;
            this.cbDisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDisco.FormattingEnabled = true;
            this.cbDisco.Items.AddRange(new object[] {
            "C:\\",
            "D:\\",
            "E:\\"});
            this.cbDisco.Location = new System.Drawing.Point(25, 74);
            this.cbDisco.Margin = new System.Windows.Forms.Padding(4);
            this.cbDisco.Name = "cbDisco";
            this.cbDisco.Size = new System.Drawing.Size(230, 27);
            this.cbDisco.TabIndex = 0;
            this.cbDisco.SelectedIndexChanged += new System.EventHandler(this.cbDisco_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbTempoFechamentoCaixa);
            this.groupBox2.Location = new System.Drawing.Point(18, 141);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(234, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período limite para o fechamento do caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período estimado";
            // 
            // cbTempoFechamentoCaixa
            // 
            this.cbTempoFechamentoCaixa.BackColor = System.Drawing.Color.Silver;
            this.cbTempoFechamentoCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempoFechamentoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTempoFechamentoCaixa.FormattingEnabled = true;
            this.cbTempoFechamentoCaixa.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbTempoFechamentoCaixa.Location = new System.Drawing.Point(25, 74);
            this.cbTempoFechamentoCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.cbTempoFechamentoCaixa.Name = "cbTempoFechamentoCaixa";
            this.cbTempoFechamentoCaixa.Size = new System.Drawing.Size(132, 27);
            this.cbTempoFechamentoCaixa.TabIndex = 1;
            this.cbTempoFechamentoCaixa.SelectedIndexChanged += new System.EventHandler(this.cbTempoFechamentoCaixa_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbTempoPagamentoPrazo);
            this.groupBox3.Location = new System.Drawing.Point(260, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(239, 115);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tempo limite para pagamento de valor a prazo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tempo estimado";
            // 
            // cbTempoPagamentoPrazo
            // 
            this.cbTempoPagamentoPrazo.BackColor = System.Drawing.Color.Silver;
            this.cbTempoPagamentoPrazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTempoPagamentoPrazo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTempoPagamentoPrazo.FormattingEnabled = true;
            this.cbTempoPagamentoPrazo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30",
            "45"});
            this.cbTempoPagamentoPrazo.Location = new System.Drawing.Point(25, 74);
            this.cbTempoPagamentoPrazo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTempoPagamentoPrazo.Name = "cbTempoPagamentoPrazo";
            this.cbTempoPagamentoPrazo.Size = new System.Drawing.Size(171, 27);
            this.cbTempoPagamentoPrazo.TabIndex = 2;
            this.cbTempoPagamentoPrazo.SelectedIndexChanged += new System.EventHandler(this.cbTempoPagamentoPrazo_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicar.Location = new System.Drawing.Point(404, 281);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(95, 40);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btbAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(303, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(202, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "dia(s)";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 333);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTempoFechamentoCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDisco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTempoPagamentoPrazo;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
    }
}