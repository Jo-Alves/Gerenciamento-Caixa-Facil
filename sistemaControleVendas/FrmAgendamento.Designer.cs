namespace sistemaControleVendas
{
    partial class FrmAgendamento
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
            this.mask_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mask_Horario = new System.Windows.Forms.MaskedTextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_BuscarServico = new System.Windows.Forms.Button();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_Servico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cliente = new System.Windows.Forms.TextBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmarAgendamento = new System.Windows.Forms.Button();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mask_Telefone);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.mask_Horario);
            this.panel1.Controls.Add(this.btn_Limpar);
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Atualizar);
            this.panel1.Controls.Add(this.btn_BuscarServico);
            this.panel1.Controls.Add(this.btn_BuscarCliente);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.txt_Servico);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Cliente);
            this.panel1.Controls.Add(this.dtp_Data);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_ConfirmarAgendamento);
            this.panel1.Controls.Add(this.panelCabecalho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 385);
            this.panel1.TabIndex = 0;
            // 
            // mask_Telefone
            // 
            this.mask_Telefone.Location = new System.Drawing.Point(123, 204);
            this.mask_Telefone.Mask = "(99) 00000-0000";
            this.mask_Telefone.Name = "mask_Telefone";
            this.mask_Telefone.Size = new System.Drawing.Size(122, 26);
            this.mask_Telefone.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Email.Location = new System.Drawing.Point(123, 239);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(456, 26);
            this.txt_Email.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(63, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 56;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(44, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Telefone:";
            // 
            // mask_Horario
            // 
            this.mask_Horario.Location = new System.Drawing.Point(322, 140);
            this.mask_Horario.Mask = "00:00:00";
            this.mask_Horario.Name = "mask_Horario";
            this.mask_Horario.Size = new System.Drawing.Size(64, 26);
            this.mask_Horario.TabIndex = 2;
            this.mask_Horario.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpar.Image = global::sistemaControleVendas.Properties.Resources.CleanMyMac_1_icon2;
            this.btn_Limpar.Location = new System.Drawing.Point(610, 308);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(119, 51);
            this.btn_Limpar.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btn_Limpar, "Cancelar");
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Pesquisar.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.btn_Pesquisar.Location = new System.Drawing.Point(137, 311);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(108, 49);
            this.btn_Pesquisar.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btn_Pesquisar, "Buscar agendamento");
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Image = global::sistemaControleVendas.Properties.Resources.Actions_edit_delete_icon;
            this.btn_Delete.Location = new System.Drawing.Point(369, 310);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 49);
            this.btn_Delete.TabIndex = 50;
            this.toolTip1.SetToolTip(this.btn_Delete, "Excluir Agendamento");
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Atualizar.Image = global::sistemaControleVendas.Properties.Resources.Text_Edit_icon__1_;
            this.btn_Atualizar.Location = new System.Drawing.Point(253, 310);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(108, 49);
            this.btn_Atualizar.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btn_Atualizar, "Atualizar Agendamento");
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_BuscarServico
            // 
            this.btn_BuscarServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarServico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btn_BuscarServico.Location = new System.Drawing.Point(586, 166);
            this.btn_BuscarServico.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarServico.Name = "btn_BuscarServico";
            this.btn_BuscarServico.Size = new System.Drawing.Size(112, 35);
            this.btn_BuscarServico.TabIndex = 48;
            this.btn_BuscarServico.Text = "Buscar Serviço";
            this.toolTip1.SetToolTip(this.btn_BuscarServico, "Cancelar");
            this.btn_BuscarServico.UseVisualStyleBackColor = true;
            this.btn_BuscarServico.Click += new System.EventHandler(this.btn_BuscarServico_Click);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.btn_BuscarCliente.Location = new System.Drawing.Point(586, 99);
            this.btn_BuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(112, 32);
            this.btn_BuscarCliente.TabIndex = 47;
            this.btn_BuscarCliente.Text = "Buscar Cliente";
            this.toolTip1.SetToolTip(this.btn_BuscarCliente, "Cancelar");
            this.btn_BuscarCliente.UseVisualStyleBackColor = true;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Image = global::sistemaControleVendas.Properties.Resources.Button_Cancel_icon__1_;
            this.btn_cancelar.Location = new System.Drawing.Point(485, 308);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(119, 51);
            this.btn_cancelar.TabIndex = 46;
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_Servico
            // 
            this.txt_Servico.Location = new System.Drawing.Point(122, 171);
            this.txt_Servico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Servico.MaxLength = 100;
            this.txt_Servico.Name = "txt_Servico";
            this.txt_Servico.Size = new System.Drawing.Size(456, 26);
            this.txt_Servico.TabIndex = 3;
            this.txt_Servico.TextChanged += new System.EventHandler(this.txt_Servico_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(249, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Horário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Serviço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(68, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Data:";
            // 
            // txt_Cliente
            // 
            this.txt_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Cliente.Location = new System.Drawing.Point(123, 103);
            this.txt_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cliente.MaxLength = 100;
            this.txt_Cliente.Name = "txt_Cliente";
            this.txt_Cliente.Size = new System.Drawing.Size(455, 26);
            this.txt_Cliente.TabIndex = 0;
            this.txt_Cliente.TextChanged += new System.EventHandler(this.txt_Cliente_TextChanged);
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(123, 137);
            this.dtp_Data.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(115, 26);
            this.dtp_Data.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cliente:";
            // 
            // btn_ConfirmarAgendamento
            // 
            this.btn_ConfirmarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmarAgendamento.Image = global::sistemaControleVendas.Properties.Resources.schedule_icon;
            this.btn_ConfirmarAgendamento.Location = new System.Drawing.Point(10, 311);
            this.btn_ConfirmarAgendamento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmarAgendamento.Name = "btn_ConfirmarAgendamento";
            this.btn_ConfirmarAgendamento.Size = new System.Drawing.Size(119, 51);
            this.btn_ConfirmarAgendamento.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btn_ConfirmarAgendamento, "Agendar");
            this.btn_ConfirmarAgendamento.UseVisualStyleBackColor = true;
            this.btn_ConfirmarAgendamento.Click += new System.EventHandler(this.btn_ConfirmarAgendamento_Click);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.label2);
            this.panelCabecalho.Location = new System.Drawing.Point(0, -1);
            this.panelCabecalho.Margin = new System.Windows.Forms.Padding(4);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(741, 77);
            this.panelCabecalho.TabIndex = 36;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Black;
            this.btn_Fechar.Location = new System.Drawing.Point(702, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(34, 38);
            this.btn_Fechar.TabIndex = 572;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // label1
            // 
            this.label1.Image = global::sistemaControleVendas.Properties.Resources.schedule_icon__1_;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 50);
            this.label1.TabIndex = 570;
            this.label1.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 567;
            this.label2.Text = "Sistema  de agendamento";
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 385);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Serviço";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cliente;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmarAgendamento;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_Servico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_BuscarServico;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.MaskedTextBox mask_Horario;
        private System.Windows.Forms.MaskedTextBox mask_Telefone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}