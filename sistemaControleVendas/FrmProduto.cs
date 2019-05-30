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
    public partial class FrmProduto : Form
    {

        public FrmProduto(string resposta)
        {
            InitializeComponent();
            if (resposta == "Sim")
            {
                tabProdutos.SelectedTab = TabAtualizar;
                tabProdutos.Controls.Remove(tabCadastro);
                tabProdutos.Controls.Remove(TabExclusao);        
            }          
        }
        public FrmProduto()
        {
            InitializeComponent();
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            CodigoProduto();
        }

        string IdProduto;
        private void CodigoProduto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT MAX(Id_Produto) from Produto";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {

                    IdProduto = "1";
                    txt_Codigo.Text = IdProduto;
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    IdProduto = ra.ToString();
                    txt_Codigo.Text = IdProduto;
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

        string Id_Categoria;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;
        private void Codigocategoria()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT MAX(Id_categoria) from categoria";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    Id_Categoria = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    Id_Categoria = ra.ToString();
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

        private void btn_LimparExclusao_Click(object sender, EventArgs e)
        {
            txt_CodigoProdutoExclusao.Clear();
            txt_CategoriaExclusao.Clear();
            txt_CodigoBarraExclusao.Clear();
            txt_MarcaExclusao.Clear();
            txt_NomeProdutoExclusao.Clear();
            txt_EstoqueAtualExclusao.Clear();
            txt_UnidadeExclusao.Clear();
        }

        int X = 0;
        int Y = 0;
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

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Lucro.Clear();
            txt_NomeFornecedor.Clear();
            txt_Categoria.Clear();
            txt_CodigoBarra.Clear();
            txt_DataValidade.Clear();
            txt_Marca.Clear();
            txt_NomeProduto.Clear();
            txt_PrecoVenda.Clear();
            txt_PrecoCusto.Clear();
            txt_EstoqueAtual.Clear();
            txt_EstoqueMinimo.Clear();
            txt_Unidade.Clear();

        }
        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }
        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Plum;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Plum;
        }
        ClassCategoria categoria = new ClassCategoria();
        ClassProduto produto = new ClassProduto();

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_NomeProduto.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Nome do produto'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.Clear();
                errorProvider.SetError(txt_NomeProduto, "Campo obrigatório!");
                txt_NomeProduto.Focus();
                return;
            }
            else if (txt_NomeFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Tecle o botão buscar e selecione o fornecedor do produto a ser inserido no sistema!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_NomeFornecedor, "Campo obrigatório!");
                txt_NomeFornecedor.Focus();
                return;
            }           
            else if (txt_Marca.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Marca'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Marca, "Campo obrigatório!");
                txt_Marca.Focus();
                return;
            }
            else if (txt_Categoria.Text == string.Empty)
            {
                MessageBox.Show("Indique a categoria do produto!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Categoria, "Campo obrigatório!");
                txt_Categoria.Focus();
                return;
            }
            else if (!txt_DataValidade.MaskCompleted)
            {
                MessageBox.Show("Coloque a data da validade do produto. Se a validade é indeterminada preencha 00/00/0000!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_DataValidade, "Campo obrigatório!");
                txt_DataValidade.Focus();
                return;
            }
            else if (txt_PrecoCusto.Text == string.Empty)
            {
                MessageBox.Show("Coloque o preço custo do produto", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_PrecoCusto, "Campo obrigatório!");
                txt_PrecoCusto.Focus();
                return;
            }
            else if (txt_PrecoVenda.Text == string.Empty)
            {
                MessageBox.Show("Coloque o valor da venda!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_PrecoVenda, "Campo obrigatório!");
                txt_PrecoVenda.Focus();
                return;
            }
            else if (txt_EstoqueMinimo.Text == string.Empty)
            {
                MessageBox.Show("Coloque a quantidade mínima que o estoque deve ter. Ex: 2.", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_EstoqueMinimo, "Campo obrigatório!");
                txt_EstoqueMinimo.Focus();
                return;
            }
            else if (txt_EstoqueAtual.Text == string.Empty)
            {
                MessageBox.Show("Coloque a quantidade atual no estoque!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_EstoqueAtual, "Campo obrigatório!");
                txt_EstoqueAtual.Focus();
                return;
            }
           
            else if (txt_Unidade.Text == string.Empty)
            {
                MessageBox.Show("Coloque a unidade. Ex: unidade. Kg. etc...", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_Unidade, "Campo obrigatório!");
                txt_Unidade.Focus();
                return;
            }
            else
            {
                try
                {

                    Codigocategoria();
                    categoria.id = int.Parse(Id_Categoria);
                    categoria.Descricao = txt_Categoria.Text.Trim();                    
                    categoria.Cadastrar();
                    produto.id = int.Parse(txt_Codigo.Text);
                    produto.descricao = txt_NomeProduto.Text.Trim();
                    produto.codigoBarra = txt_CodigoBarra.Text;
                    produto.marca = txt_Marca.Text.Trim();
                    produto.datavalidade = txt_DataValidade.Text;
                    produto.valorVenda = decimal.Parse(txt_PrecoVenda.Text.Trim());
                    produto.valorCusto = decimal.Parse(txt_PrecoCusto.Text.Trim());
                    produto.lucro = decimal.Parse(txt_Lucro.Text);
                    produto.estoqueAtual = int.Parse(txt_EstoqueAtual.Text.Trim());
                    produto.estoqueMinimo = int.Parse(txt_EstoqueMinimo.Text.Trim());
                    produto.unidade = txt_Unidade.Text.Trim();
                    produto.id_categoria = int.Parse(Id_Categoria);
                    produto.id_fornecedor = Codigo;
                    produto.Cadastrar();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CodigoProduto();
                    btn_Limpar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarProdutos pesquisarProdutos = new FrmPesquisarProdutos();
            pesquisarProdutos.ShowDialog();
            if (pesquisarProdutos.ID != null)
            {
                txt_CodigoProdutoExclusao.Text = pesquisarProdutos.ID;
                comandoProduto();
                ComandoCategoria();
            }
        }

        private void comandoProduto()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Produto where id_Produto = " + txt_CodigoProdutoExclusao.Text;
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    
                    txt_CodigoBarraExclusao.Text = Tabela.Rows[0]["CodigoBarra"].ToString();
                    txt_NomeProdutoExclusao.Text = Tabela.Rows[0]["Descricao"].ToString();
                    txt_MarcaExclusao.Text = Tabela.Rows[0]["Marca"].ToString();
                    txt_EstoqueAtualExclusao.Text = Tabela.Rows[0]["EstoqueAtual"].ToString();
                    txt_UnidadeExclusao.Text = Tabela.Rows[0]["Unidade"].ToString();
                    Id_Categoria = Tabela.Rows[0]["Id_Categoria"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComandoCategoria()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Categoria where id_Categoria = " + Id_Categoria;
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    txt_CategoriaExclusao.Text = Tabela.Rows[0]["Descricao"].ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_CodigoProdutoExclusao.Text != string.Empty)
            {
                try
                {
                    categoria.id = int.Parse(Id_Categoria);
                    produto.id = int.Parse(txt_CodigoProdutoExclusao.Text);
                    if (MessageBox.Show("Deseja mesmo excluir este produto?", "Pergunta do sistema.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Codigocategoria();
                        produto.Deletar();
                        categoria.Deletar();
                        MessageBox.Show("Produto excluido com sucesso", "Aviso do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LimparExclusao_Click(sender, e);
                        CodigoProduto();
                    }
                }
                catch 
                {
                    MessageBox.Show("Não é permitido a exclusão! Existe registros de venda(s) do produto selecionado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("É necessário buscar os dados do produto para excluir do banco de dados!", "Aviso do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoBarra_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeProduto_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Marca_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Categoria_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DataValidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Preço_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Quantidade_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Unidade_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_PrecoCusto_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_PrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }
        int Codigo;
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            FrmPesquisarFornecedor pesquisarFornecedor = new FrmPesquisarFornecedor();
            pesquisarFornecedor.ShowDialog();
            if (pesquisarFornecedor.Codigo != null)
            {
                Codigo = int.Parse(pesquisarFornecedor.Codigo);
                txt_NomeFornecedor.Text = pesquisarFornecedor.Fornecedor;
            }
        }

        private void txt_PrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoCusto.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_PrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoVenda.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_EstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_DataValidade_Leave(object sender, EventArgs e)
        {
            if ((txt_DataValidade.MaskCompleted) && txt_DataValidade.Text != "00/00/0000")
            {
                DateTime resultado = DateTime.MinValue;
                if (!DateTime.TryParse(this.txt_DataValidade.Text.Trim(), out resultado))
                {
                    MessageBox.Show("Data Inválida!", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_DataValidade.Clear();
                    txt_DataValidade.Focus();
                }
            }
        }

        private void txt_NomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        decimal PrecoCusto, PrecoVenda, Lucro;
        private void txt_PrecoCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_PrecoCusto.Text != "")
                {
                    txt_PrecoCusto.Text = Convert.ToDecimal(txt_PrecoCusto.Text.Trim()).ToString("0.00");
                    if (txt_PrecoVenda.Text != "" && txt_PrecoCusto.Text != "")
                    {
                        PrecoCusto = decimal.Parse(txt_PrecoCusto.Text);
                        PrecoVenda = decimal.Parse(txt_PrecoVenda.Text);
                        Lucro = PrecoVenda - PrecoCusto;
                        txt_Lucro.Text = Lucro.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PrecoCusto.Clear();
            }
        }

        private void btn_PesquisarCodigoProduto_Click(object sender, EventArgs e)
        {
            FrmPesquisarProdutos pesquisarProdutos = new FrmPesquisarProdutos();
            pesquisarProdutos.ShowDialog();
            if (pesquisarProdutos.ID != null)
            {
                txt_CodigoEdicao.Text = pesquisarProdutos.ID;
                AtualizarCategoria();
                produto.id = int.Parse(pesquisarProdutos.ID);
                produto.ConsultarCodigoProduto();
                txt_CodigoBarraEdicao.Text = produto.codigoBarra;
                txt_NomeProdutoEdicao.Text = produto.descricao;
                txt_MarcaEdicao.Text = produto.marca;
                mask_DataValidadeEdicao.Text = produto.datavalidade;
                txt_PrecoCustoEdicao.Text = produto.valorCusto.ToString();
                txt_PrecoVendaEdicao.Text = produto.valorVenda.ToString();
                txt_LucroEdicao.Text = produto.lucro.ToString();
                txt_EstoqueAtualEdicao.Text = produto.estoqueAtual.ToString();
                txt_EstoqueMinimoEdicao.Text = produto.estoqueMinimo.ToString();
                txt_UnidadeEdicao.Text = produto.unidade;
                txt_CategoriaEdicao.Text = pesquisarProdutos.Descricao;               
                txt_fornecedorEdicao.Text = pesquisarProdutos.Fornecedor;
                btn_PesquisarFornecedor.Enabled = true;
            }
            btn_AdicionarQuantidade.Enabled = true;
        }
        public void AtualizarCategoria()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Produto.Id_Fornecedor,Produto.Id_Categoria from Produto inner join Categoria on categoria.Id_Categoria=Produto.Id_Categoria inner join Fornecedor on Fornecedor.Id_Fornecedor=Produto.Id_Fornecedor where Produto.Id_Produto = @Id";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Id", txt_CodigoEdicao.Text);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                Id_Categoria = Tabela.Rows[0]["Id_Categoria"].ToString();
                Codigo = int.Parse(Tabela.Rows[0]["Id_Fornecedor"].ToString());
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
        private void btn_PesquisarFornecedor_Click(object sender, EventArgs e)
        {
            FrmPesquisarFornecedor pesquisarFornecedor = new FrmPesquisarFornecedor();
            pesquisarFornecedor.ShowDialog();
            if (pesquisarFornecedor.Codigo != null)
            {
                txt_fornecedorEdicao.Text = pesquisarFornecedor.Fornecedor;
            }
        }

        private void txt_CodigoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_CodigoEdicao.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_PesquisarCodigoProduto_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Editar_Click(sender, e);
                }
            }
        }

        private void txt_fornecedorEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_CodigoEdicao.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_PesquisarFornecedor_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Editar_Click(sender, e);
                }
            }
        }

        private void btn_AdicionarQuantidade_Click(object sender, EventArgs e)
        {
            FrmAdicionarQuantidade adicionarQuantidade = new FrmAdicionarQuantidade(txt_EstoqueAtualEdicao.Text);
            adicionarQuantidade.ShowDialog();
            long EstoqueAtual = long.Parse(txt_EstoqueAtualEdicao.Text);
            long quantidade = adicionarQuantidade.Quantidade;
            txt_EstoqueAtualEdicao.Text = (EstoqueAtual + quantidade).ToString();
        }

        private void btn_LimparAtualizar_Click(object sender, EventArgs e)
        {
            btn_AdicionarQuantidade.Enabled = false;
            txt_CodigoEdicao.Clear();
            txt_LucroEdicao.Clear();
            txt_fornecedorEdicao.Clear();
            txt_CategoriaEdicao.Clear();
            txt_CodigoBarraEdicao.Clear();
            mask_DataValidadeEdicao.Clear();
            txt_MarcaEdicao.Clear();
            txt_NomeProdutoEdicao.Clear();
            txt_PrecoVendaEdicao.Clear();
            txt_PrecoCustoEdicao.Clear();
            txt_EstoqueAtualEdicao.Clear();
            txt_EstoqueMinimoEdicao.Clear();
            txt_UnidadeEdicao.Clear();
            btn_PesquisarFornecedor.Enabled = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_NomeProdutoEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Nome do produto'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                errorProvider.Clear();
                errorProvider.SetError(txt_NomeProdutoEdicao, "Campo obrigatório!");
                txt_NomeProdutoEdicao.Focus();
                return;
            }
            else if (txt_fornecedorEdicao.Text == string.Empty)
            {
                MessageBox.Show("Tecle o botão buscar e selecione o fornecedor do produto a ser inserido no sistema!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.Clear();
                errorProvider.SetError(txt_fornecedorEdicao, "Campo obrigatório!");
                txt_fornecedorEdicao.Focus();
                return;
            }
            else if (txt_MarcaEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Marca'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_MarcaEdicao, "Campo obrigatório!");
                txt_MarcaEdicao.Focus();
                return;
            }
            else if (txt_CategoriaEdicao.Text == string.Empty)
            {
                MessageBox.Show("Indique a categoria do produto!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.Clear();
                errorProvider.SetError(txt_CategoriaEdicao, "Campo obrigatório!");
                txt_Categoria.Focus();
                return;
            }
            else if (!mask_DataValidadeEdicao.MaskCompleted)
            {
                MessageBox.Show("Coloque a data da validade do produto. Se a validade é indeterminada preencha 00/00/0000!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.Clear();
                errorProvider.SetError(mask_DataValidadeEdicao, "Campo obrigatório!");
                mask_DataValidadeEdicao.Focus();
                return;
            }
            else if (txt_PrecoCustoEdicao.Text == string.Empty)
            {
                MessageBox.Show("Coloque o preço custo do produto", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.SetError(txt_PrecoCustoEdicao, "Campo obrigatório!");
                txt_PrecoCustoEdicao.Focus();
                return;
            }
            else if (txt_PrecoVendaEdicao.Text == string.Empty)
            {
                MessageBox.Show("Coloque o valor da venda!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_PrecoVendaEdicao, "Campo obrigatório!");
                txt_PrecoVendaEdicao.Focus();
                return;
            }
            else if (txt_EstoqueMinimoEdicao.Text == string.Empty)
            {
                MessageBox.Show("Coloque a quantidade mínima que o estoque deve ter. Ex: 2.", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_EstoqueMinimoEdicao, "Campo obrigatório!");
                txt_EstoqueMinimoEdicao.Focus();
                return;
            }
            else if (txt_EstoqueAtualEdicao.Text == string.Empty)
            {
                MessageBox.Show("Coloque a quantidade atual no estoque!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_EstoqueAtualEdicao, "Campo obrigatório!");
                txt_EstoqueAtualEdicao.Focus();
                return;
            }

            else if (txt_UnidadeEdicao.Text == string.Empty)
            {
                MessageBox.Show("Coloque a unidade. Ex: unidade. Kg. etc...", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                errorProvider.Clear();
                errorProvider.SetError(txt_UnidadeEdicao, "Campo obrigatório!");
                txt_UnidadeEdicao.Focus();
                return;
            }
            else
            {
                try
                {
                    categoria.id = int.Parse(Id_Categoria);
                    categoria.Descricao = txt_CategoriaEdicao.Text.Trim();
                    categoria.Atualizar();
                    produto.id = int.Parse(txt_CodigoEdicao.Text);
                    produto.descricao = txt_NomeProdutoEdicao.Text.Trim();
                    produto.codigoBarra = txt_CodigoBarraEdicao.Text;
                    produto.marca = txt_MarcaEdicao.Text.Trim();
                    produto.datavalidade = mask_DataValidadeEdicao.Text;
                    produto.valorVenda = decimal.Parse(txt_PrecoVendaEdicao.Text.Trim());
                    produto.valorCusto = decimal.Parse(txt_PrecoCustoEdicao.Text.Trim());
                    produto.lucro = decimal.Parse(txt_LucroEdicao.Text);
                    produto.estoqueAtual = int.Parse(txt_EstoqueAtualEdicao.Text.Trim());
                    produto.estoqueMinimo = int.Parse(txt_EstoqueMinimoEdicao.Text.Trim());
                    produto.unidade = txt_UnidadeEdicao.Text.Trim();                    
                    produto.Atualizar();
                    MessageBox.Show("Produto atualizado com sucesso!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LimparAtualizar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_CodigoBarraEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeProdutoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_fornecedorEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_MarcaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_CategoriaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DescricaoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_DataValidadeEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_PrecoCustoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_PrecoVendaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EstoqueMinimoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EstoqueAtualEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_UnidadeEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EstoqueMinimoEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_EstoqueAtualEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_PrecoVendaEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoVendaEdicao.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_PrecoCustoEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoCustoEdicao.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_PrecoVendaEdicao_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_PrecoVendaEdicao.Text != "" && txt_PrecoCustoEdicao.Text != "")
                {
                    PrecoVenda = decimal.Parse(txt_PrecoVendaEdicao.Text);
                    PrecoCusto = decimal.Parse(txt_PrecoCustoEdicao.Text);
                    Lucro = PrecoVenda - PrecoCusto;
                    txt_LucroEdicao.Text = Lucro.ToString();
                    txt_PrecoVendaEdicao.Text = Convert.ToDecimal(txt_PrecoVendaEdicao.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PrecoVendaEdicao.Clear();
            }
        }

        private void txt_PrecoCustoEdicao_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_PrecoCustoEdicao.Text != "")
                {
                    txt_PrecoCustoEdicao.Text = Convert.ToDecimal(txt_PrecoCustoEdicao.Text.Trim()).ToString("0.00");
                    if (txt_PrecoVendaEdicao.Text != "" && txt_PrecoCustoEdicao.Text != "")
                    {
                        PrecoVenda = decimal.Parse(txt_PrecoVendaEdicao.Text);
                        PrecoCusto = decimal.Parse(txt_PrecoCustoEdicao.Text);
                        Lucro = PrecoVenda - PrecoCusto;
                        txt_LucroEdicao.Text = Lucro.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PrecoCustoEdicao.Clear();
            }
        }

        private void txt_NomeProdutoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_MarcaEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_CategoriaEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_DescricaoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_DataValidadeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_PrecoCustoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_PrecoVendaEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_LucroEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_EstoqueMinimoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_EstoqueAtualEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_UnidadeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        ClassPrestacaoServico prestacaoServico = new ClassPrestacaoServico();
        ClassFornecedor Fornecedor = new ClassFornecedor();
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor("Adicionar Fornecedor");
            fornecedor.ShowDialog();
            if (fornecedor.IdFornecedor != null)
            {
                Fornecedor.id = int.Parse(fornecedor.IdFornecedor);
                Fornecedor.Consultar();
                txt_NomeFornecedor.Text = Fornecedor.nome;
                Codigo = int.Parse(fornecedor.IdFornecedor);

            }
            
        }

        private void txt_NomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Marca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Categoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_DataValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_PrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_EstoqueMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_EstoqueAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Unidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_PrecoVenda_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_PrecoVenda.Text != "")
                {
                    txt_PrecoVenda.Text = Convert.ToDecimal(txt_PrecoVenda.Text.Trim()).ToString("0.00");
                    if (txt_PrecoVenda.Text != "" && txt_PrecoCusto.Text != "")
                    {
                        PrecoCusto = decimal.Parse(txt_PrecoCusto.Text);
                        PrecoVenda = decimal.Parse(txt_PrecoVenda.Text);
                        Lucro = PrecoVenda - PrecoCusto;
                        txt_Lucro.Text = Lucro.ToString();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PrecoVenda.Clear();
            }
        }

        private void txt_NomeFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_NomeFornecedor.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Buscar_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Salvar_Click(sender, e);
                }
            }
        }
    }    
}
