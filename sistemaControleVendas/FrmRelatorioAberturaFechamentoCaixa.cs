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
    public partial class FrmRelatorioAberturaFechamentoCaixa : Form
    {
        public FrmRelatorioAberturaFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void FrmRelatorioAberturaFechamentoCaixa_Load(object sender, EventArgs e)
        {
            cb_Opcao.SelectedIndex = 0;
            CarregarGrid();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select FluxoCaixa.Id_Fluxo, FluxoCaixa.DataEntrada, FluxoCaixa.HoraEntrada, FluxoCaixa.ValorEntrada, FluxoCaixa.ValorCaixa, FluxoCaixa.DataSaida, FluxoCaixa.HoraSaida, Usuario.Nome From FluxoCaixa inner join Usuario on FluxoCaixa.Id_Usuario = Usuario.Id_Usuario where FluxoCaixa.DataSaida <> ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dataGridView1.DataSource = Tabela;
        }

        private void PesquisarDataEntrada()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select FluxoCaixa.Id_Fluxo, FluxoCaixa.DataEntrada, FluxoCaixa.HoraEntrada, FluxoCaixa.ValorEntrada, FluxoCaixa.ValorCaixa, FluxoCaixa.DataSaida, FluxoCaixa.HoraSaida, Usuario.Nome From FluxoCaixa inner join Usuario on FluxoCaixa.Id_Usuario = Usuario.Id_Usuario where FluxoCaixa.DataEntrada like '" + txt_Descricao.Text + "%' and FluxoCaixa.DataSaida <> ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dataGridView1.DataSource = Tabela;
        }

        private void PesquisarOperador()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select FluxoCaixa.Id_Fluxo, FluxoCaixa.DataEntrada, FluxoCaixa.HoraEntrada, FluxoCaixa.ValorEntrada, FluxoCaixa.ValorCaixa, FluxoCaixa.DataSaida, FluxoCaixa.HoraSaida, Usuario.Nome From FluxoCaixa inner join Usuario on FluxoCaixa.Id_Usuario = Usuario.Id_Usuario where Usuario.Nome like '" + txt_Descricao.Text + "%' and FluxoCaixa.DataSaida <> ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dataGridView1.DataSource = Tabela;
        }

        private void PesquisarNumeroCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select FluxoCaixa.Id_Fluxo, FluxoCaixa.DataEntrada, FluxoCaixa.HoraEntrada, FluxoCaixa.ValorEntrada, FluxoCaixa.ValorCaixa, FluxoCaixa.DataSaida, FluxoCaixa.HoraSaida, Usuario.Nome From FluxoCaixa inner join Usuario on FluxoCaixa.Id_Usuario = Usuario.Id_Usuario where FluxoCaixa.Id_Fluxo like '" + txt_Descricao.Text + "%' and FluxoCaixa.DataSaida <> ''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dataGridView1.DataSource = Tabela;
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

        private void txt_Descricao_TextChanged(object sender, EventArgs e)
        {
            if (cb_Opcao.SelectedIndex == 0)
            {
                PesquisarDataEntrada();
            }
            else if (cb_Opcao.SelectedIndex == 1)
            {
                PesquisarOperador();
            }
            else if (cb_Opcao.SelectedIndex == 2)
            {
                PesquisarNumeroCaixa();
            }
        }
    }
}
