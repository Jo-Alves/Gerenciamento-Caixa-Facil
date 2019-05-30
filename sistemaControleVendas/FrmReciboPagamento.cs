using Microsoft.Reporting.WinForms;
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
    public partial class FrmReciboPagamento : Form
    {
        public FrmReciboPagamento()
        {
            InitializeComponent();
        }
        public FrmReciboPagamento(string Hora, decimal Valor, string NomeFantasia, string Cidade, string Endereco, string Numero, string CNPJ, string Cliente, string Data, string Atendente, string Id_Venda)
        {
            InitializeComponent();
            if (Cliente == "")
            {
                Cliente = "Cliente avulso";
            }
            CodigoVenda = int.Parse(Id_Venda);
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Atendente", Atendente));
            reportParameters.Add(new ReportParameter("Cidade", Cidade));
            reportParameters.Add(new ReportParameter("Cliente", Cliente));
            reportParameters.Add(new ReportParameter("CNPJ", CNPJ));
            reportParameters.Add(new ReportParameter("Data", Data));
            reportParameters.Add(new ReportParameter("Endereco", Endereco));
            reportParameters.Add(new ReportParameter("Hora", Hora));
            reportParameters.Add(new ReportParameter("Numero", Numero));
            reportParameters.Add(new ReportParameter("NomeFantasia", NomeFantasia));
            reportParameters.Add(new ReportParameter("Valor", Valor.ToString()));

            this.rv_Recibo.LocalReport.SetParameters(reportParameters);
            this.rv_Recibo.RefreshReport();
        }
        int CodigoVenda;
        private void ReciboPagamento_Load(object sender, EventArgs e)
        {
           
            this.VendaTableAdapter.Fill(this.DataSetRelatorio.Venda, CodigoVenda);

            this.rv_Recibo.RefreshReport();
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_InserirNome_Click(sender, e);
            }
        }

        private void btn_InserirNome_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "")
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();

                reportParameters.Add(new ReportParameter("Cliente", txt_Nome.Text.Trim()));
                this.rv_Recibo.LocalReport.SetParameters(reportParameters);
                this.rv_Recibo.RefreshReport();
            }
            else
            {
                MessageBox.Show("Informe o nome do cliente!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
