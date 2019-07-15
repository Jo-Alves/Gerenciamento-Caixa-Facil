using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassClientes
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");

        private int Id;
        private string Nome;
        private string DataNascimento;
        private string Cpf;
        private string Rg;
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
        public string dataNascimento
        {
            get { return DataNascimento; }
            set { DataNascimento = value; }
        }
        public string CPF
        {
            get { return Cpf; }
            set { Cpf = value; }
        }
        public string RG
        {
            get { return Rg; }
            set { Rg = value; }
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
        string _sql;
        public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into Cliente (Id_Cliente, Nome, DataNascimento,CPF, RG, Cep, Bairro," + 
                "Endereco, Numero,Cidade,Estado,Telefone,Celular,Email) Values (@ID, @Nome, @DataNascimento, @CPF, @RG, @Cep, @Bairro," +
                "@Endereco, @Numero,@Cidade,@Estado,@Telefone,@Celular,@Email)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@CPF", CPF);
            comando.Parameters.AddWithValue("@RG", RG);
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
        public bool Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Cliente where Id_Cliente = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id", id);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                id = int.Parse(Tabela.Rows[0]["Id_Cliente"].ToString());
                nome = Tabela.Rows[0]["Nome"].ToString();
                dataNascimento = Tabela.Rows[0]["DataNascimento"].ToString();
                Cpf = Tabela.Rows[0]["CPF"].ToString();
                Rg = Tabela.Rows[0]["RG"].ToString();
                Cep = Tabela.Rows[0]["cep"].ToString();
                bairro = Tabela.Rows[0]["Bairro"].ToString();
                endereco = Tabela.Rows[0]["Endereco"].ToString();
                numero = Tabela.Rows[0]["Numero"].ToString();
                cidade = Tabela.Rows[0]["Cidade"].ToString();
                estado = Tabela.Rows[0]["Estado"].ToString();
                telefone = Tabela.Rows[0]["Telefone"].ToString();
                celular = Tabela.Rows[0]["Celular"].ToString();
                email = Tabela.Rows[0]["Email"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
             _sql = "UPDATE Cliente SET Nome = @Nome, DataNascimento = @DataNascimento, CPF= @CPF, RG = @RG, CEP = @CEP, Bairro = @Bairro, Endereco = @Endereco, Numero = @Numero, Cidade = @Cidade, Estado = @Estado, Telefone = @Telefone, Celular = @Celular, Email = @Email WHERE Id_Cliente = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);

            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@CPF", CPF);
            comando.Parameters.AddWithValue("@RG", RG);
            comando.Parameters.AddWithValue("@CEP", CEP);
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
            string _sql = "DELETE FROM Cliente WHERE Id_Cliente = @ID";
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
    }
}
