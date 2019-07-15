using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassPrestacaoServico
    {
        private int Id_PrestacaoServico;
        private string Descricao;
        private decimal PrecoServico;
        private decimal Lucro;
        private string Unidade;
        private int Id_Categoria;
        private int EstoqueAtual;
        private int EstoqueMinimo;

        public int id
        {
            get { return Id_PrestacaoServico; }
            set { Id_PrestacaoServico = value; }
        }
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
        public string unidade
        {
            get { return Unidade; }
            set { Unidade = value; }
        }
        public decimal precoServico
        {
            get { return PrecoServico; }
            set { PrecoServico = value; }
        }
        public int id_Categoria
        {
            get { return Id_Categoria; }
            set { Id_Categoria = value; }
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

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;

        public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into Produto (Id_Produto, Descricao, ValorVenda, Unidade, Lucro, ID_Categoria, EstoqueAtual, EstoqueMinimo) Values (@Id, @Descricao, @PrecoServico, @Unidade, @Lucro, @ID_Categoria, @EstoqueAtual, @EstoqueMinimo)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Descricao", descricao);
            comando.Parameters.AddWithValue("@PrecoServico", precoServico);
            comando.Parameters.AddWithValue("@ID_Categoria", id_Categoria);
            comando.Parameters.AddWithValue("@Unidade", unidade);
            comando.Parameters.AddWithValue("@Lucro", lucro);
            comando.Parameters.AddWithValue("@EstoqueMinimo", estoqueMinimo);
            comando.Parameters.AddWithValue("@EstoqueAtual", estoqueAtual);
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
            _sql = "Update Produto set Descricao = @Descricao, ValorVenda = @PrecoServico where Id_Produto = @Id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Descricao", descricao);
            comando.Parameters.AddWithValue("@PrecoServico", precoServico);
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

        public void Excluir()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Delete from Produto where Id_Produto = @Id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
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
        public bool Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Produto where Id_Produto = @Id";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id", id);            
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    
                    descricao = Tabela.Rows[0]["Descricao"].ToString();
                    PrecoServico = decimal.Parse(Tabela.Rows[0]["PrecoVenda"].ToString());
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
