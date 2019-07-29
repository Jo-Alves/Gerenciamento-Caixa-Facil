using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaControleVendas
{
    public partial class FrmAgendamento : Form
    {
        public FrmAgendamento()
        {
            InitializeComponent();
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            mask_Horario.Text = DateTime.Now.ToLongTimeString();
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

        int X = 0, Y = 0;
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ClassAgendamento agendamento = new ClassAgendamento();
        private void btn_ConfirmarAgendamento_Click(object sender, EventArgs e)
        {
           
            if (txt_Cliente.Text == "")
            {
                MessageBox.Show("Informe o nome do cliente! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_Cliente, "Campo obrigatório!");
                txt_Cliente.Focus();
                return;
            }
            else if (txt_Servico.Text == "")
            {
                MessageBox.Show("Informe o serviço a prestar! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_Servico, "Campo obrigatório!");
                txt_Servico.Focus();
                return;
            }
            else if (!mask_Horario.MaskCompleted)
            {
                MessageBox.Show("Informe o o horário para o agendamento! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(mask_Horario, "Campo obrigatório!");
                mask_Horario.Focus();
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
                    agendamento.nomeCliente = txt_Cliente.Text.Trim();
                    agendamento.data = dtp_Data.Text;
                    agendamento.horario = mask_Horario.Text;
                    agendamento.servico = txt_Servico.Text.Trim();
                    agendamento.telefone = mask_Telefone.Text;
                    agendamento.email = txt_Email.Text.Trim();
                    agendamento.Agendar();
                    MessageBox.Show("Agendamento realizado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Limpar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Codigo = 0;
            txt_Cliente.Clear();
            txt_Servico.Text = "";
            dtp_Data.Text = DateTime.Now.ToLongDateString();
            mask_Horario.Text= DateTime.Now.ToLongTimeString();
            mask_Telefone.Clear();
            txt_Email.Clear();
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            FrmPesquisarCliente cliente = new FrmPesquisarCliente();
            cliente.ShowDialog();
            if (cliente.Codigo != null)
            {
                txt_Cliente.Text = cliente.Nome;
            }
        }

        private void btn_BuscarServico_Click(object sender, EventArgs e)
        {
            FrmPesquisarServico servico = new FrmPesquisarServico();
            servico.ShowDialog();
            if (servico.Codigo != null)
            {
                txt_Servico.Text = servico.Descricao;
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
          
            if (txt_Cliente.Text == "")
            {
                MessageBox.Show("Informe o nome do cliente! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_Cliente, "Campo obrigatório!");
                txt_Cliente.Focus();
                return;
            }
            else if (txt_Servico.Text == "")
            {
                MessageBox.Show("Informe o serviço a prestar! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txt_Servico, "Campo obrigatório!");
                txt_Servico.Focus();
                return;
            }
            else if (!mask_Horario.MaskCompleted)
            {
                MessageBox.Show("Informe o o horário para o agendamento! Campo obrigatório!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(mask_Horario, "Campo obrigatório!");
                mask_Horario.Focus();
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
                    agendamento.id = Codigo;
                    agendamento.nomeCliente = txt_Cliente.Text.Trim();
                    agendamento.data = dtp_Data.Text;
                    agendamento.horario = mask_Horario.Text;
                    agendamento.servico = txt_Servico.Text.Trim();
                    agendamento.telefone = mask_Telefone.Text;
                    agendamento.email = txt_Email.Text.Trim(); agendamento.AtualizarAgendamento();
                    MessageBox.Show("Agendamento atualizado com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Limpar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int Codigo;
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarAgendamento pesquisarAgendamento = new FrmPesquisarAgendamento("");
            pesquisarAgendamento.ShowDialog();
            if (pesquisarAgendamento.NomeCliente != "")
            {
                Codigo = pesquisarAgendamento.Codigo;
                txt_Cliente.Text = pesquisarAgendamento.NomeCliente;
                txt_Servico.Text = pesquisarAgendamento.Servico;
                dtp_Data.Text = pesquisarAgendamento.Data;
                mask_Horario.Text = pesquisarAgendamento.Horario;
                txt_Email.Text = pesquisarAgendamento.Email;
                mask_Telefone.Text = pesquisarAgendamento.Telefone;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Servico.Text == "" && txt_Cliente.Text == "")
                {
                    MessageBox.Show("Informa os dados para ser excluido!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    agendamento.id = Codigo;
                    agendamento.nomeCliente = txt_Cliente.Text.Trim();
                    agendamento.data = dtp_Data.Text;
                    agendamento.horario = mask_Horario.Text;
                    agendamento.servico = txt_Servico.Text.Trim();
                    agendamento.ExluirAgendamento();
                    MessageBox.Show("Agendamento excluido com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Limpar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Cliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Servico_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
