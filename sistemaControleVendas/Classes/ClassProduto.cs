using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sistemaControleVendas
{
    class ClassProduto
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;

        private long Id;
        private string CodigoBarra;
        private string Descricao;
        private string Marca;
        private string DataValidade;
        private decimal ValorCusto;
        private decimal ValorVenda;
        private decimal Lucro;
        private int EstoqueAtual;
        private int EstoqueMinimo;
        private string Unidade;
        private int Id_Categoria;
        private int Id_Fornecedor;

        public long id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string codigoBarra
        {
            get { return CodigoBarra; }
            set { CodigoBarra = value; }
        }
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public string datavalidade
        {
            get { return DataValidade; }
            set { DataValidade = value; }
        }
        public decimal valorCusto
        {
            get { return ValorCusto; }
            set { ValorCusto = value; }
        }
        public decimal valorVenda
        {
            get { return ValorVenda; }
            set { ValorVenda = value; }
        }
        public decimal lucro
        {
            get { return Lucro; }
            set { Lucro = value; }
        }
        public int estoqueAtual
        {
            get { return EstoqueAtual; }
            set { EstoqueAtual = value; }
        }
        public int estoqueMinimo
        {
            get { return EstoqueMinimo; }
            set { EstoqueMinimo = value; }
        }
        public string unidade
        {
            get { return Unidade; }
            set { Unidade = value; }
        }
        public int id_categoria
        {
            get { return Id_Categoria; }
            set { Id_Categoria = value; }
        }
        public int id_fornecedor
        {
            get { return Id_Fornecedor; }
            set { Id_Fornecedor = value; }
        }
        public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into  produto values (@ID, @CodigoBarra, @descricao, @Marca, @DataValidade, @ValorCusto, @ValorVenda, @Lucro, @EstoqueAtual, @EstoqueMinimo, @Unidade, @id_categoria, @Id_Fornecedor)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@DataValidade", datavalidade);
            comando.Parameters.AddWithValue("@ValorCusto", valorCusto);
            comando.Parameters.AddWithValue("@ValorVenda", valorVenda);
            comando.Parameters.AddWithValue("@Lucro", lucro);
            comando.Parameters.AddWithValue("@EstoqueAtual", estoqueAtual);
            comando.Parameters.AddWithValue("@EstoqueMinimo", estoqueMinimo);
            comando.Parameters.AddWithValue("@Unidade", unidade);
            comando.Parameters.AddWithValue("@id_categoria", id_categoria);
            comando.Parameters.AddWithValue("@Id_Fornecedor", id_fornecedor);
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
        public void Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update produto set CodigoBarra = @CodigoBarra, descricao = @descricao, Marca = @Marca, DataValidade = @DataValidade, ValorCusto= @ValorCusto,ValorVenda = @ValorVenda, Lucro = @Lucro, EstoqueAtual = @EstoqueAtual, Unidade = @Unidade where id_Produto = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@DataValidade", datavalidade);
            comando.Parameters.AddWithValue("@ValorCusto", valorCusto);
            comando.Parameters.AddWithValue("@ValorVenda", valorVenda);
            comando.Parameters.AddWithValue("@Lucro", lucro);
            comando.Parameters.AddWithValue("@EstoqueAtual", estoqueAtual);
            comando.Parameters.AddWithValue("@EstoqueMinimo", estoqueMinimo);
            comando.Parameters.AddWithValue("@Unidade", unidade);
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
        public void Deletar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from produto where id_Produto = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
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

        public bool ConsultarCodigoProduto()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Produto where Id_Produto = @Id_Produto";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@id_Produto", id);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    id = int.Parse(Tabela.Rows[0]["Id_produto"].ToString());
                    codigoBarra = Tabela.Rows[0]["CodigoBarra"].ToString();
                    descricao = Tabela.Rows[0]["descricao"].ToString();
                    marca = Tabela.Rows[0]["Marca"].ToString();
                    datavalidade = Tabela.Rows[0]["DataValidade"].ToString();
                    valorCusto = decimal.Parse(Tabela.Rows[0]["ValorCusto"].ToString());
                    valorVenda = decimal.Parse(Tabela.Rows[0]["ValorVenda"].ToString());
                    lucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    estoqueAtual = int.Parse(Tabela.Rows[0]["EstoqueAtual"].ToString());
                    estoqueMinimo = int.Parse(Tabela.Rows[0]["EstoqueMinimo"].ToString());
                    unidade = Tabela.Rows[0]["Unidade"].ToString();
                    id_categoria = int.Parse(Tabela.Rows[0]["Id_Categoria"].ToString());
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

        public bool ConsultarCodigoBarra()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Produto where CodigoBarra = @CodigoBarra";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);            
            comando.SelectCommand.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    id = int.Parse(Tabela.Rows[0]["Id_produto"].ToString());
                    codigoBarra = Tabela.Rows[0]["CodigoBarra"].ToString();
                    descricao = Tabela.Rows[0]["descricao"].ToString();
                    marca = Tabela.Rows[0]["Marca"].ToString();
                    datavalidade = Tabela.Rows[0]["DataValidade"].ToString();
                    valorCusto = decimal.Parse(Tabela.Rows[0]["ValorCusto"].ToString());
                    valorVenda = decimal.Parse(Tabela.Rows[0]["ValorVenda"].ToString());
                    lucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    estoqueAtual = int.Parse(Tabela.Rows[0]["EstoqueAtual"].ToString());
                    estoqueMinimo = int.Parse(Tabela.Rows[0]["EstoqueMinimo"].ToString());
                    unidade = Tabela.Rows[0]["Unidade"].ToString();
                    id_categoria = int.Parse(Tabela.Rows[0]["Id_Categoria"].ToString());
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

        public bool ConsultarProduto()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Produto where Id_Produto = @Id_Produto";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@id_Produto", id);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    id = int.Parse(Tabela.Rows[0]["Id_produto"].ToString());
                    codigoBarra = Tabela.Rows[0]["CodigoBarra"].ToString();
                    descricao = Tabela.Rows[0]["Descricao"].ToString();
                    marca = Tabela.Rows[0]["Marca"].ToString();
                    valorVenda = decimal.Parse(Tabela.Rows[0]["ValorVenda"].ToString());
                    lucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    estoqueAtual = int.Parse(Tabela.Rows[0]["EstoqueAtual"].ToString());
                    estoqueMinimo = int.Parse(Tabela.Rows[0]["EstoqueMinimo"].ToString());
                    unidade = Tabela.Rows[0]["Unidade"].ToString();
                    id_categoria = int.Parse(Tabela.Rows[0]["Id_Categoria"].ToString());
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
    }
}

