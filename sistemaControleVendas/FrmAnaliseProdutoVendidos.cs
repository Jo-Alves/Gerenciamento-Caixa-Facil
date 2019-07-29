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
    public partial class FrmAnaliseProdutoVendidos : Form
    {
        public FrmAnaliseProdutoVendidos(string DataInicial, string DataFinal, string Opcao, string Analise)
        {
            InitializeComponent();          

            this.DataInicial = DataInicial;
            this.DataFinal = DataFinal;
            this.Opcao = Opcao;
            this.Analise = Analise;

            if (Analise == "Venda")
            {
               if (Opcao == "CATEGORIA")
                {
                    lbl_Titulo.Text = "Categoria do produto mais vendido";
                    Menu_Arquivo.Visible = false;
                }
                else
                {
                    lbl_Titulo.Text = "Produto mais vendidos";
                }

                if (Opcao == "Todos")
                {
                    AnalisarProdutoMaisVendido();
                }
                else
                {
                    if (this.Opcao == "NOME DO PRODUTO")
                    {
                        this.Opcao = "Produto";
                    }

                    AnalisarProdutoMaisVendido_Produto_OU_Categoria();
                }
            }
            else
            {
                dgv_AnaliseProdutoVendido.Columns[4].Visible = false;
                lbl_Titulo.Text = "Quantidade de Serviços prestados";
                ColumnQuantidade.HeaderText = "Q. S. prestados";
                dgv_AnaliseProdutoVendido.Columns[2].HeaderText = "Nº Serviços prestados";
                if (Opcao == "Todos")
                {
                    AnalisarServicosPrestados();
                }
                else
                {
                    AnalisarServicosPrestados_Periodo();
                }
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _Sql, DataInicial, DataFinal, Opcao, Analise;

        private void AnalisarProdutoMaisVendido_Produto_OU_Categoria()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade,  Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, " + Opcao + ".Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Produto.Unidade <> 'Serviço' group by " + Opcao + ".Descricao order by Quantidade desc";
                SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal);
                comando.SelectCommand.CommandText = _Sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_AnaliseProdutoVendido.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnalisarProdutoMaisVendido()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade, Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, Produto.Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Produto.Unidade <> 'Serviço' group by Produto.Descricao order by Quantidade desc";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_AnaliseProdutoVendido.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Analise de serviços prestados
        private void AnalisarServicosPrestados()
        {
        try{    SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade, Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, Produto.Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Produto.Unidade = 'Serviço' group by Produto.Descricao order by Quantidade desc";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_AnaliseProdutoVendido.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnalisarServicosPrestados_Periodo()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _Sql = "Select Sum(ItensVenda.Quantidade) as Quantidade, Count(Venda.Id_Venda) as NumeroVendas, Sum(ItensVenda.Valor) as Valor, Sum(ItensVenda.LucroItens) as Lucro, Produto.Descricao From ItensVenda inner join Venda on Venda.Id_Venda = ItensVenda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Convert(Date, Venda.DataVenda, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Produto.Unidade = 'Serviço' group by Produto.Descricao order by Quantidade desc";
                SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@DataInicial", DataInicial);
                comando.SelectCommand.Parameters.AddWithValue("@DataFinal", DataFinal);
                comando.SelectCommand.CommandText = _Sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_AnaliseProdutoVendido.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Plum;
        }

        private void FrmAnaliseProdutoVendidos_Load(object sender, EventArgs e)
        {
            dgv_AnaliseProdutoVendido.ClearSelection();
        }

        private void Menu_GerarRelatorio_MouseEnter(object sender, EventArgs e)
        {
            Menu_GerarRelatorio.ForeColor = Color.Black;
        }

        private void Menu_GerarRelatorio_MouseLeave(object sender, EventArgs e)
        {
            Menu_GerarRelatorio.ForeColor = Color.White;
        }

        private void Menu_GerarRelatorio_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FrmRelatorioAnaliseVenda relatorioAnaliseVenda = new FrmRelatorioAnaliseVenda(DataInicial, DataFinal, Analise);            
            relatorioAnaliseVenda.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
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
    }
}
