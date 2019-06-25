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
    public partial class FrmRelatorioSaldoFinal : Form
    {


        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        public FrmRelatorioSaldoFinal()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Green;
        }

        int X = 0, Y = 0;
        private void PanelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmRelatorioSaldoFinal_Load(object sender, EventArgs e)
        {
            cb_Opcao.Text = "OPERADOR";
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            if ((cbxSaldoNegativo.Checked && cbxSaldoPositivo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> ''";
            }
            else if (cbxSaldoPositivo.Checked)
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and FluxoCaixa.SaldoCaixa >= 0";
            }
            else if (cbxSaldoNegativo.Checked)
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and FluxoCaixa.SaldoCaixa < 0";
            }

            SqlConnection conexao = new SqlConnection(stringConn);
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgvDadosSaldoFinal.DataSource = Tabela;
                    DestacarSaldoNegativo();
                    dgvDadosSaldoFinal.CurrentRow.Selected = false;
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

            if((cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa where DataSaida <> ''";
                SomarValoresCaixa();
                _sql = "Select sum(ValorCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> ''";
                SomarValoresRecebido();
                _sql = "Select sum(SaldoCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> ''";
                SomarValoresSaldoCaixa();
            }
            else if (cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked)
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa >= 0";
                SomarValoresCaixa();
                _sql = "Select sum(ValorCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa >= 0";
                SomarValoresRecebido();
                _sql = "Select sum(SaldoCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa >= 0";
                SomarValoresSaldoCaixa();
            }
            if (!cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked)
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa < 0";
                SomarValoresCaixa();
                _sql = "Select sum(ValorCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa < 0";
                SomarValoresRecebido();
                _sql = "Select sum(SaldoCaixa) AS ValorCaixa from FluxoCaixa where DataSaida <> '' and SaldoCaixa < 0";
                SomarValoresSaldoCaixa();
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_Descricao.Text == "")
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)";
            }

            if (cb_Opcao.SelectedIndex == 0)
            {
                Opcao = "FluxoCaixa.DataSaida";
            }
            else if (cb_Opcao.SelectedIndex == 1)
            {
                Opcao = "Usuario.Nome";
            }

            if ((cbxSaldoNegativo.Checked && cbxSaldoPositivo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)";
            }
            else if (cbxSaldoPositivo.Checked)
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103) and FluxoCaixa.SaldoCaixa >= 0";
            }
            else if (cbxSaldoNegativo.Checked)
            {
                _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103) and FluxoCaixa.SaldoCaixa < 0";
            }

            SqlConnection conexao = new SqlConnection(stringConn);
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@DataInicial", dtDataInicial.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@DataFinal", dtDataFinal.Text);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgvDadosSaldoFinal.DataSource = Tabela;
                    DestacarSaldoNegativo();
                    dgvDadosSaldoFinal.CurrentRow.Selected = false;
                }
                else
                {
                    MessageBox.Show("Dados não encontrado! Escolha outra opção...", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Resertar();
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

            if ((cbxSaldoNegativo.Checked && cbxSaldoPositivo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)";
                SomarValoresCaixa();

                _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)";
                SomarValoresRecebido();
                _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)";
                SomarValoresSaldoCaixa();
            }
            else if (cbxSaldoPositivo.Checked)
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa >= 0";
                SomarValoresCaixa();

                _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa >= 0";
                SomarValoresRecebido();
                _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa >= 0";
                SomarValoresSaldoCaixa();
            }
            else if (cbxSaldoNegativo.Checked)
            {
                _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa < 0";
                SomarValoresCaixa();

                _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa < 0";
                SomarValoresRecebido();
                _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and CONVERT(Date, FluxoCaixa.DataEntrada, 103) BETWEEN CONVERT(Date, @DataInicial, 103) AND CONVERT(Date, @DataFinal, 103)  and FluxoCaixa.SaldoCaixa < 0";
                SomarValoresSaldoCaixa();
            }
        }


        string Opcao;

        private void dgvDadosSaldoFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDadosSaldoFinal.CurrentRow.Selected = false;
            DestacarSaldoNegativo();
        }

        private void txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            if (cb_Opcao.SelectedIndex == 0)
            {
                Opcao = "FluxoCaixa.DataEntrada";
            }
            else if (cb_Opcao.SelectedIndex == 1)
            {
                Opcao = "Usuario.Nome";
            }

            if (txt_Descricao.Text != "")
            {
                if ((cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
                {
                    _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%'";
                }
                else if (cbxSaldoPositivo.Checked)
                {
                    _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa >= 0";
                }
                else if (cbxSaldoNegativo.Checked)
                {
                    _sql = "Select FluxoCaixa.DataEntrada, FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada AS ValorCaixa, FluxoCaixa.ValorCaixa as ValorRecebido, FluxoCaixa.SaldoCaixa, Usuario.Nome from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%'  and FluxoCaixa.SaldoCaixa < 0";
                }

                SqlConnection conexao = new SqlConnection(stringConn);
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.CommandText = _sql;
                try
                {
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    adapter.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        dgvDadosSaldoFinal.DataSource = Tabela;
                        DestacarSaldoNegativo();
                        dgvDadosSaldoFinal.CurrentRow.Selected = false;
                    }
                    else
                    {
                        MessageBox.Show("Dados não encontrado! Tente novamente.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Descricao.Clear();
                        Resertar();
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

                if (txt_Descricao.Text != "")
                {
                    if ((cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
                    {
                        _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%'";
                        SomarValoresCaixa();
                        _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%'";
                        SomarValoresRecebido();
                        _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%'";
                        SomarValoresSaldoCaixa();
                    }
                    else if (cbxSaldoPositivo.Checked)
                    {
                        _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa >= 0";
                        SomarValoresCaixa();
                        _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa >= 0";
                        SomarValoresRecebido();
                        _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa >= 0";
                        SomarValoresSaldoCaixa();
                    }
                    else if (cbxSaldoNegativo.Checked)
                    {
                        _sql = "Select sum(FluxoCaixa.ValorTotalCaixa - FluxoCaixa.ValorEntrada) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa < 0";
                        SomarValoresCaixa();
                        _sql = "Select sum(FluxoCaixa.ValorCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa < 0";
                        SomarValoresRecebido();
                        _sql = "Select sum(FluxoCaixa.SaldoCaixa) AS ValorCaixa from FluxoCaixa inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario where FluxoCaixa.DataSaida <> '' and " + Opcao + " like '" + txt_Descricao.Text.Trim() + "%' and FluxoCaixa.SaldoCaixa < 0";
                        SomarValoresSaldoCaixa();
                    }
                }              
            }
            else
            {
                CarregarGrid();
            }
        }

        private void DestacarSaldoNegativo()
        {
            foreach (DataGridViewRow row in dgvDadosSaldoFinal.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[3].Value.ToString()))
                {
                    if (Convert.ToDecimal(row.Cells["Column2"].Value) < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
                    }
                }
            }
        }

        private void cbxSaldoPositivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked)
            {
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
                else
                {
                    CarregarGrid();
                }
            }
            else if ((cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked) )
            {
                if (txt_Descricao.Text == "")
                {
                    CarregarGrid();
                }
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
            }
            else if (!cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked)
            {
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
                else
                {
                    CarregarGrid();
                }
            }
        }

        private void cbxSaldoNegativo_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked)
            {
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
                else
                {
                    CarregarGrid();
                }
            }
            else if ((cbxSaldoPositivo.Checked && cbxSaldoNegativo.Checked) || (!cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked))
            {
                if (txt_Descricao.Text == "")
                {
                    CarregarGrid();
                }
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
            }
            else if (cbxSaldoPositivo.Checked && !cbxSaldoNegativo.Checked)
            {
                if (txt_Descricao.Text != "")
                {
                    txt_Descricao_TextChanged(sender, e);
                }
                else
                {
                    CarregarGrid();
                }
            }
        }

        decimal valorTotalCaixa, ValorTotalRecebido, ValorTotalSaldoCaixa;
        private void SomarValoresCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", dtDataInicial.Text);
            comando.Parameters.AddWithValue("@Datafinal", dtDataFinal.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lblValorTotalCaixa.Text = "R$ 0,00";
                }
                else
                {
                    valorTotalCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lblValorTotalCaixa.Text = "R$ " + valorTotalCaixa;
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

        private void SomarValoresRecebido()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", dtDataInicial.Text);
            comando.Parameters.AddWithValue("@Datafinal", dtDataFinal.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lblValorTotalRecebido.Text = "R$ 0,00";
                }
                else
                {
                    ValorTotalRecebido = decimal.Parse(comando.ExecuteScalar().ToString());
                    lblValorTotalRecebido.Text = "R$ " + ValorTotalRecebido;
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

        private void SomarValoresSaldoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@DataInicial", dtDataInicial.Text);
            comando.Parameters.AddWithValue("@Datafinal", dtDataFinal.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lblValorTotalSaldo.Text = "R$ 0,00";
                }
                else
                {
                    ValorTotalSaldoCaixa = decimal.Parse(comando.ExecuteScalar().ToString());
                    lblValorTotalSaldo.Text = "R$ " + ValorTotalSaldoCaixa;
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

        private void Resertar()
        {
            cbxSaldoNegativo.Checked = false;
            cbxSaldoPositivo.Checked = false;
            txt_Descricao.Clear();
            cb_Opcao.SelectedIndex = 1;
            CarregarGrid();
        }
    }
}