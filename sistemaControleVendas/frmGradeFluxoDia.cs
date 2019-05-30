using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace sistemaControleVendas
{
    public partial class frmGradeFluxoDia : Form
    {
        public frmGradeFluxoDia(string Titulo, string Entradacaixa, string SaidaCaixa, string VendaVista, string Desconto, string SaldoCaixa, string Prazo, string Parcela, string Parcial, string ValorInfCaixa, string SaldoFinal, string CartaoDebito, string CartaoCredito, string Balanco)
        {
            InitializeComponent();
            string ValorCaixa, SaldoFinalCaixa;
            if (ValorInfCaixa != "")
            {
                ValorCaixa = "Valor Informado no Caixa: " + ValorInfCaixa;
                SaldoFinalCaixa = "Saldo final: " + SaldoFinal;
            }
            else
            {
                ValorCaixa = " ";
                SaldoFinalCaixa = " ";
            }
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Detalhes", Titulo));
            reportParameters.Add(new ReportParameter("EntradaCaixa", Entradacaixa));
            reportParameters.Add(new ReportParameter("SaidaCaixa", SaidaCaixa));
            reportParameters.Add(new ReportParameter("VendaVista", VendaVista));
            reportParameters.Add(new ReportParameter("Prazo", Prazo));
            reportParameters.Add(new ReportParameter("Parcial", Parcial));
            reportParameters.Add(new ReportParameter("Parcela", Parcela));
            reportParameters.Add(new ReportParameter("SaldoCaixa", SaldoCaixa));
            reportParameters.Add(new ReportParameter("Desconto", Desconto));
            reportParameters.Add(new ReportParameter("ValorInformadoCaixa", ValorCaixa));
            reportParameters.Add(new ReportParameter("SaldoFinal", SaldoFinalCaixa));
            reportParameters.Add(new ReportParameter("CartaoDebito", "R$ " + CartaoDebito));
            reportParameters.Add(new ReportParameter("CartaoCredito", "R$ " + CartaoCredito));
            reportParameters.Add(new ReportParameter("Balanco", "R$ " + Balanco));
            this.rv_GradeFluxoCaixa.LocalReport.SetParameters(reportParameters);
            this.rv_GradeFluxoCaixa.RefreshReport();
        }

        private void frmGradeFluxoDia_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Coral;
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

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
