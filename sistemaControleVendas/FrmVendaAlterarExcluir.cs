﻿using System;
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
    public partial class FrmVendaAlterarExcluir : Form
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql, descricao, idItensVenda, idProduto;
        decimal Valor, lucroItens;

        public FrmVendaAlterarExcluir(string CodVenda, string Cliente, string FormaPagamento, string ValorVenda)
        {
            InitializeComponent();
            lblCodigoVenda.Text = CodVenda;
            lblCliente.Text = Cliente;
            lblValorTotal.Text = "R$ " + ValorVenda;
            this.CodVenda = CodVenda;
            this.FormaPagamento = FormaPagamento;
        }

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            dgv_ListaVenda.ClearSelection();
            ListaTodasVendas();
        }

        private void ListaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Venda.Id_Venda, produto.Descricao, ItensVenda.Valor, ItensVenda.Quantidade from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto where Venda.Id_Venda = " + CodVenda;
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
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

        private void dgv_ListaVenda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void dgv_ListaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contLinhas = e.RowIndex;
            if (contLinhas > -1)
            {
                DataGridViewRow linhas = dgv_ListaVenda.Rows[contLinhas];
                CodVenda = linhas.Cells[0].Value.ToString();
                descricao = linhas.Cells[1].Value.ToString();
            }
        }

       string CodVenda = "", Cliente, FormaPagamento;

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluirTudo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja mesmo excluir todos os itens da venda?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(dr == DialogResult.Yes)
            {
                ExcluirTodosItensVenda();
                ListaTodasVendas();
                this.Close();
            }
        }

        private void ExcluirTodosItensVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from Venda where id_Venda = @IdVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdVenda", CodVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Venda excluida!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            
            if (dgv_ListaVenda.CurrentRow.Selected == true)
            {
                DialogResult dr = MessageBox.Show("Deseja mesmo excluir este item da venda?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    BuscarIdItensVenda();
                    excluirItensVenda();
                    ListaTodasVendas();
                    if (dgv_ListaVenda.Rows.Count == 0)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o item para excluir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BuscarIdItensVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select ItensVenda.Id_ItensVenda from ItensVenda  inner join  Produto on Produto.Id_Produto = ItensVenda.Id_Produto where itensVenda.id_Venda = @idVenda and Produto.Descricao = @descricao";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@idVenda", CodVenda);
            comando.Parameters.AddWithValue("@descricao", descricao);
            comando.CommandText = _sql;
            
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    idItensVenda = dr[0].ToString();
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

        private void excluirItensVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from ItensVenda where id_ItensVenda = @IdItensVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdItensVenda", idItensVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Item excluido!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if (dgv_ListaVenda.CurrentRow.Selected == true)
            {
                FrmPesquisarProdutos pesquisarProdutos = new FrmPesquisarProdutos();
                pesquisarProdutos.ShowDialog();
                if (!string.IsNullOrEmpty(pesquisarProdutos.ID_PRODUTO))
                {
                    DialogResult dr = MessageBox.Show("Deseja mesmo alterar o produto " + descricao + " por " + pesquisarProdutos.Descricao + "?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {                        
                        idProduto = pesquisarProdutos.ID_PRODUTO;
                        lucroItens = decimal.Parse(pesquisarProdutos.Lucro);
                        Valor = decimal.Parse(pesquisarProdutos.ValorVenda);
                        BuscarIdItensVenda();
                        alterarItensVenda();
                        ListaTodasVendas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione o item para alterar!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        private void alterarItensVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ItensVenda set id_Produto = @idProduto, Valor = @Valor, lucroItens = @lucroItens  where id_ItensVenda = @IdItensVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdProduto", idProduto);
            comando.Parameters.AddWithValue("@IdItensVenda", idItensVenda);
            comando.Parameters.AddWithValue("@valor", Valor);
            comando.Parameters.AddWithValue("@lucroItens", lucroItens);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Item excluido!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
