using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassAutenticacao
    {

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        private int Id_Usuario;
        private string Nome;
        private string Usuario;
        private string Senha;
        private string Funcao;

        public int id
        {
            get { return Id_Usuario; }
            set { Id_Usuario = value; }
        }
        public string NomeUsuario
        {
            get { return Nome; }
            set { Nome = value; }
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
        public string funcao
        {
            get { return Funcao; }
            set { Funcao = value; }
        }

        public bool Autenticar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _Sql = "Select * from Usuario where Usuario = @Usuario and Senha = @Senha";
            conexao.Open();
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
            comando.SelectCommand.Parameters.AddWithValue("@Senha", senha);            
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                id = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                NomeUsuario = Tabela.Rows[0]["Nome"].ToString();
                funcao = Tabela.Rows[0]["Funcao"].ToString();
                conexao.Close();
                return true;
            }
            else
            {
                conexao.Close();
                return false;
            }
           
        }
    }
}
