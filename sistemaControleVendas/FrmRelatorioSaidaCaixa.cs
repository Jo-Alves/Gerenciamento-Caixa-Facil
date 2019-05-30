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
    public partial class FrmRelatorioSaidaCaixa : Form
    {
        public FrmRelatorioSaidaCaixa()
        {
            InitializeComponent();
        }

        private void FrmRelatorioSaidaCaixa_Load(object sender, EventArgs e)
        {
            CarregarValoresSaidaCaixa();
            ValorToTalSaidaCaixa();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"), _Sql;
        private void CarregarValoresSaidaCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select FluxoCaixa.Id_Fluxo, FluxoCaixa.DataEntrada, Usuario.Nome, SaidaCaixa.ValorSaida, SaidaCaixa.MotivoRetirada from SaidaCaixa inner join FluxoCaixa on FluxoCaixa.Id_Fluxo = SaidaCaixa.Id_Fluxo inner join Usuario on Usuario.Id_Usuario = FluxoCaixa.Id_Usuario";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_SaidaCaixa.DataSource = Tabela;
        }

        private void ValorToTalSaidaCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select  Sum(SaidaCaixa.ValorSaida) as ValorTotalSaida from SaidaCaixa";
            SqlCommand comando = new SqlCommand(_Sql, conexao);
            comando.CommandText = _Sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    lbl_ValorTotalSaida.Text = "R$ 0,00";
                }
                else
                {
                    lbl_ValorTotalSaida.Text = "R$ " + comando.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
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
