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
    public partial class FrmHistoricoPagamentoDetalhado : Form
    {
        string FormaPagamento, CodCliente;
        public FrmHistoricoPagamentoDetalhado(string NVenda, string Cliente, string dateTime, decimal ValorVenda, string FormaPagamento, decimal ValorAbatido, decimal ValorRestante)
        {
            InitializeComponent();
            txtCodigoVenda.Text = NVenda;
            txtCliente.Text = Cliente;
            txtDateTime.Text = dateTime;
            txtValorVenda.Text = "R$ " + ValorVenda.ToString();
            txtFormaPagamento.Text = FormaPagamento;
            txtValorRestante.Text = "R$ " + ValorRestante.ToString();
            txtValorPago.Text = "R$ " + ValorAbatido.ToString();
            this.CodCliente = CodCliente;            
        }

        private void FrmListavenda_Load(object sender, EventArgs e)
        {
                          
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHistoricoPagamentoDetalhado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnFechar_Click(sender, e);
            }
        }

        private void PanelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}