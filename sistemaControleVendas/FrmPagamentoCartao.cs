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
    public partial class FrmPagamentoCartao : Form
    {
        public string confirmacao { get; set; }
        public int Nota { get; set; }
        public decimal Desconto { get; set; }

        int CodigoVenda, IdUsuario;
        decimal ValorTotal, descontoDinheiro, DescontoPorcento, ValorDesconto, Lucro;
        string FormaPagamento;
        public FrmPagamentoCartao(string FormaPagamento, int CodigoVenda, decimal ValorTotal, decimal Lucro, int IdUsuario)
        {
            InitializeComponent();

            this.CodigoVenda = CodigoVenda;
            this.Lucro = Lucro;
            lbl_ValorTotal.Text = ValorTotal.ToString();
            this.ValorTotal = ValorTotal;
            txt_ValorDesconto.Text = ValorTotal.ToString();
            this.FormaPagamento = FormaPagamento;
            this.IdUsuario = IdUsuario;

            if (this.FormaPagamento == "Cartão de Crédito")
            {
                gbParcelas.Visible = true;
                btn_NotaPromissoria.Visible = false;
                this.Size = new Size(625, 690);
                btn_Finalizar.Location = new Point(413, 618);
                btn_Cancelar.Location = new Point(245, 618);
                btn_Finalizar.Enabled = false;
            }
            else if (this.FormaPagamento == "Cartão de Débito")
            {
                gbParcelas.Visible = false;
                btn_NotaPromissoria.Visible = true;
                this.Size = new Size(625, 273);
                btn_Finalizar.Location = new Point(413, 202);
                btn_Cancelar.Location = new Point(41, 202);
                btn_NotaPromissoria.Location = new Point(206, 202);
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        decimal ValorDescontoDinheiro, valorDescontoPorcento;

        private void FrmPagamentoCartao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btn_Cancelar_Click(sender, e);
            else if (e.KeyCode == Keys.F10)
            {
                if (btn_Finalizar.Enabled == true)
                {
                    btn_Finalizar_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.F9)
                btn_NotaPromissoria_Click(sender, e);
        }

        private void txt_DescontoDinheiro_Leave(object sender, EventArgs e)
        {
            if (txt_DescontoDinheiro.Text != "")
            {
                try
                {                    
                    ValorDescontoDinheiro = decimal.Parse(txt_DescontoDinheiro.Text);
                    if (ValorDescontoDinheiro <= ValorTotal)
                    {
                        valorDescontoPorcento = (ValorDescontoDinheiro * 100) / ValorTotal;
                        valorDescontoPorcento = Math.Round(valorDescontoPorcento, 2);
                        txt_DescontoPorcento.Text = valorDescontoPorcento.ToString();
                        txt_ValorDesconto.Text = (ValorTotal - decimal.Parse(txt_DescontoDinheiro.Text)).ToString();
                        txt_DescontoDinheiro.Text = decimal.Parse(txt_DescontoDinheiro.Text.Trim()).ToString("0.00");
                        txt_DescontoPorcento.Text = decimal.Parse(txt_DescontoPorcento.Text.Trim()).ToString("0.00");
                    }
                    else
                    {
                        txt_DescontoDinheiro.Text = "0,00";
                        txt_DescontoPorcento.Text = "0,00";
                        txt_ValorDesconto.Text = ValorTotal.ToString();
                        ValorDescontoDinheiro = 0.00M;
                        valorDescontoPorcento = 0.00M;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem do sistema 'Gerenciamento Tempo Lan'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DescontoDinheiro.Text = "0,00";
                }
            }
        }

        private void txt_DescontoPorcento_Leave(object sender, EventArgs e)
        {
            if (txt_DescontoPorcento.Text != "")
            {
                try
                {
                   valorDescontoPorcento = decimal.Parse(txt_DescontoPorcento.Text);
                    if (valorDescontoPorcento <= 100)
                    {
                        ValorDescontoDinheiro = (valorDescontoPorcento * ValorTotal) / 100;
                        ValorDescontoDinheiro = Math.Round(ValorDescontoDinheiro, 2);
                        txt_DescontoDinheiro.Text = ValorDescontoDinheiro.ToString();
                        txt_ValorDesconto.Text = (ValorTotal - decimal.Parse(txt_DescontoDinheiro.Text)).ToString();
                        txt_DescontoPorcento.Text = decimal.Parse(txt_DescontoPorcento.Text.Trim()).ToString("0.00");
                    }
                    else
                    {
                        txt_DescontoPorcento.Text = "0,00";
                        txt_DescontoDinheiro.Text = "0,00";
                        valorDescontoPorcento = 0.00M;
                        ValorDescontoDinheiro = 0.00M;
                        txt_ValorDesconto.Text = ValorTotal.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem do sistema 'Gerenciamento Tempo Lan'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_DescontoDinheiro.Text = "0,00";
                }
            }
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            dgv_Parcelas.Rows.Clear();
            decimal ValorPago = decimal.Parse(txt_ValorDesconto.Text);
            int NParcela = int.Parse(txtNParcelas.Text);
            string Vencimento = DateTime.Now.ToShortDateString();
            DateTime Venc = DateTime.Parse(Vencimento);
            decimal ValorParcela;
            ValorParcela = ValorPago / NParcela;
            ValorParcela = Math.Round(ValorParcela, 2);
            for (int i = 1; i <= NParcela; i++)
            {
                Venc = Venc.AddMonths(1);
                dgv_Parcelas.Rows.Add(i, Venc.ToShortDateString(), ValorParcela);
            }
            txt_ValorTotalParcelas.Text = "R$ " + ValorParcela.ToString();
            btn_Finalizar.Enabled = true;
        }

        private void txtNParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtNParcelas_TextChanged(object sender, EventArgs e)
        {
            btn_Finalizar.Enabled = false;
            if (txtNParcelas.Text == "")
                txtNParcelas.Text = "1";
            if (txtNParcelas.Text == "0")
                txtNParcelas.Text = "1";
        }

        private void txt_DescontoPorcento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txt_DescontoPorcento.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DescontoDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txt_DescontoDinheiro.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NotaPromissoria_Click(object sender, EventArgs e)
        {
            EfetuarVenda();
            EfetuarParcelas();
            confirmacao = "Venda realizada com sucesso!";
            Nota = 1;
            Desconto = decimal.Parse(txt_ValorDesconto.Text);
            Close();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            txt_DescontoDinheiro_Leave(sender, e);
            txt_DescontoPorcento_Leave(sender, e);
            EfetuarVenda();
            EfetuarParcelas();
            if(FormaPagamento == "Cartão de Crédito")
            {
                MessageBox.Show("Parcelas no cartão gravadas no banco de dados com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pagamento realizado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            confirmacao = "Venda realizada com sucesso!";
            Close();
        }

        ClassVenda Venda = new ClassVenda();

        private void txt_DescontoPorcento_TextChanged(object sender, EventArgs e)
        {
            if(FormaPagamento == "Cartão de Crédito")
            btn_Finalizar.Enabled = false;
        }

        private void txt_DescontoDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (FormaPagamento == "Cartão de Crédito")
                btn_Finalizar.Enabled = false;
        }

        ClassFormaPagamento formaPagamento = new ClassFormaPagamento();
        private void EfetuarVenda()
        {
            try
            {
                Venda.Id = CodigoVenda;
                Venda.parcelas = 1;
                Venda.desconto = decimal.Parse(txt_DescontoDinheiro.Text);
                Venda.valorTotal = decimal.Parse(txt_ValorDesconto.Text);
                Venda.lucro = Lucro;
                Venda.dataVenda = DateTime.Now.ToShortDateString();
                Venda.horaVenda = DateTime.Now.ToLongTimeString();
                Venda.id_usuario = IdUsuario;
                Venda.id_cliente = 1;
                Venda.EfetuarVenda();

                formaPagamento.descricao = FormaPagamento;
                formaPagamento.id_Venda = CodigoVenda;
                formaPagamento.InformarFormaPagamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ClassParcelaVenda pagamentoCartao = new ClassParcelaVenda();

        private void EfetuarParcelas()
        {
            if (FormaPagamento == "Cartão de Crédito")
            {
                try
                {
                    for (int i = 0; i < dgv_Parcelas.Rows.Count - 1; i++)
                    {
                        pagamentoCartao.N_Parcela = int.Parse(dgv_Parcelas.Rows[i].Cells[0].Value.ToString());
                        pagamentoCartao.vencimento = dgv_Parcelas.Rows[i].Cells[1].Value.ToString();
                        pagamentoCartao.valorParcelado = decimal.Parse(dgv_Parcelas.Rows[i].Cells[2].Value.ToString());
                        pagamentoCartao.dataPagamento = "";
                        pagamentoCartao.horaPagamento = "";
                        pagamentoCartao.id_Venda = CodigoVenda;
                        pagamentoCartao.inserirParcelas();
                        GerenciarCaixaCredito();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    pagamentoCartao.N_Parcela = 1;
                    pagamentoCartao.vencimento = DateTime.Now.ToShortDateString();
                    pagamentoCartao.valorParcelado = decimal.Parse(txt_ValorDesconto.Text);
                    pagamentoCartao.dataPagamento = DateTime.Now.ToShortDateString();
                    pagamentoCartao.horaPagamento = DateTime.Now.ToShortDateString();
                    pagamentoCartao.id_Venda = CodigoVenda;
                    pagamentoCartao.inserirParcelas();
                    GerenciarCaixaDebito();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GerenciarCaixaCredito()
        {
            decimal Desconto = decimal.Parse(txt_DescontoDinheiro.Text);
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"));
            string _sql = "update FluxoCaixa set Desconto = Desconto + @Desconto Where DataSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Desconto", Desconto);
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

        public void GerenciarCaixaDebito()
        {
            decimal Valor = decimal.Parse(txt_ValorDesconto.Text);
            decimal Desconto= decimal.Parse(txt_DescontoDinheiro.Text);
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"));
            string _sql = "update FluxoCaixa set ValorRecebidoDebito = ValorRecebidoDebito + @Valor, Desconto = Desconto + @Desconto Where DataSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Desconto", Desconto);
            comando.Parameters.AddWithValue("@Valor", Valor);
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
