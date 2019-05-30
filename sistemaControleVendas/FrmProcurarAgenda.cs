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
    public partial class FrmProcurarAgenda : Form
    {
        public FrmProcurarAgenda()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            BuscarAgendamentoData(dtp_Data.Text);
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"), _Sql;

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Transparent;
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;
        private void panelCorpo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelCorpo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BuscarAgendamentoData(string DataAgenda)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select * from Agenda where Data = @DataAgenda";
            try
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(_Sql, conexao);
                comando.Parameters.AddWithValue("@DataAgenda", DataAgenda);
                comando.CommandText = _Sql;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    FrmPesquisarAgendamento PesquisarAgendamento = new FrmPesquisarAgendamento(dtp_Data.Text);
                    PesquisarAgendamento.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado. Tente outra opção!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
