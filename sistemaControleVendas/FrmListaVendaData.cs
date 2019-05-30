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
    public partial class FrmListaVendaData : Form
    {
        public FrmListaVendaData()
        {
            InitializeComponent();
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Transparent;
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
        private void panelCorpo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelCorpo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (cb_Selecao.Text != "")
            {
                if (cb_Selecao.SelectedIndex == 0)
                {
                    if (ListaTodasVendasData() == true)
                    {
                        FrmListaVenda listaVenda = new FrmListaVenda(dTP_Inicial.Text, dTP_Final.Text, cb_Selecao.Text);
                        listaVenda.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Dados não encontrado! Verifique outra opção...", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (ListaVendasData() == true)
                    {
                        FrmListaVenda listaVenda = new FrmListaVenda(dTP_Inicial.Text, dTP_Final.Text, cb_Selecao.Text);
                        listaVenda.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Dados não encontrado! Verifique outra opção...", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione a opção para verificar a lista das vendas!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"), _sql;
        private bool ListaTodasVendasData()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Convert(Date, Venda.DataVenda, 103) as DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataInicial", dTP_Inicial.Text);
            comando.SelectCommand.Parameters.AddWithValue("@DataFinal", dTP_Final.Text);
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

        private bool ListaVendasData()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.Id_Venda, ItensVenda.Quantidade, Produto.ValorVenda, ItensVenda.lucroItens, ItensVenda.Valor, FormaPagamento.Descricao, Convert(Date, Venda.DataVenda, 103) as DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, Produto.Descricao as DescricaoProduto from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and FormaPagamento.Descricao = @Descricao";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataInicial", dTP_Inicial.Text);
            comando.SelectCommand.Parameters.AddWithValue("@DataFinal", dTP_Final.Text);
            comando.SelectCommand.Parameters.AddWithValue("@Descricao", cb_Selecao.Text);
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
    }
}
