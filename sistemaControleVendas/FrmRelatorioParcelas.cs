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
    public partial class FrmRelatorioParcelas : Form
    {
        int codigoVenda;
        public FrmRelatorioParcelas(string CodigoVenda, string NomeFantasia, string Endereco, string Numero, string cidade, string Estado, string Telefone, string CNPJ)
        {
            InitializeComponent();
            codigoVenda = int.Parse(CodigoVenda);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("NomeFantasia", NomeFantasia));
            reportParameters.Add(new ReportParameter("Endereco", Endereco));
            reportParameters.Add(new ReportParameter("Numero", Numero));
            reportParameters.Add(new ReportParameter("Cidade", cidade));
            reportParameters.Add(new ReportParameter("Estado", Estado));
            reportParameters.Add(new ReportParameter("Telefone", Telefone));
            reportParameters.Add(new ReportParameter("CNPJ", CNPJ));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void FrmRelatorioParcelas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DataSetParcelas.TabelaParcelas'. Você pode movê-la ou removê-la conforme necessário.
            this.TabelaParcelasTableAdapter.Fill(this.DataSetParcelas.TabelaParcelas, codigoVenda);

            this.reportViewer1.RefreshReport();
        }

    
        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Coral;
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
