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
    public partial class FrmVendaDevolverAlterarItens : Form
    {
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql, descricao, idItensVenda, idProduto, idFluxoCaixa, codCliente, dataVenda;

        int MaxCodVenda, IdPagamentoParcial, qtdItens, qtdItensDevolvido;

        decimal Valor, lucroItens, ValorPago, ValorRestante, valorAbatido, ValorTotalPagamentoParcial, ValorVenda, valorEntrada, sumValorParcelado, valorSubTotal, ValorCaixaInicial, valorReceber;

        public FrmVendaDevolverAlterarItens(string CodVenda, string Cliente, string FormaPagamento, string ValorVenda, string codCliente, string dataVenda)
        {
            InitializeComponent();
            this.dataVenda = dataVenda;
            this.ValorVenda = decimal.Parse(ValorVenda);
            lblCodigoVenda.Text = CodVenda;
            lblCliente.Text = Cliente;
            lblValorTotal.Text = "R$ " + ValorVenda;
            this.CodVenda = CodVenda;
            this.FormaPagamento = FormaPagamento;
            this.codCliente = codCliente;
            if (FormaPagamento == "VISTA")
            {
                ValorPago = decimal.Parse(ValorVenda);
            }
            else if (FormaPagamento == "PAGAMENTO PARCIAL")
            {
                receberValor_e_IdPagamentoParcial();
                ValorTotalPagamentoParcial = ValorRestante + ReceberValorAbatido();
            }
            else if (FormaPagamento == "PARCELADO")
            {
                InformarValoresPagos();
                VerificarParcelas_E_ValorEntrada();
                valorEntrada = this.ValorVenda - sumValorParcelado;
                ValorPago += valorEntrada;
            }
            else
            {
                InformarValoresPagos();
            }
        }

        private void BuscarValorReceberFluxCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select ValorReceber from FluxoCaixa where DataSaida = '' and HoraSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdVenda", CodVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    valorReceber = decimal.Parse(comando.ExecuteScalar().ToString());
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

        private void VerificarParcelas_E_ValorEntrada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT SUM(ParcelaVenda.ValorParcelado) as ValorPago FROM ParcelaVenda INNER JOIN FormaPagamento ON ParcelaVenda.Id_Venda = FormaPagamento.Id_Venda WHERE ParcelaVenda.Id_Venda = @IdVenda AND FormaPagamento.Descricao = 'PARCELADO'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdVenda", CodVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    sumValorParcelado = decimal.Parse(comando.ExecuteScalar().ToString());
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

        // trechos de códigos para excluir todos os itens

        private void InformarValoresPagos()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            if (FormaPagamento == "PARCELADO")
            {
                _sql = "SELECT SUM(ParcelaVenda.ValorParcelado) as ValorPago FROM ParcelaVenda INNER JOIN FormaPagamento ON ParcelaVenda.Id_Venda = FormaPagamento.Id_Venda WHERE ParcelaVenda.Id_Venda = @IdVenda AND ParcelaVenda.DataPagamento <> '' AND FormaPagamento.Descricao = 'PARCELADO'";
            }
            else if (FormaPagamento == "PRAZO")
            {
                _sql = "SELECT SUM(ParcelaVenda.ValorParcelado) as ValorPago FROM ParcelaVenda INNER JOIN FormaPagamento ON ParcelaVenda.Id_Venda = FormaPagamento.Id_Venda WHERE ParcelaVenda.Id_Venda = @IdVenda AND ParcelaVenda.DataPagamento <> '' AND FormaPagamento.Descricao = 'PRAZO'";
            }
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdVenda", CodVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    ValorPago = decimal.Parse(comando.ExecuteScalar().ToString());
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

        private void receberValor_e_IdPagamentoParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select PagamentoParcial.ValorRestante, PagamentoParcial.Id_PagamentoParcial from PagamentoParcial inner join Venda on Venda.Id_Venda = PagamentoParcial.Id_Venda where Venda.Id_Cliente = @IdCliente and PagamentoParcial.ValorRestante > 0";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdCliente", codCliente);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    IdPagamentoParcial = int.Parse(dr["Id_PagamentoParcial"].ToString());
                    ValorRestante = decimal.Parse(dr["ValorRestante"].ToString());
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

        private decimal ReceberValorAbatido()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select Sum(ValorTotalAbatimento) as ValorTotalAbatimento from ValorAbatido where Id_PagamentoParcial = @IdPagamentoParcial";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdPagamentoParcial", IdPagamentoParcial);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    valorAbatido = decimal.Parse(dr["ValorTotalAbatimento"].ToString());
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
            return valorAbatido;
        }

        private void InformarIdVendaMaximo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            for (int i = 0; i <= 1; i++)
            {
                if (MaxCodVenda == 0)
                {
                    _sql = "Select Max(Venda.Id_Venda) as MaxCodVenda from Venda inner join FormaPagamento on FormaPagamento.Id_Venda = Venda.Id_Venda where Venda.Id_Venda <> " + CodVenda + " and Venda.Id_Cliente = " + codCliente + " and FormaPagamento.Descricao = 'PAGAMENTO PARCIAL'";
                }
                else if (MaxCodVenda > 0)
                {
                    _sql = "update PagamentoParcial set Id_Venda = " + MaxCodVenda + "where id_PagamentoParcial = " + IdPagamentoParcial;
                }
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    if (MaxCodVenda == 0)
                    {
                        if (comando.ExecuteScalar() != DBNull.Value)
                        {
                            MaxCodVenda = int.Parse(comando.ExecuteScalar().ToString());
                        }
                    }
                    else
                    {
                        comando.ExecuteNonQuery();
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
        }

        bool CodVendaIgual = false;

        private void VerificarIdVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from PagamentoParcial where Id_Venda = @IdVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdVenda", CodVenda);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    CodVendaIgual = true;
                }
                else
                {
                    CodVendaIgual = false;
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

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
            IdentificarFluxoCaixa();
            VerificarValorCaixa();
            VerificarSaidaCaixa();
            ValorCaixa = (ValorCaixa + ValorCaixaInicial) - ValorSaida;
            dgv_ListaVenda.ClearSelection();
            ListaTodasVendas();
            BuscarValorReceberFluxCaixa();
        }

        private void IdentificarFluxoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Id_Fluxo from FluxoCaixa where DataSaida = '' and HoraSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    idFluxoCaixa = dr["Id_Fluxo"].ToString();
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

        private void ListaTodasVendas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select Venda.Id_Venda, ItensVenda.Id_Produto, produto.Descricao, ItensVenda.Valor, ItensVenda.Quantidade, Venda.DataVenda from Cliente inner join venda on Venda.Id_Cliente = Cliente.Id_Cliente inner join ItensVenda on ItensVenda.Id_Venda = Venda.Id_Venda inner join Produto on Produto.Id_Produto = ItensVenda.Id_Produto where Venda.Id_Venda = " + CodVenda;
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

        string CodVenda = "", Cliente, FormaPagamento;

        private void btnDevolverTudo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja mesmo aceitar a devolução do produto(s)?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                if (ValorCaixa > 0)
                {
                    if (ValorCaixa >= ValorPago)
                    {
                        AlterarValoresPagamentoParcial_E_Parcelado();
                        verificarDataPagamento_E_AtualizarValoresFluxoCaixa();
                        ExcluirTodosItensVenda();
                        GerenciarFluxoCaixa();
                    }
                    else
                    {
                        dr = MessageBox.Show("O Valor a devolver para o cliente é maior que o valor que está em caixa no momento. Você deseja que retire o valor do caixa?", "Aviso do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                        if (dr == DialogResult.Yes)
                        {
                            AlterarValoresPagamentoParcial_E_Parcelado();
                            verificarDataPagamento_E_AtualizarValoresFluxoCaixa();
                            ExcluirTodosItensVenda();
                            GerenciarFluxoCaixa();
                        }
                        else if (dr == DialogResult.No)
                        {
                            AlterarValoresPagamentoParcial_E_Parcelado();
                            verificarDataPagamento_E_AtualizarValoresFluxoCaixa();
                            ExcluirTodosItensVenda(); ;
                        }
                    }
                }
                else
                {
                    dr = MessageBox.Show("Informamos que não existe valores no caixa no momento. Os valores da venda não irá afetar o fluxo do caixa. Deseja continuar?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        AlterarValoresPagamentoParcial_E_Parcelado();
                        verificarDataPagamento_E_AtualizarValoresFluxoCaixa();
                        ExcluirTodosItensVenda();
                    }
                }

                AtualizarTodoEstoque();
                this.Close();
            }
        }

        private void AtualizarTodoEstoque()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            for (int i = 0; i < dgv_ListaVenda.Rows.Count; i++)
            {
                _sql = "update Produto set EstoqueAtual = EstoqueAtual + @Quantidade where id_Produto = @IdProduto";

                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Quantidade", dgv_ListaVenda.Rows[i].Cells["ColQuantidade"].Value.ToString());
                comando.Parameters.AddWithValue("@IdProduto", dgv_ListaVenda.Rows[i].Cells["ColCodProduto"].Value.ToString());
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
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
        }

        decimal subValorVendaValorAbatido, subValorReceber;
        private void AlterarValoresPagamentoParcial_E_Parcelado()
        {
            if (FormaPagamento == "PAGAMENTO PARCIAL")
            {
                if (ValorTotalPagamentoParcial > ValorVenda)
                {
                    // primeiro Verifica se o idVenda informado é igual ao idVenda da tabela Pagamento Parcial

                    VerificarIdVenda();

                    if (CodVendaIgual)
                    {
                        InformarIdVendaMaximo();
                    }

                    subValorVendaValorAbatido = ValorTotalPagamentoParcial - ValorVenda - ReceberValorAbatido();
                    AlterarValorRestantePagamentoParcial();

                }
                else
                {
                    ValorPago = valorAbatido;
                }
            }
        }

        private void verificarDataPagamento_E_AtualizarValoresFluxoCaixa()
        {
            if (FormaPagamento == "PAGAMENTO PARCIAL")
            {
                VerificarDataAbatimentoDataVenda();
                subValorReceber = valorReceber - (ValorVenda - valorAbatido);
                if (valorReceber >= subValorReceber)
                    AtualizarValorReceberPagamentoParcial();
            }
            else if (FormaPagamento == "PRAZO")
            {
                subValorReceber = ValorVenda;
            }
            else
            {
                subValorReceber = ValorVenda - ValorPago;
            }
            if (valorReceber >= subValorReceber)
                AtualizarValorReceberPagamentoPrazoParcela();
        }

        private void AtualizarValorReceberPagamentoPrazoParcela()
        {
            if (FormaPagamento == "PARCELADO" || FormaPagamento == "PRAZO")
            {
                if (dataVenda == DateTime.Now.ToShortDateString())
                {
                    SqlConnection conexao = new SqlConnection(stringConn);

                    _sql = "update fluxoCaixa set ValorReceber = ValorReceber - @ValorReceber where DataSaida = '' and HoraSaida = ''";

                    SqlCommand comando = new SqlCommand(_sql, conexao);
                    comando.Parameters.AddWithValue("@ValorReceber", subValorReceber);
                    comando.CommandText = _sql;
                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
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
            }
        }

        private void verificarDataVendaPrazo()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            _sql = "Select ValorTotalAbatimento, DataPagamento from ValorAbatido where Id_PagamentoParcial = @IdPagamentoParcial";

            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdPagamentoParcial", IdPagamentoParcial);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    ValorPagamento = decimal.Parse(dr["ValorTotalAbatimento"].ToString());
                    DataAbatimento = dr["DataPagamento"].ToString();

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

        private void AtualizarValorReceberPagamentoParcial()
        {
            if (dataVenda == DateTime.Now.ToShortDateString() && DataAbatimento == DateTime.Now.ToShortDateString())
            {
                SqlConnection conexao = new SqlConnection(stringConn);

                _sql = "update fluxoCaixa set ValorReceber = @ValorReceber where DataSaida = '' and HoraSaida = ''";

                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@ValorReceber", subValorReceber);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
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
        }

        string DataAbatimento;
        decimal ValorPagamento;
        private void VerificarDataAbatimentoDataVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            _sql = "Select ValorTotalAbatimento, DataPagamento from ValorAbatido where Id_PagamentoParcial = @IdPagamentoParcial";

            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdPagamentoParcial", IdPagamentoParcial);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    ValorPagamento = decimal.Parse(dr["ValorTotalAbatimento"].ToString());
                    DataAbatimento = dr["DataPagamento"].ToString();

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

        private void AlterarValorRestantePagamentoParcial()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            _sql = "update PagamentoParcial set ValorRestante = @ValorRestante where Id_PagamentoParcial = @IdPagamentoParcial";

            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorRestante", subValorVendaValorAbatido);
            comando.Parameters.AddWithValue("@IdPagamentoParcial", IdPagamentoParcial);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        decimal ValorRetirado;
        private void GerenciarFluxoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            _sql = "insert into SaidaCaixa values (@Valor, 'Devolução de Itens vendidos', @IdFluxo)";

            SqlCommand comando = new SqlCommand(_sql, conexao);
            if (ValorCaixa >= ValorPago)
            {
                comando.Parameters.AddWithValue("@Valor", ValorPago);
            }
            else
            {
                comando.Parameters.AddWithValue("@Valor", ValorCaixa);
            }
            comando.Parameters.AddWithValue("@IdFluxo", idFluxoCaixa);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        decimal ValorCaixa, ValorSaida;
        private void VerificarValorCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select ValorCaixa, valorEntrada from FluxoCaixa  where DataSaida = '' and HoraSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    ValorCaixa = decimal.Parse(dr["ValorCaixa"].ToString());
                    ValorCaixaInicial = decimal.Parse(dr["ValorEntrada"].ToString());
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

        private void VerificarSaidaCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select sum(ValorSaida) as ValorSaida from SaidaCaixa  where Id_Fluxo = @IdFluxo";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@IdFluxo", idFluxoCaixa);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    ValorSaida = decimal.Parse(comando.ExecuteScalar().ToString());
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
                if (FormaPagamento != "PAGAMENTO PARCIAL" || ValorTotalPagamentoParcial == ValorVenda)
                {

                    string messagem = "";
                    if (ValorPago > 0)
                    {
                        messagem = " O valor já foi pago pelo cliente está no valor de " + ValorPago;
                    }

                    MessageBox.Show("Itens devolvidos!" + messagem, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Item alterado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Excluir Item

        private void btnDevolverItem_Click(object sender, EventArgs e)
        {
            if (qtdItens >= 2)
            {
                MessageBox.Show("Informe a quantidade de itens que vai ser devolvida.", "Aviso do sistema Gerenciamento Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmDevolverQuantidadeItens devolverQuantidadeItens = new FrmDevolverQuantidadeItens(qtdItens);
                devolverQuantidadeItens.ShowDialog();
                if (devolverQuantidadeItens.qtdItens > 0)
                {
                    qtdItensDevolvido = devolverQuantidadeItens.qtdItens;
                }
                else
                {
                    MessageBox.Show("É necessário informar a quantidade de itens que vai ser devolvida.", "Aviso do sistema Gerenciamento Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (FormaPagamento == "VISTA")
            {
                ValorPago = decimal.Parse(dgv_ListaVenda.CurrentRow.Cells["ColvalorSubTotal"].Value.ToString());
            }

            if (dgv_ListaVenda.Rows.Count > 1)
            {
                if (dgv_ListaVenda.CurrentRow.Selected == true)
                {
                    DialogResult dr = MessageBox.Show("Deseja mesmo aceitar a devolução do(a) " + descricao + " ?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        DevolverItens();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o item para excluir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (qtdItensDevolvido == 0 || qtdItens == qtdItensDevolvido)
                {
                    btnDevolverTudo_Click(sender, e);
                }
                else
                {
                    DevolverItens();
                }
            }
        }

        private void DevolverItens()
        {
            verificarFormaPagamentos();
            deleteUpdateItensVenda();

            subValorReceber = valorSubTotal;
            if (FormaPagamento == "PARCELADO" || FormaPagamento == "PRAZO")
            {
                if (valorEntrada < ValorVenda)
                    if (qtdItensDevolvido > 0 && qtdItensDevolvido < qtdItens)
                        subValorReceber /= qtdItens;
                if (valorReceber >= subValorReceber)
                    AtualizarValorReceberPagamentoPrazoParcela();
            }
            else if (FormaPagamento == "PAGAMENTO PARCIAL")
            {
                subValorReceber = (valorReceber + valorAbatido) - valorSubTotal - valorAbatido;
                VerificarDataAbatimentoDataVenda();
                if (valorReceber >= subValorReceber)
                    AtualizarValorReceberPagamentoParcial();
            }

            AtualizarEstoque();
            ListaTodasVendas();
            lblValorTotal.Text = "R$ " + ValorVenda;
            if (dgv_ListaVenda.Rows.Count == 0)
            {
                this.Close();
            }
        }

        private void AtualizarEstoque()
        {
            if(qtdItensDevolvido > 0 && qtdItensDevolvido < qtdItens)
            {
                qtdItens = qtdItensDevolvido;
            }

            SqlConnection conexao = new SqlConnection(stringConn);

            _sql = "update Produto set EstoqueAtual = EstoqueAtual + @Quantidade where id_Produto = @IdProduto";

            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Quantidade", qtdItens);
            comando.Parameters.AddWithValue("@IdProduto", dgv_ListaVenda.CurrentRow.Cells["ColCodProduto"].Value.ToString());
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        decimal subValoresTotalUnitario, valorParcela;
        int qtdParcela;
        private void verificarFormaPagamentos()
        {

            if (qtdItensDevolvido == 0 || qtdItens == qtdItensDevolvido || qtdItens == 1)
            {
                ValorVenda -= valorSubTotal;
                subValoresTotalUnitario = valorSubTotal;
            }
            else
            {
                subValoresTotalUnitario = valorSubTotal - (valorSubTotal / qtdItens);
                ValorVenda = subValoresTotalUnitario + (ValorVenda - valorSubTotal);
            }

            if (FormaPagamento == "PARCELADO")
            {
                if (valorEntrada < ValorVenda)
                {
                    verificarNumeroParcelas();
                    valorParcela = (ValorVenda - valorEntrada) / qtdParcela;
                    AlterarValoresParcelas();
                }
                else
                {
                    MessageBox.Show("O cliente no início da compra, deu o valor de entrada de " + valorEntrada + ", e com devolução do{s} produto(s) e na contabilização dos valores da venda, fica constatado que o cliente tem o direito de receber " + (valorEntrada - ValorVenda) + ". A partir deste momento a conta do cliente zera.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExcluirParcelas();
                }
            }
            else if (FormaPagamento == "PRAZO" || FormaPagamento == "VISTA")
            {
                valorParcela = subValoresTotalUnitario;
            }
            else if (FormaPagamento == "PAGAMENTO PARCIAL")
            {
                if (qtdItensDevolvido > 0 && qtdItensDevolvido < qtdItens)
                    valorSubTotal -= subValoresTotalUnitario;

                subValorVendaValorAbatido = ((ValorRestante + valorAbatido) - valorSubTotal) - valorAbatido;
                if (subValorVendaValorAbatido < 0)
                {
                    MessageBox.Show("Deverá ser devolvido o valor de R$ " + (valorSubTotal - ValorRestante) + "! Pois, o cliente tinha o valor restante em sua conta de R$ " + ValorRestante + " e abateu R$" + valorAbatido + ", e com o item devolvido no valor de R$ " + valorSubTotal + " a conta do cliente zera e terá o direito de receber R$ " + (valorSubTotal - ValorRestante) + " que é o valor que ultrapassou durante toda a transação da venda e devolução.", "Aviso do sistema Gerenciamento Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    subValorVendaValorAbatido = 0;
                }
                else
                {
                    MessageBox.Show("Com a devolução do(a) " + dgv_ListaVenda.CurrentRow.Cells["ColDescricao"].Value.ToString() + " o cliente passa a dever R$ " + subValorVendaValorAbatido, "Aviso do sistema Gerenciamento Caixa Fácil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AlterarValorRestantePagamentoParcial();
            }
            AlterarValorVenda();
        }

        private void ExcluirParcelas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "delete from ParcelaVenda where id_Venda = @idVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@idVenda", CodVenda);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void AlterarValorVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update Venda set ValorTotal = @ValorTotal where id_Venda = @idVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@idVenda", CodVenda);
            comando.Parameters.AddWithValue("@ValorTotal", ValorVenda);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void AlterarValoresParcelas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ParcelaVenda set valorParcelado = @ValorParcela where id_Venda = @idVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@idVenda", CodVenda);
            comando.Parameters.AddWithValue("@ValorParcela", valorParcela);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void verificarNumeroParcelas()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select count(Parcela) from ParcelaVenda where id_Venda = @idVenda";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@idVenda", CodVenda);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    qtdParcela = int.Parse(comando.ExecuteScalar().ToString());
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
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void deleteUpdateItensVenda()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            if (qtdItens >= 2)
            {
                if (qtdItensDevolvido == qtdItens)
                {
                    _sql = "delete from ItensVenda where id_Produto = " + dgv_ListaVenda.CurrentRow.Cells["ColCodProduto"].Value.ToString() + "and id_Venda = " + CodVenda;
                }
                else
                {
                    _sql = "update ItensVenda set Quantidade = Quantidade - " + qtdItensDevolvido + ", Valor = Valor - (Valor / " + qtdItens + ") where id_Produto = " + dgv_ListaVenda.CurrentRow.Cells["ColCodProduto"].Value.ToString() + "and id_Venda = " + CodVenda;
                }
            }
            else
            {
                _sql = "delete from ItensVenda where id_Produto = " + dgv_ListaVenda.CurrentRow.Cells["ColCodProduto"].Value.ToString() + "and id_Venda = " + CodVenda;
            }
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Item(ns) devolvido!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_ListaVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contLinhas = e.RowIndex;
            if (contLinhas > -1)
            {
                DataGridViewRow linhas = dgv_ListaVenda.Rows[contLinhas];
                CodVenda = linhas.Cells["ColCodVenda"].Value.ToString();
                descricao = linhas.Cells["ColDescricao"].Value.ToString();
                qtdItens = int.Parse(linhas.Cells["ColQuantidade"].Value.ToString());
                valorSubTotal = decimal.Parse(linhas.Cells["ColValorSubTotal"].Value.ToString());
            }
        }
    }
}
