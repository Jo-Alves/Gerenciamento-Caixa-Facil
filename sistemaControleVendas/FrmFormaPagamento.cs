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
    public partial class FrmFormaPagamento : Form
    {
        public string Confirmacao { get; set; }
        public int Nota { get; set; }
        public decimal Desconto { get; set; }

        public FrmFormaPagamento(string CodigoVenda, decimal ValorTotal, decimal Lucro, int IdUsuario)
        {
            InitializeComponent();
            this.CodigoVenda = int.Parse(CodigoVenda);
            this.ValorTotal = ValorTotal;
            this.Lucro = Lucro;
            this.IdUsuario = IdUsuario;
        }
        int CodigoVenda, IdUsuario;
        decimal ValorTotal, Lucro;
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cb_FormasPagamento.SelectedIndex > -1)
            {
                this.Visible = false;
                FrmPagamentoCartao PagamentoCartao = new FrmPagamentoCartao(cb_FormasPagamento.Text, CodigoVenda, ValorTotal, Lucro, IdUsuario);
                PagamentoCartao.ShowDialog();
                Confirmacao = PagamentoCartao.confirmacao;
                Nota = PagamentoCartao.Nota;
                Desconto = PagamentoCartao.Desconto;
                this.Close();
               
            }
            else
                MessageBox.Show("Selecione a forma de pagamento!", "Mensagem do sistema 'Gerenciamneto Caixa Fácil'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
