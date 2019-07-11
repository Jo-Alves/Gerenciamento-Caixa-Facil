using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassContasNaoContabilizada
    {

        string _sql;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");

        private int Codigo;
        private string Nome;
        private string Bairro;
        private string Endereco;
        private string Numero;
        private string Telefone;
        private decimal ValorConta;
        private string DataConta;

        public int codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
        }
        public string endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }
        public string numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public decimal valorConta
        {
            get { return ValorConta; }
            set { ValorConta = value; }
        }
        public string dataConta
        {
            get { return DataConta; }
            set { DataConta = value; }
        }

        public void ConfimarVendaNaoContabilizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into ContasNaoContabilizadas values (@NomeCliente, @BairroCliente, @EnderecoCliente, @NumeroCliente, @ValorConta, @DataConta)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@NomeCliente", nome);
            comando.Parameters.AddWithValue("@BairroCliente", bairro);
            comando.Parameters.AddWithValue("@EnderecoCliente", endereco);
            comando.Parameters.AddWithValue("@NumeroCliente", numero);
            comando.Parameters.AddWithValue("@ValorConta", valorConta);
            comando.Parameters.AddWithValue("@DataConta", dataConta);
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

        public void EditarVendaNaoContabilizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ContasNaoContabilizadas set Nome_Cliente = @NomeCliente, Bairro_Cliente = @BairroCliente, Endereco_Cliente = @EnderecoCliente, Numero_Cliente = @NumeroCliente, Valor_Conta = @ValorConta, Data_Conta = @DataConta where id = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", codigo);
            comando.Parameters.AddWithValue("@NomeCliente", nome);
            comando.Parameters.AddWithValue("@BairroCliente", bairro);
            comando.Parameters.AddWithValue("@EnderecoCliente", endereco);
            comando.Parameters.AddWithValue("@NumeroCliente", numero);
            comando.Parameters.AddWithValue("@ValorConta", valorConta);
            comando.Parameters.AddWithValue("@DataConta", dataConta);
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

        public void ExcluirVendaNaoContabilizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from ContasNaoContabilizadas where id = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", codigo);
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

        public void AbaterVendaNaoContabilizada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ContasNaoContabilizadas set Valor_Conta = @ValorConta where id = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", codigo);
            comando.Parameters.AddWithValue("@ValorConta", valorConta);
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
