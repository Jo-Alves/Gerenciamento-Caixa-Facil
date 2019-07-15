using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassUsuario
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");

        private int Id;
        private string Nome;
        private string Funcao;
        private string Email;
        private string Usuario;
        private string Senha;
        private string Situacao;
        private string DicaSenha;
        private string PerguntaSeguranca;
        private string RespostaSeguranca;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
         public string funcao
        {
            get { return Funcao; }
            set { Funcao = value; }
        }        
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string senha
        {
            get { return Senha; }
            set { Senha = value; }
        }
       public string situacao
        {
            get { return Situacao; }
            set { Situacao = value; }
        }
        public string dicaSenha
        {
            get { return DicaSenha; }
            set { DicaSenha = value; }
        }
        public string perguntaSeguranca
        {
            get { return PerguntaSeguranca; }
            set { PerguntaSeguranca = value; }
        }
        public string respostaSeguranca
        {
            get { return RespostaSeguranca; }
            set { RespostaSeguranca = value; }
        }

        string _sql;
        public bool Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Usuario = @Usuario";
            SqlDataAdapter comandoSelect = new SqlDataAdapter(_sql, conexao);
            comandoSelect.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
            comandoSelect.SelectCommand.Parameters.AddWithValue("@DicaSenha", dicaSenha);
            comandoSelect.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comandoSelect.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                _sql = "Insert into Usuario (Nome, Funcao, Email, Usuario, Senha, Situacao, DicaSenha, PerguntaSeguranca, RespostaSeguranca) Values (@Nome, @Funcao, @Email, @Usuario, @Senha, @Situacao, @DicaSenha, @PerguntaSeguranca, @RespostaSeguranca)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Funcao", funcao);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Senha", Senha);
                comando.Parameters.AddWithValue("@Situacao", situacao);
                comando.Parameters.AddWithValue("@DicaSenha", dicaSenha);
                comando.Parameters.AddWithValue("@PerguntaSeguranca", perguntaSeguranca);
                comando.Parameters.AddWithValue("@RespostaSeguranca", respostaSeguranca);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
                return false;
            }
        }
        public bool Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Id_Usuario = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", id);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                id = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                nome = Tabela.Rows[0]["Nome"].ToString();
               funcao= Tabela.Rows[0]["Funcao"].ToString();
                email = Tabela.Rows[0]["Email"].ToString();
                usuario = Tabela.Rows[0]["Usuario"].ToString();
                senha = Tabela.Rows[0]["Senha"].ToString();
                dicaSenha = Tabela.Rows[0]["DicaSenha"].ToString();
                perguntaSeguranca = Tabela.Rows[0]["PerguntaSeguranca"].ToString();
                respostaSeguranca = Tabela.Rows[0]["RespostaSeguranca"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where DicaSenha = @DicaSenha and Id_Usuario <> @Id_Usuario";
            SqlDataAdapter comandoSelect = new SqlDataAdapter(_sql, conexao);
            comandoSelect.SelectCommand.Parameters.AddWithValue("@Id_Usuario", id);
            comandoSelect.SelectCommand.Parameters.AddWithValue("@DicaSenha", dicaSenha);
            comandoSelect.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comandoSelect.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            {
                _sql = "UPDATE Usuario SET Nome = @Nome, Funcao = @Funcao, Email = @Email, Usuario = @Usuario, Senha = @Senha, DicaSenha = @DicaSenha, PerguntaSeguranca = @PerguntaSeguranca, RespostaSeguranca = @RespostaSeguranca WHERE Id_Usuario = @ID";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@Nome", nome);
                comando.Parameters.AddWithValue("@Funcao", funcao);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Senha", Senha);
                comando.Parameters.AddWithValue("@DicaSenha", dicaSenha);
                comando.Parameters.AddWithValue("@PerguntaSeguranca", perguntaSeguranca);
                comando.Parameters.AddWithValue("@RespostaSeguranca", respostaSeguranca);
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
                return false;
            }
        }
        public void Deletar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "update Usuario set Situacao = 'BLOQUEADO' WHERE Id_Usuario = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
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
        public void RedefinirSenha()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update Usuario set Senha = @Senha where Usuario = @Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Senha", senha);
            comando.Parameters.AddWithValue("@Usuario", usuario);
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