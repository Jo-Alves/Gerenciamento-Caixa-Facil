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
    public partial class FrmClientes : Form
    {
        public FrmClientes(string reposta)
        {
            InitializeComponent();
            if (reposta == "Sim")
            {
                TabClientes.SelectedTab = tabPageCadastro;
                TabClientes.Controls.Remove(tabPageEdicao);
                TabClientes.Controls.Remove(tabPageExclusao);
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
        //MÉTODO PARA MOSTRAR AO USUÁRIO DO SISTEMA O CÓDIGO DO CLIENTE QUE SERÁ GERADO AO CADASTRAR O CLIENTE NO SISTEMA
        private void codigoCliente()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT MAX(Id_Cliente) from Cliente";
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
        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.DarkTurquoise;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.DarkTurquoise;
        }

        private void mask_Cpf_Leave(object sender, EventArgs e)
        {
            if (mask_Cpf.MaskCompleted)
            {
                string validar = mask_Cpf.Text;
                if (!CPF.ValidaCpf(validar))
                {
                    MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.SetError(mask_Cpf, "CPF inválido!");
                    mask_Cpf.Clear();
                    return;
                }
            }
        }

        private void btn_BuscarCep_Click(object sender, EventArgs e)
        {
            if (mask_Cep.MaskCompleted)
            {
                try
                {
                    using (var ws = new WsCorreios.AtendeClienteClient())
                    {
                        var consultaCep = ws.consultaCEP(mask_Cep.Text);
                        txt_Endereco.Text = consultaCep.end;
                        txt_Bairro.Text = consultaCep.bairro;
                        txt_Cidade.Text = consultaCep.cidade;
                        cb_Estado.Text = consultaCep.uf;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        internal void ShowDialog(string atualizar)
        {
            throw new NotImplementedException();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            txt_Nome.Clear();
            txt_Endereco.Clear();
            txt_Email.Clear();
            txt_Cidade.Clear();
            txt_Bairro.Clear();
            mask_Celular.Clear();
            mask_Cep.Clear();
            mask_Cpf.Clear();
            mask_RG.Clear();
            mask_Telefone.Clear();
            cb_Estado.Text = " ";
            txt_Numero.Clear();
            lbl_Idade.Text = "";
        }
        ClassClientes cliente = new ClassClientes();
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Código'! ", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Codigo, "Campo obrigatório!");
                    txt_Codigo.Focus();
                    return;
                }
                else if (txt_Nome.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Nome'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Nome, "Campo obrigatório!");
                    txt_Nome.Focus();
                    return;
                }
                else if (!mask_Cep.MaskCompleted)
                {
                    MessageBox.Show("Preencha todo o campo do Cep!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(mask_Cep, "Campo Incompleto!");
                    mask_Cep.Focus();
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

                else if (txt_Endereco.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Endereço'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Endereco, "Campo obrigatório!");
                    txt_Endereco.Focus();
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
                else if (txt_Cidade.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Cidade'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Cidade, "Campo obrigatório!");
                    txt_Cidade.Focus();
                    return;
                }
                else if (cb_Estado.Text == string.Empty)
                {
                    MessageBox.Show("Selecione o Estado de sua região!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if (mask_Cpf.MaskCompleted)
                    {
                        string validar = mask_Cpf.Text;
                        if (CPF.ValidaCpf(validar) == true)
                        {
                            cliente.id = int.Parse(txt_Codigo.Text);
                            cliente.nome = txt_Nome.Text.Trim();
                            cliente.dataNascimento = dateNascimento.Text;
                            cliente.CPF = ClassSeguranca.Criptografar(mask_Cpf.Text);
                            cliente.RG = ClassSeguranca.Criptografar(mask_RG.Text);
                            cliente.CEP = mask_Cep.Text;
                            cliente.bairro = txt_Bairro.Text.Trim();
                            cliente.endereco = txt_Endereco.Text.Trim();
                            cliente.numero = txt_Numero.Text.Trim();
                            cliente.cidade = txt_Cidade.Text.Trim();
                            cliente.estado = cb_Estado.Text;
                            cliente.telefone = mask_Telefone.Text;
                            cliente.celular = mask_Celular.Text;
                            cliente.email = txt_Email.Text.Trim();

                            cliente.Cadastrar();

                            MessageBox.Show("Cliente cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Limpar_Click(sender, e);
                            codigoCliente();
                        }
                        else
                        {
                            MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProvider.Clear();
                            errorProvider.SetError(mask_Cpf, "CPF inválido!");
                            return;
                        }
                    }
                    else
                    {
                        cliente.id = int.Parse(txt_Codigo.Text);
                        cliente.nome = txt_Nome.Text.Trim();
                        cliente.dataNascimento = dateNascimento.Text;
                        cliente.CPF = ClassSeguranca.Criptografar(mask_Cpf.Text);
                        cliente.RG = ClassSeguranca.Criptografar(mask_RG.Text);
                        cliente.CEP = mask_Cep.Text;
                        cliente.bairro = txt_Bairro.Text.Trim();
                        cliente.endereco = txt_Endereco.Text.Trim();
                        cliente.numero = txt_Numero.Text.Trim();
                        cliente.cidade = txt_Cidade.Text.Trim();
                        cliente.estado = cb_Estado.Text;
                        cliente.telefone = mask_Telefone.Text;
                        cliente.celular = mask_Celular.Text;
                        cliente.email = txt_Email.Text.Trim();

                        cliente.Cadastrar();

                        MessageBox.Show("Cliente cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Limpar_Click(sender, e);
                        codigoCliente();
                    }                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            codigoCliente();
        }
        int X = 0;
        int Y = 0;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_RG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void mask_Cep_KeyDown(object sender, KeyEventArgs e)
        {
            if ((txt_Cidade.Text != "") && (cb_Estado.Text != ""))
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

        private void txt_Codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_RG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }

        private void mask_Cpf_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Bairro_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
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

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LimparEdicao_Click(object sender, EventArgs e)
        {
            txt_CodigoEdicao.Clear();
            txt_NomeEdicao.Clear();
            txt_EnderecoEdicao.Clear();
            txt_EmailEdicao.Clear();
            txt_CidadeEdicao.Clear();
            txt_BairroEdicao.Clear();
            mask_CelularEdicao.Clear();
            mask_CepEdicao.Clear();
            mask_CPFEdicao.Clear();
            dateNascimentoEdicao.Text = DateTime.Now.ToShortDateString();
            mask_RGEdicacao.Clear();
            mask_TelefoneEdicao.Clear();
            cb_EstadoEdicao.Text = " ";
            txt_NumeroEdicao.Clear();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            //código para  editar os dados do cliente
            try
            {
                if (txt_CodigoEdicao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Código'! ", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_CodigoEdicao, "Campo obrigatório!");
                    txt_CodigoEdicao.Focus();
                    return;
                }
                else if (txt_NomeEdicao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Nome'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_NomeEdicao, "Campo obrigatório!");
                    txt_NomeEdicao.Focus();
                    return;
                }              
                else if (!mask_CepEdicao.MaskCompleted)
                {
                    MessageBox.Show("Preencha todo o campo do Cep!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(mask_CepEdicao, "Campo Incompleto!");
                    mask_CepEdicao.Focus();
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

                else if (txt_EnderecoEdicao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Endereço'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_EnderecoEdicao, "Campo obrigatório!");
                    txt_EnderecoEdicao.Focus();
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
                else if (txt_CidadeEdicao.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo 'Cidade'!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(txt_CidadeEdicao, "Campo obrigatório!");
                    txt_CidadeEdicao.Focus();
                    return;
                }
                else if (cb_EstadoEdicao.Text == string.Empty)
                {
                    MessageBox.Show("Selecione o Estado de sua região!", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(cb_EstadoEdicao, "Campo obrigatório!");
                    cb_EstadoEdicao.Focus();
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
                    if (mask_CPFEdicao.MaskCompleted)
                    {
                        string validar = mask_CPFEdicao.Text;
                        if (CPF.ValidaCpf(validar))
                        {
                            cliente.id = int.Parse(txt_CodigoEdicao.Text.Trim());
                            cliente.nome = txt_NomeEdicao.Text.Trim();
                            cliente.dataNascimento =dateNascimentoEdicao.Text;
                            cliente.CPF = ClassSeguranca.Criptografar(mask_CPFEdicao.Text);
                            cliente.RG = ClassSeguranca.Criptografar(mask_RGEdicacao.Text);
                            cliente.CEP = mask_CepEdicao.Text;
                            cliente.bairro = txt_BairroEdicao.Text.Trim();
                            cliente.endereco = txt_EnderecoEdicao.Text.Trim();
                            cliente.numero = txt_NumeroEdicao.Text.Trim();
                            cliente.cidade = txt_CidadeEdicao.Text.Trim();
                            cliente.estado = cb_EstadoEdicao.Text;
                            cliente.telefone = mask_TelefoneEdicao.Text;
                            cliente.celular = mask_CelularEdicao.Text;
                            cliente.email = txt_EmailEdicao.Text.Trim();

                            cliente.Atualizar();

                            MessageBox.Show("Dados do cliente atualizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_LimparEdicao_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            mask_CPFEdicao.Focus();
                            errorProvider.Clear();
                            errorProvider.SetError(mask_CPFEdicao, "CPF inválido!");
                            return;
                        }
                    }
                    else
                    {
                        cliente.id = int.Parse(txt_CodigoEdicao.Text.Trim());
                        cliente.nome = txt_NomeEdicao.Text.Trim();
                        cliente.dataNascimento = dateNascimentoEdicao.Text;
                        cliente.CPF = ClassSeguranca.Criptografar(mask_CPFEdicao.Text);
                        cliente.RG = ClassSeguranca.Criptografar(mask_RGEdicacao.Text);
                        cliente.CEP = mask_CepEdicao.Text;
                        cliente.bairro = txt_BairroEdicao.Text.Trim();
                        cliente.endereco = txt_EnderecoEdicao.Text.Trim();
                        cliente.numero = txt_NumeroEdicao.Text.Trim();
                        cliente.cidade = txt_CidadeEdicao.Text.Trim();
                        cliente.estado = cb_EstadoEdicao.Text;
                        cliente.telefone = mask_TelefoneEdicao.Text;
                        cliente.celular = mask_CelularEdicao.Text;
                        cliente.email = txt_EmailEdicao.Text.Trim();

                        cliente.Atualizar();

                        MessageBox.Show("Dados do cliente atualizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LimparEdicao_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_NomeEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }        

        private void mask_CPFEdicao_Leave(object sender, EventArgs e)
        {
            //código para validar o CPF

            string validar = mask_CPFEdicao.Text;
            if (mask_CPFEdicao.MaskCompleted)
            {
                if (!CPF.ValidaCpf(validar))
                {
                    MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errorProvider.Clear();
                    errorProvider.SetError(mask_CPFEdicao, "Campo inválido");
                    mask_CPFEdicao.Clear();
                    return;
                }
            }
        }

        private void btn_BuscaCepEdicao_Click(object sender, EventArgs e)
        {
            //código para buscar o CEP
            if (mask_CepEdicao.MaskCompleted)
            {
                try
                {
                   using(var ws = new WsCorreios.AtendeClienteClient())
                    {
                        var consultaCEP = ws.consultaCEP(mask_CepEdicao.Text);
                        txt_EnderecoEdicao.Text = consultaCEP.end;
                        txt_BairroEdicao.Text = consultaCEP.bairro;
                        txt_CidadeEdicao.Text = consultaCEP.cidade;
                        cb_EstadoEdicao.Text = consultaCEP.uf;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_NumeroEdicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NomeEdicao_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_RGEdicacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_CPFEdicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void cb_EstadoEdicao_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txt_CodigoEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void txt_NomeEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_RGEdicacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_CPFEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Editar_Click(sender, e);
            }
        }

        private void mask_CepEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            // se o campo cidade e estado estiver diferente de vazio
            // ao acionar o enter o evento do botão editar será acionado
            //Se não o evento do botão buscar cep será acionado
            if ((txt_CidadeEdicao.Text != "") && (cb_EstadoEdicao.Text != ""))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_Editar_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_BuscaCepEdicao_Click(sender, e);
                }
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

        private void btn_BuscarEdicao_Click(object sender, EventArgs e)
        {
            //abre o formulario frmpesquisarCliente e recebe os valores da propriedade do frmpesquisarcliente   
            FrmPesquisarCliente PC = new FrmPesquisarCliente();
            PC.ShowDialog();


            if (PC.Codigo != null && PC.Codigo!="1")
            {
                txt_CodigoEdicao.Text = PC.Codigo;
                try
                {
                    cliente.id = int.Parse(PC.Codigo);
                    cliente.Consultar();
                    txt_NomeEdicao.Text = cliente.nome;
                    dateNascimentoEdicao.Text = cliente.dataNascimento;
                    mask_CPFEdicao.Text = ClassSeguranca.Descriptografar(cliente.CPF);
                    mask_RGEdicacao.Text = ClassSeguranca.Descriptografar(cliente.RG);
                    mask_CepEdicao.Text = cliente.CEP;
                    txt_BairroEdicao.Text = cliente.bairro;
                    txt_EnderecoEdicao.Text = cliente.endereco;
                    txt_NumeroEdicao.Text = cliente.numero.ToString();
                    txt_CidadeEdicao.Text = cliente.cidade;
                    cb_EstadoEdicao.Text = cliente.estado;
                    mask_TelefoneEdicao.Text = cliente.telefone;
                    mask_CelularEdicao.Text = cliente.celular;
                    txt_EmailEdicao.Text = cliente.email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_PesquisarExclusao_Click(object sender, EventArgs e)
        {
            //abre o formulário FrmPequisarCliente
            FrmPesquisarCliente PC = new FrmPesquisarCliente();
            PC.ShowDialog();

            if (PC.Codigo != null && PC.Codigo != "1")
            {
                txt_CodigoExclusao.Text = PC.Codigo;
                try
                {
                    cliente.id = int.Parse(PC.Codigo);
                    cliente.Consultar();
                    txt_NomeExclusao.Text = cliente.nome;
                    Mask_DataNascimentoExclusao.Text = cliente.dataNascimento;
                    mask_CPFExclusao.Text = ClassSeguranca.Descriptografar(cliente.CPF);
                    mask_RGExclusao.Text = ClassSeguranca.Descriptografar(cliente.RG);
                    Mask_CepExclusao.Text = cliente.CEP;
                    txt_BairroExclusao.Text = cliente.bairro;
                    txt_EnderecoExclusao.Text = cliente.endereco;
                    txt_NumeroExclusao.Text = cliente.numero.ToString();
                    txt_CidadeExclusao.Text = cliente.cidade;
                    cb_EstadoExclusao.Text = cliente.estado;
                    mask_TelefoneExclusao.Text = cliente.telefone;
                    mask_CelularExclusao.Text = cliente.celular;
                    txt_EmailExclusao.Text = cliente.email;
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
            txt_EnderecoExclusao.Clear();
            txt_EmailExclusao.Clear();
            txt_CidadeExclusao.Clear();
            txt_BairroExclusao.Clear();
            mask_CelularExclusao.Clear();
            Mask_CepExclusao.Clear();
            mask_CPFExclusao.Clear();
            Mask_DataNascimentoExclusao.Clear();
            mask_RGExclusao.Clear();
            mask_TelefoneExclusao.Clear();
            cb_EstadoExclusao.Text = " ";
            txt_NumeroExclusao.Clear();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //código instaciado da classe classCliente
            //função para excluir os dados do cliente
            if (txt_Codigo.Text != "")
            {
                cliente.id = int.Parse(txt_CodigoExclusao.Text);
                if (MessageBox.Show("Deseja mesmo excluir os dados do cliente?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        cliente.Deletar();
                        MessageBox.Show("Dados do cliente deletado com sucesso!", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_LimparExclusao_Click(sender, e);
                        codigoCliente();
                    }
                    catch
                    {
                        MessageBox.Show("Não é permitido a exclusão! Existe registros de venda(s) do cliente", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                MessageBox.Show("É necessário preencher os campos para excluir os dados dos banco de dados!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }       

        private void dateNascimento_Leave(object sender, EventArgs e)
        {

            DateTime resultado = DateTime.MinValue;
            if (DateTime.TryParse(this.dateNascimento.Text.Trim(), out resultado))
            {
                string DataAtual = DateTime.Now.ToShortDateString();

                DateTime DataNascimento = Convert.ToDateTime(dateNascimento.Text);
                DateTime DataHoje = Convert.ToDateTime(DataAtual);
                TimeSpan time = DataHoje.Subtract(DataNascimento);

                int dias = time.Days;
                int Idade = dias / 365;
                lbl_Idade.Text = Idade.ToString();
            }

        }
    }
}
