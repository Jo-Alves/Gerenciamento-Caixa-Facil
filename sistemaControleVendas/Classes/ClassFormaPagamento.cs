using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassFormaPagamento
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
        private int Id_FormaPagamento;
        private string Descricao;
        private int Id_Venda;

        public int id_FormaPagamento
        {
            get { return Id_FormaPagamento; }
            set { Id_FormaPagamento = value; }
        }
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
        public int id_Venda
        {
            get { return Id_Venda; }
            set { Id_Venda = value; }
        }

        public void InformarFormaPagamento()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into FormaPagamento values (@Descricao, @Id_Venda)";
            SqlCommand comando = new SqlCommand(_sql, conexao);            
            comando.Parameters.AddWithValue("@Descricao", descricao);
            comando.Parameters.AddWithValue("@Id_Venda", id_Venda);
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
