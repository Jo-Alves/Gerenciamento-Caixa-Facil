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
    public partial class FrmAnaliseProdutoMaisVendidosPorData : Form
    {
        public FrmAnaliseProdutoMaisVendidosPorData(string Analise)
        {
            InitializeComponent();
            this.Analise = Analise;
            if (Analise == "Venda")
            {
                this.AnaliseVendaServico = "Venda";
                cb_Opcao.Items.Add("NOME DO PRODUTO");
                cb_Opcao.Items.Add("CATEGORIA");
                cb_Opcao.Text = "NOME DO PRODUTO";
            }
            else
            {
                AnaliseVendaServico = "Serviços";
                cb_Opcao.Items.Add("SERVIÇOS");
                cb_Opcao.Text = "SERVIÇOS";
            }
        }

        string AnaliseVendaServico, Analise;
        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Transparent;
        }

        int X = 0, Y = 0;
        private void panelTela_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (Analise == "Venda")
            {
                if (cb_Opcao.Text == "NOME DO PRODUTO")
                {
                    Opcao = "Produto";
                }
                else
                {
                    Opcao = "Categoria";
                }

                if (AnalisarProdutoMaisVendido() == true)
                {
                    FrmAnaliseProdutoVendidos AnaliseProdutoVendidos = new FrmAnaliseProdutoVendidos(dtp_DataInicial.Text, dtp_DataFinal.Text, cb_Opcao.Text, AnaliseVendaServico);
                    AnaliseProdutoVendidos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dados não encontrado! Verifique outra opção...", "Mensagem do sistema 'Gerenciamento Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (AnalisarServicosPrestados_Periodo() == true)
                {
                    FrmAnaliseProdutoVendidos AnaliseProdutoVendidos = new FrmAnaliseProdutoVendidos(dtp_DataInicial.Text, dtp_DataFinal.Text, cb_Opcao.Text, AnaliseVendaServico);
                    AnaliseProdutoVendidos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Dados não encontrado! Verifique outra opção...", "Mensagem do sistema 'Gerenciamento Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _Sql, Opcao;
        private bool AnalisarProdutoMaisVendido()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade,  Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, " + Opcao + ".Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Produto.Unidade <> 'Serviço' group by " + Opcao + ".Descricao order by Quantidade desc";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataInicial", dtp_DataInicial.Text);
            comando.SelectCommand.Parameters.AddWithValue("@DataFinal", dtp_DataFinal.Text);
            comando.SelectCommand.CommandText = _Sql;
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
        private bool AnalisarServicosPrestados_Periodo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade, Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, Produto.Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Produto.Unidade = 'Serviço' group by Produto.Descricao order by Quantidade desc";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataInicial", dtp_DataInicial.Text);
            comando.SelectCommand.Parameters.AddWithValue("@DataFinal", dtp_DataFinal.Text);
            comando.SelectCommand.CommandText = _Sql;
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
