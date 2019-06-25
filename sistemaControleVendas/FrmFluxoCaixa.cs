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
    public partial class FrmFluxoCaixa : Form
    {
        public FrmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void FrmFluxoCaixaDiario_Load(object sender, EventArgs e)
        {
            PreencherCombobox();
        }

        private void PreencherCombobox()
        {
            string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
            string _Sql;
            SqlConnection conexão = new SqlConnection(stringConn);
            _Sql = "Select Nome from Usuario where Situacao <> 'BLOQUEADO' order by Nome ASC";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexão);
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            cb_SelecaoFuncionario.DisplayMember = "Nome";
            cb_SelecaoFuncionario.DataSource = Tabela;
        }
        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
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

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string Todos = "", Funcionario;
            Funcionario = cb_SelecaoFuncionario.Text;
            if (cbBuscarCompleto.Checked)
            {
                Todos = "Todos";
                Funcionario = "";
            }
            else
            {
                Todos = "";
                Funcionario = cb_SelecaoFuncionario.Text;
            }

            FrmRegistroCaixa registroCaixa = new FrmRegistroCaixa(dTP_Inicial.Text, dTP_Final.Text, Funcionario, Todos);
            registroCaixa.ShowDialog();
        }

    }
}
