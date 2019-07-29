using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaControleVendas
{
    public partial class FrmRegistroCaixa : Form
    {
        public FrmRegistroCaixa(string DataInicial, string DataFinal, string Operador, string Todos)
        {
            InitializeComponent();
            this.DataInicial = DataInicial;
            this.DataFinal = DataFinal;
            this.Operador = Operador;
            if (DataInicial != "" && DataFinal != "" && Operador != "" )
            {
                RegistrosPeriodicos();
            }
            else if (Todos == "Todos")
            {
                RegistrosTodos();
            }
            else
            {
                RegistrosDia();
                gb_ValoresPos.Visible = false;
                this.btn_VisualizaImprimir.Location = new System.Drawing.Point(264, 409);
            }
        }

        private void RegistrosTodos()
        {
            VisualizarFluxoCaixaCompleto();
            VisualizarFluxoCaixaVendaVistaCompleto();
            VisualizarFluxoCaixaVendaPrazoCompleto();
            VisualizarFluxoCaixaParcelaCompleto();
            VisualizarFluxoCaixaParcialCompleto();
            VisualizarFluxoCaixaDescontoCompleto();
            VisualizarFluxoCaixaValorEntradaCompleto();
            VisualizarFluxoCaixaValorSaidaCaixaCompleto();
            VisualizarFluxoCaixaEntradaParcelaCompleto();
            VisualizarFluxoCaixaValorInfCaixaCompleto();
            VisualizarFluxoCaixaValorSaldoFinalCaixaCompleto();
            VisualizarFluxoCaixaCreditoCompleto();
            VisualizarFluxoCaixaDebitoCompleto();
            lbl_RecebimentoParcela.Text = "R$ " + (ValorRecebidoParcela + EntradaParcela);
            lbl_SaldoCaixa.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada);
            lbl_Balanco.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada + ValorCredito + ValorDebito);
        }

        private void VisualizarFluxoCaixaDebitoCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorRecebidoDebito) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorDebito = 0.00m;
                    lbl_CartaoDebito.Text = "R$ " + ValorDebito;
                }
                else
                {
                    ValorDebito = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_CartaoDebito.Text = "R$ " + ValorDebito;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void VisualizarFluxoCaixaCreditoCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorRecebidoCredito) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorCredito = 0.00m;
                    lbl_CartaoCredito.Text = "R$ " + ValorCredito;
                }
                else
                {
                    ValorCredito = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_CartaoCredito.Text = "R$ " + ValorCredito;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void VisualizarFluxoCaixaValorSaldoFinalCaixaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.SaldoCaixa) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    SaldoFinal = 0.00m;
                    lbl_SaldoFinal.Text = "R$ 0,00";
                }
                else
                {
                    SaldoFinal = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaldoFinal.Text = "R$ " + SaldoFinal;

                    if (SaldoFinal > 0)
                    {
                        lbl_SaldoFinal.ForeColor = Color.Green;
                    }
                    else if (SaldoFinal < 0)
                    {
                        lbl_SaldoFinal.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }



        private void VisualizarFluxoCaixaValorInfCaixaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorTotalCaixa) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorInfCaixa = 0.00m;
                    lbl_ValorInfCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorInfCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorInfCaixa.Text = "R$ " + ValorInfCaixa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Sum(FluxoCaixa.ValorCaixa) From fluxoCaixa where convert(Date, FluxoCaixa.DataEntrada, 103) between convert(date, @DataInicial, 103) and convert(date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorCaixa = 0.00m;
                    lbl_SaldoCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaldoCaixa.Text = "R$ " + ValorCaixa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaVendaVistaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoVista) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(date, @DataInicial, 103) and convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorVendaVista = 0.00m;
                    lbl_ValorVenda.Text = "R$ " + ValorVendaVista;
                }
                else
                {
                    ValorVendaVista = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorVenda.Text = "R$ " + ValorVendaVista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaVendaPrazoCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoPrazo) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_RecebimentoPrazo.Text = "R$ 0,00";
                }
                else
                {
                    lbl_RecebimentoPrazo.Text = "R$ " + comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaParcelaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoParcela) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorRecebidoParcela = 0.00m;
                }
                else
                {
                    ValorRecebidoParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaEntradaParcelaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.EntradaParcela) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    EntradaParcela = 0.00m;
                }
                else
                {
                    EntradaParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaParcialCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoParcial) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_RecebimentoParcial.Text = "R$ 0,00";
                }
                else
                {
                    lbl_RecebimentoParcial.Text = "R$ " + comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaDescontoCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.Desconto) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial,103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    Desconto = 0.00m;
                    lbl_Descontos.Text = "R$ " + Desconto;
                }
                else
                {
                    Desconto = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_Descontos.Text = "R$ " + Desconto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorEntradaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorEntrada) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorEntrada = 0.00m;
                    lbl_EntradaCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorEntrada = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_EntradaCaixa.Text = "R$ " + ValorEntrada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorSaidaCaixaCompleto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(SaidaCaixa.ValorSaida) from SaidaCaixa inner join FluxoCaixa on FluxoCaixa.Id_Fluxo = SaidaCaixa.Id_Fluxo inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorSaida = 0.00m;
                    lbl_SaidaCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorSaida = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaidaCaixa.Text = "R$ " + ValorSaida;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        string AreaAtuacao;
        private void AreaAtuacaoEmpresa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select AreaAtuacao From Empresa";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql,conexao); ;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                AreaAtuacao = Tabela.Rows[0]["AreaAtuacao"].ToString();
            }
        }

        private void btn_VisualizaImprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmGradeFluxoDia gradeFluxoDia = new frmGradeFluxoDia(lbl_titulo.Text, lbl_EntradaCaixa.Text, lbl_SaidaCaixa.Text, lbl_ValorVenda.Text, lbl_Descontos.Text, lbl_SaldoCaixa.Text, lbl_RecebimentoPrazo.Text, lbl_RecebimentoParcela.Text, lbl_RecebimentoParcial.Text, lbl_ValorInfCaixa.Text, lbl_SaldoFinal.Text, lbl_CartaoDebito.Text, lbl_CartaoCredito.Text, lbl_Balanco.Text);
            gradeFluxoDia.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        string DataInicial, DataFinal, Operador;

        private void CodigoUsuario()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Id_Usuario From Usuario where nome = @Nome";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Nome", Operador);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    Id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void RegistrosPeriodicos()
        {
            lbl_titulo.Text = "Detalhe do fluxo de caixa do dia " + DataInicial + " à " + DataFinal;

            CodigoUsuario();
            VisualizarFluxoCaixaPeriodico();
            VisualizarFluxoCaixaVendaVistaPeriodico();
            VisualizarFluxoCaixaVendaPrazoPeriodico();
            VisualizarFluxoCaixaParcelaPeriodico();
            VisualizarFluxoCaixaParcialPeriodico();
            VisualizarFluxoCaixaDescontoPeriodico();
            VisualizarFluxoCaixaValorEntradaPeriodico();
            VisualizarFluxoCaixaValorSaidaCaixaPeriodico();
            VisualizarFluxoCaixaEntradaParcelaPeriodico();
            VisualizarFluxoCaixaValorInfCaixaPeriodico();
            VisualizarFluxoCaixaValorSaldoFinalCaixaPeriodico();
            VisualizarFluxoCaixaCreditoPeriodico();
            VisualizarFluxoCaixaDebitoPeriodico();
            lbl_RecebimentoParcela.Text = "R$ " + (ValorRecebidoParcela + EntradaParcela);
            lbl_SaldoCaixa.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada);
            lbl_Balanco.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada + ValorCredito + ValorDebito);
        }
        private void VisualizarFluxoCaixaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Sum(FluxoCaixa.ValorCaixa) From fluxoCaixa where convert(Date, FluxoCaixa.DataEntrada, 103) between convert(date, @DataInicial, 103) and convert(date, @DataFinal, 103) and Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorCaixa = 0.00m;
                    lbl_SaldoCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaldoCaixa.Text = "R$ " + ValorCaixa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaVendaVistaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoVista) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(date, @DataInicial, 103) and convert(Date, @DataFinal, 103) and Usuario.Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorVendaVista = 0.00m;
                    lbl_ValorVenda.Text = "R$ " + ValorVendaVista;
                }
                else
                {
                    ValorVendaVista = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorVenda.Text = "R$ " + ValorVendaVista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaVendaPrazoPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoPrazo) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_RecebimentoPrazo.Text = "R$ 0,00";
                }
                else
                {
                    lbl_RecebimentoPrazo.Text = "R$ " + comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        decimal ValorRecebidoParcela, EntradaParcela;
        private void VisualizarFluxoCaixaParcelaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoParcela) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorRecebidoParcela = 0.00m;
                }
                else
                {
                    ValorRecebidoParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaEntradaParcelaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.EntradaParcela) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    EntradaParcela = 0.00m;
                }
                else
                {
                    EntradaParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaParcialPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(FluxoCaixa.ValorRecebidoParcial) FROM  FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.Id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_RecebimentoParcial.Text = "R$ 0,00";
                }
                else
                {
                    lbl_RecebimentoParcial.Text = "R$ " + comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaDescontoPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.Desconto) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial,103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    Desconto = 0.00m;
                    lbl_Descontos.Text = "R$ " + Desconto;
                }
                else
                {
                    Desconto = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_Descontos.Text = "R$ " + Desconto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorEntradaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorEntrada) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorEntrada = 0.00m;
                    lbl_EntradaCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorEntrada = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_EntradaCaixa.Text = "R$ " + ValorEntrada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorSaidaCaixaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(SaidaCaixa.ValorSaida) from SaidaCaixa inner join FluxoCaixa on FluxoCaixa.Id_Fluxo = SaidaCaixa.Id_Fluxo inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorSaida = 0.00m;
                    lbl_SaidaCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorSaida = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaidaCaixa.Text = "R$ " + ValorSaida;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        decimal ValorCredito, ValorDebito;
        private void VisualizarFluxoCaixaDebitoPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorRecebidoDebito) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorDebito = 0.00m;
                    lbl_CartaoDebito.Text = "R$ " + ValorDebito;
                }
                else
                {
                    ValorDebito = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_CartaoDebito.Text = "R$ " + ValorDebito;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaCreditoPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorRecebidoCredito) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorCredito = 0.00m;
                    lbl_CartaoCredito.Text = "R$ " + ValorCredito;
                }
                else
                {
                    ValorCredito = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_CartaoCredito.Text = "R$ " + ValorCredito;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorSaldoFinalCaixaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.SaldoCaixa) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                   SaldoFinal = 0.00m;
                    lbl_SaldoFinal.Text = "R$ 0,00";
                }
                else
                {
                    SaldoFinal = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaldoFinal.Text = "R$ " + SaldoFinal;

                    if (SaldoFinal > 0)
                    {
                        lbl_SaldoFinal.ForeColor = Color.Green;
                    }
                    else if (SaldoFinal < 0)
                    {
                        lbl_SaldoFinal.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VisualizarFluxoCaixaValorInfCaixaPeriodico()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(FluxoCaixa.ValorTotalCaixa) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where Convert(Date, FluxoCaixa.DataEntrada, 103) between Convert(Date, @DataInicial, 103) and Convert(Date, @DataFinal, 103) and Usuario.id_Usuario = @Id_Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", DataInicial);
            comando.Parameters.AddWithValue("@DataFinal", DataFinal);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorInfCaixa = 0.00m;
                    lbl_ValorInfCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorInfCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorInfCaixa.Text = "R$ " + ValorInfCaixa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void RegistrosDia()
        {
            lbl_titulo.Text = "Detalhe do fluxo de caixa do dia " + DateTime.Now.ToShortDateString();
            CodigoCaixa();
            ValoresCaixa();

            lbl_EntradaCaixa.Text = "R$ " + ValorEntrada;
            InformarDescontoDia();
            InformarRetiradaCaixaDia();
            lbl_SaldoCaixa.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada);
            lbl_Balanco.Text = "R$ " + ((ValorCaixa - ValorSaida) + ValorEntrada + ValorCredito + ValorDebito);
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        int Id_FluxoCaixa;
        public void CodigoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Max(Id_Fluxo) from FluxoCaixa where DataSaida = '' and horaSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                Id_FluxoCaixa = int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        string DataEntrada, HoraEntrada, NomeUsuario;
        decimal ValorEntrada, ValorReceber, ValorSaida, Desconto, ValorVendaVista, ValorCaixa, ValorInfCaixa, SaldoFinal;

        int Id_Usuario;

        public void ValoresCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.Id_Fluxo = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", Id_FluxoCaixa);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    lbl_ValorVenda.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoVista"].ToString();
                    decimal ValorParcela = decimal.Parse(Tabela.Rows[0]["ValorRecebidoParcela"].ToString());
                    decimal EntradaParcela = decimal.Parse(Tabela.Rows[0]["EntradaParcela"].ToString());
                    lbl_RecebimentoParcela.Text = "R$ " + (ValorParcela + EntradaParcela);
                    lbl_RecebimentoParcial.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoParcial"].ToString();
                    lbl_RecebimentoPrazo.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoPrazo"].ToString();
                    ValorCredito = decimal.Parse(Tabela.Rows[0]["ValorRecebidoCredito"].ToString());
                    ValorDebito = decimal.Parse(Tabela.Rows[0]["ValorRecebidoDebito"].ToString());
                    lbl_CartaoCredito.Text = "R$ " + ValorCredito;
                    lbl_CartaoDebito.Text = "R$ " + ValorDebito;
                    ValorEntrada = decimal.Parse(Tabela.Rows[0]["ValorEntrada"].ToString());
                    DataEntrada = Tabela.Rows[0]["DataEntrada"].ToString();
                    HoraEntrada = Tabela.Rows[0]["HoraEntrada"].ToString();
                    NomeUsuario = Tabela.Rows[0]["Nome"].ToString();
                    ValorReceber = decimal.Parse(Tabela.Rows[0]["ValorReceber"].ToString());
                    Desconto = decimal.Parse(Tabela.Rows[0]["Desconto"].ToString());
                    Id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                    ValorCaixa = decimal.Parse(Tabela.Rows[0]["ValorCaixa"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void InformarDescontoDia()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Desconto from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.Id_Fluxo = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", Id_FluxoCaixa);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    lbl_Descontos.Text = "R$ " + Tabela.Rows[0]["Desconto"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void InformarRetiradaCaixaDia()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(SaidaCaixa.ValorSaida) from SaidaCaixa inner join FluxoCaixa on FluxoCaixa.Id_Fluxo = SaidaCaixa.Id_Fluxo where SaidaCaixa.Id_Fluxo = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", Id_FluxoCaixa);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_SaidaCaixa.Text = "R$ 0,00";
                }
                else
                {
                    ValorSaida = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_SaidaCaixa.Text = "R$ " + ValorSaida;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        int X = 0, Y = 0;
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmRegistroCaixa_Load(object sender, EventArgs e)
        {
            AreaAtuacaoEmpresa();
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO")
            {
                label11.Text = "Serviços";
                groupBox4.Text = "Recebimentos à vista";
            }
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
