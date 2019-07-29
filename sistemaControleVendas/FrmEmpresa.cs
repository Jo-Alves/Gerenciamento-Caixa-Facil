using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaControleVendas.Properties;

namespace sistemaControleVendas
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
            CodigoEmpresa();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_AreaAtuacao.Text = " ";
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_Logradouro.Clear();
            txt_NomeFantasia.Clear();
            txt_Email.Clear();
            txt_Logradouro.Clear();
            txt_Numero.Clear();
            txt_RazaoSocial.Clear();
            mask_celular.Clear();
            mask_Cep.Clear();
            mask_CNPJ.Clear();
            mask_Telefone.Clear();
            mask_InscricaoEstadual.Clear();
            pb_ImagemEmpresa.Image = null;
            btn_LimparImagem.Enabled = false;
            cb_Estado.Text = " ";
        }

      
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarEmpresa pesquisarEmpresa = new FrmPesquisarEmpresa();
            pesquisarEmpresa.ShowDialog();
            if (pesquisarEmpresa.Codigo != null)
            {
                Cod = pesquisarEmpresa.Codigo;
                try
                {
                    empresa.id = int.Parse(pesquisarEmpresa.Codigo);
                    empresa.Consultar();
                    txt_RazaoSocialEdicao.Text = empresa.razaoSocial;
                    cb_AreaAtuacaoEdicao.Text = empresa.areaAtuacao;
                    txt_NomeFantasiaEdicao.Text = empresa.nomeFantasia;
                    
                    mask_CNPJEdicao.Text = empresa.CNPJ;
                    mask_InscricaoEstadualEdicao.Text = empresa.inscricao;
                    txt_LogradouroEdicao.Text = empresa.endereco;
                    mask_CepEdicao.Text = empresa.CEP;
                    txt_NumeroEdicao.Text = empresa.numero.ToString();
                    txt_BairroEdicao.Text = empresa.bairro;
                    txt_CidadeEdicao.Text = empresa.cidade;
                    cb_EstadoEdicao.Text = empresa.estado;
                    mask_TelefoneEdicao.Text = empresa.telefone;
                    mask_CelularEdicao.Text = empresa.celular;
                    txt_EmailEdicao.Text = empresa.email;
                    if (empresa.logoEmpresa != "")
                    {
                        pb_ImagemAlterar.Load(empresa.logoEmpresa);
                        Diretorio = empresa.logoEmpresa;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btn_AlterarImagem.Enabled = true;
            btn_LimparImagemAtualizar.Enabled = true;
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
            btn_Minimizar.ForeColor = Color.White;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.White;
            btn_Minimizar.ForeColor = Color.Black;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
            btn_Fechar.ForeColor = Color.White;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.White;
            btn_Fechar.ForeColor = Color.Black;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;
        int Id_Empresa;
        public void CodigoEmpresa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Max(Id_Empresa) from Empresa";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                Id_Empresa = int.Parse(comando.ExecuteScalar().ToString() + 1);
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void CriarPasta()
        {
            string Pasta = Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Imagens do sistema\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        ClassEmpresa empresa = new ClassEmpresa();
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txt_RazaoSocial.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Razão Social'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_RazaoSocial, "Campo obrigatório!");
                txt_RazaoSocial.Focus();
                return;
            }
            else if (txt_NomeFantasia.Text == string.Empty)
            {
                MessageBox.Show("Preencha  o campo 'Nome Fantasia'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_NomeFantasia, "Campo obrigatório!");
                txt_NomeFantasia.Focus();
                return;
            }
            else if (cb_AreaAtuacao.Text == " ")
            {
                MessageBox.Show("Preencha  a área de atuação da empresa!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(cb_AreaAtuacao, "Campo obrigatório!");
                cb_AreaAtuacao.Focus();
                return;
            }
            else if (!mask_CNPJ.MaskCompleted)
            {
                MessageBox.Show("Preencha todo o campo do 'CPNJ'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(mask_CNPJ, "Campo obrigatório!");
                mask_CNPJ.Focus();
                return;
            }
            else if (txt_Logradouro.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Endereço'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_Logradouro, "Campo obrigatório!");
                txt_Logradouro.Focus();
                return;
            }
            else if (!mask_Cep.MaskCompleted)
            {
                MessageBox.Show("Preencha todo o campo do 'CEP'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_Cep, "Campo obrigatório!");
                mask_Cep.Focus();
                return;
            }
            else if (txt_Numero.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Número'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Numero, "Campo obrigatório!");
                txt_Numero.Focus();
                return;
            }
            else if (txt_Bairro.Text == string.Empty)
            {

                MessageBox.Show("Preencha o campo 'Bairro'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Bairro, "Campo obrigatório!");
                txt_Bairro.Focus();
                return;
            }
            else if (txt_Cidade.Text == string.Empty)
            {
                MessageBox.Show("Preencha todo o campo 'Cidade'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_Cidade, "Campo obrigatório!");
                txt_Cidade.Focus();
                return;
            }
            else if (cb_Estado.Text == "")
            {
                MessageBox.Show("Selecione o 'Estado'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(cb_Estado, "Campo obrigatório!");
                cb_Estado.Focus();
                return;
            }
            else if ((txt_Email.Text != string.Empty) && (!ClassValidacaoEmail.validarEmail(txt_Email.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txt_Email, "E-mail inválido!");
                txt_Email.Focus();
                return;
            }            
            else
            {               
                try
                {
                    if (ValidarCNPJ() == true)
                    {
                        empresa.id = Id_Empresa;
                        empresa.razaoSocial = txt_RazaoSocial.Text.Trim();
                        empresa.nomeFantasia = txt_NomeFantasia.Text.Trim();
                        empresa.areaAtuacao = cb_AreaAtuacao.Text;
                        empresa.CNPJ = mask_CNPJ.Text;
                        empresa.inscricao = mask_InscricaoEstadual.Text;
                        empresa.endereco = txt_Logradouro.Text.Trim();
                        empresa.CEP = mask_Cep.Text;
                        empresa.numero = int.Parse(txt_Numero.Text.Trim());
                        empresa.bairro = txt_Bairro.Text.Trim();
                        empresa.cidade = txt_Cidade.Text.Trim();
                        empresa.celular = mask_celular.Text;
                        empresa.estado = cb_Estado.Text;
                        empresa.telefone = mask_Telefone.Text;
                        empresa.email = txt_Email.Text.Trim();
                        empresa.areaAtuacao = cb_AreaAtuacao.Text;
                        if (Diretorio == null)
                        {
                            Diretorio = "";

                        }
                        else if (Diretorio != null)
                        {
                            try
                            {
                                CriarPasta();
                                string ArquivoImagem = Diretorio;
                                string NomedoArquivo = Path.GetFileName(Diretorio);

                                FileInfo fileInfo = new FileInfo(ArquivoImagem);
                                fileInfo.CopyTo(Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Imagens do sistema\" + NomedoArquivo);
                                Diretorio = Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Imagens do sistema\" + NomedoArquivo;
                            }
                            catch
                            {

                            }
                        }
                        else if (pb_ImagemEmpresa.Image == null)
                        {
                            Diretorio = "";
                        }
                        empresa.logoEmpresa = Diretorio;
                        if (empresa.cadastrar() == false)
                        {                           
                            MessageBox.Show("Dados da empresa cadastrada com sucesso!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Limpar_Click(sender, e);
                            Diretorio = "";
                        }
                        else
                        {
                            MessageBox.Show("Já existe uma empresa cadastrada no sistema!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexao com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_BuscarCep_Click(object sender, EventArgs e)
        {
            if (mask_Cep.MaskCompleted)
            {
                try
                {
                   using(var ws = new WsCorreios.AtendeClienteClient())
                    {
                        var consultaCEP = ws.consultaCEP(mask_Cep.Text);
                        txt_Logradouro.Text = consultaCEP.end;
                        txt_Bairro.Text = consultaCEP.bairro;
                        txt_Cidade.Text = consultaCEP.cidade;
                        cb_Estado.Text = consultaCEP.uf;
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

        private void mask_CNPJ_Leave(object sender, EventArgs e)
        {
            if (ValidarCNPJ() == false)
            {
                MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_CNPJ, "Campo inválido!");
                mask_CNPJ.Clear();
                return;
            }
        }

        private void btn_LimparEdicao_Click(object sender, EventArgs e)
        {
            cb_AreaAtuacaoEdicao.Text= " ";
            btn_AlterarImagem.Enabled = false;
            btn_LimparImagemAtualizar.Enabled = false;
            pb_ImagemAlterar.Image = null;
            txt_BairroEdicao.Clear();
            txt_CidadeEdicao.Clear();
            txt_LogradouroEdicao.Clear();
            txt_NomeFantasiaEdicao.Clear();
            txt_EmailEdicao.Clear();
            txt_LogradouroEdicao.Clear();
            txt_NumeroEdicao.Clear();
            txt_RazaoSocialEdicao.Clear();
            mask_CelularEdicao.Clear();
            mask_CepEdicao.Clear();
            mask_CNPJEdicao.Clear();
            mask_TelefoneEdicao.Clear();
            mask_InscricaoEstadualEdicao.Clear();
            cb_EstadoEdicao.Text = " ";
        }

        private void txt_RazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_NomeFantasia_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Logradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_Cep_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Cidade.Text != string.Empty)
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

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Bairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Cidade_KeyDown(object sender, KeyEventArgs e)
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

        private void mask_celular_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_RazaoSocialEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeFantasiaEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CNPJEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_InscricaoEstadualEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_LogradouroEdicacao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CepEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_BairroEdicao_TextChanged(object sender, EventArgs e)
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

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_EmailEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_RazaoSocialEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_NomeFantasiaEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void mask_CNPJEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void mask_InscricaoEstadualEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_LogradouroEdicacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void mask_CepEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_NumeroEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_BairroEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_CidadeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void mask_TelefoneEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void mask_CelularEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }

        private void txt_EmailEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editar_Click(sender, e);
            }
        }
        string Cod;
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_RazaoSocialEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Razão Social'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(txt_RazaoSocialEdicao, "Campo obrigatório!");
                txt_RazaoSocialEdicao.Focus();
                return;
            }
            else if (txt_NomeFantasiaEdicao.Text == string.Empty)
            {

                MessageBox.Show("Preencha o campo 'Nome Fantasia'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_NomeFantasiaEdicao, "Campo obrigatório!");
                txt_NomeFantasiaEdicao.Focus();
                return;
            }
            else if (cb_AreaAtuacaoEdicao.Text == " ")
            {
                MessageBox.Show("Preencha  a área de atuação da empresa!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); errorProvider.Clear();
                errorProvider.SetError(cb_AreaAtuacaoEdicao, "Campo obrigatório!");
                cb_AreaAtuacaoEdicao.Focus();
                return;
            }
            else if (!mask_CNPJEdicao.MaskCompleted)
            {
                MessageBox.Show("Preencha todo o campo do 'CNPJ!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_CNPJEdicao, "Campo obrigatório!");
                mask_CNPJEdicao.Focus();
                return;
            }

            else if (txt_LogradouroEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Endereço'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_LogradouroEdicao, "Campo obrigatório!");
                txt_LogradouroEdicao.Focus();
                return;
            }
            else if (!mask_CepEdicao.MaskCompleted)
            {
                MessageBox.Show("Preencha todo o campo 'CEP'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_CepEdicao, "Campo obrigatório!");
                mask_CepEdicao.Focus();
                return;
            }
            else if (txt_NumeroEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Número'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_NumeroEdicao, "Campo obrigatório!");
                txt_NumeroEdicao.Focus();
                return;
            }
            else if (txt_BairroEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Bairro'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_BairroEdicao, "Campo obrigatório!");
                txt_BairroEdicao.Focus();
                return;
            }
            else if (txt_CidadeEdicao.Text == string.Empty)
            {
                MessageBox.Show("Preencha o campo 'Cidade'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(txt_CidadeEdicao, "Campo obrigatório!");
                txt_CidadeEdicao.Focus();
                return;
            }
            else if (PanelCorpo.Text == "")
            {
                MessageBox.Show("Selecione o 'Estado'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(PanelCorpo, "Campo obrigatório!");
                cb_Estado.Focus();
                return;
            }
            else if ((txt_EmailEdicao.Text != string.Empty) && (!ClassValidacaoEmail.validarEmail(txt_EmailEdicao.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProvider.SetError(txt_EmailEdicao, "E-mail inválido!");
                txt_EmailEdicao.Focus();
                return;
            }
            else
            {
                try
                {
                    if (ValidarCNPJEdicao() == true)
                    {
                        empresa.id = int.Parse(Cod);
                        empresa.razaoSocial = txt_RazaoSocialEdicao.Text.Trim();
                        empresa.nomeFantasia = txt_NomeFantasiaEdicao.Text.Trim();
                        empresa.areaAtuacao = cb_AreaAtuacaoEdicao.Text;
                        empresa.CNPJ = mask_CNPJEdicao.Text;
                        empresa.inscricao = mask_InscricaoEstadualEdicao.Text;
                        empresa.endereco = txt_LogradouroEdicao.Text.Trim();
                        empresa.CEP = mask_CepEdicao.Text;
                        empresa.numero = int.Parse(txt_NumeroEdicao.Text.Trim());
                        empresa.bairro = txt_BairroEdicao.Text.Trim();
                        empresa.cidade = txt_CidadeEdicao.Text.Trim();
                        empresa.estado = cb_EstadoEdicao.Text;
                        empresa.celular = mask_CelularEdicao.Text;
                        empresa.email = txt_EmailEdicao.Text.Trim();
                        empresa.telefone = mask_TelefoneEdicao.Text;
                        if (Diretorio == null)
                        {
                            Diretorio = "";

                        }
                        else if (Diretorio != null)
                        {
                            try
                            {
                                CriarPasta();
                                string ArquivoImagem = Diretorio;
                                string NomedoArquivo = Path.GetFileName(Diretorio);

                                FileInfo fileInfo = new FileInfo(ArquivoImagem);
                                fileInfo.CopyTo(Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Imagens do sistema\" + NomedoArquivo);
                                Diretorio = Settings.Default["Disco"].ToString() + @"Gerenciamento Caixa Fácil\Imagens do sistema\" + NomedoArquivo;
                            }
                            catch
                            {
                            }
                        }
                        else if (pb_ImagemEmpresa.Image == null)
                        {
                            Diretorio = "";
                        }
                        empresa.logoEmpresa = Diretorio;
                        empresa.Atualizar();
                        MessageBox.Show("Dados da empresa atualizada com sucesso!", "Informação do sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro na conexao com o banco de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void mask_CNPJEdicao_Leave(object sender, EventArgs e)
        {
            if (ValidarCNPJEdicao() == false)
            {
                MessageBox.Show("CNPJ inválido!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.Clear();
                errorProvider.SetError(mask_CNPJEdicao, "Campo inválido!");
                mask_CNPJEdicao.Clear();
                return;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_Estadoedicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

     public string Diretorio { get; set; }

        private void btn_AlterarImagem_Click(object sender, EventArgs e)
        {
            AbrirArquivo = new OpenFileDialog();
            AbrirArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF*";
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                Diretorio = AbrirArquivo.FileName;
                pb_ImagemAlterar.Load(Diretorio);
            }
        }

        private void btn_LimparImagemAtualizar_Click(object sender, EventArgs e)
        {
            pb_ImagemAlterar.Image = null;
            Diretorio = null;
        }

        private void btn_LimparImagem_Click(object sender, EventArgs e)
        {
            pb_ImagemEmpresa.Image = null;
            Diretorio = null;
            btn_LimparImagem.Enabled = false;
        }
        OpenFileDialog AbrirArquivo;

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void cb_AreaAtuacao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cb_AreaAtuacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_RazaoSocial_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeFantasia_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_InscricaoEstadual_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Logradouro_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Cep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Bairro_TextChanged(object sender, EventArgs e)
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

        private void mask_celular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void btn_BuscarCepEdicao_Click(object sender, EventArgs e)
        {
            if (mask_CepEdicao.MaskCompleted)
            {
                try
                {
                    using (var ws = new WsCorreios.AtendeClienteClient())
                    {
                        var consultaCEP = ws.consultaCEP(mask_CepEdicao.Text);
                        txt_LogradouroEdicao.Text = consultaCEP.end;
                        txt_BairroEdicao.Text = consultaCEP.bairro;
                        txt_CidadeEdicao.Text = consultaCEP.cidade;
                        cb_EstadoEdicao.Text = consultaCEP.uf;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            AbrirArquivo = new OpenFileDialog();
            AbrirArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF*";
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                Diretorio = AbrirArquivo.FileName;
                pb_ImagemEmpresa.ImageLocation = Diretorio;
                pb_ImagemEmpresa.Load();                
            }
            btn_LimparImagem.Enabled = true; 
        }
    }
}
