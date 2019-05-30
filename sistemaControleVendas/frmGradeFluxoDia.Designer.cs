namespace sistemaControleVendas
{
    partial class frmGradeFluxoDia
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
            this.rv_GradeFluxoCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rv_GradeFluxoCaixa);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 768);
            this.panel1.TabIndex = 0;
            // 
            // rv_GradeFluxoCaixa
            // 
            this.rv_GradeFluxoCaixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rv_GradeFluxoCaixa.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.RelatorioGradeFluxoCaixa.rdlc";
            this.rv_GradeFluxoCaixa.Location = new System.Drawing.Point(-2, 53);
            this.rv_GradeFluxoCaixa.Name = "rv_GradeFluxoCaixa";
            this.rv_GradeFluxoCaixa.ServerReport.BearerToken = null;
            this.rv_GradeFluxoCaixa.Size = new System.Drawing.Size(1378, 714);
            this.rv_GradeFluxoCaixa.TabIndex = 5;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Coral;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.label15);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(-2, -1);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1378, 52);
            this.panelCabecalho.TabIndex = 4;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::sistemaControleVendas.Properties.Resources.flow_icon;
            this.label15.Location = new System.Drawing.Point(8, -2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 52);
            this.label15.TabIndex = 62;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Coral;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(1327, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 61;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // frmGradeFluxoDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGradeFluxoDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Fluxo Dia";
            this.Load += new System.EventHandler(this.frmGradeFluxoDia_Load);
            this.panel1.ResumeLayout(false);
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_GradeFluxoCaixa;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Fechar;
    }
}