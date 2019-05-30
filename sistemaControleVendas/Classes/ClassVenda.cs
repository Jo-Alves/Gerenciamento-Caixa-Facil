using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassVenda
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;

        private int Id_Venda;
        private int Parcelas;
        private decimal ValorTotal;
        private decimal Desconto;
        private decimal Lucro;
        private string DataVenda;
        private string HoraVenda;
        private int Id_Usuario;
        private int Id_Cliente;
        
        public int Id
        {
            get { return Id_Venda; }
            set { Id_Venda = value; }
        }
        public int parcelas
        {
            get { return Parcelas; }
            set { Parcelas = value; }
        }
        public decimal valorTotal
        {
            get { return ValorTotal; }
            set { ValorTotal = value; }
        }
        public decimal desconto
        {
            get { return Desconto; }
            set { Desconto = value; }
        }
        public decimal lucro
        {
            get { return Lucro; }
            set { Lucro = value; }
        }
        public string dataVenda
        {
            get { return DataVenda; }
            set { DataVenda = value; }
        }
        public string horaVenda
        {
            get { return HoraVenda; }
            set { HoraVenda = value; }
        }
        public int id_usuario
        {
            get { return Id_Usuario; }
            set { Id_Usuario = value; }
        }
        public int id_cliente
        {
            get { return Id_Cliente; }
            set { Id_Cliente = value; }
        }       

        public void EfetuarVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into Venda values (@Id, @Parcela,  @Desconto, @ValorTotal, @Lucro, @DataVenda, @HoraVenda, @Id_Usuario, @Id_Cliente)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Parcela", parcelas);
            comando.Parameters.AddWithValue("@Desconto", desconto);
            comando.Parameters.AddWithValue("@ValorTotal", valorTotal);
            comando.Parameters.AddWithValue("@Lucro", lucro);
            comando.Parameters.AddWithValue("@DataVenda", dataVenda);
            comando.Parameters.AddWithValue("@HoraVenda", horaVenda);
            comando.Parameters.AddWithValue("@Id_Usuario", id_usuario);
            comando.Parameters.AddWithValue("@Id_Cliente", id_cliente);
         
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
            try
            {
                conexao.Open();
                _sql = "Select * from Venda where id_venda = @id";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("id", Id);
            comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    Id = int.Parse(Tabela.Rows[0]["Id_Venda"].ToString());
                    parcelas = int.Parse(Tabela.Rows[0]["parcelas"].ToString());
                    desconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    valorTotal = decimal.Parse(Tabela.Rows[0]["ValorTotal"].ToString());
                    lucro = decimal.Parse(Tabela.Rows[0]["Lucro"].ToString());
                    dataVenda = Tabela.Rows[0]["DataVenda"].ToString();
                    HoraVenda = Tabela.Rows[0]["HoraVenda"].ToString();
                    id_usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                    Id_Cliente = int.Parse(Tabela.Rows[0]["Id_Cliente"].ToString());
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
