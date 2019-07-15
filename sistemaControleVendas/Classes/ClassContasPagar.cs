using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassContasPagar
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
        private int Id;
        private string Beneficiario;
        private int NumeroDocumento;
        private string Vencimento;
        private double ValorDocumento;
        private string DataPagamento;
        private double Multa;
        private double Desconto;
        private double ValorPago;
        private string Referencia;
        private string Status;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string beneficiario
        {
            get { return Beneficiario; }
            set { Beneficiario = value; }
        }
        public int numeroDocumento
        {
            get { return NumeroDocumento; }
            set { NumeroDocumento = value; }
        }
        public string vencimento
        {
            get { return Vencimento; }
            set { Vencimento = value; }
        }
        public double valorDocumento 
        {
            get { return ValorDocumento; }
            set { ValorDocumento = value; }
        }
        public string dataPagamento
        {
            get { return DataPagamento; }
            set { DataPagamento = value; }
        }
        public double multa
        {
            get { return Multa; }
            set { Multa = value; }
        }
        public double desconto
        {
            get { return Desconto; }
            set { Desconto = value; }
        }
        public double valorPago
        {
            get { return ValorPago; }
            set { ValorPago = value; }
        }
        public string Referente
        {
            get { return Referencia; }
            set { Referencia = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        
        public void Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into ContasPagar (Beneficiario, NumeroDocumento, Vencimento, ValorDocumento, Desconto, Referencia, Status ) values (@Beneficiario, @NumeroDocumento, @Vencimento, @ValorDocumento, @Desconto, @Referencia, @Status)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Beneficiario", beneficiario);
            comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@Vencimento", vencimento);
            comando.Parameters.AddWithValue("@ValorDocumento", valorDocumento);
            comando.Parameters.AddWithValue("@Desconto", desconto);
            comando.Parameters.AddWithValue("@Referencia", Referente);
            comando.Parameters.AddWithValue("@Status", status);
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
            _sql = "Update ContasPagar set Beneficiario = @Beneficiario, Numerodocumeto = @NumeroDocumento, Vencimento = @Vencimento, ValorDocumento = @ValorDocumento where id = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", id); comando.Parameters.AddWithValue("@Beneficiario", beneficiario);
            comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
            comando.Parameters.AddWithValue("@Vencimento", vencimento);
            comando.Parameters.AddWithValue("@ValorDocumento", valorDocumento);
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
            _sql = "Delete from ContasPagar where Id = @Id and DataPagamento = @DataPagamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Datapagamento", dataPagamento);
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
            _sql = "Select * from ContasPagar where Id = @Id and Status = 'Não Pago'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id", id);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable tabela = new DataTable();
                comando.Fill(tabela);
                if (tabela.Rows.Count > 0)
                {
                    beneficiario = tabela.Rows[0]["Beneficiario"].ToString();
                    numeroDocumento = int.Parse(tabela.Rows[0]["NumeroDocumento"].ToString());
                    vencimento = tabela.Rows[0]["Vencimento"].ToString();
                    valorDocumento = double.Parse(tabela.Rows[0]["ValorDocumento"].ToString());
                    Referente = tabela.Rows[0]["Referencia"].ToString();
                    desconto = double.Parse(tabela.Rows[0]["Desconto"].ToString());
                    return true;
                }
                else
                    return false;
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
        public void QuitarPagamento()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update ContasPagar set Datapagamento = @DataPagamento, Multa = @Multa, ValorPago = @ValorPago, Status = @Status where id = @id";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@DataPagamento", dataPagamento);
            comando.Parameters.AddWithValue("@Multa", multa);
            comando.Parameters.AddWithValue("@ValorPago", valorPago);
            comando.Parameters.AddWithValue("@Status", status);
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
