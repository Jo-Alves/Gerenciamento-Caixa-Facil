using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Tulpep.NotificationWindow;
using System.Media;
using System.IO;
using sistemaControleVendas.Properties;

namespace sistemaControleVendas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(int Id_Usuario, string NomeUsuario, string Funcao)
        {
            InitializeComponent();
            
            this.Funcao = Funcao;
            lbl_Data.Text = "Data: " + DateTime.Now.ToLongDateString();
            this.Id_Usuario = Id_Usuario;
            this.NomeUsuario = NomeUsuario;
            lbl_Usuario.Text = NomeUsuario;
            CarregarImagem();
            BuscarAtuacaoEmpresaSalao();
            Condicao();
        }

        string Funcao;
        private void Condicao()
        {
            if (Funcao != "ADMINISTRADOR")
            {
                Menu_Usuario.Visible = false;
                Menu_Empresa.Visible = false;
                Menu_RelatorioFechamentoCaixa.Visible = false;
                Menu_AberturaCaixa.Visible = false;
                Menu_Relatorio_RetiradasCaixa.Visible = false;
                Menu_registroAtual.Visible = false;
                Menu_registroPeriódico.Visible = false;
                MenuRegistroSaldoFinal.Visible = false;
                menuConfiguracao.Visible = false;
            }
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO")
            {
                Menu_RealizarVendas.Text = "P.D.S";
                Menu_ValidadesProdutos.Visible = false;
                Menu_ListagemVendasRealizadasNoDia.Visible = false;
                Menu_Fonecedores.Visible = false;
                Menu_Produtos.Visible = false;
                Menu_listagemDeProdutosCadastrados.Visible = false;
                Menu_listagemDeServiçosCadastrados.Visible = false;
                Menu_listagensDeClientesCadastrados.Visible = false;
                btn_atualizarEstoque.Visible = false;
                this.btn_RealizarVenda.Image = global::sistemaControleVendas.Properties.Resources.Very_Basic_Services_icon;
                Menu_RealizarVendas.Image = Properties.Resources.Very_Basic_Services_icon;
                toolTip1.SetToolTip(btn_RealizarVenda, "Prestar serviço");
                Menu_AnaliseDeVendas.Text = "Analise de serviços prestados";
                Menu_AnaliseVenda.Visible = false;
            }
            else if (AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                Menu_Agendamento.Visible = true;
                Menu_ProcurarAgenda.Visible = true;
            }
            else
            {
                Menu_Agendamento.Visible = false;
                Menu_ProcurarAgenda.Visible = false;
            }
        }

        int Id_Usuario;
        string NomeUsuario, stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void CarregarImagem()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select LogoEmpresa From Empresa";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    string Diretorio = dr["LogoEmpresa"].ToString();
                    if (Diretorio != "")
                    {
                        pb_ImagemEmpresa.Load(Diretorio);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.DeepSkyBlue;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.DeepSkyBlue;
        }

        string confirmacao;
       private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        int fecharPrograma;
        private void FecharPrograma()
        {
            DialogResult dr = MessageBox.Show("Deseja gerar o backup de segurança agora?", "Mensagem do sistema 'Gerenciamento de Caixa Fácil'", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                fecharPrograma = 2;
            }
            else if (dr == DialogResult.No)
            {
                fecharPrograma = 1;
            }
            else
            {
                fecharPrograma = 0;
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (confirmacao == null)
                {
                    FecharPrograma();

                    if (fecharPrograma == 2)
                    {
                        GerarBackup();
                        confirmacao = "ok";
                        Application.Exit();
                    }
                    else if (fecharPrograma == 0)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        confirmacao = "ok";
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        string Pasta, DataTempo;

        private void CriarPasta()
        {
            Pasta = Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Arquivo-Backup\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        private void SetHorarioBackup()
        {
            DateTime DataAtual = DateTime.Now;
            int hr = DataAtual.Hour;
            int min = DataAtual.Minute;
            int sec = DataAtual.Second;
            int dia = DataAtual.Day;
            int mes = DataAtual.Month;
            int ano = DataAtual.Year;


            DataTempo = dia + "-" + mes + "-" + ano + "_" + hr + "_" + min + "_" + sec;
        }

        private void GerarBackup()
        {
            CriarPasta();
            SetHorarioBackup();

            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdHJjGrOXTsH7b9NW1qcCpVJxD4wsfhTDR6OXOUSfCqDynZ+0PYEaREWQ=="));
            _sql = "backup database dbControleVenda to disk = '" + Pasta + "Backup - " + DataTempo + ".bak'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Backup realizado com sucesso. O arquivo se encontra no diretório '" + Pasta + "Backup - " + DataTempo + ".bak'", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        string opcao = "Maximizar";
        private void btn_MaximizarRestaurar_Click(object sender, EventArgs e)
        {
            switch (opcao)
            {
                case "Normal":
                    this.WindowState = FormWindowState.Maximized;
                    this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Maximizar2;
                    opcao = "Maximizar";
                    break;
                case "Maximizar":
                    this.WindowState = FormWindowState.Normal;
                    this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Restaurar;
                    opcao = "Normal";
                    break;

            }

        }

        private void btn_MaximizarRestaurar_MouseEnter(object sender, EventArgs e)
        {
            if (opcao == "Normal")
            {
                this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Maximizar11;
                this.toolTip1.SetToolTip(this.btn_MaximizarRestaurar, "Maximizar");
            }
            else
            {
                this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Restaurar1;
                this.toolTip1.SetToolTip(this.btn_MaximizarRestaurar, "Restaurar");
            }
        }

        private void btn_MaximizarRestaurar_MouseLeave(object sender, EventArgs e)
        {
            if (opcao == "Normal")
            {
                this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Maximizar2;
                this.toolTip1.SetToolTip(this.btn_MaximizarRestaurar, "Máximizar");

            }
            else
            {
                this.btn_MaximizarRestaurar.Image = global::sistemaControleVendas.Properties.Resources.Botão_Restaurar;
                this.toolTip1.SetToolTip(this.btn_MaximizarRestaurar, "Retaurar");
            }
        }

        private void Menu_CadastroClientes_Click(object sender, EventArgs e)
        {
            Atualizar = "Não";
            FrmClientes clientes = new FrmClientes(Atualizar);
            clientes.ShowDialog();
        }
        int X = 0;
        int Y = 0;

        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void Menu_Fonecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor("");
            fornecedor.ShowDialog();
        }

       private void Menu_Empresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa empresa = new FrmEmpresa();
            empresa.ShowDialog();
            if (empresa.Diretorio == "")
            {
                pb_ImagemEmpresa.Image = null;
            }
            else if (empresa.Diretorio != null)
            {
                pb_ImagemEmpresa.Load(empresa.Diretorio);
            }
        }

        private void Menu_ContasPagar_Click(object sender, EventArgs e)
        {
            FrmContasPagar contasPagar = new FrmContasPagar();
            contasPagar.ShowDialog();
        }

        private void btn_CadastroCliente_Click(object sender, EventArgs e)
        {
            Atualizar = "Não";
            FrmClientes clientes = new FrmClientes(Atualizar);
            clientes.ShowDialog();
        }

        private void btn_RealizarVenda_Click(object sender, EventArgs e)
        {
            if (SituacaoCaixa() == true)
            {
                FrmVenda vendas = new FrmVenda(Id_Usuario, NomeUsuario);
                vendas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa Fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        string Atualizar = null;

        public object SqlConnecyion { get; private set; }

        private void btn_atualizarEstoque_Click(object sender, EventArgs e)
        {
            Atualizar = "Sim";
            FrmProduto produto = new FrmProduto(Atualizar);
            produto.ShowDialog();
        }

        private void Menu_RealizarVendas_Click(object sender, EventArgs e)
        {
            if (SituacaoCaixa() == true)
            {
                FrmVenda venda = new FrmVenda(Id_Usuario, NomeUsuario);
                venda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        string Cliente, Servico, Horario;
        private void NotificarAgenda()
        {
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "Select * from Agenda where Data = @Data and Horario = @Hora";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao); comando.SelectCommand.Parameters.AddWithValue("@Data", DateTime.Now.ToShortDateString());
                comando.SelectCommand.Parameters.AddWithValue("@Hora", DateTime.Now.ToLongTimeString());
                comando.SelectCommand.CommandText = _sql;
                DataTable tabela = new DataTable();
                comando.Fill(tabela);
                if (tabela.Rows.Count > 0)
                {
                    linkLabel_NoticaçaoAgendamento.Visible = true;
                    Cliente = tabela.Rows[0]["NomeCliente"].ToString();
                    Servico = tabela.Rows[0]["Servico"].ToString();
                    Horario = tabela.Rows[0]["Horario"].ToString();
                    SoundPlayer sound = new SoundPlayer();
                    if (File.Exists(Arquivo))
                    {
                        sound.SoundLocation = Arquivo;
                        sound.Play();
                    }
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources._1Apps_Notifications_icon;
                    popup.TitleText = "Notificação do sistema...";
                    popup.ContentText = "O sistema notifica: " + Servico + " às " + Horario + ". Nome do cliente: " + Cliente;
                    popup.Popup();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                NotificarAgenda();
            }
            lbl_Hora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void Menu_FechamentoCaixa_Click(object sender, EventArgs e)
        {
            if (SituacaoCaixa() == true)
            {
                FrmFechamentoCaixa FechamentoCaixa = new FrmFechamentoCaixa("", "");
                FechamentoCaixa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa Fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                btn_atualizarEstoque_Click(sender, e);
            }
        }

        private bool SituacaoCaixa()
        {
            string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from FluxoCaixa where DataSaida = ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Menu_retirarDinheiro_Click(object sender, EventArgs e)
        {
            if (SituacaoCaixa() == true)
            {
                FrmRetiraDinheiroCaixa SaidaCaixa = new FrmRetiraDinheiroCaixa();
                SaidaCaixa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa Fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Menu_ContasClientes_Click(object sender, EventArgs e)
        {
            FrmContasClientes contasClientes = new FrmContasClientes();
            contasClientes.ShowDialog();
        }

        private void Menu_registroAtual_Click(object sender, EventArgs e)
        {
            if (SituacaoCaixa() == true)
            {
                FrmRegistroCaixa registroDiario = new FrmRegistroCaixa("", "", "","");
                registroDiario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa Fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Menu_registroPeriodico_Click(object sender, EventArgs e)
        {
            FrmFluxoCaixa fluxoCaixa = new FrmFluxoCaixa();
            fluxoCaixa.ShowDialog();
        }

        private void Menu_Calculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Calc.exe");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_ContasReceber_Click(object sender, EventArgs e)
        {
            FrmContasReceber contasReceber = new FrmContasReceber();
            contasReceber.ShowDialog();
        }

        private void Menu_Usuario_Click(object sender, EventArgs e)
        {
            FrmUsuario funcionario = new FrmUsuario();
            funcionario.ShowDialog();
        }

        private void Menu_ValidadesProdutos_Click(object sender, EventArgs e)
        {
            FrmProcurarValidadeProdutos PVP = new FrmProcurarValidadeProdutos();
            PVP.ShowDialog();
        }

        private void linkNotificacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            VerificarValidadeProdutos();
            if (retorno == true)
            {
                if (AreaAtuacao != "SALÃO DE BELEZA" && AreaAtuacao != "PRESTAÇÃO DE SERVIÇO")
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources._1Apps_Notifications_icon;
                    popup.TitleText = "Notificaçao do sistema...";
                    popup.ContentText = "O sistema consta que há produtos que vencem hoje, dia: " + DateTime.Now.ToShortDateString() + "! Verifique na base de dados!";
                    popup.Popup();
                    linkNotificacao.Visible = false;
                }
            }
        }

        string Arquivo = @"C:\Program Files\LAS Technology\Gerenciamento Caixa Fácil\Toque.wav";
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            VerificarValidadeProdutos();
            if (retorno == true)
            {
                if (AreaAtuacao != "SALÃO DE BELEZA" && AreaAtuacao != "PRESTAÇÃO DE SERVIÇO")
                {
                    linkNotificacao.Visible = true;
                    SoundPlayer sound = new SoundPlayer();
                    if (File.Exists(Arquivo))
                    {
                        sound.SoundLocation = Arquivo;
                        sound.Play();
                    }
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources._1Apps_Notifications_icon;
                    popup.TitleText = "Notificaçao do sistema...";
                    popup.ContentText = "O sistema consta que há produtos que vencem hoje, dia: " + DateTime.Now.ToShortDateString() + "! Verifique na base de dados!";
                    popup.Popup();
                }
            }
        }           

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                FrmAgendamento agendamento = new FrmAgendamento();
                agendamento.ShowDialog();
            }
        }

        private void Menu_ProcurarAgendaPorData_Click(object sender, EventArgs e)
        {
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                FrmProcurarAgenda procurarAgenda = new FrmProcurarAgenda();
                procurarAgenda.ShowDialog();
            }
        }

        private void Menu_ProcurarTodosOsAgendamentos_Click(object sender, EventArgs e)
        {
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                FrmPesquisarAgendamento pesquisarAgendamento = new FrmPesquisarAgendamento("Apartir de hoje");
                pesquisarAgendamento.ShowDialog();
            }
        }

        bool retorno = false;

        private void Menu_Serviço_Click(object sender, EventArgs e)
        {
            FrmServico servico = new FrmServico();
            servico.ShowDialog();
        }

        private void Menu_Produtos_Click(object sender, EventArgs e)
        {
            Atualizar = "Não";
            FrmProduto produto = new FrmProduto(Atualizar);
            produto.ShowDialog();
        }

        private void Menu_RelatorioFechamentoCaixa_Click(object sender, EventArgs e)
        {
            FrmRegistroCaixaTodos rct = new FrmRegistroCaixaTodos();
            rct.ShowDialog();
        }

        private void Menu_AberturaCaixa_Click(object sender, EventArgs e)
        {
            FrmRelatorioAberturaFechamentoCaixa rabc = new FrmRelatorioAberturaFechamentoCaixa();
            rabc.ShowDialog();
        }

        private void Menu_TodasAsVendas_Click(object sender, EventArgs e)
        {
            if (ListaTodasVendas() == "true")
            {
                FrmListaVenda listavenda = new FrmListaVenda("", "", "");
                listavenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há venda realizadas.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string ListaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if(Tabela.Rows.Count == 0)
                {
                    return "false";
                }
                else
                {
                    return "true";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "erro";
            }
        }

        private void Menu_RelatorioVendaPeriodo_Click(object sender, EventArgs e)
        {
            FrmListaVendaData listaVendaData = new FrmListaVendaData();
            listaVendaData.ShowDialog();
        }

        private void Menu_RelatorioVendasDias_Click(object sender, EventArgs e)
        {
            if (ListaTodasVendasDia() == true)
            {
                FrmListaVenda listaVenda = new FrmListaVenda("", "", "DIA");
                listaVenda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há lista de vendas de hoje no momento!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ListaTodasVendasDia()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Venda.Datavenda = @DataVenda";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToShortDateString());
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Menu_Relatorio_RetiradasCaixa_Click(object sender, EventArgs e)
        {
            FrmRelatorioSaidaCaixa relatorioSaidaCaixa = new FrmRelatorioSaidaCaixa();
            relatorioSaidaCaixa.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void listagemDeProdutosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarProdutos pesquisarProdutos = new FrmPesquisarProdutos();
            pesquisarProdutos.ShowDialog();
        }

        private void listagensDeClientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarCliente pesquisarCliente = new FrmPesquisarCliente();
            pesquisarCliente.ShowDialog();
        }

        private void listagemDeServiçosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisarServico pesquisarServico = new FrmPesquisarServico();
            pesquisarServico.ShowDialog();
        }

        private void Menu_DataAnaliseVenda_Click(object sender, EventArgs e)
        {
            FrmAnaliseProdutoMaisVendidosPorData AnaliseProdutoMaisVendidosPorData = new FrmAnaliseProdutoMaisVendidosPorData("Venda");
            AnaliseProdutoMaisVendidosPorData.ShowDialog();
        }

        private void Menu_TodosOsProdutosAnaliseVenda_Click(object sender, EventArgs e)
        {
            FrmAnaliseProdutoVendidos analiseProdutoVendidos = new FrmAnaliseProdutoVendidos("", "", "Todos", "Venda");
            analiseProdutoVendidos.ShowDialog();
        }

        private void Memu_DataServico_Click(object sender, EventArgs e)
        {
            FrmAnaliseProdutoMaisVendidosPorData AnaliseProdutoMaisVendidosPorData = new FrmAnaliseProdutoMaisVendidosPorData("Serviços");
            AnaliseProdutoMaisVendidosPorData.ShowDialog();
        }

        private void Menu_todosServiçosPrestados_Click(object sender, EventArgs e)
        {
            FrmAnaliseProdutoVendidos analiseProdutoVendidos = new FrmAnaliseProdutoVendidos("", "", "Todos", "Serviços");
            analiseProdutoVendidos.ShowDialog();
        }

        private void menuAjustar_Click(object sender, EventArgs e)
        {
            FrmSetting setting = new FrmSetting();
            setting.ShowDialog();
        }

        private void menuAlterardevolverItensVenda_Click(object sender, EventArgs e)
        {
            FrmBuscarItensVendaAlterarExcluir alterarExcluirVenda = new FrmBuscarItensVendaAlterarExcluir();
            alterarExcluirVenda.ShowDialog();
        }

        private void MenuRegistroSaldoFinal_Click(object sender, EventArgs e)
        {
            FrmRelatorioSaldoFinal relatorioSaldoFinal = new FrmRelatorioSaldoFinal();
            relatorioSaldoFinal.ShowDialog();
        }

        private void VerificarValidadeProdutos()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select DataValidade from Produto where DataValidade = @DataValidade and DataValidade <> '00/00/0000' and Unidade <> 'Serviço'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataValidade", DateTime.Now.ToShortDateString());
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void linkLabel_NoticaçaoAgendamento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "SALÃO DE BELEZA E LOJA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO" || AreaAtuacao == "SALÃO DE BELEZA E LOJA")
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources._1Apps_Notifications_icon;
                popup.TitleText = "Notificação do sistema...";
                popup.ContentText = "O sistema notifica: " + Servico + " às " + Horario + ". Nome do cliente: " + Cliente;
                popup.Popup();
                linkLabel_NoticaçaoAgendamento.Visible = false;
            }
        }

        string AreaAtuacao;
        private void BuscarAtuacaoEmpresaSalao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select AreaAtuacao From Empresa";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                AreaAtuacao = Tabela.Rows[0]["AreaAtuacao"].ToString();
            }
        }
    }
}

