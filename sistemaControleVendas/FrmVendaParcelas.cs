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
    public partial class FrmVendaParcelas : Form
    {
        decimal valorNCaixa, ValorTotal;
        decimal Montante, ValorEntrada, ValorReceber, valorParcela;
        int Nparcelas;
        public bool vendaConfirmada = false;
        public DataTable Parcelas;
        public int idCliente { get; set; }
        public decimal valorEntrada { get; set; }
        public decimal ValorParcelamento { get; set; }

        public FrmVendaParcelas(decimal ValorTotal)
        {
            InitializeComponent();
            this.ValorTotal = ValorTotal;
            Montante = ValorTotal;
            valorParcela = ValorTotal;
            txt_ValorVenda.Text = ValorTotal.ToString();
            txt_ValorParcela.Text = valorParcela.ToString();
        }

        private void txt_Busca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Pesquisar_Click(sender, e);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarCliente pesquisarCliente = new FrmPesquisarCliente();
            pesquisarCliente.ShowDialog();
            if (pesquisarCliente.Codigo != null && pesquisarCliente.Codigo != "1")
            {
                lbl_Codigo.Text = pesquisarCliente.Codigo;
                lbl_Nome.Text = pesquisarCliente.Nome;
                idCliente = int.Parse(pesquisarCliente.Codigo);
                lbl_Separador.Visible = true;
                txt_Busca.Text = pesquisarCliente.Nome;
            }
        }

        private void txt_ValorEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txt_ValorEntrada.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ValorEntrada_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorEntrada.Text != "")
                {
                    valorNCaixa = decimal.Parse(txt_ValorEntrada.Text);
                    txt_Juros_Leave(sender, e);
                    txt_NumeroParcelas_Leave(sender, e);
                    ValorReceber = Montante - ValorEntrada;
                    txt_ValorEntrada.Text = Convert.ToDecimal(txt_ValorEntrada.Text.Trim()).ToString("0.00");
                    valorEntrada = decimal.Parse(txt_ValorEntrada.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorEntrada.Text = "0,00";
            }
        }

        private void txt_ValorEntrada_TextChanged(object sender, EventArgs e)
        {
            if (txt_ValorEntrada.Text == "")
            {
                txt_ValorEntrada.Text = "0,00";
            }
        }

        private void txt_Juros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txt_Juros.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Juros_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Juros.Text != "")
                {
                    decimal Juros;
                    Juros = decimal.Parse(txt_Juros.Text);
                    Montante = (ValorTotal * Juros) / 100;
                    Montante += ValorTotal;
                    Nparcelas = int.Parse(txt_NumeroParcelas.Text);
                    txt_NumeroParcelas_Leave(sender, e);
                    txt_Juros.Text = Convert.ToDecimal(txt_Juros.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Juros.Text = "0,00";
            }
        }

        private void txt_NumeroParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_FecharParcelamento_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_FecharParcelamento.BackColor = Color.Red;
        }

        private void lbl_FecharParcelamento_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_FecharParcelamento.BackColor = Color.Transparent;
        }

        private void lbl_FecharParcelamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CancelarParcelamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVendaParcelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btn_CancelarParcelamento_Click(sender, e);
            if (e.KeyCode == Keys.F9)
                btn_GerarParcelamento_Click(sender, e);
            if (e.KeyCode == Keys.F10)
                btn_FinalizarParcelamento_Click(sender, e);
        }

        private void btn_FinalizarParcelamento_Click(object sender, EventArgs e)
        {

            if (idCliente > 0)
            {
                SituacaoCliente();
                if (situacaoClienteParcela == 0 && situacaoClientePrazo == 0)
                {
                    confirmarParcelas();
                    vendaConfirmada = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Venda não permitida. O cliente tem conta(s) vencida(s) com a empresa!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Informe o nome do cliente!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
           

        private void confirmarParcelas()
        {
            Parcelas = new DataTable();
            Parcelas.Columns.Add("nParcela", typeof(int));
            Parcelas.Columns.Add("vencimento", typeof(string));
            Parcelas.Columns.Add("valorParcela", typeof(decimal));

            foreach(DataGridViewRow dgwRow in dgv_Parcelas.Rows)
            {
                Parcelas.Rows.Add(int.Parse(dgwRow.Cells["ColumnNParcelas"].Value.ToString()), dgwRow.Cells["ColumnVencimento"].Value.ToString(), decimal.Parse(dgwRow.Cells["ColumnValorParcela"].Value.ToString()));
            }
        }

        private void txt_NumeroParcelas_Leave(object sender, EventArgs e)
        {
            try
            {
                btn_FinalizarParcelamento.Enabled = false;
                btn_GerarRepasse.Enabled = false;
                ValorEntrada = decimal.Parse(txt_ValorEntrada.Text);
                Nparcelas = int.Parse(txt_NumeroParcelas.Text);
                if (Montante > ValorTotal)
                {
                    valorParcela = (Montante - ValorEntrada) / Nparcelas;
                    valorParcela = Math.Round(valorParcela, 2);
                    txt_ValorParcela.Text = valorParcela.ToString();
                }
                else
                {
                    valorParcela = (ValorTotal - ValorEntrada) / Nparcelas;
                    valorParcela = Math.Round(valorParcela, 2);
                    txt_ValorParcela.Text = valorParcela.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_NumeroParcelas_TextChanged(object sender, EventArgs e)
        {
            if (txt_NumeroParcelas.Text == "0")
            {
                txt_NumeroParcelas.Text = "1";
            }
            else if (txt_NumeroParcelas.Text == "")
            {
                txt_NumeroParcelas.Text = "1";
            }
        }

        private void btn_GerarParcelamento_Click(object sender, EventArgs e)
        {
            dgv_Parcelas.Rows.Clear();
            Nparcelas = int.Parse(txt_NumeroParcelas.Text);

            string Vencimento = DateTime.Now.ToShortDateString();
            DateTime dv = DateTime.Parse(Vencimento);
            for (int i = 1; i <= Nparcelas; i++)
            {
                decimal ValorParcelas = (Montante - ValorEntrada) / Nparcelas;
                dv = dv.AddMonths(1);
                dgv_Parcelas.Rows.Add(i, dv.ToShortDateString(), ValorParcelas);
            }
            ValorParcelamento = valorParcela * Nparcelas;
            txt_ValorTotalParcelas.Text = "R$ " + ValorParcelamento;
            btn_FinalizarParcelamento.Enabled = true;
            btn_GerarRepasse.Enabled = true;
        }

        private void txt_Juros_TextChanged(object sender, EventArgs e)
        {
            if (txt_Juros.Text == "")
            {
                txt_Juros.Text = "0,00";
            }
        }

        int situacaoClienteParcela, situacaoClientePrazo;
        private void SituacaoCliente()
        {
            VerificarSituacaoClienteParcela();
            string DataAtual = DateTime.Now.ToShortDateString();
            DateTime DA = Convert.ToDateTime(DataAtual);
            DateTime DV = Convert.ToDateTime(DataVencimento);
            // Se a datavencimento for maior que a data atual o cliente não tem nenhuma parcela vencida , ou seja, ainda a prazo para o vencimento
            // caso contário a váriavel situaçãoClienteParcela irá receber valor 1 para a comparação
            if (DA <= DV)
            {
                situacaoClienteParcela = 0;
            }
            else
            {
                situacaoClienteParcela = 1;
            }
            if (DataVencimento == null)
            {
                situacaoClienteParcela = 0;
            }

            VerificarSituacaoClientePrazo();
            DataAtual = DateTime.Now.ToShortDateString();
            DA = Convert.ToDateTime(DataAtual);
            DV = Convert.ToDateTime(DatavencimentoPrazo);
            // Se a datavencimento for maior que a data atual o cliente não tem nenhuma pendência , ou seja, ainda a prazo para o vencimento
            // caso contário a váriavel situaçãoClientePrazo irá receber valor 1 para a comparação
            if (DA < DV)
            {
                situacaoClientePrazo = 0;
            }
            else
            {
                situacaoClientePrazo = 1;
            }
            if (DatavencimentoPrazo == null)
            {
                situacaoClientePrazo = 0;
            }
        }

        string DataVencimento;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void VerificarSituacaoClienteParcela()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Convert(Date, ParcelaVenda.DataVencimento, 103) as DataVencimento FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE (Cliente.Id_Cliente = @Id_Cliente) AND (FormaPagamento.Descricao = 'PARCELADO') AND (ParcelaVenda.DataPagamento = '')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Cliente", idCliente);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                DataVencimento = Tabela.Rows[0]["DataVencimento"].ToString();
            }
        }

        string DatavencimentoPrazo;
        private void VerificarSituacaoClientePrazo()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Convert(Date, ParcelaVenda.DataVencimento, 103) as DataVencimento FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE (Cliente.Id_Cliente = @Id_Cliente) AND (FormaPagamento.Descricao = 'PRAZO') AND (ParcelaVenda.DataPagamento = '')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id_Cliente", idCliente);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                DatavencimentoPrazo = Tabela.Rows[0]["DataVencimento"].ToString();
            }
        }
    }
}
