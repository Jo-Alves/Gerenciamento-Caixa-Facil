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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor(string Cadastro)
        {
            InitializeComponent();
            this.Cadastro = Cadastro;
            if(Cadastro == "Adicionar Fornecedor")
            {
                TabFornecedor.Controls.Remove(tabPageEdicao);
                TabFornecedor.Controls.Remove(tabPageExclusao);
            }
        }

        string Cadastro;
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
        private void mask_InscricaoEstadual_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Fornecedor_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Bairro_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Endereco_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Cidade_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Celular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_FornecedorEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CNPJEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_InscricaoEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CepEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_BairroEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EnderecoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_CidadeEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_TelefoneEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CelularEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EmailEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }        

        private void txt_NomeSituacao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void Mask_DataAnterior_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_DataPosterior_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Fornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_CNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_InscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_Cep_KeyDown(object sender, KeyEventArgs e)
        {
            if(cb_Estado.Text!=string.Empty && txt_Cidade.Text!=string.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Salvar_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_BuscarCep_Click(sender, e);
                }
            }
               
        }

        private void txt_Bairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_Cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void cb_Estado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_Telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_Celular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_FornecedorEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_CNPJEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_InscricaoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_CepEdicao_KeyDown(object sender, KeyEventArgs e)
        {

            if (cb_EstadoEdicao.Text != string.Empty && txt_Cidade.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Editar_Click(sender, e);
                }
            }
            else
            {
                btn_BuscaCepEdicao_Click(sender, e);
            }
        }

        private void txt_BairroEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_EnderecoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_NumeroEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_NumeroEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_CidadeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void cb_EstadoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_TelefoneEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_CelularEdicao_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_BuscarCep_Click(object sender, EventArgs e)
        {
            if (mask_Cep.MaskCompleted)
            {
                try
                {
                    string url = "https://www.republicavirtual.com.br/web_cep.php?cep=@Cep&formato=xml";
                    DataSet ds = new DataSet();
                    ds.ReadXml(url.Replace("@Cep", mask_Cep.Text));

                    string retorno = ds.Tables[0].Rows[0]["Resultado"].ToString();

                    if (retorno == "0")
                    {
                        MessageBox.Show("CEP inválido! Verifique o número do CEP ou a conexão com a internet ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txt_Cidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                        cb_Estado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sem conexão com a internet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todo o campo do Cep! Campo Obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_Cep, "Campo Incompleto!");
                mask_Cep.Focus();
                return;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_RazaoSocial.Clear();
            mask_CNPJ.Clear();
            mask_InscricaoEstadual.Clear();
            mask_Cep.Clear();
            txt_Bairro.Clear();
            txt_Endereco.Clear();
            txt_Numero.Clear();
            txt_Cidade.Clear();
            cb_Estado.Text = " ";
            mask_Telefone.Clear();
            mask_Celular.Clear();
            txt_Email.Clear();
        }
        ClassFornecedor Fornecedor = new ClassFornecedor();

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_RazaoSocial.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Razão Social'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_RazaoSocial, "Campo obrigatório!");
                txt_RazaoSocial.Focus();
                return;
            }
            else
            {
                try
                {
                    if (mask_CNPJ.MaskCompleted)
                    {
                        if (ValidarCNPJ() == true)
                        {
                            Fornecedor.id = int.Parse(txt_Codigo.Text);
                            Fornecedor.nome = txt_RazaoSocial.Text.Trim();
                            Fornecedor.Cnpj = mask_CNPJ.Text;
                            Fornecedor.Inscricao = mask_InscricaoEstadual.Text;
                            Fornecedor.CEP = mask_Cep.Text;
                            Fornecedor.bairro = txt_Bairro.Text.Trim();
                            Fornecedor.endereco = txt_Endereco.Text.Trim();
                            Fornecedor.numero = txt_Numero.Text.Trim();
                            Fornecedor.cidade = txt_Cidade.Text.Trim();
                            Fornecedor.estado = cb_Estado.Text;
                            Fornecedor.telefone = mask_Telefone.Text;
                            Fornecedor.celular = mask_Celular.Text;
                            Fornecedor.email = txt_Email.Text.Trim();
                            Fornecedor.Cadastrar();
                            MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (Cadastro == "")
                            {
                                btn_Limpar_Click(sender, e);
                                CodigoFornecedor();
                            }
                            else
                            {
                                IdFornecedor = txt_Codigo.Text;
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProvider.Clear();
                            errorProvider.SetError(mask_CNPJ, "Campo inválido!");
                            mask_CNPJ.Clear();
                            return;
                        }
                    }
                    else
                    {
                        Fornecedor.id = int.Parse(txt_Codigo.Text);
                        Fornecedor.nome = txt_RazaoSocial.Text.Trim();
                        Fornecedor.Cnpj = mask_CNPJ.Text;
                        Fornecedor.Inscricao = mask_InscricaoEstadual.Text;
                        Fornecedor.CEP = mask_Cep.Text;
                        Fornecedor.bairro = txt_Bairro.Text.Trim();
                        Fornecedor.endereco = txt_Endereco.Text.Trim();
                        Fornecedor.numero = txt_Numero.Text.Trim();
                        Fornecedor.cidade = txt_Cidade.Text.Trim();
                        Fornecedor.estado = cb_Estado.Text;
                        Fornecedor.telefone = mask_Telefone.Text;
                        Fornecedor.celular = mask_Celular.Text;
                        Fornecedor.email = txt_Email.Text.Trim();
                        Fornecedor.Cadastrar();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Cadastro == "")
                        {
                            btn_Limpar_Click(sender, e);
                            CodigoFornecedor();
                        }
                        else
                        {
                            IdFornecedor = txt_Codigo.Text;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }        

        public string IdFornecedor { get; set; }

        private void btn_BuscaCepEdicao_Click(object sender, EventArgs e)
        {
            if (mask_CepEdicao.MaskCompleted)
            {
                try
                {
                    string url = "https://www.republicavirtual.com.br/web_cep.php?cep=@Cep&formato=xml";
                    DataSet ds = new DataSet();
                    ds.ReadXml(url.Replace("@Cep", mask_CepEdicao.Text));

                    string retorno = ds.Tables[0].Rows[0]["Resultado"].ToString();

                    if (retorno == "0")
                    {
                        MessageBox.Show("CEP inválido! Verifique o número do CEP ou a conexão com a internet ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txt_CidadeEdicao.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                        cb_EstadoEdicao.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sem conexão com a internet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todo o campo do Cep! Campo Obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_Cep, "Campo Incompleto!");
                mask_Cep.Focus();
                return;
            }
        }

        private void btn_LimparEdicao_Click(object sender, EventArgs e)
        {
            txt_CodigoEdicao.Clear();
            txt_RazaoSocialEdicao.Clear();
            mask_CNPJEdicao.Clear();
            mask_InscricaoEdicao.Clear();
            mask_CepEdicao.Clear();
            txt_BairroEdicao.Clear();
            txt_EnderecoEdicao.Clear();
            txt_NumeroEdicao.Clear();
            txt_CidadeEdicao.Clear();
            cb_EstadoEdicao.Text = " ";
            mask_TelefoneEdicao.Clear();
            mask_CelularEdicao.Clear();
            txt_EmailEdicao.Clear();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txt_RazaoSocialEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Razão Social'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.Clear();
                errorProvider.SetError(txt_RazaoSocialEdicao, "Campo obrigatório!");
                txt_RazaoSocialEdicao.Focus();
                return;
            }            
            else
            {
                try
                {
                    if (mask_CNPJEdicao.MaskCompleted)
                    {
                        if (ValidarCNPJEdicao() == true)
                        {
                            Fornecedor.nome = txt_RazaoSocialEdicao.Text.Trim();
                            Fornecedor.Cnpj = mask_CNPJEdicao.Text;
                            Fornecedor.Inscricao = mask_InscricaoEdicao.Text;
                            Fornecedor.CEP = mask_CepEdicao.Text;
                            Fornecedor.bairro = txt_BairroEdicao.Text.Trim();
                            Fornecedor.endereco = txt_EnderecoEdicao.Text.Trim();
                            Fornecedor.numero = txt_NumeroEdicao.Text.Trim();
                            Fornecedor.cidade = txt_CidadeEdicao.Text.Trim();
                            Fornecedor.estado = cb_EstadoEdicao.Text;
                            Fornecedor.telefone = mask_TelefoneEdicao.Text;
                            Fornecedor.celular = mask_CelularEdicao.Text;
                            Fornecedor.email = txt_EmailEdicao.Text.Trim();

                            Fornecedor.Atualizar();
                            MessageBox.Show("Dados do Fornecedor atualizado com sucesso!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_LimparEdicao_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProvider.Clear();
                            errorProvider.SetError(mask_CNPJEdicao, "Campo inválido!");
                            mask_CNPJEdicao.Clear();
                            return;
                        }
                    }
                    else
                    {
                        Fornecedor.nome = txt_RazaoSocialEdicao.Text.Trim();
                        Fornecedor.Cnpj = mask_CNPJEdicao.Text;
                        Fornecedor.Inscricao = mask_InscricaoEdicao.Text;
                        Fornecedor.CEP = mask_CepEdicao.Text;
                        Fornecedor.bairro = txt_BairroEdicao.Text.Trim();
                        Fornecedor.endereco = txt_EnderecoEdicao.Text.Trim();
                        Fornecedor.numero = txt_NumeroEdicao.Text.Trim();
                        Fornecedor.cidade = txt_CidadeEdicao.Text.Trim();
                        Fornecedor.estado = cb_EstadoEdicao.Text;
                        Fornecedor.telefone = mask_TelefoneEdicao.Text;
                        Fornecedor.celular = mask_CelularEdicao.Text;
                        Fornecedor.email = txt_EmailEdicao.Text.Trim();

                        Fornecedor.Atualizar();
                        MessageBox.Show("Dados do Fornecedor atualizado com sucesso!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LimparEdicao_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;            
            btn_Minimizar.ForeColor=Color.White;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Moccasin;
            btn_Minimizar.ForeColor = Color.Black;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
            btn_Fechar.ForeColor = Color.White;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Moccasin;
            btn_Fechar.ForeColor = Color.Black;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CodigoFornecedor();
        }
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;
        //MÉTODO PARA MOSTRAR AO USUÁRIO DO SISTEMA O CÓDIGO DO CLIENTE QUE SERÁ GERADO AO CADASTRAR O CLIENTE NO SISTEMA
        private void CodigoFornecedor()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT MAX(Id_Fornecedor) from Fornecedor";
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
        bool ValidarCNPJ()
        {
            try
            {
                if (!(mask_CNPJ.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(mask_CNPJ.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(mask_CNPJ.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(mask_CNPJ.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(mask_CNPJ.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(mask_CNPJ.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(mask_CNPJ.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(mask_CNPJ.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(mask_CNPJ.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(mask_CNPJ.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(mask_CNPJ.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(mask_CNPJ.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(mask_CNPJ.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(mask_CNPJ.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(mask_CNPJ.Text.Substring(17, 1));

                    int soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador = soma1 % 11;
                    if (digitoVerificador < 2)
                    {
                        digitoVerificador = 0;
                    }
                    else
                    {
                        digitoVerificador = 11 - digitoVerificador;
                    }

                    int soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador * 2;

                    int digitoVerificador2 = soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }
                    if (digito1 == digitoVerificador && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        bool ValidarCNPJEdicao()
        {
            try
            {
                if (!(mask_CNPJEdicao.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(mask_CNPJEdicao.Text.Substring(17, 1));

                    int soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador = soma1 % 11;
                    if (digitoVerificador < 2)
                    {
                        digitoVerificador = 0;
                    }
                    else
                    {
                        digitoVerificador = 11 - digitoVerificador;
                    }

                    int soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador * 2;

                    int digitoVerificador2 = soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }
                    if (digito1 == digitoVerificador && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        private void mask_CNPJ_Leave(object sender, EventArgs e)
        {
            if (mask_CNPJ.MaskCompleted)
            {
                if (ValidarCNPJ() == false)
                {
                    MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(mask_CNPJ, "CNPJ inválida!");
                    mask_CNPJ.Clear();
                    return;
                }
            }
        }

        private void mask_CNPJEdicao_Leave(object sender, EventArgs e)
        {
            if (mask_CNPJEdicao.MaskCompleted)
            {
                if (ValidarCNPJEdicao() == false)
                {
                    MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(mask_CNPJEdicao, "CNPJ inválido");
                    mask_CNPJEdicao.Clear();
                    return;
                }
            }
        }
        
        private void btn_BuscarEdicao_Click(object sender, EventArgs e)
        {
            FrmPesquisarFornecedor pesquisarFornecedor = new FrmPesquisarFornecedor();
            pesquisarFornecedor.ShowDialog();
            if (pesquisarFornecedor.Codigo != null)
            {
                txt_CodigoEdicao.Text = pesquisarFornecedor.Codigo;
                try
                {
                    Fornecedor.id = int.Parse(pesquisarFornecedor.Codigo);
                    Fornecedor.Consultar();
                    txt_RazaoSocialEdicao.Text = Fornecedor.nome;
                    mask_CNPJEdicao.Text = Fornecedor.Cnpj;
                    mask_InscricaoEdicao.Text = Fornecedor.Inscricao;
                    mask_CepEdicao.Text = Fornecedor.CEP;
                    txt_BairroEdicao.Text = Fornecedor.bairro;
                    txt_EnderecoEdicao.Text = Fornecedor.endereco;
                    txt_NumeroEdicao.Text = Fornecedor.numero.ToString();
                    txt_CidadeEdicao.Text = Fornecedor.cidade;
                    cb_EstadoEdicao.Text = Fornecedor.estado;
                    mask_TelefoneEdicao.Text = Fornecedor.telefone;
                    mask_CelularEdicao.Text = Fornecedor.celular;
                    txt_Email.Text = Fornecedor.email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_PesquisarExclusao_Click(object sender, EventArgs e)
        {
            FrmPesquisarFornecedor pesquisarFornecedor = new FrmPesquisarFornecedor();
            pesquisarFornecedor.ShowDialog();
            if (pesquisarFornecedor.Codigo != null)
            {
                txt_CodigoExclusao.Text = pesquisarFornecedor.Codigo;
                try
                {
                    Fornecedor.id = int.Parse(pesquisarFornecedor.Codigo);
                    Fornecedor.Consultar();
                    txt_RazaoSocialExclusao.Text = Fornecedor.nome;
                    mask_CNPJExclusao.Text = Fornecedor.Cnpj;
                    mask_InscricaoExclusao.Text = Fornecedor.Inscricao;
                    Mask_CepExclusao.Text = Fornecedor.CEP;
                    txt_BairroExclusao.Text = Fornecedor.bairro;
                    txt_EnderecoExclusao.Text = Fornecedor.endereco;
                    txt_NumeroExclusao.Text = Fornecedor.numero.ToString();
                    txt_CidadeExclusao.Text = Fornecedor.cidade;
                    cb_EstadoExclusao.Text = Fornecedor.estado;
                    mask_TelefoneExclusao.Text = Fornecedor.telefone;
                    mask_CelularExclusao.Text = Fornecedor.celular;
                    txt_Email.Text = Fornecedor.email;

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
            txt_RazaoSocialExclusao.Clear();
            mask_CNPJExclusao.Clear();
            mask_InscricaoExclusao.Clear();
            Mask_CepExclusao.Clear();
            txt_BairroExclusao.Clear();
            txt_EnderecoExclusao.Clear();
            txt_NumeroExclusao.Clear();
            txt_CidadeExclusao.Clear();
            cb_EstadoExclusao.Text = " ";
            mask_TelefoneExclusao.Clear();
            mask_CelularExclusao.Clear();
            txt_EmailExclusao.Clear();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor.id = int.Parse(txt_CodigoExclusao.Text);
                if(MessageBox.Show("Deseja mesmo excluir os dados do fornecedor?","Sistema de exclusão...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Fornecedor.Deletar();
                    MessageBox.Show("Dados do fornecedor excluido com sucesso!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_LimparExclusao_Click(sender, e);
                    CodigoFornecedor();
                }
                
            }
            catch 
            {
                MessageBox.Show("Não é permitido a exclusão! Existe Produto(s) relacionadas com o fornecedor selecionado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_PesquisarVendas_Click(object sender, EventArgs e)
        {

        }
    }
}
