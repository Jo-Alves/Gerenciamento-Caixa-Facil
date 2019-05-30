namespace sistemaControleVendas
{
    partial class FrmProcurarAgenda
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
            this.panelCorpo = new System.Windows.Forms.Panel();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fechar = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCorpo
            // 
            this.panelCorpo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelCorpo.Controls.Add(this.dtp_Data);
            this.panelCorpo.Controls.Add(this.lbl_Fechar);
            this.panelCorpo.Controls.Add(this.btn_Pesquisar);
            this.panelCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorpo.Location = new System.Drawing.Point(0, 0);
            this.panelCorpo.Name = "panelCorpo";
            this.panelCorpo.Size = new System.Drawing.Size(280, 68);
            this.panelCorpo.TabIndex = 2;
            this.panelCorpo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCorpo_MouseDown);
            this.panelCorpo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCorpo_MouseMove);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(21, 21);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(114, 26);
            this.dtp_Data.TabIndex = 8;
            // 
            // lbl_Fechar
            // 
            this.lbl_Fechar.AutoSize = true;
            this.lbl_Fechar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_Fechar.Location = new System.Drawing.Point(260, 0);
            this.lbl_Fechar.Name = "lbl_Fechar";
            this.lbl_Fechar.Size = new System.Drawing.Size(20, 19);
            this.lbl_Fechar.TabIndex = 7;
            this.lbl_Fechar.Text = "X";
            this.lbl_Fechar.Click += new System.EventHandler(this.lbl_Fechar_Click);
            this.lbl_Fechar.MouseEnter += new System.EventHandler(this.lbl_Fechar_MouseEnter);
            this.lbl_Fechar.MouseLeave += new System.EventHandler(this.lbl_Fechar_MouseLeave);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(150, 16);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(101, 40);
            this.btn_Pesquisar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Pesquisar, "Pesquisar");
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // FrmProcurarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 68);
            this.Controls.Add(this.panelCorpo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProcurarAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Agenda";
            this.panelCorpo.ResumeLayout(false);
            this.panelCorpo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCorpo;
        private System.Windows.Forms.Label lbl_Fechar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}