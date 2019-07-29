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
    public partial class FrmRedefinicaoSenha : Form
    {
        public FrmRedefinicaoSenha(string Usuario)
        {
            InitializeComponent();
            lbl_Usuario.Text = Usuario;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_ConfirmarSenha.Text.Trim() == txt_Senha.Text.Trim())
            {
                try
                {
                    ClassUsuario usuario = new ClassUsuario();
                    usuario.usuario = lbl_Usuario.Text;
                    usuario.senha = ClassSeguranca.Criptografar(txt_ConfirmarSenha.Text);
                    usuario.RedefinirSenha();
                    MessageBox.Show("Senha redefinida com sucesso!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("As senhas não correspondem", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
        }

        int X = 0, Y = 0;
        private void panelTela_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }

        private void txt_ConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }

        private void panelTela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
