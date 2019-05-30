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
    public partial class FrmPesquisarAgendamento : Form
    {
        public FrmPesquisarAgendamento(string Data)
        {
            InitializeComponent();
            DataAgenda = Data;
            if (Data == "")
            {
                CarregarDataGrid();
            }
            else if (Data == "Apartir de hoje")
            {
                BuscarAgendamentoDataNow();
            }
            else
            {
                BuscarAgendamentoData();
            }
        }

        string DataAgenda;
        private void BuscarAgendamentoData()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select * from Agenda where Data = @DataAgenda";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataAgenda", DataAgenda);
            comando.SelectCommand.CommandText = _Sql;
            DataTable tabela = new DataTable();
            comando.Fill(tabela);
            dgv_Busca.DataSource = tabela;
        }

        private void BuscarAgendamentoDataNow()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Id_Agenda, NomeCliente, convert(Date, Data, 103) as Data, Horario, Servico, Telefone, Email from Agenda where convert(date, Data, 103) >= Convert(Date, @DataAgenda, 103)";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataAgenda", DateTime.Now.ToShortDateString());
            comando.SelectCommand.CommandText = _Sql;
            DataTable tabela = new DataTable();
            comando.Fill(tabela);
            dgv_Busca.DataSource = tabela;
        }
        private void CarregarDataGrid()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select * from Agenda";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            DataTable tabela = new DataTable();
            comando.Fill(tabela);
            dgv_Busca.DataSource = tabela;
        }

        public int Codigo { get; set; }
        public string NomeCliente { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }
        public string Servico { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"), _Sql;

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
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select * from Agenda where NomeCliente like '" + txt_Nome.Text + "%'";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            DataTable tabela = new DataTable();
            comando.Fill(tabela);
            dgv_Busca.DataSource = tabela;
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow linha = dgv_Busca.Rows[e.RowIndex];
                Codigo = int.Parse(linha.Cells[0].Value.ToString());
                NomeCliente = linha.Cells[1].Value.ToString();
                Data = linha.Cells[2].Value.ToString();
                Horario = linha.Cells[3].Value.ToString();
                Servico = linha.Cells[4].Value.ToString();
                Telefone = linha.Cells[5].Value.ToString();
                Email = linha.Cells[6].Value.ToString();
                if (DataAgenda == "")
                {
                    this.Close();
                }
            }
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmPesquisarAgendamento_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
