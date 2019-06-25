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
using Microsoft.Reporting.WinForms;

namespace sistemaControleVendas
{
    public partial class FrmRelatorioAnaliseVenda : Form
    {
        public FrmRelatorioAnaliseVenda(string DataInicial, string DataFinal, string Analise)
        {
            InitializeComponent();
            if (DataInicial == "" && DataFinal == "")
            {
                DataVenda();
                DataInicial = this.DataInicial;
                DataFinal = this.DataFinal;
            }

            empresa.Consultar();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("NomeEmpresa", empresa.nomeFantasia));
            reportParameters.Add(new ReportParameter("EnderecoEmpresa", empresa.endereco));
            reportParameters.Add(new ReportParameter("NumeroEndereco", empresa.numero.ToString()));
            reportParameters.Add(new ReportParameter("CidadeEmpresa", empresa.cidade));
            reportParameters.Add(new ReportParameter("FoneEmpresa", empresa.telefone));
            reportParameters.Add(new ReportParameter("CNPJ", empresa.CNPJ));
            reportParameters.Add(new ReportParameter("DataConsulta", DateTime.Now.ToLongDateString()));
            reportParameters.Add(new ReportParameter("HoraConsulta", DateTime.Now.ToLongTimeString()));


            if (Analise == "Venda")
            {
                rv_AnaliseProduto.Visible = true;
                rv_AnaliseProduto.LocalReport.SetParameters(reportParameters);
                rv_AnaliseProduto.RefreshReport();
                this.AnaliseProdutoTableAdapter.Fill(this.DataSetRelatorio.AnaliseProduto, DataInicial, DataFinal);
                this.rv_AnaliseProduto.RefreshReport();
            }
            else
            {
                rv_analiseServicosPrestados.Visible = true;
                rv_analiseServicosPrestados.LocalReport.SetParameters(reportParameters);
                rv_analiseServicosPrestados.RefreshReport();
                this.AnaliseServicoPrestadosTableAdapter.Fill(this.DataSetRelatorio.AnaliseServicoPrestados, DataInicial, DataFinal);
                this.rv_AnaliseProduto.RefreshReport();
            }
        }

        ClassEmpresa empresa = new ClassEmpresa();
        string DataInicial, DataFinal;
        private void DataVenda()
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"));
            SqlDataAdapter comando = new SqlDataAdapter("", conexao);
            comando.SelectCommand.CommandText = "select Min(Convert(Date, Venda.DataVenda, 103)) as DataInicial, MAX(Convert(Date, Venda.DataVenda, 103)) as DataFinal From Venda";
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                DataInicial = Tabela.Rows[0]["DataInicial"].ToString();
                DataFinal = Tabela.Rows[0]["DataFinal"].ToString();
            }
        }

       
        private void FrmRelatorioAnaliseVenda_Load(object sender, EventArgs e)
        {            
            this.rv_analiseServicosPrestados.RefreshReport();
        }

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
            this.Close();
        }

        int X = 0, Y = 0;
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
