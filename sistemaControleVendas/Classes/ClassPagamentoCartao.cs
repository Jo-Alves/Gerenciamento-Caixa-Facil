using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassPagamentoCartao
    {
        private int Parcela;
        private decimal ValorParcelado;
        private string DataVencimento;
        private string dataPagamento;
        private string HoraPagamento;
        private int IdVenda;

        public int _Parcela
        {
            get { return Parcela; }
            set { Parcela = value; }
        }
        public decimal _ValorParcelado
        {
            get { return ValorParcelado; }
            set { ValorParcelado = value; }
        }
        public string _DataVencimento
        {
            get { return DataVencimento; }
            set { DataVencimento = value; }
        }
        public string _DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }
        public string _HoraPagamento
        {
            get { return HoraPagamento; }
            set { HoraPagamento = value; }
        }
        public int _Id_Venda
        {
            get { return IdVenda; }
            set { IdVenda = value; }
        }

        public void EetuarPagamentocartao()
        {
            SqlConnection Conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"));
            string _sql = "Insert into PagamentoCartao Values (@Parcela, @DataVencimento, @ValorParcelado, @DataPagamento, @HoraPagamento, @IdVenda)";
            SqlCommand comando = new SqlCommand(_sql, Conexao);
            comando.Parameters.AddWithValue("@Parcela", _Parcela);
            comando.Parameters.AddWithValue("@ValorParcelado", _ValorParcelado);
            comando.Parameters.AddWithValue("@DataVencimento", _DataVencimento);
            comando.Parameters.AddWithValue("@DataPagamento", _DataPagamento);
            comando.Parameters.AddWithValue("@HoraPagamento", _HoraPagamento);
            comando.Parameters.AddWithValue("@IdVenda", _Id_Venda);
            comando.CommandText = _sql;
            try
            {                
                Conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
