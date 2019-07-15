using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassFornecedor
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;

        private int Id;
        private string Nome;
        private string CNPJ;
        private string Inscricaoestadual;
        private string Cep;
        private string Bairro;
        private string Endereco;
        private string Numero;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Celular;
        private string Email;
        
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
      
        public string Cnpj
        {
            get { return CNPJ; }
            set { CNPJ = value; }
        }
        public string Inscricao
        {
            get { return Inscricaoestadual; }
            set { Inscricaoestadual = value; }
        }
        public string CEP
        {
            get { return Cep; }
            set { Cep = value; }
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
        public string cidade
        {
            get { return Cidade; }
            set { Cidade = value; }
        }
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public string celular
        {
            get { return Celular; }
            set { Celular = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into Fornecedor (Id_Fornecedor, Nome, CNPJ, InscricaoEstadual, Cep, Bairro," +
                "Endereco, Numero,Cidade,Estado,Telefone,Celular,Email) Values (@ID, @Nome, @CNPJ, @Inscricao, @Cep, @Bairro," +
                "@Endereco, @Numero,@Cidade,@Estado,@Telefone,@Celular,@Email)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Nome", nome);          
            comando.Parameters.AddWithValue("@CNPJ", Cnpj);
            comando.Parameters.AddWithValue("@Inscricao", Inscricao);
            comando.Parameters.AddWithValue("@Cep", CEP);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@Email", email);
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
        }
        public void Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update Fornecedor set Nome = @Nome, CNPJ =  @CNPJ, inscricaoEstadual =  @Inscricao, CEP =  @Cep, Bairro = @Bairro," +
                " Endereco = @Endereco, Numero = @Numero, Cidade = @Cidade, Estado = @Estado, Telefone = @Telefone, Celular = @Celular, Email = @Email where Id_fornecedor = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@CNPJ", Cnpj);
            comando.Parameters.AddWithValue("@Inscricao", Inscricao);
            comando.Parameters.AddWithValue("@Cep", CEP);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@Email", email);
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
        }
        public void Deletar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Delete from Fornecedor where Id_fornecedor = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);            
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
        }
        public void Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Fornecedor where Id_Fornecedor = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", id);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                nome = Tabela.Rows[0]["Nome"].ToString();
                Cnpj = Tabela.Rows[0]["CNPJ"].ToString();
                Inscricao = Tabela.Rows[0]["InscricaoEstadual"].ToString();
                CEP = Tabela.Rows[0]["Cep"].ToString();
                bairro = Tabela.Rows[0]["Bairro"].ToString();
                endereco = Tabela.Rows[0]["Endereco"].ToString();
                numero = Tabela.Rows[0]["Numero"].ToString();
                cidade = Tabela.Rows[0]["Cidade"].ToString();
                estado = Tabela.Rows[0]["Estado"].ToString();
                telefone = Tabela.Rows[0]["Telefone"].ToString();
                celular = Tabela.Rows[0]["Celular"].ToString();
                email = Tabela.Rows[0]["Email"].ToString();
            }
        }
    }
}
