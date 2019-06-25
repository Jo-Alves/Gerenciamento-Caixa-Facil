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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;

        private void CodigoUsuario()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT MAX(Id_Usuario) from Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txt_Codigo.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    txt_Codigo.Text = ra.ToString();
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
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CodigoUsuario();
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Minimizar.BackColor = Color.Blue; ;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Minimizar.BackColor = Color.Orchid;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Fechar.BackColor = Color.Orchid;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int X = 0;
        int Y = 0;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int totalValue = 0 + txt_senha.TextLength;
            lbl_Contador.Text = totalValue.ToString() + " Caracter(es).";
            if (txt_senha.Text == string.Empty)
            {
                lbl_Contador.Text = string.Empty;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_PerguntaSeguranca.Text = " ";
            txt_RespostaSeguranca.Clear();
            txt_Nome.Clear();
            txt_Email.Clear();
            txt_Usuario.Clear();
            txt_senha.Clear();
            cb_Funcao.Text = string.Empty;
            lbl_Contador.Text = string.Empty;
            txt_DicaSenha.Clear();
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }


        ClassUsuario Usuario = new ClassUsuario();
        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (txt_Nome.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Nome'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear(); errorProvider.Clear();
                errorProvider.SetError(txt_Nome, "Campo obrigatório!");
                txt_Nome.Focus();
                return;
            }

            else if ((txt_Email.Text != string.Empty) && (!ClassValidacaoEmail.validarEmail(txt_Email.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txt_Email, "E-mail inválido!");
                txt_Email.Focus();
                return;
            }
            else if (txt_Usuario.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'usuário' para logar!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear(); errorProvider.Clear();
                errorProvider.SetError(txt_Usuario, "Campo obrigatório!");
                txt_Usuario.Focus();
                return;
            }
            if (txt_senha.Text == string.Empty)
            {
                MessageBox.Show("Coloque a senha!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.Clear();
                errorProvider.SetError(txt_senha, "Campo obrigatório!");
                txt_senha.Focus();
                return;
            }
            else if (txt_senha.TextLength < 5)
            {
                MessageBox.Show("A senha deve ter de 5 a 15 caracteres!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_senha, "Campo obrigatório!");
                txt_senha.Focus();
                return;
            }
            else if (txt_DicaSenha.Text == string.Empty)
            {
                MessageBox.Show("Digite uma dica de segurança!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_DicaSenha, "Campo obrigatório!");
                txt_DicaSenha.Focus();
                return;
            }
            else if (cb_PerguntaSeguranca.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione ou digite uma pergunta de segurança!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(cb_PerguntaSeguranca, "Campo obrigatório!");
                cb_PerguntaSeguranca.Focus();
                return;
            }
            else if (txt_RespostaSeguranca.Text == string.Empty)
            {
                MessageBox.Show("Digite a sua resposta!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_RespostaSeguranca, "Campo obrigatório!");
                txt_RespostaSeguranca.Focus();
                return;
            }
            else if (cb_Funcao.Text == string.Empty)
            {
                MessageBox.Show("Selecione o campo 'Função'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(cb_Funcao, "Campo obrigatório!");
                cb_Funcao.Focus();
                return;
            }            
            else
            {

                try
                {

                    Usuario.nome = txt_Nome.Text.Trim();
                    Usuario.email = txt_Email.Text.Trim();
                    Usuario.funcao = cb_Funcao.Text.Trim().ToUpper();
                    Usuario.usuario = txt_Usuario.Text.Trim();
                    Usuario.senha = ClassSeguranca.Criptografar(txt_senha.Text.Trim());
                    Usuario.dicaSenha = txt_DicaSenha.Text.Trim();
                    Usuario.perguntaSeguranca = cb_PerguntaSeguranca.Text;
                    Usuario.respostaSeguranca = txt_RespostaSeguranca.Text;
                    Usuario.situacao = "ATIVO";
                    if (Usuario.Cadastrar() == false)
                    {
                        Usuario.Cadastrar();

                        MessageBox.Show("Usuario cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Limpar_Click(sender, e);
                        CodigoUsuario();
                    }
                    else
                    {
                        MessageBox.Show("O Usuário já existe!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider.Clear();
                        errorProvider.SetError(txt_Usuario, "");
                        txt_Usuario.Focus();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_NomeEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EmailEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_SenhaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int totalValue = 0 + txt_SenhaEdicao.TextLength;
            lbl_ContadorEdicao.Text = totalValue.ToString() + " Caracter(es).";
            if (txt_SenhaEdicao.Text == string.Empty)
            {
                lbl_ContadorEdicao.Text = string.Empty;
            }
        }

        private void txt_UsuarioEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_EmailEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_UsuarioEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_SenhaEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }


        private void btn_LimparEdicao_Click(object sender, EventArgs e)
        {
            cb_PerguntaSegurancaEdicao.Text = " ";
            txt_RespostaSegurancaEdicao.Clear();
            txt_DicaSenhaEdicao.Clear();
            txt_CodigoEdicao.Clear();
            txt_NomeEdicao.Clear();
            txt_EmailEdicao.Clear();
            txt_UsuarioEdicao.Clear();
            txt_SenhaEdicao.Clear();
            cb_FuncaoEdicao.Text = string.Empty;
            lbl_ContadorEdicao.Text = string.Empty;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            if (txt_NomeEdicao.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_NomeEdicao, "Campo obrigatório!");
                txt_NomeEdicao.Focus();
                return;
            }
            else if ((txt_EmailEdicao.Text != string.Empty) && (!ClassValidacaoEmail.validarEmail(txt_EmailEdicao.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txt_EmailEdicao, "E-mail inválido!");
                txt_EmailEdicao.Focus();
                return;
            }
            else if (txt_UsuarioEdicao.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_UsuarioEdicao, "Campo obrigatório!");
                txt_UsuarioEdicao.Focus();
                return;
            }
            if (txt_SenhaEdicao.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_SenhaEdicao, "Campo obrigatório!");
                txt_SenhaEdicao.Focus();
                return;
            }
            else if (txt_SenhaEdicao.TextLength < 5)
            {
                MessageBox.Show("A senha deve ter de 5 a 15 caracteres!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_SenhaEdicao, "Campo obrigatório!");
                txt_SenhaEdicao.Focus();
                return;
            }
            else if (txt_DicaSenhaEdicao.Text == string.Empty)
            {
                MessageBox.Show("Digite uma dica de segurança!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_DicaSenhaEdicao, "Campo obrigatório!");
                txt_DicaSenhaEdicao.Focus();
                return;
            }
            else if (cb_PerguntaSegurancaEdicao.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione ou digite uma pergunta de segurança!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(cb_PerguntaSegurancaEdicao, "Campo obrigatório!");
                cb_PerguntaSegurancaEdicao.Focus();
                return;
            }
            else if (txt_RespostaSegurancaEdicao.Text == string.Empty)
            {
                MessageBox.Show("Digite a sua resposta!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_RespostaSegurancaEdicao, "Campo obrigatório!");
                txt_RespostaSegurancaEdicao.Focus();
                return;
            }
            else if (cb_FuncaoEdicao.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(cb_FuncaoEdicao, "Campo obrigatório!");
                cb_FuncaoEdicao.Focus();
                return;
            }
            else
            {

                try
                {
                    string Senha = ClassSeguranca.Criptografar(txt_SenhaEdicao.Text);
                    Usuario.id = int.Parse(txt_CodigoEdicao.Text.Trim());
                    Usuario.nome = txt_NomeEdicao.Text.Trim();
                    Usuario.nome = txt_NomeEdicao.Text.Trim();
                    Usuario.email = txt_EmailEdicao.Text.Trim();
                    Usuario.usuario = txt_UsuarioEdicao.Text.Trim();
                    Usuario.dicaSenha = txt_DicaSenhaEdicao.Text.Trim();
                    Usuario.senha = Senha;
                    Usuario.funcao = cb_FuncaoEdicao.Text.Trim().ToUpper();
                    Usuario.perguntaSeguranca = cb_PerguntaSegurancaEdicao.Text;
                    Usuario.respostaSeguranca = txt_RespostaSegurancaEdicao.Text;
                    if (Usuario.Atualizar() == false)
                    {
                        MessageBox.Show("Dados do Usuario atualizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LimparEdicao_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Dica de Senha inválida! Crie outra dica!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_BuscarEdicao_Click(object sender, EventArgs e)
        {
            FrmPesquisarUsuario pesquisarUsuario = new FrmPesquisarUsuario();
            pesquisarUsuario.ShowDialog();
            if (pesquisarUsuario.Codigo != null)
            {
                txt_CodigoEdicao.Text = pesquisarUsuario.Codigo;
                try
                {
                    Usuario.id = int.Parse(pesquisarUsuario.Codigo);
                    Usuario.Consultar();
                    txt_NomeEdicao.Text = Usuario.nome;
                    cb_FuncaoEdicao.Text = Usuario.funcao;
                    txt_EmailEdicao.Text = Usuario.email;
                    txt_UsuarioEdicao.Text = Usuario.usuario;
                    txt_SenhaEdicao.Text = ClassSeguranca.Descriptografar(Usuario.senha);
                    txt_DicaSenhaEdicao.Text = Usuario.dicaSenha;
                    cb_PerguntaSegurancaEdicao.Text = Usuario.perguntaSeguranca;
                    txt_RespostaSegurancaEdicao.Text = Usuario.respostaSeguranca;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_LimparExclusao_Click(object sender, EventArgs e)
        {
            txt_CodigoExclusao.Clear();
            txt_NomeExclusao.Clear();
            txt_EmailExclusao.Clear();
            txt_UsuarioExclusao.Clear();
            txt_SenhaExclusao.Clear();
            cb_FuncaoExcluir.Text = string.Empty;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Deseja mesmo excluir os dados do usuário?", "Pergunta do sistema.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usuario.id = int.Parse(txt_CodigoExclusao.Text);
                    Usuario.usuario = txt_UsuarioExclusao.Text;
                    Usuario.Deletar();
                    MessageBox.Show("Dados do Usuário deletado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LimparExclusao_Click(sender, e);
                    CodigoUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PesquisarExclusao_Click(object sender, EventArgs e)
        {
            FrmPesquisarUsuario pesquisarUsuario = new FrmPesquisarUsuario();
            pesquisarUsuario.ShowDialog();
            if (pesquisarUsuario.Codigo != null)
            {
                txt_CodigoExclusao.Text = pesquisarUsuario.Codigo;

                try
                {
                    Usuario.id = int.Parse(pesquisarUsuario.Codigo);
                    Usuario.Consultar();
                    txt_NomeExclusao.Text = Usuario.nome;
                    cb_FuncaoExcluir.Text = Usuario.funcao;
                    txt_EmailExclusao.Text = Usuario.email;
                    txt_UsuarioExclusao.Text = Usuario.usuario;
                    txt_SenhaExclusao.Text = ClassSeguranca.Descriptografar(Usuario.senha);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_FuncaoExcluir_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_FuncaoEdicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_Funcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DicaSenhaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_PerguntaSegurancaEdicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DicaSenha_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_PerguntaSeguranca_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_RespostaSeguranca_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}