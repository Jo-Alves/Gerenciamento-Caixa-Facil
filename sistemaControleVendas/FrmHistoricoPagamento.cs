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
    public partial class FrmHistoricoPagamento : Form
    {
        public FrmHistoricoPagamento()
        {
            InitializeComponent();
        }

        string NVenda, Cliente, dateTime, codCliente;
        decimal ValorVenda;

        private void MostrarHistoricoPagamento()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_DadosVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            MostrarHistoricoPagamento();
            cbFormaPagamento.Text = "Parcial";
        }

        int idVenda, idPagamentoParcial; decimal ValorRestante, ValorAbatido;
        private void informarValorVendaParcial()
        {
            InformarValorPagamentoParcial();
            InformarValorPagamentoAbatido();
            ValorVenda = ValorAbatido + ValorRestante;
        }

        private void InformarValorPagamentoParcial()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select sum(PagamentoParcial.ValorRestante) as valor, PagamentoParcial.Id_PagamentoParcial from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0  and PagamentoParcial.Id_Venda = " + NVenda + " group by PagamentoParcial.Id_PagamentoParcial";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    ValorRestante = decimal.Parse(Tabela.Rows[0]["valor"].ToString());
                    idPagamentoParcial = int.Parse(Tabela.Rows[0]["Id_PagamentoParcial"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InformarValorPagamentoAbatido()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select sum(ValorAbatido.ValorTotalAbatimento) as valor from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join ValorAbatido on ValorAbatido.Id_PagamentoParcial = PagamentoParcial.Id_PagamentoParcial inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0  and PagamentoParcial.Id_PagamentoParcial = " + idPagamentoParcial;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    ValorAbatido = decimal.Parse(Tabela.Rows[0]["valor"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void informarValorVendaPrazo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select distinct Venda.ValorTotal from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> ''  and ParcelaVenda.Id_Venda = " + NVenda;
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                ValorVenda = decimal.Parse(Tabela.Rows[0]["ValorTotal"].ToString());
                ValorAbatido = ValorVenda;
                ValorRestante = 0.00m;
            }
        }

        private void InformarValorPagamentoParcela()
        {
            InformarValorVendaParcela();
            InformarValorParcelaPago();
            ValorRestante = ValorVenda - ValorAbatido;
        }

        private void InformarValorVendaParcela()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Venda.ValorTotal from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> ''  and ParcelaVenda.Id_Venda = " + NVenda;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    ValorVenda = decimal.Parse(Tabela.Rows[0]["ValorTotal"].ToString());
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InformarValorParcelaPago()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select sum(ParcelaVenda.ValorParcelado) as ValorPago from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> ''  and ParcelaVenda.Id_Venda = " + NVenda;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    ValorAbatido = decimal.Parse(Tabela.Rows[0]["ValorPago"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;


        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
        string FormaPagamento;

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCliente.Text.Trim()))
                {
                    if (cbFormaPagamento.Text == "Parcela")
                    {
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> ''";
                    }
                    else if (cbFormaPagamento.Text == "Prazo")
                    {
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> ''";
                    }
                    else if (cbFormaPagamento.Text == "Parcial")
                    {
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0";
                    }

                    BuscarHistoricoPagamentoPorFormasPagamento();
                }
                else
                {
                   txtCliente_TextChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmHistoricoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnVerHistoricoPagamento_Click(sender, e);
            }
        }

        private void BuscarHistoricoPagamentoPorFormasPagamento()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgv_DadosVenda.DataSource = Tabela;
            }
            else
            {
                MessageBox.Show("Não há histórico de pagamentos realizados nesta forma de pagamento", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCliente.Clear();
                MostrarHistoricoPagamento();
                cbFormaPagamento.Text = "Parcial";
            }
        }

        private void dgv_DadosVenda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPagamento.Text == "Parcela")
            {
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> '' and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }
            else if (cbFormaPagamento.Text == "Prazo")
            {
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> '' and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }
            else if (cbFormaPagamento.Text == "Parcial")
            {
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as nomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0 and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }
                BuscarHistoricoPagamentoPorFormasPagamento();
        }

        private void btnVerHistoricoPagamento_Click(object sender, EventArgs e)
        {
            if(dgv_DadosVenda.CurrentRow.Selected == true)
            {
                if (cbFormaPagamento.Text == "Parcial")
                {
                    informarValorVendaParcial();
                }
                else if (cbFormaPagamento.Text == "Prazo")
                {
                    informarValorVendaPrazo();
                }
                else
                {
                    InformarValorPagamentoParcela();
                }

                FrmHistoricoPagamentoDetalhado historicoPagamentoDetalhado = new FrmHistoricoPagamentoDetalhado(NVenda, Cliente, dateTime, ValorVenda, cbFormaPagamento.Text, ValorAbatido, ValorRestante, idPagamentoParcial);
                historicoPagamentoDetalhado.ShowDialog();
            }
            else
            {
                MessageBox.Show("É necessário selecionar a venda para Visualizar o histórico!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dgv_DadosVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgv_DadosVenda.Rows[e.RowIndex];
                NVenda = row.Cells["ColVenda"].Value.ToString();
                codCliente = row.Cells["ColCodCliente"].Value.ToString();
                Cliente = row.Cells["ColCliente"].Value.ToString();              
                dateTime = row.Cells["ColDataVenda"].Value.ToString() + ", " + row.Cells["ColHoraVenda"].Value.ToString();
            }
        }

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
    }
}