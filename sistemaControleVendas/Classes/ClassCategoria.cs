using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassCategoria
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;

        private int Id;
        private string descricao;

         public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
      public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into categoria values (@Id, @Descricao)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Descricao", Descricao);
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
            _sql = "update categoria set Descricao = @Descricao where Id_Categoria = @Id";
            SqlCommand comando = new SqlCommand(_sql, conexao);

            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Descricao", Descricao);
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
            _sql = "delete from categoria where Id_Categoria = @Id";
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
        public void Cosultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from categoria where Id_Categoria = @Id";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id", id);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if(Tabela.Rows.Count>0)
                {
                    Descricao = Tabela.Rows[0]["Descricao"].ToString();                    
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
