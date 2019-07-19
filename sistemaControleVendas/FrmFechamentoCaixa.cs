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
    public partial class FrmFechamentoCaixa : Form
    {
        public FrmFechamentoCaixa(string Data, string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.Data = Data;
           
        }

        string Usuario, Data;
        private void BuscarId_Usuario()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Id_Usuario from Usuario where Usuario = @Usuario";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Usuario", Usuario);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                Id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
            }
        }

        int Id_Caixa;
        private void RegistroCaixa(string Data, int Id_Usuario)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from FluxoCaixa inner join Usuario on Usuario.Id_Usuario=FluxoCaixa.Id_Usuario where FluxoCaixa.Id_Usuario = @Id_Usuario and convert(Date, FluxoCaixa.DataEntrada, 103) = Convert(Date, @Data, 103)";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.SelectCommand.Parameters.AddWithValue("@Data", Data);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_ValorEntrada.Text = Tabela.Rows[0]["ValorEntrada"].ToString();

                Id_Usuario = int.Parse(Tabela.Rows[0]["Id_Usuario"].ToString());
                DataEntrada = Tabela.Rows[0]["DataEntrada"].ToString();
                HoraEntrada = Tabela.Rows[0]["HoraEntrada"].ToString();
                txt_DateTimeAberturaCaixa.Text = DataEntrada + ", " + HoraEntrada;
                txt_Operador.Text = Tabela.Rows[0]["Nome"].ToString();
                Id_Caixa = int.Parse(Tabela.Rows[0]["Id_Fluxo"].ToString());
                txt_CodigoCaixa.Text = Id_Caixa.ToString();
                txt_Desconto.Text = "R$ " + Tabela.Rows[0]["Desconto"].ToString();
                decimal ValorPrazo = decimal.Parse(Tabela.Rows[0]["ValorRecebidoPrazo"].ToString());
                decimal ValorParcela = decimal.Parse(Tabela.Rows[0]["ValorRecebidoParcela"].ToString());
                decimal ValorParcial = decimal.Parse(Tabela.Rows[0]["ValorRecebidoParcial"].ToString());
                txt_ValorRecebido.Text = "R$ " + Tabela.Rows[0]["ValorCaixa"].ToString();
                txt_ValorReceber.Text = (ValorParcela + ValorParcial + ValorPrazo).ToString();
                txt_ValorTotalCaixa.Text = Tabela.Rows[0]["ValorTotalCaixa"].ToString();
                decimal saldo = decimal.Parse(Tabela.Rows[0]["SaldoCaixa"].ToString());
                if (saldo > 0)
                {
                    txt_SaldoCaixa.ForeColor = Color.Green;
                }
                else if (saldo < 0)
                {
                    txt_SaldoCaixa.ForeColor = Color.Red;
                }
                txt_SaldoCaixa.Text = "R$ " + saldo;
                txt_ValorCredito.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoCredito"].ToString();
                txt_ValorDebito.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoDebito"].ToString();
            }
        }

        private void RegistroSaidaCaixa()
        {
             SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from FluxoCaixa inner join SaidaCaixa on SaidaCaixa.Id_Fluxo = FluxoCaixa.Id_Fluxo where SaidaCaixa.Id_Fluxo = @Id_Fluxo";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Fluxo", Id_Caixa);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                txt_ValorRetiradas.Text = Tabela.Rows[0]["ValorSaida"].ToString();
            }
            else
            {
                txt_ValorRetiradas.Text = "R$ 0,00";
            }
        }


        private void RegistroVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Produto.Id_Produto, Produto.Descricao AS DescricaoProduto, Produto.ValorVenda, ItensVenda.Quantidade, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda FROM Produto INNER JOIN ItensVenda ON Produto.Id_Produto = ItensVenda.Id_Produto INNER JOIN Venda ON ItensVenda.Id_Venda = Venda.Id_Venda INNER JOIN FormaPagamento ON Venda.Id_Venda = FormaPagamento.Id_Venda INNER JOIN Usuario ON Usuario.Id_Usuario = Venda.Id_Usuario WHERE (Usuario.Id_Usuario = @Id_Usuario) AND (convert(Date, Venda.DataVenda, 103) = Convert(Date, @DataVenda, 103))";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.SelectCommand.Parameters.AddWithValue("@DataVenda", DataEntrada);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_HistoricoVendas.DataSource = Tabela;
        }

        private void FrmFechamentoCaixa_Load(object sender, EventArgs e)
        {
            if (Data != "" && Usuario != "")
            {
                BuscarId_Usuario();
                RegistroCaixa(Data, Id_Usuario);
                RegistroSaidaCaixa();
                btn_Cancelar.Visible = false;
                btn_FecharCaixa.Visible = false;
                txt_ValorTotalCaixa.ReadOnly = true;
                txt_ValorTotalCaixa.BackColor = Color.White;
                RegistroVenda();
                txtValorCaixa.Visible = false;
                lblValorCaixa.Visible = false;
            }
            else
            {
                txt_ValorTotalCaixa.Focus();
                CodigoCaixa();
                ValoresCaixa();
                HistoricoVendas();
                txt_ValorEntrada.Text = "R$ " + ValorEntrada.ToString();
                txt_ValorRecebido.Text = "R$ " + ValoresRecebidos.ToString();
                ValoresSaidaCaixa();
                txt_DateTimeAberturaCaixa.Text = DataEntrada + ", " + HoraEntrada;
                txt_Operador.Text = NomeUsuario;
                if (ValorReceber == 0)
                {
                    txt_ValorReceber.Text = "R$ 0,00";
                }
                else
                {
                    txt_ValorReceber.Text = "R$ " + ValorReceber;
                }

                //decimal saldo
                txtValorCaixa.Text = "R$ " + ((ValoresRecebidos + ValorEntrada) - ValorSaida).ToString();
            }
        }

        private void HistoricoVendas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Produto.Id_Produto, Produto.Descricao As DescricaoProduto, Produto.ValorVenda, ItensVenda.Quantidade, ItensVenda.Valor, FormaPagamento.Descricao, Venda.DataVenda, Venda.HoraVenda FROM Produto INNER JOIN ItensVenda ON Produto.Id_Produto = ItensVenda.Id_Produto INNER JOIN Venda ON ItensVenda.Id_Venda = Venda.Id_Venda INNER JOIN FormaPagamento ON Venda.Id_Venda = FormaPagamento.Id_Venda inner join Usuario on Usuario.Id_Usuario=Venda.Id_Usuario where Usuario.Id_Usuario = @Id_Usuario and convert(Date, Venda.DataVenda, 103) >= convert(Date, @DataVenda, 103) and convert(time, Venda.HoraVenda, 108) > convert(time, @HoraVenda, 108)";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataVenda", DataEntrada);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.SelectCommand.Parameters.AddWithValue("@HoraVenda", HoraEntrada);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_HistoricoVendas.DataSource = Tabela;
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

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
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
                txt_CodigoCaixa.Text = comando.ExecuteScalar().ToString();
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
        string DataEntrada, HoraEntrada, NomeUsuario;

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ClassFluxoCaixa FluxoCaixa = new ClassFluxoCaixa();
        private void btn_FecharCaixa_Click(object sender, EventArgs e)
        {
           if (txt_ValorTotalCaixa.Text != "")
            {
                try
                {
                    FluxoCaixa.id = int.Parse(txt_CodigoCaixa.Text);
                    FluxoCaixa.dataSaida = DateTime.Now.ToShortDateString();
                    FluxoCaixa.horaSaida = DateTime.Now.ToLongTimeString();
                    FluxoCaixa.saldoCaixa = Saldo;
                    FluxoCaixa.valorTotalCaixa = ValorTotalCaixa;
                    FluxoCaixa.FinalizarCaixa();
                    MessageBox.Show("Caixa do dia Fechado!", "Fechamento do Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o valor total em caixa!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_ValorTotalCaixa.Focus();
            }
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Green;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
        private void PanelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void txt_ValorTotalCaixa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorTotalCaixa.Text != "")
                {
                    ValorTotalCaixa = decimal.Parse(txt_ValorTotalCaixa.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorTotalCaixa.Clear();
            }
        }

        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txt_ValorTotalCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorTotalCaixa.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
        decimal Saldo;

        private void FrmFechamentoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Cancelar_Click(sender, e);
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                txt_ValorTotalCaixa_Leave(sender, e);
                btn_FecharCaixa_Click(sender, e);
            }
        }

        private void txt_ValorTotalCaixa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorTotalCaixa.ReadOnly == false)
                {
                    if (txt_ValorTotalCaixa.Text != "")
                    {
                        txt_ValorTotalCaixa.Text = Convert.ToDecimal(txt_ValorTotalCaixa.Text.Trim()).ToString("0.00");
                        if (txt_ValorTotalCaixa.Text == "0,00")
                        {
                            Saldo = ((ValoresRecebidos + ValorEntrada) - ValorSaida);
                        }
                        else
                        {
                            Saldo = ValorTotalCaixa - ((ValoresRecebidos + ValorEntrada) - ValorSaida);
                        }                        txt_SaldoCaixa.Text = "R$ " + Saldo;
                        if (Saldo < 0)
                        {
                            txt_SaldoCaixa.ForeColor = Color.Red;
                        }
                        else if (Saldo > 0)
                        {
                            txt_SaldoCaixa.ForeColor = Color.Lime;
                        }
                        else
                        {
                            txt_SaldoCaixa.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorTotalCaixa.Clear();
            }
        }

        decimal ValorEntrada, ValoresRecebidos, ValorReceber, ValorTotalCaixa, ValorSaida;

        private void dgv_HistoricoVendas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_HistoricoVendas.ClearSelection();
        }

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Id_Usuario;
        public void ValoresCaixa()
        {
             SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.Id_Fluxo = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", txt_CodigoCaixa.Text);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    ValorEntrada = decimal.Parse(Tabela.Rows[0]["ValorEntrada"].ToString());
                    ValoresRecebidos = decimal.Parse(Tabela.Rows[0]["ValorCaixa"].ToString());
                    DataEntrada = Tabela.Rows[0]["DataEntrada"].ToString();
                    HoraEntrada = Tabela.Rows[0]["HoraEntrada"].ToString();
                    NomeUsuario = Tabela.Rows[0]["Nome"].ToString();
                    ValorReceber = decimal.Parse(Tabela.Rows[0]["ValorReceber"].ToString());
                    txt_Desconto.Text = "R$ " + Tabela.Rows[0]["Desconto"].ToString();
                    txt_ValorCredito.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoCredito"].ToString();
                    txt_ValorDebito.Text = "R$ " + Tabela.Rows[0]["ValorRecebidoDebito"].ToString();
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

        public void ValoresSaidaCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(SaidaCaixa.ValorSaida) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario inner join SaidaCaixa on SaidaCaixa.Id_Fluxo = FluxoCaixa.Id_Fluxo where FluxoCaixa.Id_Fluxo = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", txt_CodigoCaixa.Text);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txt_ValorRetiradas.Text = "R$ 0,00";
                }
                else
                {
                    ValorSaida = decimal.Parse(comando.ExecuteScalar().ToString());
                   txt_ValorRetiradas.Text = "R$ " + ValorSaida;
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
    }
}
