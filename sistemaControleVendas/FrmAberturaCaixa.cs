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
    public partial class FrmAberturaCaixa : Form
    {
        public FrmAberturaCaixa(int Id_Usuario, string NomeUsuario, string Funcao)
        {
            InitializeComponent();
            this.Id_Usuario = Id_Usuario;
            this.NomeUsuario = NomeUsuario;
            this.Funcao = Funcao;
            txt_ValorInicial.Focus();
        }
        int Id_Usuario;
        string NomeUsuario, Funcao;
        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Green;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (txt_ValorInicial.Text == "" || txt_ValorInicial.Text != "")
            {
                Application.Exit();
            }
        }

        ClassFluxoCaixa fluxoCaixa = new ClassFluxoCaixa();
        ClassParcelaVenda parcelaVenda = new ClassParcelaVenda();
        decimal ValorInicial;
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_ValorInicial.Text != "")
            {
                AbrirCaixa();
            }
            else
            {
                ValorInicial = 0.00m;
                AbrirCaixa();
            }
        }

        public void AbrirCaixa()
        {
            try
            {
                if (txt_ValorInicial.Text != "")
                {
                    ValorInicial = decimal.Parse(txt_ValorInicial.Text);
                }
                fluxoCaixa.valorEntrada = ValorInicial;
                fluxoCaixa.valorCaixa = 0.00m;
                fluxoCaixa.dataEntrada = DateTime.Now.ToShortDateString();
                fluxoCaixa.horaEntrada = DateTime.Now.ToLongTimeString();
                fluxoCaixa.dataSaida = "";
                fluxoCaixa.horaSaida = "";
                fluxoCaixa.id_Usuario = Id_Usuario;
                fluxoCaixa.valorReceber = 0.00m;
                fluxoCaixa.desconto = 0.00m;
                fluxoCaixa.valorCaixa = 0.00m;
                fluxoCaixa.valorRecebidoParcela = 0.00m;
                fluxoCaixa.valorRecebidoParcial = 0.00m;
                fluxoCaixa.valorRecebidoPrazo = 0.00m;
                fluxoCaixa.valorRecebidoVista = 0.00m;
                fluxoCaixa.entradaParcela = 0.00m;
                if (parcelaVenda.VerificarVencimento() == true)
                {
                    parcelaVenda.SomarValorCredito();
                    fluxoCaixa.valorRecebidoCredito = parcelaVenda.valorParcelado;
                    parcelaVenda.BaixarCredito();
                }
                else
                {
                    fluxoCaixa.valorRecebidoCredito = 0.00m;
                }
                fluxoCaixa.valorRecebidoDebito = 0.00m;
                fluxoCaixa.AbrirCaixa();
                this.Visible = false;
                FrmPrincipal frmPrincipal = new FrmPrincipal(Id_Usuario, NomeUsuario, Funcao);
                frmPrincipal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ValorInicial_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorInicial.Text != "")
                {
                    txt_ValorInicial.Text = Convert.ToDecimal(txt_ValorInicial.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorInicial.Clear();
            }
        }

        private void txt_ValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorInicial.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_ValorInicial_TextChanged(object sender, EventArgs e)
        {
            if (txt_ValorInicial.Text == "")
            {
                ValorInicial = 0.00m;
            }
        }

        private void txt_ValorInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Confirmar_Click(sender, e);
            }
        }
    }
}
