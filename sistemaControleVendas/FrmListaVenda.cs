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

namespace sistemaControleVendas
{
    public partial class FrmListaVenda : Form
    {
        public FrmListaVenda(string DataInicial, string DataFinal, string Opcao)
        {
            InitializeComponent();

            this.DataInicial = DataInicial;
            this.DataFinal = DataFinal;
            this.Opcao = Opcao;
            if (DataInicial == "" && DataFinal == "" && Opcao == "")
            {
                Lbl_Titulo.Text = "Lista de todas as vendas e serviços";
                ListaTodasVendas();
                SomaTodasVendas();
            }
            else if (Opcao == "DIA")
            {
                Lbl_Titulo.Text = "Lista de todas as vendas e serviços do dia";
                ListaTodasVendasDia();
                SomaVendaDia();
            }
            else if (Opcao != "TODAS AS VENDAS")
            {
                Lbl_Titulo.Text = "Lista de todas as vendas e serviços do período de " + DataInicial + " à " + DataFinal + ".";
                ListaVendasData();
                SomaVendasData();
            }
            else if (Opcao == "TODAS AS VENDAS")
            {
                Lbl_Titulo.Text = "Lista de todas as vendas e serviços do período de " + DataInicial + " à " + DataFinal + ".";
                ListaTodasVendasData();
                SomaTodasVendasData();
            }
        }

        private void ListaTodasVendasDia()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Venda.Datavenda = @DataVenda";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToShortDateString());
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        decimal TotalLucro, TotalVenda, TotalDesconto, TotalVendaDesconto;
        private void SomaVendaDia()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Sum(ItensVenda.LucroItens) as Lucro, sum(ItensVenda.Valor) as Valor, Sum(Venda.Desconto) as Desconto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Venda.DataVenda = @DataVenda";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToShortDateString());
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    TotalLucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    lbl_TotalLucros.Text = "R$ " + TotalLucro;
                    TotalVenda = decimal.Parse(Tabela.Rows[0]["Valor"].ToString());
                    lbl_TotalVendas.Text = "R$ " + TotalVenda;
                    TotalDesconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    lbl_TotalDesconto.Text = "R$ " + TotalDesconto;
                    TotalVendaDesconto = TotalVenda - TotalDesconto;
                    lbl_TotalVendaDesconto.Text = "R$ " + TotalVendaDesconto;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string DataInicial, DataFinal, Opcao;

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            dgv_ListaVenda.ClearSelection();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void ListaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SomaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Sum(ItensVenda.LucroItens) as Lucro, sum(ItensVenda.Valor) as Valor, Sum(Venda.Desconto) as Desconto from venda inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    TotalLucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    lbl_TotalLucros.Text = "R$ " + TotalLucro;
                    TotalVenda = decimal.Parse(Tabela.Rows[0]["Valor"].ToString());
                    lbl_TotalVendas.Text = "R$ " + TotalVenda;
                    TotalDesconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    lbl_TotalDesconto.Text = "R$ " + TotalDesconto;
                    TotalVendaDesconto = TotalVenda - TotalDesconto;
                    lbl_TotalVendaDesconto.Text = "R$ " + TotalVendaDesconto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaVendasData()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Convert(Date, Venda.DataVenda, 103) as DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and FormaPagamento.Descricao = @Descricao";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal);
                comando.SelectCommand.Parameters.AddWithValue("@Descricao", Opcao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SomaVendasData()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select  Sum(ItensVenda.LucroItens) as Lucro, sum(ItensVenda.Valor) as Valor, Sum(Venda.Desconto) as Desconto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and FormaPagamento.Descricao = @Descricao";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal);
                comando.SelectCommand.Parameters.AddWithValue("@Descricao", Opcao); comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    TotalLucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    lbl_TotalLucros.Text = "R$ " + TotalLucro;
                    TotalVenda = decimal.Parse(Tabela.Rows[0]["Valor"].ToString());
                    lbl_TotalVendas.Text = "R$ " + TotalVenda;
                    TotalDesconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    lbl_TotalDesconto.Text = "R$ " + TotalDesconto;
                    TotalVendaDesconto = TotalVenda - TotalDesconto;
                    lbl_TotalVendaDesconto.Text = "R$ " + TotalVendaDesconto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaTodasVendasData()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Convert(Date, Venda.DataVenda, 103) as DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal);
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SomaTodasVendasData()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select  Sum(ItensVenda.LucroItens) as Lucro, sum(ItensVenda.Valor) as Valor, Sum(Venda.Desconto) as Desconto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal); comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    TotalLucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    lbl_TotalLucros.Text = "R$ " + TotalLucro;
                    TotalVenda = decimal.Parse(Tabela.Rows[0]["Valor"].ToString());
                    lbl_TotalVendas.Text = "R$ " + TotalVenda;
                    TotalDesconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    lbl_TotalDesconto.Text = "R$ " + TotalDesconto;
                    TotalVendaDesconto = TotalVenda - TotalDesconto;
                    lbl_TotalVendaDesconto.Text = "R$ " + TotalVendaDesconto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string NomeFantasia, Cidade, Numero, Endereco, CNPJ, Telefone, Estado, Bairro;
        ClassEmpresa empresa = new ClassEmpresa();

        private void dgv_ListaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contLinhas = e.RowIndex;
            if (contLinhas > -1)
            {
                DataGridViewRow linhas = dgv_ListaVenda.Rows[e.RowIndex];
                Cliente = linhas.Cells[1].Value.ToString();
                CodVenda = linhas.Cells[2].Value.ToString();
                horaVenda = linhas.Cells[9].Value.ToString();
                dataVenda = linhas.Cells[8].Value.ToString();
                atendente = linhas.Cells[10].Value.ToString();
                FormaPagamento = linhas.Cells[7].Value.ToString();
                InformarValor();
            }
        }

        private void InformacaoEmpresa()
        {
            empresa.Consultar();
            NomeFantasia = empresa.nomeFantasia;
            Cidade = empresa.cidade;
            Bairro = empresa.bairro;
            Endereco = empresa.endereco;
            Numero = Convert.ToString(empresa.numero);
            CNPJ = empresa.CNPJ;
            Estado = empresa.estado;
            Telefone = empresa.telefone;
        }

        string CodVenda = "", Cliente, horaVenda, dataVenda, atendente, FormaPagamento;

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_imprimirDuplicaPromissoria_Click(object sender, EventArgs e)
        {
            if (CodVenda != "")
            {
                InformacaoEmpresa();
                this.Cursor = Cursors.WaitCursor;
                FrmReciboPagamento reciboPagamento = new FrmReciboPagamento(horaVenda, valorTotal, NomeFantasia, Cidade, Endereco, Numero, CNPJ, Cliente, dataVenda, atendente, CodVenda);
                reciboPagamento.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Selecione o item a ser impresso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        decimal valorTotal;
        private void InformarValor()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select ValorTotal From Venda where Id_Venda = " + CodVenda;
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                valorTotal = decimal.Parse(Tabela.Rows[0]["ValorTotal"].ToString());
            }
        }

        string Desconto;
        private void InformarDesconto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Desconto, ValorTotal From Venda where Id_Venda = " + CodVenda;
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
               Desconto = Tabela.Rows[0]["Desconto"].ToString();              
            }
        }

        int X = 0, Y = 0;
        private void PanelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
