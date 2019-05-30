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
    public partial class FrmBaixarPagamentoParcial : Form
    {
        public FrmBaixarPagamentoParcial(decimal ValorConta, string CodigoCliente, string NomeCliente)
        {
            InitializeComponent();
            txt_ValorConta.Text = "R$ " + ValorConta.ToString();
            this.ValorConta = ValorConta;
            txt_CodigoCliente.Text = CodigoCliente;
            txt_Nome.Text = NomeCliente;
            CodigoCaixa();
            ValoresCaixa();
        }

        private void FrmBaixarPagamentoParcial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Cancelar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F10)
            {
                txt_ValorPago_Leave(sender, e);
                btn_Baixa_Click(sender, e);
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_Fechar_Click(sender, e);
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
        }

        int X = 0, Y = 0;
        private void panelPagamentoParcial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        decimal ValorAbatimento, ValorRestante, ValorConta;

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;
        private void Abater()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update PagamentoParcial set ValorRestante = @Restante, dataAbatimento = @DataAbatimento from PagamentoParcial inner join Venda on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Cliente on Cliente.Id_Cliente = venda.Id_Cliente where Cliente.Id_Cliente = @id and ValorRestante > 0";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", txt_CodigoCliente.Text);
            comando.Parameters.AddWithValue("@Restante", ValorRestante);
            comando.Parameters.AddWithValue("@DataAbatimento", DateTime.Now.ToShortDateString());
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }        

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorPago.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void btn_Baixa_Click(object sender, EventArgs e)
        {
            if (txt_ValorPago.Text != "")
            {
                ValorRecebido = decimal.Parse(txt_ValorPago.Text);
                if (ValorRecebido <= ValorConta)
                {
                    ValorNCaixa = decimal.Parse(txt_ValorPago.Text);
                    CaixaDia();
                    GerenciarCaixa();
                    InformarValorabatido();
                    Abater();
                    AtualizarValorReceber();
                    MessageBox.Show("Valor Abatido com sucesso! Valor Restante: " + txt_ValorRestante.Text, "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Informe valor menor ou igual ao valor da conta para abatimento!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Informe o valor para abater a conta!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        decimal ValorCaixa, ValorNCaixa;
        private void CaixaDia()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select ValorCaixa from FluxoCaixa where DataSaida = ''";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
                ValorCaixa = decimal.Parse(Tabela.Rows[0]["ValorCaixa"].ToString());
        }

        decimal ValorRecebido;
        private void GerenciarCaixa()
        {



            ValorCaixa += ValorNCaixa;
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update FluxoCaixa set ValorCaixa = @ValorCaixa, ValorRecebidoParcial = ValorRecebidoParcial + @ValorRecebidoParcial where HoraSaida = '' and DataSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorCaixa", ValorCaixa);
            comando.Parameters.AddWithValue("@ValorRecebidoParcial", ValorRecebido);
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
            
        ClassPagamentoParcial PagamentoParcial = new ClassPagamentoParcial();
        private void InformarValorabatido()
        {
             SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from PagamentoParcial inner join Venda on Venda.Id_Venda= PagamentoParcial.Id_Venda inner join Cliente on Cliente.Id_Cliente=venda.Id_Cliente where Cliente.Id_Cliente = @ID_Cliente and PagamentoParcial.ValorRestante > 0";
            try
            {
                conexao.Open();
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@ID_Cliente", txt_CodigoCliente.Text);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    int id = int.Parse(Tabela.Rows[0]["Id_PagamentoParcial"].ToString());
                    PagamentoParcial.Id = id;
                    PagamentoParcial.valorTotalAbatido = decimal.Parse(txt_ValorPago.Text);
                    PagamentoParcial.dataAbatimento = DateTime.Now.ToShortDateString();
                    PagamentoParcial.horaPagamento = DateTime.Now.ToLongTimeString();
                    PagamentoParcial.InserirValorAbatido();
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

        private void txt_ValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorPago.Text != "")
                {
                    ValorAbatimento = decimal.Parse(txt_ValorPago.Text);
                    ValorRestante = ValorConta - ValorAbatimento;
                    txt_ValorRestante.Text = "R$ " + ValorRestante;
                    txt_ValorPago.Text = Convert.ToDecimal(txt_ValorPago.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorPago.Clear();
            }
        }

        private void panelPagamentoParcial_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        int Id_FluxoCaixa, Id_Usuario;
        string DataEntrada, HoraEntrada;
        decimal ValorReceber;

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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

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
                    DataEntrada = Tabela.Rows[0]["DataEntrada"].ToString();
                    HoraEntrada = Tabela.Rows[0]["HoraEntrada"].ToString();
                    ValorReceber = decimal.Parse(Tabela.Rows[0]["ValorReceber"].ToString());
                    Id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void AtualizarValorReceber()
        {
            decimal ValorPago = decimal.Parse(txt_ValorPago.Text);
            ValorReceber -= ValorPago;
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update FluxoCaixa set ValorReceber = @ValorReceber from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario inner join Venda on Venda.Id_Usuario=Usuario.Id_Usuario inner join Cliente on Cliente.Id_Cliente = Venda.Id_Cliente inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda where FluxoCaixa.Id_Fluxo = @Id_Fluxo and  PagamentoParcial.DataAbatimento = @DataEntrada and venda.DataVenda = @DataEntrada and Venda.HoraVenda > @HoraEntrada and Usuario.Id_Usuario = @Id_Usuario and cliente.Id_Cliente = @Id_Cliente";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Id_Fluxo", Id_FluxoCaixa);
            comando.Parameters.AddWithValue("@DataEntrada", DataEntrada);
            comando.Parameters.AddWithValue("@HoraEntrada", HoraEntrada);
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.Parameters.AddWithValue("@Id_Cliente", txt_CodigoCliente.Text);
            comando.Parameters.AddWithValue("@ValorReceber", ValorReceber);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
