namespace sistemaControleVendas
{
    partial class FrmRegistroCaixaTodos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Operador = new System.Windows.Forms.ComboBox();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelTela.Controls.Add(this.lbl_Fechar);
            this.panelTela.Controls.Add(this.label2);
            this.panelTela.Controls.Add(this.label1);
            this.panelTela.Controls.Add(this.cb_Operador);
            this.panelTela.Controls.Add(this.dt_Data);
            this.panelTela.Controls.Add(this.btn_Buscar);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(581, 84);
            this.panelTela.TabIndex = 0;
            this.panelTela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseDown);
            this.panelTela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTela_MouseMove);
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(561, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 5;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operador:";
            // 
            // cb_Operador
            // 
            this.cb_Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Operador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Operador.FormattingEnabled = true;
            this.cb_Operador.Items.AddRange(new object[] {
            "Todos"});
            this.cb_Operador.Location = new System.Drawing.Point(129, 36);
            this.cb_Operador.Name = "cb_Operador";
            this.cb_Operador.Size = new System.Drawing.Size(299, 27);
            this.cb_Operador.TabIndex = 2;
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(10, 36);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(112, 26);
            this.dt_Data.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Buscar.Location = new System.Drawing.Point(434, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(110, 42);
            this.btn_Buscar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_Buscar, "Buscar");
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // FrmRegistroCaixaTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 84);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistroCaixaTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar opções para Registro Caixa ";
            this.Load += new System.EventHandler(this.FrmRegistroCaixaTodos_Load);
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.ComboBox cb_Operador;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_Fechar;
    }
}