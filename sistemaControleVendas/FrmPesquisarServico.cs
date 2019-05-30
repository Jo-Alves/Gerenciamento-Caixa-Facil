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
    public partial class FrmPesquisarServico : Form
    {
        public FrmPesquisarServico()
        {
            InitializeComponent();
        }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string PrecoServico { get; set; }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        string _sql;
        private void FrmPesquisarServico_Load(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Produto.Id_Produto, Produto.Descricao, Produto.ValorVenda from Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Categoria.Descricao = 'Serviço'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Busca.DataSource = Tabela;
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Produto.Id_Produto, Produto.Descricao, Produto.ValorVenda from Produto inner join Categoria on Categoria.Id_Categoria = Produto.Id_Categoria where Produto.Descricao like '" + txt_Nome.Text.Trim() + "%' and Categoria.Descricao = 'Serviço'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Busca.DataSource = Tabela;
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
            btn_Fechar.BackColor = Color.DarkOrange;
        }

        int X = 0, Y = 0;
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelCabecalho_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow linha = dgv_Busca.Rows[e.RowIndex];
                Codigo = linha.Cells["ColumnCodigo"].Value.ToString();
                Descricao = linha.Cells["ColumnDescricao"].Value.ToString();
                PrecoServico = linha.Cells["ColumnPreco"].Value.ToString();
                this.Close();
            }
        }

        private void dgv_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Busca.ClearSelection();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
