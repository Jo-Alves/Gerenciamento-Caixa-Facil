using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassEmpresa
    {
        private int ID;
        private string RazaoSocial;
        private string NomeFantasia;
        private string AreaAtuacao;
        private string Cnpj;
        private string InscricaoEstadual;
        private string Endereco;
        private string Cep;
        private int Numero;
        private string Bairro;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Celular;
        private string Email;
        private string LogoEmpresa;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }          
        public string razaoSocial
        {
            get { return RazaoSocial; }
            set { RazaoSocial = value; }
        }
        public string nomeFantasia
        {
            get { return NomeFantasia; }
            set { NomeFantasia = value; }
        }
        public string areaAtuacao
        {
            get { return AreaAtuacao; }
            set { AreaAtuacao = value; }
        }
        public string CNPJ
        {
            get { return Cnpj; }
            set { Cnpj = value; }
        }
        public string inscricao
        {
            get { return InscricaoEstadual; }
            set { InscricaoEstadual = value; }
        }
        public string endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }
        public string CEP
        {
            get { return Cep; }
            set { Cep = value; }
        }
        public int numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
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
        public string logoEmpresa
        {
            get { return LogoEmpresa; }
            set { LogoEmpresa = value; }
        }


        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
        public bool cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Empresa";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
        
                _sql = "Insert into empresa values (@ID_Empresa, @Razao, @Nome, @AreaAtuacao, @CNPJ, @Inscricao, @Endereco, @CEP, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Celular, @Email, @LogoEmpresa)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Id_Empresa", id);
                comando.Parameters.AddWithValue("@Razao", razaoSocial);
                comando.Parameters.AddWithValue("@Nome", nomeFantasia);
                comando.Parameters.AddWithValue("@AreaAtuacao", areaAtuacao);
                comando.Parameters.AddWithValue("@CNPJ", CNPJ);
                comando.Parameters.AddWithValue("@Inscricao", inscricao);
                comando.Parameters.AddWithValue("@Endereco", endereco);
                comando.Parameters.AddWithValue("@CEP", CEP);
                comando.Parameters.AddWithValue("@Numero", numero);
                comando.Parameters.AddWithValue("@Bairro", bairro);
                comando.Parameters.AddWithValue("@Cidade", cidade);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@Telefone", telefone);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@LogoEmpresa", logoEmpresa);
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
        public void Atualizar()
        {
           
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update  empresa set RazaoSocial = @Razao, NomeFantasia = @Nome, AreaAtuacao = @AreaAtuacao, CNPJ =  @CNPJ, InscricaoEstadual = @Inscricao, Endereco = @Endereco, CEP = @CEP, Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, Telefone = @Telefone, Celular = @Celular, Email = @Email, LogoEmpresa = @LogoEmpresa where Id_Empresa = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id); comando.Parameters.AddWithValue("@Razao", razaoSocial);
            comando.Parameters.AddWithValue("@Nome", nomeFantasia);
            comando.Parameters.AddWithValue("@AreaAtuacao", areaAtuacao);
            comando.Parameters.AddWithValue("@CNPJ", CNPJ);
            comando.Parameters.AddWithValue("@Inscricao", inscricao);
            comando.Parameters.AddWithValue("@Endereco", endereco);
            comando.Parameters.AddWithValue("@CEP", CEP);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@LogoEmpresa", logoEmpresa);
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
        public void Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Empresa";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);            
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    razaoSocial = Tabela.Rows[0]["RazaoSocial"].ToString();
                    nomeFantasia = Tabela.Rows[0]["NomeFantasia"].ToString();
                    CNPJ = Tabela.Rows[0]["CNPJ"].ToString();
                    inscricao = Tabela.Rows[0]["InscricaoEstadual"].ToString();
                    endereco = Tabela.Rows[0]["Endereco"].ToString();
                    CEP = Tabela.Rows[0]["CEP"].ToString();
                    numero = int.Parse(Tabela.Rows[0]["Numero"].ToString());
                    bairro = Tabela.Rows[0]["Bairro"].ToString();
                    cidade = Tabela.Rows[0]["Cidade"].ToString();
                    estado = Tabela.Rows[0]["Estado"].ToString();
                    telefone = Tabela.Rows[0]["Telefone"].ToString();
                    celular = Tabela.Rows[0]["Celular"].ToString();
                    email = Tabela.Rows[0]["Email"].ToString();
                    logoEmpresa = Tabela.Rows[0]["LogoEmpresa"].ToString();
                }
                areaAtuacao = Tabela.Rows[0]["AreaAtuacao"].ToString();
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

        public void CadastrarLogo()
        {
            byte[] imagem = Encoding.ASCII.GetBytes(logoEmpresa);
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into ImagemEmpresa values (@Foto, @ID)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Foto", imagem);
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
