using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sistemaControleVendas
{
    class ClassParcelaVenda
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;

        private int Id_Parcela;
        private string DataPagamento;
        private string DataVencimento;
        private decimal ValorParcelado;
        private int Id_Venda;
        private int NParcela;
        private string HoraPagamento;

        public int Id
        {
            get { return Id_Parcela; }
            set { Id_Parcela = value; }
        }
        public string dataPagamento
        {
            get { return DataPagamento; }
            set { DataPagamento = value; }
        }
        public string horaPagamento
        {
            get { return HoraPagamento; }
            set { HoraPagamento = value; }
        }
        public string vencimento
        {
            get { return DataVencimento; }
            set { DataVencimento = value; }
        }
        public decimal valorParcelado
        {
            get { return ValorParcelado; }
            set { ValorParcelado = value; }
        }
        public int id_Venda
        {
            get { return Id_Venda; }
            set { Id_Venda = value; }
        }
        public int N_Parcela
        {
            get { return NParcela; }
            set { NParcela = value; }
        }

        public void inserirParcelas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into ParcelaVenda values (@Parcela, @DataVencimento, @ValorParcelado, @DataPagamento, @HoraPagamento, @ID_Venda)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Parcela", N_Parcela);
            comando.Parameters.AddWithValue("@DataPagamento", dataPagamento);
            comando.Parameters.AddWithValue("@HoraPagamento", horaPagamento);
            comando.Parameters.AddWithValue("@DataVencimento", vencimento);
            comando.Parameters.AddWithValue("@ValorParcelado", valorParcelado);
            comando.Parameters.AddWithValue("@ID_Venda", id_Venda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool VerificarVencimento()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select DataVencimento from ParcelaVenda inner join Venda on Venda.Id_Venda = ParcelaVenda.Id_Venda inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda where FormaPagamento.Descricao = 'Cartão de Crédito'and ParcelaVenda.DataPagamento = '' and ParcelaVenda.DataVencimento = '" + DateTime.Now.ToShortDateString() + "'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
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
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void SomarValorCredito()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select sum(ParcelaVenda.ValorParcelado) as ValorParcelado from ParcelaVenda inner join Venda on Venda.Id_Venda = ParcelaVenda.Id_Venda inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda where FormaPagamento.Descricao = 'Cartão de Crédito'and ParcelaVenda.DataPagamento = '' and ParcelaVenda.DataVencimento = '" + DateTime.Now.ToShortDateString() + "'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    valorParcelado = decimal.Parse(dr["ValorParcelado"].ToString());
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void BaixarCredito()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ParcelaVenda set DataPagamento = @DataPagamento, HoraPagamento = @HoraPagamento from ParcelaVenda inner join FormaPagamento on FormaPagamento.Id_Venda = ParcelaVenda.Id_Venda where FormaPagamento.Descricao = 'Cartão de Crédito' and ParcelaVenda.DataPagamento = '' and ParcelaVenda.HoraPagamento = '' and ParcelaVenda.DataVencimento = @DataPagamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataPagamento", DateTime.Now.ToShortDateString());
            comando.Parameters.AddWithValue("@HoraPagamento", DateTime.Now.ToLongTimeString());
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Clone();
            }
        }
    }
}
