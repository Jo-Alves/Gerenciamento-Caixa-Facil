using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassAgendamento
    {
        private int Id_Agenda;
        private string NomeCliente;
        private string Data;
        private string Horario;
        private string Servico;
        private string Telefone;
        private string Email;

        public int id
        {
            get { return Id_Agenda; }
            set { Id_Agenda = value; }
        }
        public string nomeCliente
        {
            get { return NomeCliente; }
            set { NomeCliente = value; }
        }
        public string data
        {
            get { return Data; }
            set { Data = value; }
        }
        public string horario
        {
            get { return Horario; }
            set { Horario = value; }
        }
        public string servico
        {
            get { return Servico; }
            set { Servico = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"),
        _Sql;
        public void Agendar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Insert into Agenda values (@NomeCliente, @Data, @Horario, @Servico, @Telefone, @Email)";
            SqlCommand comando = new SqlCommand(_Sql, conexao);
            comando.Parameters.AddWithValue("@NomeCliente", nomeCliente);
            comando.Parameters.AddWithValue("@Data", data);
            comando.Parameters.AddWithValue("Horario", horario);
            comando.Parameters.AddWithValue("@Servico", servico);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Email", email);
            comando.CommandText = _Sql;
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

        public void AtualizarAgendamento()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Update Agenda set NomeCliente =  @NomeCliente, Data = @Data, Horario = @Horario, Servico = @Servico, Telefone = @Telefone, Email = @Email where Id_Agenda = @Id_Agenda";
            SqlCommand comando = new SqlCommand(_Sql, conexao);
            comando.Parameters.AddWithValue("@Id_Agenda", id);
            comando.Parameters.AddWithValue("@NomeCliente", nomeCliente);
            comando.Parameters.AddWithValue("@Data", data);
            comando.Parameters.AddWithValue("Horario", horario);
            comando.Parameters.AddWithValue("@Servico", servico);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Email", email);
            comando.CommandText = _Sql;
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

        public void ExluirAgendamento()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Delete from Agenda where Id_Agenda = @Id_Agenda";
            SqlCommand comando = new SqlCommand(_Sql, conexao);
            comando.Parameters.AddWithValue("@Id_Agenda", id);
            comando.CommandText = _Sql;
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
