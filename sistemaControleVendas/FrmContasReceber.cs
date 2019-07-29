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
    public partial class FrmContasReceber : Form
    {
        public FrmContasReceber()
        {
            InitializeComponent();
            ContasReceberPrazo();
            ContasReceberParcela();
            ContasReceberParcial();
            ValorContasReceberPrazo();
            ValorContasReceberParcela();
            ValorContasReceberParcial();
            ValorTotalReceber = ValorReceberParcela + ValorReceberParcial + ValorReceberPrazo;
            lbl_ValorTotal.Text = "R$ " + ValorTotalReceber;
            areaAtuacao();
            if(AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO")
            {
                dgv_Parcela.Columns["Column13"].HeaderText = "Cód. Serviço";
                dgv_Parcial.Columns["Column16"].HeaderText = "Cód. Serviço";
            }
        }

        decimal ValorReceberParcial, ValorReceberParcela, ValorReceberPrazo, ValorTotalReceber;

        private void ValorContasReceberParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Sum(PagamentoParcial.ValorRestante) FROM PagamentoParcial INNER JOIN Venda ON  PagamentoParcial.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Cliente.Id_Cliente = Venda.Id_Cliente WHERE PagamentoParcial.ValorRestante > 0";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorReceberParcial = 0.00m;
                    lbl_Parcial.Text = "R$ " + ValorReceberParcial;
                }
                else
                {
                    ValorReceberParcial = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_Parcial.Text = "R$ " + ValorReceberParcial;
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
        private void areaAtuacao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select AreaAtuacao From Empresa";
            SqlCommand comando = new SqlCommand(_sql,conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    AreaAtuacao = dr["AreaAtuacao"].ToString();
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

        private void ValorContasReceberParcela()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Sum(ParcelaVenda.ValorParcelado) FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN  FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE(ParcelaVenda.DataPagamento = '') AND(FormaPagamento.Descricao = 'parcelado')";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorReceberParcela = 0.00m;
                    lbl_ValorParcela.Text = "R$ " + ValorReceberParcela;
                }
                else
                {
                    ValorReceberParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorParcela.Text = "R$ " + ValorReceberParcela;
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

        private void ValorContasReceberPrazo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(ItensVenda.Valor) FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ItensVenda ON Venda.Id_Venda = ItensVenda.Id_Venda INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda INNER JOIN Produto ON ItensVenda.Id_Produto = Produto.Id_Produto where FormaPagamento.Descricao = 'prazo' and ParcelaVenda.DataPagamento = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();

                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorReceberPrazo = 0.00m;
                    lbl_ValorPrazo.Text = "R$ " + ValorReceberPrazo;
                }
                else
                {
                    ValorReceberPrazo = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorPrazo.Text = "R$ " + ValorReceberPrazo;
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

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void ContasReceberPrazo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Produto.Descricao, produto.ValorVenda, Cliente.Id_Cliente, Cliente.Nome, ItensVenda.Valor, ItensVenda.Quantidade,  ParcelaVenda.DataVencimento, Venda.DataVenda, Venda.HoraVenda FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ItensVenda ON Venda.Id_Venda = ItensVenda.Id_Venda INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda INNER JOIN Produto ON ItensVenda.Id_Produto = Produto.Id_Produto where FormaPagamento.Descricao = 'prazo' and ParcelaVenda.DataPagamento = ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Prazo.DataSource = Tabela;
        }

        private void ContasReceberParcela()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cliente.Id_Cliente, Cliente.Nome, Venda.Id_Venda, ParcelaVenda.Parcela, ParcelaVenda.DataVencimento, ParcelaVenda.ValorParcelado FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda INNER JOIN  FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE(ParcelaVenda.DataPagamento = '') AND(FormaPagamento.Descricao = 'parcelado')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Parcela.DataSource = Tabela;
        }

        private void ContasReceberParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cliente.Id_Cliente, Cliente.Nome, PagamentoParcial.ID_Venda, PagamentoParcial.ValorRestante FROM PagamentoParcial INNER JOIN Venda ON  PagamentoParcial.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Cliente.Id_Cliente = Venda.Id_Cliente WHERE PagamentoParcial.ValorRestante > 0";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Parcial.DataSource = Tabela;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.White;
            btn_Fechar.ForeColor = Color.Black;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
            btn_Fechar.ForeColor = Color.White;
        }

        private void dgv_Parcela_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Parcela.ClearSelection();
        }

        private void dgv_Prazo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Prazo.ClearSelection();
        }

        private void dgv_Parcial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Parcial.ClearSelection();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
