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

        private void MostrarHistoricoPagamento()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante > 0";
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

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
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
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> ''";
                    }
                    else if (cbFormaPagamento.Text == "Prazo")
                    {
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> ''";
                    }
                    else if (cbFormaPagamento.Text == "Parcial")
                    {
                        _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante > 0";
                    }

                    BuscarHistoricoPagamentoPorFormasPagamento();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PARCELADO' and ParcelaVenda.DataPagamento <> '' and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }
            else if (cbFormaPagamento.Text == "Prazo")
            {
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join ParcelaVenda on ParcelaVenda.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PRAZO' and ParcelaVenda.DataPagamento <> '' and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }
            else if (cbFormaPagamento.Text == "Parcial")
            {
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.DataVenda, Venda.HoraVenda, Venda.ValorTotal, Usuario.Nome as NomeUsuario from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda inner join PagamentoParcial on PagamentoParcial.Id_Venda = Venda.Id_Venda inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario where FormaPagamento.Descricao = 'PAGAMENTO PARCIAL' and PagamentoParcial.ValorRestante > 0 and Cliente.Nome like '%" + txtCliente.Text.Trim() + "%'";
            }

            BuscarHistoricoPagamentoPorFormasPagamento();
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