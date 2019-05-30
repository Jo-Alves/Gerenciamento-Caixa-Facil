namespace sistemaControleVendas
{
    partial class FrmServico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PesquisarServico = new System.Windows.Forms.Button();
            this.btn_EditarServico = new System.Windows.Forms.Button();
            this.btn_LimparServico = new System.Windows.Forms.Button();
            this.btn_SalvarServico = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_PrecoServico = new System.Windows.Forms.TextBox();
            this.txt_DescricaoServico = new System.Windows.Forms.TextBox();
            this.txt_CodigoServico = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_PesquisarServico);
            this.panel1.Controls.Add(this.btn_EditarServico);
            this.panel1.Controls.Add(this.btn_LimparServico);
            this.panel1.Controls.Add(this.btn_SalvarServico);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.txt_PrecoServico);
            this.panel1.Controls.Add(this.txt_DescricaoServico);
            this.panel1.Controls.Add(this.txt_CodigoServico);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 315);
            this.panel1.TabIndex = 0;
            // 
            // btn_PesquisarServico
            // 
            this.btn_PesquisarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PesquisarServico.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_PesquisarServico.Location = new System.Drawing.Point(170, 226);
            this.btn_PesquisarServico.Name = "btn_PesquisarServico";
            this.btn_PesquisarServico.Size = new System.Drawing.Size(144, 75);
            this.btn_PesquisarServico.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_PesquisarServico, "Pesquisar");
            this.btn_PesquisarServico.UseVisualStyleBackColor = true;
            this.btn_PesquisarServico.Click += new System.EventHandler(this.btn_PesquisarServico_Click);
            // 
            // btn_EditarServico
            // 
            this.btn_EditarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditarServico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarServico.ForeColor = System.Drawing.Color.White;
            this.btn_EditarServico.Image = global::sistemaControleVendas.Properties.Resources.Text_Edit_icon;
            this.btn_EditarServico.Location = new System.Drawing.Point(325, 226);
            this.btn_EditarServico.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EditarServico.Name = "btn_EditarServico";
            this.btn_EditarServico.Size = new System.Drawing.Size(144, 75);
            this.btn_EditarServico.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_EditarServico, "Atualizar");
            this.btn_EditarServico.UseVisualStyleBackColor = true;
            this.btn_EditarServico.Click += new System.EventHandler(this.btn_EditarServico_Click);
            // 
            // btn_LimparServico
            // 
            this.btn_LimparServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LimparServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimparServico.ForeColor = System.Drawing.Color.White;
            this.btn_LimparServico.Image = global::sistemaControleVendas.Properties.Resources.CleanMyMac_1_icon;
            this.btn_LimparServico.Location = new System.Drawing.Point(20, 226);
            this.btn_LimparServico.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LimparServico.Name = "btn_LimparServico";
            this.btn_LimparServico.Size = new System.Drawing.Size(144, 75);
            this.btn_LimparServico.TabIndex = 8;
            this.btn_LimparServico.Text = "__";
            this.toolTip1.SetToolTip(this.btn_LimparServico, "Limpar");
            this.btn_LimparServico.UseVisualStyleBackColor = true;
            this.btn_LimparServico.Click += new System.EventHandler(this.btn_LimparServico_Click);
            // 
            // btn_SalvarServico
            // 
            this.btn_SalvarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SalvarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarServico.ForeColor = System.Drawing.Color.White;
            this.btn_SalvarServico.Image = global::sistemaControleVendas.Properties.Resources.Save_icon;
            this.btn_SalvarServico.Location = new System.Drawing.Point(478, 226);
            this.btn_SalvarServico.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SalvarServico.Name = "btn_SalvarServico";
            this.btn_SalvarServico.Size = new System.Drawing.Size(144, 75);
            this.btn_SalvarServico.TabIndex = 4;
            this.btn_SalvarServico.Text = "__";
            this.toolTip1.SetToolTip(this.btn_SalvarServico, "Salvar");
            this.btn_SalvarServico.UseVisualStyleBackColor = true;
            this.btn_SalvarServico.Click += new System.EventHandler(this.btn_SalvarServico_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(15, 91);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 19);
            this.label29.TabIndex = 40;
            this.label29.Text = "Código Serviço:";
            // 
            // txt_PrecoServico
            // 
            this.txt_PrecoServico.BackColor = System.Drawing.SystemColors.Window;
            this.txt_PrecoServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PrecoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PrecoServico.Location = new System.Drawing.Point(138, 157);
            this.txt_PrecoServico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrecoServico.Name = "txt_PrecoServico";
            this.txt_PrecoServico.Size = new System.Drawing.Size(91, 26);
            this.txt_PrecoServico.TabIndex = 2;
            this.txt_PrecoServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PrecoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecoServico_KeyPress);
            this.txt_PrecoServico.Leave += new System.EventHandler(this.txt_PrecoServico_Leave);
            // 
            // txt_DescricaoServico
            // 
            this.txt_DescricaoServico.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DescricaoServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DescricaoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DescricaoServico.Location = new System.Drawing.Point(138, 123);
            this.txt_DescricaoServico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DescricaoServico.Name = "txt_DescricaoServico";
            this.txt_DescricaoServico.Size = new System.Drawing.Size(364, 26);
            this.txt_DescricaoServico.TabIndex = 1;
            // 
            // txt_CodigoServico
            // 
            this.txt_CodigoServico.BackColor = System.Drawing.Color.White;
            this.txt_CodigoServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoServico.Location = new System.Drawing.Point(138, 89);
            this.txt_CodigoServico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoServico.Name = "txt_CodigoServico";
            this.txt_CodigoServico.ReadOnly = true;
            this.txt_CodigoServico.Size = new System.Drawing.Size(91, 26);
            this.txt_CodigoServico.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(14, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Preço do serviço:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(47, 125);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Descrição:";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Plum;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.btn_Minimizar);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Controls.Add(this.label11);
            this.panelCabecalho.Controls.Add(this.label10);
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(633, 68);
            this.panelCabecalho.TabIndex = 3;
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_Minimizar.Location = new System.Drawing.Point(537, 4);
            this.btn_Minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 38);
            this.btn_Minimizar.TabIndex = 12;
            this.btn_Minimizar.Text = "__";
            this.btn_Minimizar.UseVisualStyleBackColor = true;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            this.btn_Minimizar.MouseEnter += new System.EventHandler(this.btn_Minimizar_MouseEnter);
            this.btn_Minimizar.MouseLeave += new System.EventHandler(this.btn_Minimizar_MouseLeave);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(583, 4);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 38);
            this.btn_Fechar.TabIndex = 11;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(68, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sistema de cadastro de serviços prestados";
            // 
            // label10
            // 
            this.label10.Image = global::sistemaControleVendas.Properties.Resources.Very_Basic_Services_icon;
            this.label10.Location = new System.Drawing.Point(4, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 50);
            this.label10.TabIndex = 9;
            // 
            // FrmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 315);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Serviço";
            this.Load += new System.EventHandler(this.FrmServico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_PrecoServico;
        private System.Windows.Forms.TextBox txt_DescricaoServico;
        private System.Windows.Forms.TextBox txt_CodigoServico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_PesquisarServico;
        private System.Windows.Forms.Button btn_EditarServico;
        private System.Windows.Forms.Button btn_LimparServico;
        private System.Windows.Forms.Button btn_SalvarServico;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}