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
    public partial class FrmCupom : Form
    {
        public FrmCupom(int CodVenda, string Hora, string NomeFantasia, string Cidade, string Estado, string Endereco, string Numero, string CNPJ, string Cliente, string Data, string Atendente, string Id_Venda, decimal ValorPago, decimal troco, string Bairro)
        {
            InitializeComponent();
            ReportParameterCollection rp = new ReportParameterCollection();
            rp.Add(new ReportParameter("NomeFantasia", NomeFantasia));
            rp.Add(new ReportParameter("logradouro", Endereco));
            rp.Add(new ReportParameter("numero", Numero));
            rp.Add(new ReportParameter("bairro", Bairro));
            rp.Add(new ReportParameter("cidade", Cidade));
            rp.Add(new ReportParameter("estado", Estado));
            rp.Add(new ReportParameter("CNPJ", CNPJ));
            rp.Add(new ReportParameter("ValorPago", ValorPago.ToString()));            
            rp.Add(new ReportParameter("troco", troco.ToString()));
            rvCupom.LocalReport.SetParameters(rp);
            rvCupom.RefreshReport();
            this.CodVenda = CodVenda;
        }

        int CodVenda;
        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        int X = 0, Y = 0;
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void FrmCupom_Load(object sender, EventArgs e)
        {
           this.TableCupomTableAdapter.Fill(this.DbControleVendaDataSet.TableCupom, CodVenda);

            this.rvCupom.RefreshReport();
            this.rvCupom.RefreshReport();
            this.rvCupom.RefreshReport();
            this.rvCupom.RefreshReport();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
