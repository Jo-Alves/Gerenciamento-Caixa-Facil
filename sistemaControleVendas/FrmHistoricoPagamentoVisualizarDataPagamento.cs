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
    public partial class FrmHistoricoPagamentoVisualizarDataPagamento : Form
    {
        string FormaPagamento, codVenda;
        int IdPagamentoparcial;
        public FrmHistoricoPagamentoVisualizarDataPagamento(string NVenda, string FormaPagamento, int idPagamentoParcial)
        {
            InitializeComponent();
            codVenda = NVenda;
            this.FormaPagamento = FormaPagamento;
            this.IdPagamentoparcial = idPagamentoParcial;
        }

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            if (FormaPagamento == "Parcela")
            {
                InformarDataEValorPagamentoParcelaPago();               
            }
            else if (FormaPagamento == "Prazo")
            {
                InformarDataEValorPagamentoPrazoPago();
            }
            else
            {
                InformarDataEValorPagamentoParcialPago();
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;


        private void InformarDataEValorPagamentoParcelaPago()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select ParcelaVenda.Id_Venda as venda, ParcelaVenda.ValorParcelado as ValorAbatido, ParcelaVenda.DataPagamento as DataAbatimento, ParcelaVenda.HoraPagamento as HoraAbatimento from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> ''  and ParcelaVenda.Id_Venda = " + codVenda;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dataGridView1.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InformarDataEValorPagamentoPrazoPago()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select ParcelaVenda.Id_Venda as venda, ParcelaVenda.ValorParcelado as ValorAbatido, ParcelaVenda.DataPagamento as DataAbatimento, ParcelaVenda.HoraPagamento as HoraAbatimento from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> ''  and ParcelaVenda.Id_Venda = " + codVenda;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dataGridView1.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InformarDataEValorPagamentoParcialPago()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select venda.id_Venda as venda, ValorAbatido.ValorTotalAbatimento as ValorAbatido,  ValorAbatido.DataPagamento as DataAbatimento,  ValorAbatido.HoraPagamento as HoraAbatimento from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join ValorAbatido on ValorAbatido.Id_PagamentoParcial = PagamentoParcial.Id_PagamentoParcial inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante >= 0 and ValorAbatido.ValorTotalAbatimento > 0  and PagamentoParcial.Id_PagamentoParcial = " + IdPagamentoparcial;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dataGridView1.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHistoricoPagamentoDetalhado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar_Click(sender, e);
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