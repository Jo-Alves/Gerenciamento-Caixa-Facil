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
    public partial class FrmInformarDicaSenha : Form
    {
        public FrmInformarDicaSenha(string PerguntaSeguranca)
        {
            InitializeComponent();
            lbl_PerguntaSeguranca.Text = PerguntaSeguranca;
        }

        public string RespostaSeguranca { get; set; }    
        public string AcaoFechar { get; set; }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_DicaSenha.Text == "")
            {
                MessageBox.Show("Digite a dica de senha!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RespostaSeguranca = txt_DicaSenha.Text.Trim();
                txt_DicaSenha.Clear();
                txt_DicaSenha.Focus();
                this.Close();
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            RespostaSeguranca = "";
            AcaoFechar = "Fechar";
            Close();
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

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
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
