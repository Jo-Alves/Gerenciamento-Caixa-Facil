namespace sistemaControleVendas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_MaximizarRestaurar = new System.Windows.Forms.Button();
            this.btn_CadastroCliente = new System.Windows.Forms.Button();
            this.btn_atualizarEstoque = new System.Windows.Forms.Button();
            this.btn_RealizarVenda = new System.Windows.Forms.Button();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Icone = new System.Windows.Forms.Label();
            this.PanelCorpo = new System.Windows.Forms.Panel();
            this.linkLabel_NoticaçaoAgendamento = new System.Windows.Forms.LinkLabel();
            this.linkNotificacao = new System.Windows.Forms.LinkLabel();
            this.pb_ImagemEmpresa = new System.Windows.Forms.PictureBox();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Fonecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Serviço = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Movimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ContasClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_RealizarVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterardevolverItensVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AnaliseDeVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AnaliseVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DataAnaliseVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TodosOsProdutosAnaliseVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Memu_DataServico = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_todosServiçosPrestados = new System.Windows.Forms.ToolStripMenuItem();
            this.diversosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ValidadesProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Agendamento = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ProcurarAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ProcurarAgendaPorData = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ProcurarTodosOsAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Relatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_RelatorioFechamentoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AberturaCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistroSaldoFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ListagemVendasRealizadasNoDia = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_RelatorioVendasDias = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_RelatorioVendaPeriodo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TodasAsVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Relatorio_RetiradasCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_listagemDeProdutosCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_listagensDeClientesCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_listagemDeServiçosCadastrados = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_retirarDinheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_registroAtual = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_registroPeriódico = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_FechamentoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Calculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendasNãoContablizadas = new System.Windows.Forms.ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(this.components);
            this.panelCabecalho.SuspendLayout();
            this.PanelCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagemEmpresa)).BeginInit();
            this.panelRodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fechar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(948, 12);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(38, 41);
            this.btn_Fechar.TabIndex = 57;
            this.btn_Fechar.Text = "X";
            this.toolTip1.SetToolTip(this.btn_Fechar, "Fechar");
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            this.btn_Fechar.MouseEnter += new System.EventHandler(this.btn_Fechar_MouseEnter);
            this.btn_Fechar.MouseLeave += new System.EventHandler(this.btn_Fechar_MouseLeave);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minimizar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_Minimizar.Location = new System.Drawing.Point(860, 12);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(38, 41);
            this.btn_Minimizar.TabIndex = 56;
            this.btn_Minimizar.Text = "__";
            this.toolTip1.SetToolTip(this.btn_Minimizar, "Minimizar");
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            this.btn_Minimizar.MouseEnter += new System.EventHandler(this.btn_Minimizar_MouseEnter);
            this.btn_Minimizar.MouseLeave += new System.EventHandler(this.btn_Minimizar_MouseLeave);
            // 
            // btn_MaximizarRestaurar
            // 
            this.btn_MaximizarRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaximizarRestaurar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_MaximizarRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MaximizarRestaurar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MaximizarRestaurar.ForeColor = System.Drawing.Color.White;
            this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Restaurar;
            this.btn_MaximizarRestaurar.Location = new System.Drawing.Point(904, 12);
            this.btn_MaximizarRestaurar.Name = "btn_MaximizarRestaurar";
            this.btn_MaximizarRestaurar.Size = new System.Drawing.Size(38, 41);
            this.btn_MaximizarRestaurar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btn_MaximizarRestaurar, "Minimizar");
            this.btn_MaximizarRestaurar.UseVisualStyleBackColor = false;
            this.btn_MaximizarRestaurar.Click += new System.EventHandler(this.btn_MaximizarRestaurar_Click);
            this.btn_MaximizarRestaurar.MouseEnter += new System.EventHandler(this.btn_MaximizarRestaurar_MouseEnter);
            this.btn_MaximizarRestaurar.MouseLeave += new System.EventHandler(this.btn_MaximizarRestaurar_MouseLeave);
            // 
            // btn_CadastroCliente
            // 
            this.btn_CadastroCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CadastroCliente.Image = global::sistemaControleVendas.Properties.Resources.User_Clients_icon1;
            this.btn_CadastroCliente.Location = new System.Drawing.Point(300, 30);
            this.btn_CadastroCliente.Name = "btn_CadastroCliente";
            this.btn_CadastroCliente.Size = new System.Drawing.Size(105, 66);
            this.btn_CadastroCliente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_CadastroCliente, "Cadastrar Cliente");
            this.btn_CadastroCliente.UseVisualStyleBackColor = true;
            this.btn_CadastroCliente.Click += new System.EventHandler(this.btn_CadastroCliente_Click);
            // 
            // btn_atualizarEstoque
            // 
            this.btn_atualizarEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_atualizarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizarEstoque.Image = global::sistemaControleVendas.Properties.Resources.controle_de_estoque;
            this.btn_atualizarEstoque.Location = new System.Drawing.Point(522, 30);
            this.btn_atualizarEstoque.Name = "btn_atualizarEstoque";
            this.btn_atualizarEstoque.Size = new System.Drawing.Size(105, 66);
            this.btn_atualizarEstoque.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_atualizarEstoque, "Atualizar Estoque");
            this.btn_atualizarEstoque.UseVisualStyleBackColor = true;
            this.btn_atualizarEstoque.Click += new System.EventHandler(this.btn_atualizarEstoque_Click);
            // 
            // btn_RealizarVenda
            // 
            this.btn_RealizarVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_RealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RealizarVenda.Image = global::sistemaControleVendas.Properties.Resources.Carrinho_de_compra;
            this.btn_RealizarVenda.Location = new System.Drawing.Point(411, 30);
            this.btn_RealizarVenda.Name = "btn_RealizarVenda";
            this.btn_RealizarVenda.Size = new System.Drawing.Size(105, 66);
            this.btn_RealizarVenda.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_RealizarVenda, "Realizar Venda");
            this.btn_RealizarVenda.UseVisualStyleBackColor = true;
            this.btn_RealizarVenda.Click += new System.EventHandler(this.btn_RealizarVenda_Click);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.Lbl_Titulo);
            this.panelCabecalho.Controls.Add(this.Lbl_Icone);
            this.panelCabecalho.Controls.Add(this.btn_MaximizarRestaurar);
            this.panelCabecalho.Controls.Add(this.btn_Fechar);
            this.panelCabecalho.Controls.Add(this.btn_Minimizar);
            this.panelCabecalho.Controls.Add(this.PanelCorpo);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(998, 658);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Titulo.Location = new System.Drawing.Point(101, 34);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(730, 19);
            this.Lbl_Titulo.TabIndex = 60;
            this.Lbl_Titulo.Text = "Sistema Gerenciamento Fácil (LAS Technology - Email: lastechnology2018@gmail.com)" +
    "  - Sistema não fiscal";
            // 
            // Lbl_Icone
            // 
            this.Lbl_Icone.Image = global::sistemaControleVendas.Properties.Resources.LAS_Technology;
            this.Lbl_Icone.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Icone.Name = "Lbl_Icone";
            this.Lbl_Icone.Size = new System.Drawing.Size(83, 65);
            this.Lbl_Icone.TabIndex = 59;
            this.Lbl_Icone.Text = "    ";
            // 
            // PanelCorpo
            // 
            this.PanelCorpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCorpo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCorpo.Controls.Add(this.linkLabel_NoticaçaoAgendamento);
            this.PanelCorpo.Controls.Add(this.linkNotificacao);
            this.PanelCorpo.Controls.Add(this.pb_ImagemEmpresa);
            this.PanelCorpo.Controls.Add(this.panelRodape);
            this.PanelCorpo.Controls.Add(this.btn_CadastroCliente);
            this.PanelCorpo.Controls.Add(this.btn_atualizarEstoque);
            this.PanelCorpo.Controls.Add(this.btn_RealizarVenda);
            this.PanelCorpo.Controls.Add(this.menuStrip1);
            this.PanelCorpo.Location = new System.Drawing.Point(0, 77);
            this.PanelCorpo.Name = "PanelCorpo";
            this.PanelCorpo.Size = new System.Drawing.Size(996, 579);
            this.PanelCorpo.TabIndex = 1;
            // 
            // linkLabel_NoticaçaoAgendamento
            // 
            this.linkLabel_NoticaçaoAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_NoticaçaoAgendamento.AutoSize = true;
            this.linkLabel_NoticaçaoAgendamento.Location = new System.Drawing.Point(557, 517);
            this.linkLabel_NoticaçaoAgendamento.Name = "linkLabel_NoticaçaoAgendamento";
            this.linkLabel_NoticaçaoAgendamento.Size = new System.Drawing.Size(231, 19);
            this.linkLabel_NoticaçaoAgendamento.TabIndex = 11;
            this.linkLabel_NoticaçaoAgendamento.TabStop = true;
            this.linkLabel_NoticaçaoAgendamento.Text = "Verificar notificação de agendamento\r\n";
            this.linkLabel_NoticaçaoAgendamento.Visible = false;
            this.linkLabel_NoticaçaoAgendamento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_NoticaçaoAgendamento_LinkClicked);
            // 
            // linkNotificacao
            // 
            this.linkNotificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNotificacao.AutoSize = true;
            this.linkNotificacao.Location = new System.Drawing.Point(794, 517);
            this.linkNotificacao.Name = "linkNotificacao";
            this.linkNotificacao.Size = new System.Drawing.Size(197, 19);
            this.linkNotificacao.TabIndex = 4;
            this.linkNotificacao.TabStop = true;
            this.linkNotificacao.Text = "Verificar notificação novamente";
            this.linkNotificacao.Visible = false;
            this.linkNotificacao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNotificacao_LinkClicked);
            // 
            // pb_ImagemEmpresa
            // 
            this.pb_ImagemEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_ImagemEmpresa.Location = new System.Drawing.Point(99, 118);
            this.pb_ImagemEmpresa.Name = "pb_ImagemEmpresa";
            this.pb_ImagemEmpresa.Size = new System.Drawing.Size(767, 393);
            this.pb_ImagemEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ImagemEmpresa.TabIndex = 10;
            this.pb_ImagemEmpresa.TabStop = false;
            // 
            // panelRodape
            // 
            this.panelRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRodape.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRodape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRodape.Controls.Add(this.lbl_Data);
            this.panelRodape.Controls.Add(this.lbl_Hora);
            this.panelRodape.Controls.Add(this.lbl_Usuario);
            this.panelRodape.Controls.Add(this.label1);
            this.panelRodape.Location = new System.Drawing.Point(0, 539);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(995, 78);
            this.panelRodape.TabIndex = 9;
            // 
            // lbl_Data
            // 
            this.lbl_Data.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(627, 11);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(0, 19);
            this.lbl_Data.TabIndex = 5;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(882, 11);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 19);
            this.lbl_Hora.TabIndex = 4;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(146, 11);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(52, 19);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Joelmir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário logado:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Cadastro,
            this.Menu_Movimentos,
            this.diversosToolStripMenuItem,
            this.Menu_Relatórios,
            this.Menu_FluxoDeCaixa,
            this.calculadoraToolStripMenuItem,
            this.Menu_Ajuda,
            this.menuConfiguracao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(994, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Cadastro
            // 
            this.Menu_Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_CadastroClientes,
            this.Menu_Empresa,
            this.Menu_Fonecedores,
            this.Menu_Produtos,
            this.Menu_Usuario,
            this.Menu_Serviço});
            this.Menu_Cadastro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Cadastro.Image = global::sistemaControleVendas.Properties.Resources.cadastro;
            this.Menu_Cadastro.Name = "Menu_Cadastro";
            this.Menu_Cadastro.Size = new System.Drawing.Size(89, 23);
            this.Menu_Cadastro.Text = "Cadastro";
            // 
            // Menu_CadastroClientes
            // 
            this.Menu_CadastroClientes.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_CadastroClientes.Image = global::sistemaControleVendas.Properties.Resources.User_Clients_icon1;
            this.Menu_CadastroClientes.Name = "Menu_CadastroClientes";
            this.Menu_CadastroClientes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Menu_CadastroClientes.Size = new System.Drawing.Size(189, 22);
            this.Menu_CadastroClientes.Text = "Clientes";
            this.Menu_CadastroClientes.Click += new System.EventHandler(this.Menu_CadastroClientes_Click);
            // 
            // Menu_Empresa
            // 
            this.Menu_Empresa.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Empresa.Image = global::sistemaControleVendas.Properties.Resources.Company_icon;
            this.Menu_Empresa.Name = "Menu_Empresa";
            this.Menu_Empresa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Menu_Empresa.Size = new System.Drawing.Size(189, 22);
            this.Menu_Empresa.Text = "Empresa";
            this.Menu_Empresa.Click += new System.EventHandler(this.Menu_Empresa_Click);
            // 
            // Menu_Fonecedores
            // 
            this.Menu_Fonecedores.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Fonecedores.Image = global::sistemaControleVendas.Properties.Resources.Carteira_Clientes_Fornecedores_Tela_Sobre3;
            this.Menu_Fonecedores.Name = "Menu_Fonecedores";
            this.Menu_Fonecedores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Menu_Fonecedores.Size = new System.Drawing.Size(189, 22);
            this.Menu_Fonecedores.Text = "Fornecedor";
            this.Menu_Fonecedores.Click += new System.EventHandler(this.Menu_Fonecedores_Click);
            // 
            // Menu_Produtos
            // 
            this.Menu_Produtos.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Produtos.Image = global::sistemaControleVendas.Properties.Resources.product_icon;
            this.Menu_Produtos.Name = "Menu_Produtos";
            this.Menu_Produtos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Menu_Produtos.Size = new System.Drawing.Size(189, 22);
            this.Menu_Produtos.Text = "Produtos";
            this.Menu_Produtos.Click += new System.EventHandler(this.Menu_Produtos_Click);
            // 
            // Menu_Usuario
            // 
            this.Menu_Usuario.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Usuario.Image = global::sistemaControleVendas.Properties.Resources.Preppy_icon;
            this.Menu_Usuario.Name = "Menu_Usuario";
            this.Menu_Usuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.Menu_Usuario.Size = new System.Drawing.Size(189, 22);
            this.Menu_Usuario.Text = "Usuário";
            this.Menu_Usuario.Click += new System.EventHandler(this.Menu_Usuario_Click);
            // 
            // Menu_Serviço
            // 
            this.Menu_Serviço.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Serviço.Image = global::sistemaControleVendas.Properties.Resources.Very_Basic_Services_icon;
            this.Menu_Serviço.Name = "Menu_Serviço";
            this.Menu_Serviço.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_Serviço.Size = new System.Drawing.Size(189, 22);
            this.Menu_Serviço.Text = "Serviço";
            this.Menu_Serviço.Click += new System.EventHandler(this.Menu_Serviço_Click);
            // 
            // Menu_Movimentos
            // 
            this.Menu_Movimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AnaliseDeVendas,
            this.menuAlterardevolverItensVenda,
            this.Menu_ContasClientes,
            this.Menu_ContasPagar,
            this.Menu_ContasReceber,
            this.Menu_RealizarVendas,
            this.menuVendasNãoContablizadas});
            this.Menu_Movimentos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Movimentos.Image = global::sistemaControleVendas.Properties.Resources.Cash_register_icon;
            this.Menu_Movimentos.Name = "Menu_Movimentos";
            this.Menu_Movimentos.Size = new System.Drawing.Size(108, 23);
            this.Menu_Movimentos.Text = "Movimentos";
            // 
            // Menu_ContasClientes
            // 
            this.Menu_ContasClientes.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ContasClientes.Image = global::sistemaControleVendas.Properties.Resources.client_account_template_icon;
            this.Menu_ContasClientes.Name = "Menu_ContasClientes";
            this.Menu_ContasClientes.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.Menu_ContasClientes.Size = new System.Drawing.Size(354, 22);
            this.Menu_ContasClientes.Text = "Contas Clientes";
            this.Menu_ContasClientes.Click += new System.EventHandler(this.Menu_ContasClientes_Click);
            // 
            // Menu_ContasPagar
            // 
            this.Menu_ContasPagar.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ContasPagar.Image = global::sistemaControleVendas.Properties.Resources.Contas_a_pagar_e_receber_300x227;
            this.Menu_ContasPagar.Name = "Menu_ContasPagar";
            this.Menu_ContasPagar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.Menu_ContasPagar.Size = new System.Drawing.Size(354, 22);
            this.Menu_ContasPagar.Text = "Contas a pagar";
            this.Menu_ContasPagar.Click += new System.EventHandler(this.Menu_ContasPagar_Click);
            // 
            // Menu_ContasReceber
            // 
            this.Menu_ContasReceber.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ContasReceber.Image = global::sistemaControleVendas.Properties.Resources.Money_icon;
            this.Menu_ContasReceber.Name = "Menu_ContasReceber";
            this.Menu_ContasReceber.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Menu_ContasReceber.Size = new System.Drawing.Size(354, 22);
            this.Menu_ContasReceber.Text = "Contas a receber";
            this.Menu_ContasReceber.Click += new System.EventHandler(this.Menu_ContasReceber_Click);
            // 
            // Menu_RealizarVendas
            // 
            this.Menu_RealizarVendas.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_RealizarVendas.Image = global::sistemaControleVendas.Properties.Resources.Carrinho_de_compra1;
            this.Menu_RealizarVendas.Name = "Menu_RealizarVendas";
            this.Menu_RealizarVendas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Menu_RealizarVendas.Size = new System.Drawing.Size(354, 22);
            this.Menu_RealizarVendas.Text = "Realizar Vendas";
            this.Menu_RealizarVendas.Click += new System.EventHandler(this.Menu_RealizarVendas_Click);
            // 
            // menuAlterardevolverItensVenda
            // 
            this.menuAlterardevolverItensVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.menuAlterardevolverItensVenda.Image = global::sistemaControleVendas.Properties.Resources.Carrinho_de_compra;
            this.menuAlterardevolverItensVenda.Name = "menuAlterardevolverItensVenda";
            this.menuAlterardevolverItensVenda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuAlterardevolverItensVenda.Size = new System.Drawing.Size(354, 22);
            this.menuAlterardevolverItensVenda.Text = "Alteração/devolução de itens da Venda";
            this.menuAlterardevolverItensVenda.Click += new System.EventHandler(this.menuAlterardevolverItensVenda_Click);
            // 
            // Menu_AnaliseDeVendas
            // 
            this.Menu_AnaliseDeVendas.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_AnaliseDeVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AnaliseVenda,
            this.produtoMenosVendidosToolStripMenuItem});
            this.Menu_AnaliseDeVendas.Image = global::sistemaControleVendas.Properties.Resources.Market_Analysis_icon;
            this.Menu_AnaliseDeVendas.Name = "Menu_AnaliseDeVendas";
            this.Menu_AnaliseDeVendas.Size = new System.Drawing.Size(354, 22);
            this.Menu_AnaliseDeVendas.Text = "Análise de vendas e serviços prestados";
            // 
            // Menu_AnaliseVenda
            // 
            this.Menu_AnaliseVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_AnaliseVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_DataAnaliseVenda,
            this.Menu_TodosOsProdutosAnaliseVenda});
            this.Menu_AnaliseVenda.Name = "Menu_AnaliseVenda";
            this.Menu_AnaliseVenda.Size = new System.Drawing.Size(188, 22);
            this.Menu_AnaliseVenda.Text = "Venda realizada";
            // 
            // Menu_DataAnaliseVenda
            // 
            this.Menu_DataAnaliseVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_DataAnaliseVenda.Image = ((System.Drawing.Image)(resources.GetObject("Menu_DataAnaliseVenda.Image")));
            this.Menu_DataAnaliseVenda.Name = "Menu_DataAnaliseVenda";
            this.Menu_DataAnaliseVenda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Menu_DataAnaliseVenda.Size = new System.Drawing.Size(268, 22);
            this.Menu_DataAnaliseVenda.Text = "Data";
            this.Menu_DataAnaliseVenda.Click += new System.EventHandler(this.Menu_DataAnaliseVenda_Click);
            // 
            // Menu_TodosOsProdutosAnaliseVenda
            // 
            this.Menu_TodosOsProdutosAnaliseVenda.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_TodosOsProdutosAnaliseVenda.Image = ((System.Drawing.Image)(resources.GetObject("Menu_TodosOsProdutosAnaliseVenda.Image")));
            this.Menu_TodosOsProdutosAnaliseVenda.Name = "Menu_TodosOsProdutosAnaliseVenda";
            this.Menu_TodosOsProdutosAnaliseVenda.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.Menu_TodosOsProdutosAnaliseVenda.Size = new System.Drawing.Size(268, 22);
            this.Menu_TodosOsProdutosAnaliseVenda.Text = "Todos os Produtos";
            this.Menu_TodosOsProdutosAnaliseVenda.Click += new System.EventHandler(this.Menu_TodosOsProdutosAnaliseVenda_Click);
            // 
            // produtoMenosVendidosToolStripMenuItem
            // 
            this.produtoMenosVendidosToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.produtoMenosVendidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Memu_DataServico,
            this.Menu_todosServiçosPrestados});
            this.produtoMenosVendidosToolStripMenuItem.Name = "produtoMenosVendidosToolStripMenuItem";
            this.produtoMenosVendidosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.produtoMenosVendidosToolStripMenuItem.Text = "Serviços Prestados";
            // 
            // Memu_DataServico
            // 
            this.Memu_DataServico.BackColor = System.Drawing.Color.Aquamarine;
            this.Memu_DataServico.Image = ((System.Drawing.Image)(resources.GetObject("Memu_DataServico.Image")));
            this.Memu_DataServico.Name = "Memu_DataServico";
            this.Memu_DataServico.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.Memu_DataServico.Size = new System.Drawing.Size(300, 22);
            this.Memu_DataServico.Text = "Data";
            this.Memu_DataServico.Click += new System.EventHandler(this.Memu_DataServico_Click);
            // 
            // Menu_todosServiçosPrestados
            // 
            this.Menu_todosServiçosPrestados.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_todosServiçosPrestados.Image = ((System.Drawing.Image)(resources.GetObject("Menu_todosServiçosPrestados.Image")));
            this.Menu_todosServiçosPrestados.Name = "Menu_todosServiçosPrestados";
            this.Menu_todosServiçosPrestados.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.Menu_todosServiçosPrestados.Size = new System.Drawing.Size(300, 22);
            this.Menu_todosServiçosPrestados.Text = "Todos Serviços Prestados";
            this.Menu_todosServiçosPrestados.Click += new System.EventHandler(this.Menu_todosServiçosPrestados_Click);
            // 
            // diversosToolStripMenuItem
            // 
            this.diversosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Agendamento,
            this.Menu_ProcurarAgenda,
            this.Menu_ValidadesProdutos});
            this.diversosToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.diversosToolStripMenuItem.Image = global::sistemaControleVendas.Properties.Resources.images;
            this.diversosToolStripMenuItem.Name = "diversosToolStripMenuItem";
            this.diversosToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.diversosToolStripMenuItem.Text = "Diversos";
            // 
            // Menu_ValidadesProdutos
            // 
            this.Menu_ValidadesProdutos.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ValidadesProdutos.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.Menu_ValidadesProdutos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_ValidadesProdutos.Image")));
            this.Menu_ValidadesProdutos.Name = "Menu_ValidadesProdutos";
            this.Menu_ValidadesProdutos.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.Menu_ValidadesProdutos.Size = new System.Drawing.Size(288, 22);
            this.Menu_ValidadesProdutos.Text = "Validade dos produtos";
            this.Menu_ValidadesProdutos.Click += new System.EventHandler(this.Menu_ValidadesProdutos_Click);
            // 
            // Menu_Agendamento
            // 
            this.Menu_Agendamento.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Agendamento.Image = global::sistemaControleVendas.Properties.Resources.schedule_icon__1_;
            this.Menu_Agendamento.Name = "Menu_Agendamento";
            this.Menu_Agendamento.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.Menu_Agendamento.Size = new System.Drawing.Size(288, 22);
            this.Menu_Agendamento.Text = "Agendamento";
            this.Menu_Agendamento.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // Menu_ProcurarAgenda
            // 
            this.Menu_ProcurarAgenda.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ProcurarAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ProcurarAgendaPorData,
            this.Menu_ProcurarTodosOsAgendamentos});
            this.Menu_ProcurarAgenda.Image = global::sistemaControleVendas.Properties.Resources.magnifying_glass_icon;
            this.Menu_ProcurarAgenda.Name = "Menu_ProcurarAgenda";
            this.Menu_ProcurarAgenda.Size = new System.Drawing.Size(288, 22);
            this.Menu_ProcurarAgenda.Text = "Procurar Agenda";
            // 
            // Menu_ProcurarAgendaPorData
            // 
            this.Menu_ProcurarAgendaPorData.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ProcurarAgendaPorData.Image = global::sistemaControleVendas.Properties.Resources.calendar_icon;
            this.Menu_ProcurarAgendaPorData.Name = "Menu_ProcurarAgendaPorData";
            this.Menu_ProcurarAgendaPorData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Menu_ProcurarAgendaPorData.Size = new System.Drawing.Size(300, 22);
            this.Menu_ProcurarAgendaPorData.Text = "Por data";
            this.Menu_ProcurarAgendaPorData.Click += new System.EventHandler(this.Menu_ProcurarAgendaPorData_Click);
            // 
            // Menu_ProcurarTodosOsAgendamentos
            // 
            this.Menu_ProcurarTodosOsAgendamentos.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ProcurarTodosOsAgendamentos.Image = global::sistemaControleVendas.Properties.Resources.schedule_icon__1_;
            this.Menu_ProcurarTodosOsAgendamentos.Name = "Menu_ProcurarTodosOsAgendamentos";
            this.Menu_ProcurarTodosOsAgendamentos.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.Menu_ProcurarTodosOsAgendamentos.Size = new System.Drawing.Size(300, 22);
            this.Menu_ProcurarTodosOsAgendamentos.Text = "Todos os agendamentos";
            this.Menu_ProcurarTodosOsAgendamentos.Click += new System.EventHandler(this.Menu_ProcurarTodosOsAgendamentos_Click);
            // 
            // Menu_Relatórios
            // 
            this.Menu_Relatórios.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Relatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AberturaCaixa,
            this.Menu_ListagemVendasRealizadasNoDia,
            this.Menu_Relatorio_RetiradasCaixa,
            this.Menu_listagensDeClientesCadastrados,
            this.Menu_listagemDeProdutosCadastrados,
            this.Menu_listagemDeServiçosCadastrados,
            this.Menu_RelatorioFechamentoCaixa,
            this.MenuRegistroSaldoFinal});
            this.Menu_Relatórios.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Relatórios.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Relatórios.Image")));
            this.Menu_Relatórios.Name = "Menu_Relatórios";
            this.Menu_Relatórios.Size = new System.Drawing.Size(95, 23);
            this.Menu_Relatórios.Text = "Relatórios";
            // 
            // Menu_RelatorioFechamentoCaixa
            // 
            this.Menu_RelatorioFechamentoCaixa.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_RelatorioFechamentoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("Menu_RelatorioFechamentoCaixa.Image")));
            this.Menu_RelatorioFechamentoCaixa.Name = "Menu_RelatorioFechamentoCaixa";
            this.Menu_RelatorioFechamentoCaixa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.Menu_RelatorioFechamentoCaixa.Size = new System.Drawing.Size(379, 22);
            this.Menu_RelatorioFechamentoCaixa.Text = "Registro de Fechamento de caixa";
            this.Menu_RelatorioFechamentoCaixa.Click += new System.EventHandler(this.Menu_RelatorioFechamentoCaixa_Click);
            // 
            // Menu_AberturaCaixa
            // 
            this.Menu_AberturaCaixa.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_AberturaCaixa.Image = ((System.Drawing.Image)(resources.GetObject("Menu_AberturaCaixa.Image")));
            this.Menu_AberturaCaixa.Name = "Menu_AberturaCaixa";
            this.Menu_AberturaCaixa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Menu_AberturaCaixa.Size = new System.Drawing.Size(379, 22);
            this.Menu_AberturaCaixa.Text = "Horário de abertura e fechamento de Caixa";
            this.Menu_AberturaCaixa.Click += new System.EventHandler(this.Menu_AberturaCaixa_Click);
            // 
            // MenuRegistroSaldoFinal
            // 
            this.MenuRegistroSaldoFinal.BackColor = System.Drawing.Color.Aquamarine;
            this.MenuRegistroSaldoFinal.Image = global::sistemaControleVendas.Properties.Resources.Sales_report_icon;
            this.MenuRegistroSaldoFinal.Name = "MenuRegistroSaldoFinal";
            this.MenuRegistroSaldoFinal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuRegistroSaldoFinal.Size = new System.Drawing.Size(379, 22);
            this.MenuRegistroSaldoFinal.Text = "Registro de Saldo Final";
            this.MenuRegistroSaldoFinal.Click += new System.EventHandler(this.MenuRegistroSaldoFinal_Click);
            // 
            // Menu_ListagemVendasRealizadasNoDia
            // 
            this.Menu_ListagemVendasRealizadasNoDia.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_ListagemVendasRealizadasNoDia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_RelatorioVendasDias,
            this.Menu_RelatorioVendaPeriodo,
            this.Menu_TodasAsVendas});
            this.Menu_ListagemVendasRealizadasNoDia.Image = ((System.Drawing.Image)(resources.GetObject("Menu_ListagemVendasRealizadasNoDia.Image")));
            this.Menu_ListagemVendasRealizadasNoDia.Name = "Menu_ListagemVendasRealizadasNoDia";
            this.Menu_ListagemVendasRealizadasNoDia.Size = new System.Drawing.Size(379, 22);
            this.Menu_ListagemVendasRealizadasNoDia.Text = "Listagem de Vendas";
            // 
            // Menu_RelatorioVendasDias
            // 
            this.Menu_RelatorioVendasDias.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_RelatorioVendasDias.Image = ((System.Drawing.Image)(resources.GetObject("Menu_RelatorioVendasDias.Image")));
            this.Menu_RelatorioVendasDias.Name = "Menu_RelatorioVendasDias";
            this.Menu_RelatorioVendasDias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.Menu_RelatorioVendasDias.Size = new System.Drawing.Size(248, 22);
            this.Menu_RelatorioVendasDias.Text = "Do dia";
            this.Menu_RelatorioVendasDias.Click += new System.EventHandler(this.Menu_RelatorioVendasDias_Click);
            // 
            // Menu_RelatorioVendaPeriodo
            // 
            this.Menu_RelatorioVendaPeriodo.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_RelatorioVendaPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("Menu_RelatorioVendaPeriodo.Image")));
            this.Menu_RelatorioVendaPeriodo.Name = "Menu_RelatorioVendaPeriodo";
            this.Menu_RelatorioVendaPeriodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.Menu_RelatorioVendaPeriodo.Size = new System.Drawing.Size(248, 22);
            this.Menu_RelatorioVendaPeriodo.Text = "Por Período";
            this.Menu_RelatorioVendaPeriodo.Click += new System.EventHandler(this.Menu_RelatorioVendaPeriodo_Click);
            // 
            // Menu_TodasAsVendas
            // 
            this.Menu_TodasAsVendas.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_TodasAsVendas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_TodasAsVendas.Image")));
            this.Menu_TodasAsVendas.Name = "Menu_TodasAsVendas";
            this.Menu_TodasAsVendas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.Menu_TodasAsVendas.Size = new System.Drawing.Size(248, 22);
            this.Menu_TodasAsVendas.Text = "Todas as Vendas";
            this.Menu_TodasAsVendas.Click += new System.EventHandler(this.Menu_TodasAsVendas_Click);
            // 
            // Menu_Relatorio_RetiradasCaixa
            // 
            this.Menu_Relatorio_RetiradasCaixa.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Relatorio_RetiradasCaixa.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Relatorio_RetiradasCaixa.Image")));
            this.Menu_Relatorio_RetiradasCaixa.Name = "Menu_Relatorio_RetiradasCaixa";
            this.Menu_Relatorio_RetiradasCaixa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.Menu_Relatorio_RetiradasCaixa.Size = new System.Drawing.Size(379, 22);
            this.Menu_Relatorio_RetiradasCaixa.Text = "Retiradas do caixa";
            this.Menu_Relatorio_RetiradasCaixa.Click += new System.EventHandler(this.Menu_Relatorio_RetiradasCaixa_Click);
            // 
            // Menu_listagemDeProdutosCadastrados
            // 
            this.Menu_listagemDeProdutosCadastrados.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_listagemDeProdutosCadastrados.Image = ((System.Drawing.Image)(resources.GetObject("Menu_listagemDeProdutosCadastrados.Image")));
            this.Menu_listagemDeProdutosCadastrados.Name = "Menu_listagemDeProdutosCadastrados";
            this.Menu_listagemDeProdutosCadastrados.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.Menu_listagemDeProdutosCadastrados.Size = new System.Drawing.Size(379, 22);
            this.Menu_listagemDeProdutosCadastrados.Text = "Listagem de produtos cadastrados";
            this.Menu_listagemDeProdutosCadastrados.Click += new System.EventHandler(this.listagemDeProdutosCadastradosToolStripMenuItem_Click);
            // 
            // Menu_listagensDeClientesCadastrados
            // 
            this.Menu_listagensDeClientesCadastrados.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_listagensDeClientesCadastrados.Image = ((System.Drawing.Image)(resources.GetObject("Menu_listagensDeClientesCadastrados.Image")));
            this.Menu_listagensDeClientesCadastrados.Name = "Menu_listagensDeClientesCadastrados";
            this.Menu_listagensDeClientesCadastrados.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.Menu_listagensDeClientesCadastrados.Size = new System.Drawing.Size(379, 22);
            this.Menu_listagensDeClientesCadastrados.Text = "Listagem de Clientes cadastrados";
            this.Menu_listagensDeClientesCadastrados.Click += new System.EventHandler(this.listagensDeClientesCadastradosToolStripMenuItem_Click);
            // 
            // Menu_listagemDeServiçosCadastrados
            // 
            this.Menu_listagemDeServiçosCadastrados.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_listagemDeServiçosCadastrados.Image = ((System.Drawing.Image)(resources.GetObject("Menu_listagemDeServiçosCadastrados.Image")));
            this.Menu_listagemDeServiçosCadastrados.Name = "Menu_listagemDeServiçosCadastrados";
            this.Menu_listagemDeServiçosCadastrados.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.Menu_listagemDeServiçosCadastrados.Size = new System.Drawing.Size(379, 22);
            this.Menu_listagemDeServiçosCadastrados.Text = "Listagem de serviços cadastrados";
            this.Menu_listagemDeServiçosCadastrados.Click += new System.EventHandler(this.listagemDeServiçosCadastradosToolStripMenuItem_Click);
            // 
            // Menu_FluxoDeCaixa
            // 
            this.Menu_FluxoDeCaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_retirarDinheiro,
            this.Menu_registroAtual,
            this.Menu_registroPeriódico,
            this.Menu_FechamentoCaixa});
            this.Menu_FluxoDeCaixa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_FluxoDeCaixa.Image = global::sistemaControleVendas.Properties.Resources.flow_icon;
            this.Menu_FluxoDeCaixa.Name = "Menu_FluxoDeCaixa";
            this.Menu_FluxoDeCaixa.Size = new System.Drawing.Size(124, 23);
            this.Menu_FluxoDeCaixa.Text = "Fluxo de Caixa";
            // 
            // Menu_retirarDinheiro
            // 
            this.Menu_retirarDinheiro.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_retirarDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("Menu_retirarDinheiro.Image")));
            this.Menu_retirarDinheiro.Name = "Menu_retirarDinheiro";
            this.Menu_retirarDinheiro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Menu_retirarDinheiro.Size = new System.Drawing.Size(233, 22);
            this.Menu_retirarDinheiro.Text = "Retirar Dinheiro";
            this.Menu_retirarDinheiro.Click += new System.EventHandler(this.Menu_retirarDinheiro_Click);
            // 
            // Menu_registroAtual
            // 
            this.Menu_registroAtual.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_registroAtual.Image = ((System.Drawing.Image)(resources.GetObject("Menu_registroAtual.Image")));
            this.Menu_registroAtual.Name = "Menu_registroAtual";
            this.Menu_registroAtual.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.Menu_registroAtual.Size = new System.Drawing.Size(233, 22);
            this.Menu_registroAtual.Text = "Registro Atual";
            this.Menu_registroAtual.Click += new System.EventHandler(this.Menu_registroAtual_Click);
            // 
            // Menu_registroPeriódico
            // 
            this.Menu_registroPeriódico.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_registroPeriódico.Image = ((System.Drawing.Image)(resources.GetObject("Menu_registroPeriódico.Image")));
            this.Menu_registroPeriódico.Name = "Menu_registroPeriódico";
            this.Menu_registroPeriódico.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.Menu_registroPeriódico.Size = new System.Drawing.Size(233, 22);
            this.Menu_registroPeriódico.Text = "Registro Periódico";
            this.Menu_registroPeriódico.Click += new System.EventHandler(this.Menu_registroPeriodico_Click);
            // 
            // Menu_FechamentoCaixa
            // 
            this.Menu_FechamentoCaixa.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_FechamentoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("Menu_FechamentoCaixa.Image")));
            this.Menu_FechamentoCaixa.Name = "Menu_FechamentoCaixa";
            this.Menu_FechamentoCaixa.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.Menu_FechamentoCaixa.Size = new System.Drawing.Size(233, 22);
            this.Menu_FechamentoCaixa.Text = "Fechar caixa";
            this.Menu_FechamentoCaixa.Click += new System.EventHandler(this.Menu_FechamentoCaixa_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Calculadora});
            this.calculadoraToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.calculadoraToolStripMenuItem.Image = global::sistemaControleVendas.Properties.Resources.accessories_calculator_icon;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.calculadoraToolStripMenuItem.Text = "Acessório";
            // 
            // Menu_Calculadora
            // 
            this.Menu_Calculadora.BackColor = System.Drawing.Color.Aquamarine;
            this.Menu_Calculadora.Image = global::sistemaControleVendas.Properties.Resources.Apps_accessories_calculator_icon;
            this.Menu_Calculadora.Name = "Menu_Calculadora";
            this.Menu_Calculadora.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.Menu_Calculadora.Size = new System.Drawing.Size(197, 22);
            this.Menu_Calculadora.Text = "Calculadora";
            this.Menu_Calculadora.Click += new System.EventHandler(this.Menu_Calculadora_Click);
            // 
            // Menu_Ajuda
            // 
            this.Menu_Ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.Menu_Ajuda.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Ajuda.Image = global::sistemaControleVendas.Properties.Resources.Button_Help_icon;
            this.Menu_Ajuda.Name = "Menu_Ajuda";
            this.Menu_Ajuda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Menu_Ajuda.Size = new System.Drawing.Size(71, 23);
            this.Menu_Ajuda.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.sobreToolStripMenuItem.Image = global::sistemaControleVendas.Properties.Resources.Actions_help_about_icon;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // menuConfiguracao
            // 
            this.menuConfiguracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjustar});
            this.menuConfiguracao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuConfiguracao.Image = global::sistemaControleVendas.Properties.Resources.Settings_icon;
            this.menuConfiguracao.Name = "menuConfiguracao";
            this.menuConfiguracao.Size = new System.Drawing.Size(118, 23);
            this.menuConfiguracao.Text = "Configuração";
            // 
            // menuAjustar
            // 
            this.menuAjustar.BackColor = System.Drawing.Color.Aquamarine;
            this.menuAjustar.Image = global::sistemaControleVendas.Properties.Resources.Settings_icon;
            this.menuAjustar.Name = "menuAjustar";
            this.menuAjustar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.menuAjustar.Size = new System.Drawing.Size(175, 24);
            this.menuAjustar.Text = "Ajustar";
            this.menuAjustar.Click += new System.EventHandler(this.menuAjustar_Click);
            // 
            // menuVendasNãoContablizadas
            // 
            this.menuVendasNãoContablizadas.BackColor = System.Drawing.Color.Aquamarine;
            this.menuVendasNãoContablizadas.Image = global::sistemaControleVendas.Properties.Resources.Carrinho_de_compra;
            this.menuVendasNãoContablizadas.Name = "menuVendasNãoContablizadas";
            this.menuVendasNãoContablizadas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuVendasNãoContablizadas.Size = new System.Drawing.Size(354, 22);
            this.menuVendasNãoContablizadas.Text = "Vendas não contablizadas";
            this.menuVendasNãoContablizadas.Click += new System.EventHandler(this.menuVendasNãoContablizadas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 658);
            this.Controls.Add(this.panelCabecalho);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Caixa Fácil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.PanelCorpo.ResumeLayout(false);
            this.PanelCorpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagemEmpresa)).EndInit();
            this.panelRodape.ResumeLayout(false);
            this.panelRodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btn_MaximizarRestaurar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Panel PanelCorpo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Menu_CadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Fonecedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_Usuario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Produtos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Movimentos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Relatórios;
        private System.Windows.Forms.ToolStripMenuItem Menu_FluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_FechamentoCaixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_registroAtual;
        private System.Windows.Forms.ToolStripMenuItem Menu_registroPeriódico;
        private System.Windows.Forms.ToolStripMenuItem Menu_Ajuda;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Icone;
        private System.Windows.Forms.ToolStripMenuItem Menu_Empresa;
        private System.Windows.Forms.ToolStripMenuItem Menu_ContasPagar;
        private System.Windows.Forms.ToolStripMenuItem Menu_ContasReceber;
        private System.Windows.Forms.ToolStripMenuItem Menu_RealizarVendas;
        private System.Windows.Forms.Button btn_RealizarVenda;
        private System.Windows.Forms.Button btn_atualizarEstoque;
        private System.Windows.Forms.Button btn_CadastroCliente;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Menu_AnaliseDeVendas;
        private System.Windows.Forms.ToolStripMenuItem Menu_AnaliseVenda;
        private System.Windows.Forms.ToolStripMenuItem produtoMenosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_retirarDinheiro;
        private System.Windows.Forms.ToolStripMenuItem Menu_ContasClientes;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Calculadora;
        private System.Windows.Forms.PictureBox pb_ImagemEmpresa;
        private System.Windows.Forms.ToolStripMenuItem Menu_ListagemVendasRealizadasNoDia;
        private System.Windows.Forms.ToolStripMenuItem Menu_Relatorio_RetiradasCaixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_RelatorioFechamentoCaixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_AberturaCaixa;
        private System.Windows.Forms.ToolStripMenuItem Menu_RelatorioVendasDias;
        private System.Windows.Forms.ToolStripMenuItem Menu_RelatorioVendaPeriodo;
        private System.Windows.Forms.ToolStripMenuItem diversosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_ValidadesProdutos;
        private System.Windows.Forms.LinkLabel linkNotificacao;
        private System.Windows.Forms.ToolStripMenuItem Menu_Agendamento;
        private System.Windows.Forms.ToolStripMenuItem Menu_ProcurarAgenda;
        private System.Windows.Forms.ToolStripMenuItem Menu_ProcurarAgendaPorData;
        private System.Windows.Forms.ToolStripMenuItem Menu_ProcurarTodosOsAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Serviço;
        private System.Windows.Forms.LinkLabel linkLabel_NoticaçaoAgendamento;
        private System.Windows.Forms.ToolStripMenuItem Menu_TodasAsVendas;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_listagemDeProdutosCadastrados;
        private System.Windows.Forms.ToolStripMenuItem Menu_listagensDeClientesCadastrados;
        private System.Windows.Forms.ToolStripMenuItem Menu_listagemDeServiçosCadastrados;
        private System.Windows.Forms.ToolStripMenuItem Menu_DataAnaliseVenda;
        private System.Windows.Forms.ToolStripMenuItem Menu_TodosOsProdutosAnaliseVenda;
        private System.Windows.Forms.ToolStripMenuItem Memu_DataServico;
        private System.Windows.Forms.ToolStripMenuItem Menu_todosServiçosPrestados;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistroSaldoFinal;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracao;
        private System.Windows.Forms.ToolStripMenuItem menuAjustar;
        private System.Windows.Forms.ToolStripMenuItem menuAlterardevolverItensVenda;
        private System.Windows.Forms.ToolStripMenuItem menuVendasNãoContablizadas;
    }
}

