namespace sistemaControleVendas
{
    partial class FrmCupom
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TableCupomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbControleVendaDataSet = new sistemaControleVendas.DbControleVendaDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvCupom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.TableCupomTableAdapter = new sistemaControleVendas.DbControleVendaDataSetTableAdapters.TableCupomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TableCupomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbControleVendaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableCupomBindingSource
            // 
            this.TableCupomBindingSource.DataMember = "TableCupom";
            this.TableCupomBindingSource.DataSource = this.DbControleVendaDataSet;
            // 
            // DbControleVendaDataSet
            // 
            this.DbControleVendaDataSet.DataSetName = "DbControleVendaDataSet";
            this.DbControleVendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rvCupom);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 658);
            this.panel1.TabIndex = 0;
            // 
            // rvCupom
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TableCupomBindingSource;
            this.rvCupom.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCupom.LocalReport.ReportEmbeddedResource = "sistemaControleVendas.RelatorioCupom.rdlc";
            this.rvCupom.Location = new System.Drawing.Point(3, 92);
            this.rvCupom.Name = "rvCupom";
            this.rvCupom.ServerReport.BearerToken = null;
            this.rvCupom.Size = new System.Drawing.Size(619, 565);
            this.rvCupom.TabIndex = 10;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Location = new System.Drawing.Point(2, -1);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(624, 95);
            this.panelCabecalho.TabIndex = 9;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Recibo de pagamento";
            // 
            // label1
            // 
            this.label1.Image = global::sistemaControleVendas.Properties.Resources.Sales_report_icon;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 73);
            this.label1.TabIndex = 65;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(578, 5);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 64;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // TableCupomTableAdapter
            // 
            this.TableCupomTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 658);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCupom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCupom";
            this.Load += new System.EventHandler(this.FrmCupom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableCupomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbControleVendaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Fechar;
        private Microsoft.Reporting.WinForms.ReportViewer rvCupom;
        private System.Windows.Forms.BindingSource TableCupomBindingSource;
        private DbControleVendaDataSet DbControleVendaDataSet;
        private DbControleVendaDataSetTableAdapters.TableCupomTableAdapter TableCupomTableAdapter;
    }
}