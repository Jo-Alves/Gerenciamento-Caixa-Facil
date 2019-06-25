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
    public partial class FrmRetiraDinheiroCaixa : Form
    {
        public FrmRetiraDinheiroCaixa()
        {
            InitializeComponent();
        }

        int Codigo;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
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
                Codigo = int.Parse(comando.ExecuteScalar().ToString());
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

        decimal ValorTotal, ValorTotalSaida;
        private void VerificarValorCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select (valorCaixa + ValorEntrada) from FluxoCaixa where DataSaida = '' and horaSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorTotal = 0.00m;
                }
                else
                {
                    ValorTotal = decimal.Parse(comando.ExecuteScalar().ToString());
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


        private void VerificarValorSaidaCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select sum(SaidaCaixa.ValorSaida) from FluxoCaixa inner join SaidaCaixa on SaidaCaixa.id_Fluxo = FluxoCaixa.Id_Fluxo where FluxoCaixa.DataSaida = '' and FluxoCaixa.horaSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorTotalSaida = 0.00m;
                }
                else
                {
                    ValorTotalSaida = decimal.Parse(comando.ExecuteScalar().ToString());
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

        private void FrmRetiraDinheiroCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_Retirar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_Cancelar_Click(sender, e);
            }
        }

        ClassFluxoCaixa FluxoCaixa = new ClassFluxoCaixa();
        private void btn_Retirar_Click(object sender, EventArgs e)
        {
            if (txt_Valor.Text != "" && rTB_Motivo.Text != "")
            {
                VerificarValorCaixa();
                VerificarValorSaidaCaixa();
                ValorTotal -= ValorTotalSaida;
                if (decimal.Parse(txt_Valor.Text) <= ValorTotal)
                {
                    FluxoCaixa.id = Codigo;
                    FluxoCaixa.valorRetiradas = decimal.Parse(txt_Valor.Text);
                    FluxoCaixa.motivoRetirada = " Motivo: " + rTB_Motivo.Text.ToUpper();
                    FluxoCaixa.RetirarDinheiroCaixa();

                    MessageBox.Show("Valor retirado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Valor.Clear();
                    rTB_Motivo.Clear();
                }
                else
                    MessageBox.Show("O valor é menor que o valor do caixa! Verifique novamente o valor a retirar.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha o valor da retiragem e o motivo", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Valor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Valor.Text != "")
                {
                    txt_Valor.Text = Convert.ToDecimal(txt_Valor.Text).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Valor.Clear();
            }
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Valor.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.LightCoral;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRetiraDinheiroCaixa_Load(object sender, EventArgs e)
        {
            CodigoCaixa();
            txt_Valor.Focus();
        }
    }
}
