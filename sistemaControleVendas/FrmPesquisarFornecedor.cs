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
    public partial class FrmPesquisarFornecedor : Form
    {
        public FrmPesquisarFornecedor()
        {
            InitializeComponent();
        }
        public string Codigo { get; set; }
        public string Fornecedor { get; set; }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");
        private void FrmPesquisarFornecedor_Load(object sender, EventArgs e)
        {

            CarregarGrid();
        }

        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection(stringConn);

            string _sql = "SELECT * FROM Fornecedor";

            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgv_Busca.DataSource = Tabela;
                }
            }
            catch { }

            finally
            {
                conexao.Close();
            }

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

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.DarkOrange;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nome.Text != string.Empty)
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Select * FROM Fornecedor WHERE  Nome like   '" + txt_Nome.Text.Trim() + "%'";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgv_Busca.DataSource = Tabela;
                }
                else
                {
                    MessageBox.Show("Dados não encontrado no banco de dados!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                CarregarGrid();
            }
        }

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Nome_TextChanged(sender, e);
            }
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow LINHA = dgv_Busca.Rows[e.RowIndex];
                Codigo = LINHA.Cells[0].Value.ToString();
                Fornecedor = LINHA.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void dgv_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_Busca.ClearSelection();
        }
    }
}
