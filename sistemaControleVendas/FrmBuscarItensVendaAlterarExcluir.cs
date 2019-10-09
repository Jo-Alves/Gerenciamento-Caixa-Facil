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
    public partial class FrmBuscarItensVendaAlterarExcluir : Form
    {
        public FrmBuscarItensVendaAlterarExcluir()
        {
            InitializeComponent();
        }

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            ListaTodasVendas();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void ListaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.ValorTotal, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, FormaPagamento.Descricao from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        string NomeFantasia, Cidade, Numero, Endereco, CNPJ, Telefone, Estado, Bairro, FormaPagamento;

        private void dgv_ListaVenda_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CodVenda))
            {
                MessageBox.Show(@"Selecione a Venda que será devolvida\alterada!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                FrmVendaDevolverAlterarItens vendaAlterarExcluir = new FrmVendaDevolverAlterarItens(CodVenda, Cliente, FormaPagamento, ValorVenda, codCliente, dataVenda);
                vendaAlterarExcluir.ShowDialog();
                CodVenda = "";
                if (txtNomeCliente.Text != "")
                {
                    txtNomeCliente_TextChanged(sender, e);
                }
                else
                {
                    ListaTodasVendas();
                }
            }
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select distinct Venda.Id_Venda, Cliente.Id_Cliente, Cliente.Nome as NomeCliente, Venda.ValorTotal, Venda.DataVenda, Venda.HoraVenda, Usuario.Nome as NomeUsuario, FormaPagamento.Descricao from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto inner join Usuario on Usuario.Id_Usuario = Venda.Id_Usuario inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda where Cliente.Nome like '%" + txtNomeCliente.Text + "%'";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_ListaVenda.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ClassEmpresa empresa = new ClassEmpresa();

        private void dgv_ListaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contLinhas = e.RowIndex;
            if (contLinhas > -1)
            {
                DataGridViewRow linhas = dgv_ListaVenda.Rows[contLinhas];
                CodVenda = linhas.Cells["ColCodVenda"].Value.ToString();
                codCliente = linhas.Cells["ColCodCliente"].Value.ToString();
                Cliente = linhas.Cells["ColCliente"].Value.ToString();
                ValorVenda = linhas.Cells["ColValorVenda"].Value.ToString();
                FormaPagamento = linhas.Cells["ColFormaPagamento"].Value.ToString();
                dataVenda = linhas.Cells["ColDataVenda"].Value.ToString();
                horaVenda = linhas.Cells["ColHoraVenda"].Value.ToString();
                atendente = linhas.Cells["ColOperador"].Value.ToString();                
            }
        }

       string CodVenda = "", Cliente, horaVenda, dataVenda, atendente, ValorVenda, codCliente;

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
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
