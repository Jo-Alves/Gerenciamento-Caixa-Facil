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
    public partial class FrmServico : Form
    {
        public FrmServico()
        {
            InitializeComponent();
        }

        private void btn_LimparServico_Click(object sender, EventArgs e)
        {
            txt_CodigoServico.Clear();
            txt_DescricaoServico.Clear();
            txt_PrecoServico.Clear();
        }

        private void btn_PesquisarServico_Click(object sender, EventArgs e)
        {
            FrmPesquisarServico pesquisarServico = new FrmPesquisarServico();
            pesquisarServico.ShowDialog();
            if (pesquisarServico.Codigo != null)
            {
                txt_CodigoServico.Text = pesquisarServico.Codigo;
                txt_DescricaoServico.Text = pesquisarServico.Descricao;
                txt_PrecoServico.Text = pesquisarServico.PrecoServico;
            }
        }

        ClassPrestacaoServico prestacaoServico = new ClassPrestacaoServico();
        ErrorProvider errorProvider = new ErrorProvider();
        private void btn_EditarServico_Click(object sender, EventArgs e)
        {
            if (txt_DescricaoServico.Text == "")
            {
                errorProvider.Clear();
                MessageBox.Show("Informe o nome do seviço para ser atualizado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_DescricaoServico, "Campo obrigatório!");
                txt_DescricaoServico.Focus();
                return;
            }
            else if (txt_PrecoServico.Text == "")
            {
                errorProvider.Clear();
                MessageBox.Show("Informe o preço do seviço para ser cadastrado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_PrecoServico, "Campo obrigatório!");
                txt_PrecoServico.Focus();
                return;
            }
            else
            {
                try
                {
                    prestacaoServico.id = int.Parse(txt_CodigoServico.Text);
                    prestacaoServico.descricao = txt_DescricaoServico.Text.Trim();
                    prestacaoServico.precoServico = decimal.Parse(txt_PrecoServico.Text);
                    prestacaoServico.Atualizar();
                    MessageBox.Show("Dados da prestação de Serviço atualizado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LimparServico_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_SalvarServico_Click(object sender, EventArgs e)
        {
            if (txt_DescricaoServico.Text == "")
            {
                errorProvider.Clear();
                MessageBox.Show("Informe o nome do seviço para ser cadastrado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_DescricaoServico, "Campo obrigatório!");
                txt_DescricaoServico.Focus();
                return;
            }
            else if (txt_PrecoServico.Text == "")
            {
                errorProvider.Clear();
                MessageBox.Show("Informe o preço do seviço para ser cadastrado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_PrecoServico, "Campo obrigatório!");
                txt_PrecoServico.Focus();
                return;
            }
            else
            {
                try
                {
                    categoria.id = Id_Categoria;
                    categoria.Descricao = "Serviço";
                    categoria.Cadastrar();
                    prestacaoServico.id = int.Parse(txt_CodigoServico.Text);
                    prestacaoServico.descricao = txt_DescricaoServico.Text.Trim();
                    prestacaoServico.precoServico = decimal.Parse(txt_PrecoServico.Text);
                    prestacaoServico.lucro = decimal.Parse(txt_PrecoServico.Text);
                    prestacaoServico.estoqueAtual = 0;
                    prestacaoServico.estoqueMinimo = 0;
                    prestacaoServico.unidade = "Serviço";
                    prestacaoServico.id_Categoria = Id_Categoria;
                    prestacaoServico.Cadastrar();
                    MessageBox.Show("Serviço cadastrado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LimparServico_Click(sender, e);
                    CodigoProduto();
                    Codigocategoria();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            Codigocategoria();
            CodigoProduto();
        }

        ClassCategoria categoria = new ClassCategoria();
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
                    Id_Categoria = 1;
                }
                else
                {
                    Id_Categoria = Convert.ToInt32(comando.ExecuteScalar()) + 1;
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

        int Id_Produto, Id_Categoria;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.White;
            btn_Minimizar.ForeColor = Color.Black;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Transparent;
            btn_Minimizar.ForeColor = Color.White;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PrecoServico_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_PrecoServico.Text != "")
                {
                    txt_PrecoServico.Text = Convert.ToDecimal(txt_PrecoServico.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PrecoServico.Clear();
            }
        }

        private void txt_PrecoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_PrecoServico.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

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

                    Id_Produto = 1;
                    txt_CodigoServico.Text = Id_Produto.ToString();
                }
                else
                {
                    Id_Produto = Convert.ToInt32(comando.ExecuteScalar()) + 1;                    
                   txt_CodigoServico.Text = Id_Produto.ToString();
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
}
