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
    public partial class FrmContasClientes : Form
    {
        public FrmContasClientes()
        {
            InitializeComponent();
            areaAtuacao();
            if (AreaAtuacao == "SALÃO DE BELEZA" || AreaAtuacao == "PRESTAÇÃO DE SERVIÇO")
            {
                dgv_PagamentoParcelas.Columns[0].HeaderText = "Serviço";
                dgv_PagamentoParcial.Columns[0].HeaderText = "Serviço";
            }
        }

        string AreaAtuacao;
        private void areaAtuacao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select AreaAtuacao From Empresa";
            SqlCommand comando = new SqlCommand(_sql, conexao);
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
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void FrmContasClientes_Load(object sender, EventArgs e)
        {
            dgv_PagamentoParcelas.ClearSelection();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            lblNome_Cliente.Text = "";
            lblCodigo_Cliente.Text = "";
            lbl_SeparadorDados.Visible = false;
            cod = 0;
            PagamentoParcelas();
            PagamentoPrazo();
            PagamentoParcial();
            ValorTotal = 0.00m;
            Vencimento = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            ValorTotal = 0.00m;
            this.Close();
        }

        private void FrmContasClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Sair_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_Baixar_Click(sender, e);
            }
        }
        int cod = 0;
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            FrmPesquisarCliente pesquisarCliente = new FrmPesquisarCliente();
            pesquisarCliente.ShowDialog();
            if (pesquisarCliente.Codigo != null && pesquisarCliente.Codigo != "1")
            {
                txt_nome.Text = pesquisarCliente.Nome;
                lblCodigo_Cliente.Text = pesquisarCliente.Codigo;
                lblNome_Cliente.Text = pesquisarCliente.Nome;
                lbl_SeparadorDados.Visible = true;
                cod = int.Parse(pesquisarCliente.Codigo);
                PagamentoPrazo();
                PagamentoParcelas();
                PagamentoParcial();

                if (dgv_PagamentoParcelas.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count >= 1 && dgv_PagamentoPrazo.Rows.Count >= 1)
                {
                    tabPagamento.SelectedTab = Tab_ComprasPrazo;
                }
                else if (dgv_PagamentoPrazo.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count == 0 && dgv_PagamentoParcelas.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = Tab_ComprasPrazo;
                }
                else if (dgv_PagamentoParcelas.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count == 0 && dgv_PagamentoPrazo.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = tab_ComprasParceladas;
                }
                else if (dgv_PagamentoParcial.Rows.Count >= 1 && dgv_PagamentoParcelas.Rows.Count == 0 && dgv_PagamentoPrazo.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = tab_PagamentoParcial;
                }
                else if (dgv_PagamentoPrazo.Rows.Count >= 1 && dgv_PagamentoParcelas.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = Tab_ComprasPrazo;
                }
                else if (dgv_PagamentoPrazo.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count >= 1 && dgv_PagamentoParcelas.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = Tab_ComprasPrazo;
                }
                else if (dgv_PagamentoParcelas.Rows.Count >= 1 && dgv_PagamentoParcial.Rows.Count >= 1 && dgv_PagamentoPrazo.Rows.Count == 0)
                {
                    tabPagamento.SelectedTab = tab_ComprasParceladas;
                }
                else if (dgv_PagamentoParcelas.Rows.Count == 0 && dgv_PagamentoParcial.Rows.Count == 0 && dgv_PagamentoPrazo.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe conta associada ao cliente: " + pesquisarCliente.Codigo + " - " + pesquisarCliente.Nome, "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dgv_PagamentoParcelas.ClearSelection();
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;
        private void PagamentoParcelas()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT Venda.Id_Venda, ParcelaVenda.Parcela, ParcelaVenda.DataVencimento, ParcelaVenda.ValorParcelado, Venda.DataVenda, Venda.HoraVenda FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN FormaPagamento ON Venda.Id_Venda = FormaPagamento.Id_Venda INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda WHERE (FormaPagamento.Descricao = 'parcelado') AND (ParcelaVenda.DataPagamento = '') AND (Cliente.Id_Cliente = @id)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@id", cod);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_PagamentoParcelas.DataSource = Tabela;
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

        private void PagamentoPrazo()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT Produto.Id_Produto, Produto.Descricao, ItensVenda.Quantidade, Produto.Unidade, Produto.ValorVenda, ItensVenda.Valor, Venda.DataVenda, Venda.HoraVenda FROM Produto INNER JOIN ItensVenda ON Produto.Id_Produto = ItensVenda.Id_Produto INNER JOIN Venda ON ItensVenda.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Venda.Id_Cliente = Cliente.Id_Cliente INNER JOIN ParcelaVenda ON ParcelaVenda.Id_Venda = Venda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE(ParcelaVenda.DataPagamento = '') AND(FormaPagamento.Descricao = 'PRAZO') AND(Venda.Id_Cliente = @id)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@id", cod);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_PagamentoPrazo.DataSource = Tabela;
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

        decimal ValorRestante;
        private void PagamentoParcial()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT PagamentoParcial.ID_Venda, PagamentoParcial.ValorRestante, PagamentoParcial.DataAbatimento FROM PagamentoParcial INNER JOIN Venda ON  PagamentoParcial.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Cliente.Id_Cliente = Venda.Id_Cliente WHERE PagamentoParcial.ValorRestante > 0 AND Cliente.Id_cliente = @id";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@id", cod);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_PagamentoParcial.DataSource = Tabela;
                if (Tabela.Rows.Count > 0)
                {
                    ValorRestante = decimal.Parse(Tabela.Rows[0]["ValorRestante"].ToString());
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
        private void ValorPrazo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT SUM(ItensVenda.valor) FROM Produto INNER JOIN ItensVenda ON Produto.Id_Produto = ItensVenda.Id_Produto INNER JOIN Venda ON ItensVenda.Id_Venda = Venda.Id_Venda INNER JOIN Cliente ON Venda.Id_Cliente = Cliente.Id_Cliente INNER JOIN ParcelaVenda ON ParcelaVenda.Id_Venda = Venda.Id_Venda INNER JOIN FormaPagamento ON FormaPagamento.Id_Venda = Venda.Id_Venda WHERE(ParcelaVenda.DataPagamento = '') AND(FormaPagamento.Descricao = 'PRAZO') AND(Venda.Id_Cliente = @id)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@id", cod);
                comando.CommandText = _sql;
                DataTable Tabela = new DataTable();
                ValorTotal = decimal.Parse(comando.ExecuteScalar().ToString());
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
        int Id_Venda, NTParcela;
        private void NumeroParcelas()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT count(parcelaVenda.Parcela) FROM Cliente INNER JOIN Venda ON Cliente.Id_Cliente = Venda.Id_Cliente INNER JOIN FormaPagamento ON Venda.Id_Venda = FormaPagamento.Id_Venda INNER JOIN ParcelaVenda ON Venda.Id_Venda = ParcelaVenda.Id_Venda WHERE (FormaPagamento.Descricao = 'parcelado') AND (ParcelaVenda.DataPagamento = '') AND (Cliente.Id_Cliente = @ID_CLiente) AND ParcelaVenda.Id_Venda= @ID_Venda";
                SqlCommand comando = new SqlCommand(_sql, conexao); comando.Parameters.AddWithValue("@id_Cliente", cod); comando.Parameters.AddWithValue("@id_Venda", Id_Venda);
                comando.CommandText = _sql;
                NTParcela = int.Parse(comando.ExecuteScalar().ToString());

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

        decimal ValorTotal;
        private void btn_Baixar_Click(object sender, EventArgs e)
        {
            if (tabPagamento.SelectedTab == Tab_ComprasPrazo)
            {
                if (dgv_PagamentoPrazo.Rows.Count > 0)
                {
                    ValorPrazo();
                    if (ValorTotal > 0)
                    {
                        FrmBaixarPagamentoPrazo baixarPagamentoPrazo = new FrmBaixarPagamentoPrazo(ValorTotal, lblCodigo_Cliente.Text, lblNome_Cliente.Text);
                        baixarPagamentoPrazo.ShowDialog();
                        PagamentoPrazo();
                    }
                }
            }
            else if (tabPagamento.SelectedTab == tab_ComprasParceladas)
            {
                NumeroParcelas();
                if (Vencimento != "")
                {
                    FrmBaixarParcela BaixarParcelas = new FrmBaixarParcela(Id_Venda, Vencimento, ValorParcela, NumeroParcela, cod, lblNome_Cliente.Text, NTParcela);
                    BaixarParcelas.ShowDialog();
                    PagamentoParcelas(); dgv_PagamentoParcelas.ClearSelection();
                    Vencimento = "";
                }
                else
                {
                    MessageBox.Show("Selecione a parcela para pagamento!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (tabPagamento.SelectedTab == tab_PagamentoParcial)
            {
                if (dgv_PagamentoParcial.Rows.Count >= 1)
                {
                    FrmBaixarPagamentoParcial baixarPagamentoParcial = new FrmBaixarPagamentoParcial(ValorRestante, lblCodigo_Cliente.Text, lblNome_Cliente.Text);
                    baixarPagamentoParcial.ShowDialog();
                    PagamentoParcial();
                }
            }
        }

        string Vencimento = "", ValorParcela = "";

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Buscar_Click(sender, e);
            }
        }

        string NumeroParcela = "";
        private void dgv_PagamentoParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont > -1)
            {
                DataGridViewRow linha = dgv_PagamentoParcelas.Rows[e.RowIndex];
                Id_Venda = int.Parse(linha.Cells[0].Value.ToString());
                Vencimento = linha.Cells["Column2"].Value.ToString();
                ValorParcela = linha.Cells["Column3"].Value.ToString();
                NumeroParcela = linha.Cells["Column4"].Value.ToString();
            }
        }
    }
}
