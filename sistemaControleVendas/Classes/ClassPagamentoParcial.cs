using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassPagamentoParcial
    {
         private string DataAbatimento;
        private decimal ValorRestante;
        private int Id_Venda;
        private int Id_Cliente;
        private int Id_ValorAbatido;
        private decimal ValorTotalAbatido;
        private int Id_PagamentoParcial;
        private string HoraPagamento;
        public int Id
        {
            get { return Id_PagamentoParcial; }
            set { Id_PagamentoParcial = value; }
        }
        public string dataAbatimento
        {
            get { return DataAbatimento; }
            set { DataAbatimento = value; }
        }
        public decimal valorRestante
        {
            get { return ValorRestante; }
            set { ValorRestante = value; }
        }
        public int id_Venda
        {
            get { return Id_Venda; }
            set { Id_Venda = value; }
        }
        public int id_Cliente
        {
            get { return Id_Cliente; }
            set { Id_Cliente = value; }
        }

        public int id_ValorAbatido
        {
            get { return Id_ValorAbatido; }
            set { Id_ValorAbatido = value; }
        }
        public decimal valorTotalAbatido
        {
            get { return ValorTotalAbatido; }
            set { ValorTotalAbatido = value; }
        }
        public string horaPagamento
        {
            get { return HoraPagamento; }
            set { HoraPagamento = value; }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"), _sql;

        public void CodigoIdPagamentoParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT PagamentoParcial.Id_PagamentoParcial FROM PagamentoParcial INNER JOIN Venda ON  PagamentoParcial.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Cliente.Id_Cliente = Venda.Id_Cliente WHERE PagamentoParcial.ValorRestante > 0 AND Cliente.Id_cliente = @id";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@id", Id_Cliente);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                Id = int.Parse(Tabela.Rows[0]["ID_PagamentoParcial"].ToString());
            }
            else
            {
                _sql = "Select Max(id_PagamentoParcial) From PagamentoParcial";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql; try
                {                  
                    conexao.Open();
                    if (comando.ExecuteScalar() != DBNull.Value)
                    {
                        Id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
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
        }

        public bool ConfirmarPagamentoParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            try
            {
                conexao.Open();
                _sql = "SELECT PagamentoParcial.ID_Venda, PagamentoParcial.ValorRestante, PagamentoParcial.DataAbatimento FROM PagamentoParcial INNER JOIN Venda ON  PagamentoParcial.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Cliente.Id_Cliente = Venda.Id_Cliente WHERE PagamentoParcial.ValorRestante > 0 AND Cliente.Id_cliente = @id";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@id", Id_Cliente);
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {                   
                    _sql = "update PagamentoParcial set ValorRestante = ValorRestante + @ValorRestante, DataAbatimento = @DataAbatimento from PagamentoParcial inner join Venda on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Cliente on Cliente.Id_Cliente = venda.Id_Cliente  where Cliente.Id_Cliente = @id and PagamentoParcial.ValorRestante > 0";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@id", id_Cliente);
                    comando.Parameters.AddWithValue("@ValorRestante", valorRestante);
                    comando.Parameters.AddWithValue("@DataAbatimento", DateTime.Now.ToShortDateString());
                    comando.CommandText = _sql;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    _sql = "Insert into PagamentoParcial values (@Id_PagamentoParcial, @DataAbatimento, @ValorRestante, @Id_Venda)";
                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@Id_PagamentoParcial", Id);
                    comando.Parameters.AddWithValue("@DataAbatimento", dataAbatimento);
                    comando.Parameters.AddWithValue("@ValorRestante", valorRestante);
                    comando.Parameters.AddWithValue("@Id_Venda", Id_Venda);
                    comando.CommandText = _sql;               
                    comando.ExecuteNonQuery();
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

        public void InserirValorAbatido()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into ValorAbatido values (@ValorTotalAbatido, @Id_PagamentoParcial, @DataPagamento, @HoraPagamento)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorTotalAbatido", valorTotalAbatido);
            comando.Parameters.AddWithValue("@Id_PagamentoParcial", Id);
            comando.Parameters.AddWithValue("@DataPagamento", dataAbatimento);
            comando.Parameters.AddWithValue("@HoraPagamento", horaPagamento);
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
    }
}
