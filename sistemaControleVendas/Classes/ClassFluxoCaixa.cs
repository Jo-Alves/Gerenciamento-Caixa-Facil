using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassFluxoCaixa
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;

        private int Id_Fluxo;
        private decimal ValorEntrada;
        private decimal ValorCaixa;
        private decimal ValorRetiradas;
        private decimal Desconto;
        private string MotivoRetirada;
        private decimal Lucro;
        private string DataEntrada;
        private string DataSaida;
        private string HoraEntrada;
        private string HoraSaida;
        private int Id_Usuario;
        private string NomeUsuario;
        private decimal ValorReceber;
        private decimal SaldoCaixa;
        private decimal ValorTotalCaixa;
        private decimal ValorRecebidoPrazo;
        private decimal ValorRecebidoParcial;
        private decimal ValorRecebidoVista;
        private decimal ValorRecebidoParcela;
        private decimal EntradaParcela;
        private decimal ValorRecebidoCredito;
        private decimal ValorRecebidoDebito;

        public int id
        {
            get { return Id_Fluxo; }
            set { Id_Fluxo = value; }
        }
        public decimal valorEntrada
        {
            get { return ValorEntrada; }
            set { ValorEntrada = value; }
        }
        public decimal valorCaixa
        {
            get { return ValorCaixa; }
            set { ValorCaixa = value; }
        }
        public decimal valorRetiradas
        {
            get { return ValorRetiradas; }
            set { ValorRetiradas = value; }
        }
        public decimal lucro
        {
            get { return Lucro; }
            set { Lucro = value; }
        }
        public string dataEntrada
        {
            get { return DataEntrada; }
            set { DataEntrada = value; }
        }
        public string dataSaida
        {
            get { return DataSaida; }
            set { DataSaida = value; }
        }
        public string horaEntrada
        {
            get { return HoraEntrada; }
            set { HoraEntrada = value; }
        }
        public string horaSaida
        {
            get { return HoraSaida; }
            set { HoraSaida = value; }
        }
        public int id_Usuario
        {
            get { return Id_Usuario; }
            set { Id_Usuario = value; }
        }
        public string nomeUsuario
        {
            get { return NomeUsuario; }
            set { NomeUsuario = value; }
        }
        public decimal valorReceber
        {
            get { return ValorReceber; }
            set { ValorReceber = value; }
        }
        public decimal saldoCaixa
        {
            get { return SaldoCaixa; }
            set { SaldoCaixa = value; }
        }
        public decimal valorTotalCaixa
        {
            get { return ValorTotalCaixa; }
            set { ValorTotalCaixa = value; }
        }
        public string motivoRetirada
        {
            get { return MotivoRetirada; }
            set { MotivoRetirada = value; }
        }
        public decimal desconto
        {
            get { return Desconto; }
            set { Desconto = value; }
        }
        public decimal valorRecebidoPrazo
        {
            get { return ValorRecebidoPrazo; }
            set { ValorRecebidoPrazo = value; }
        }
        public decimal valorRecebidoParcial
        {
            get { return ValorRecebidoParcial; }
            set { ValorRecebidoParcial = value; }
        }
        public decimal valorRecebidoVista
        {
            get { return ValorRecebidoVista; }
            set { ValorRecebidoVista = value; }
        }
        public decimal valorRecebidoParcela
        {
            get { return ValorRecebidoParcela; }
            set { ValorRecebidoParcela = value; }
        }
        public decimal entradaParcela
        {
            get { return EntradaParcela; }
            set { EntradaParcela = value; }
        }
        public decimal valorRecebidoCredito
        {
            get { return ValorRecebidoCredito; }
            set { ValorRecebidoCredito = value; }
        }
        public decimal valorRecebidoDebito
        {
            get { return ValorRecebidoDebito; }
            set { ValorRecebidoDebito = value; }
        }
        public void AbrirCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into FluxoCaixa (ValorCaixa, ValorEntrada, DataEntrada, HoraEntrada, DataSaida, HoraSaida, Id_Usuario, ValorReceber, Desconto, ValorTotalCaixa, ValorRecebidoPrazo, ValorRecebidoParcial, ValorRecebidoVista, ValorRecebidoParcela, EntradaParcela, ValorRecebidoCredito, ValorRecebidoDebito) values (@ValorCaixa, @ValorEntrada, @DataEntrada, @HoraEntrada, @DataSaida, @HoraSaida, @Id_Usuario, @ValorReceber, @Desconto, @ValorTotalCaixa, @ValorRecebidoPrazo, @ValorRecebidoParcial, @ValorRecebidoVista, @ValorRecebidoParcela, @EntradaParcela, @ValorRecebidoCredito, @ValorRecebidoDebito)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorEntrada", valorEntrada);
            comando.Parameters.AddWithValue("@Desconto", desconto);
            comando.Parameters.AddWithValue("@DataEntrada", dataEntrada);
            comando.Parameters.AddWithValue("@HoraEntrada", horaEntrada);
            comando.Parameters.AddWithValue("@ValorCaixa", valorCaixa);
            comando.Parameters.AddWithValue("@DataSaida", dataSaida);
            comando.Parameters.AddWithValue("@HoraSaida", horaSaida);
            comando.Parameters.AddWithValue("@Id_Usuario", id_Usuario);           
            comando.Parameters.AddWithValue("@ValorReceber", valorReceber);
            comando.Parameters.AddWithValue("@EntradaParcela", entradaParcela);
            comando.Parameters.AddWithValue("@ValorTotalCaixa", ValorTotalCaixa);
            comando.Parameters.AddWithValue("@ValorRecebidoParcial", valorRecebidoParcial);
            comando.Parameters.AddWithValue("@ValorRecebidoParcela", valorRecebidoParcela);
            comando.Parameters.AddWithValue("@ValorRecebidoVista", valorRecebidoVista);
            comando.Parameters.AddWithValue("@ValorRecebidoPrazo", valorRecebidoPrazo);
            comando.Parameters.AddWithValue("@ValorRecebidoCredito", valorRecebidoCredito);
            comando.Parameters.AddWithValue("@ValorRecebidoDebito", valorRecebidoDebito);
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
        public void GerenciarCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update FluxoCaixa set ValorCaixa = ValorCaixa + " + valorCaixa + " where HoraSaida = '' and DataSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
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
        public void FinalizarCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update FluxoCaixa set DataSaida = @DataSaida, HoraSaida = @HoraSaida, SaldoCaixa = @SaldoCaixa, ValorTotalCaixa = @ValorTotalCaixa where Id_Fluxo = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@DataSaida", dataSaida);
            comando.Parameters.AddWithValue("@HoraSaida", horaSaida);
            comando.Parameters.AddWithValue("@SaldoCaixa", saldoCaixa);
            comando.Parameters.AddWithValue("@ValorTotalCaixa", valorTotalCaixa);
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
        public bool SituacaoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from FluxoCaixa inner join Usuario on Usuario.id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida = '' and FluxoCaixa.HoraSaida = ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                nomeUsuario = Tabela.Rows[0]["Nome"].ToString();   
                DataEntrada = Tabela.Rows[0]["DataEntrada"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RetirarDinheiroCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Insert into SaidaCaixa values (@ValorSaida, @MotivoRetirada,  @ID_Fluxo)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
           comando.Parameters.AddWithValue("@ValorSaida", valorRetiradas);
            comando.Parameters.AddWithValue("@MotivoRetirada", motivoRetirada);
            comando.Parameters.AddWithValue("@ID_Fluxo", id);
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
