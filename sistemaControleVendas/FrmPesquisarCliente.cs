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
    public partial class FrmPesquisarCliente : Form
    {
        public FrmPesquisarCliente()
        {
            InitializeComponent();
        }
        
        string codigo = null;        
      
        private void CarregarGrid()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql,conexao);
            adapter.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                dgv_Busca.DataSource = Tabela;
                for (int i = 0; i < dgv_Busca.Rows.Count; i++)
                {
                    dgv_Busca.Rows[i].Cells["ColumnCPF"].Value = ClassSeguranca.Descriptografar (dgv_Busca.Rows[i].Cells["ColumnCPF"].Value.ToString());
                    dgv_Busca.Rows[i].Cells["ColumnRG"].Value = ClassSeguranca.Descriptografar(dgv_Busca.Rows[i].Cells["ColumnRG"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"),  _sql;

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Telefone { get; set; }

        int X = 0;
        int Y = 0;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void FrmPesquisarCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.DarkOrange;
        }

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Nome_TextChanged(sender, e);
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nome.Text != string.Empty)
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                string _sql = "Select * FROM Cliente WHERE  Nome like   '%" + txt_Nome.Text.Trim() + "%'";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgv_Busca.DataSource = Tabela;
                    for (int i = 0; i < dgv_Busca.Rows.Count; i++)
                    {
                        string CPF = dgv_Busca.Rows[i].Cells["ColumnCPF"].Value.ToString();
                        string RG = dgv_Busca.Rows[i].Cells["ColumnRG"].Value.ToString();

                        dgv_Busca.Rows[i].Cells["ColumnCPF"].Value = ClassSeguranca.Descriptografar(CPF);
                        dgv_Busca.Rows[i].Cells["ColumnRG"].Value = ClassSeguranca.Descriptografar(RG);
                    }
                }
                else
                    MessageBox.Show("Dados não encontrado no banco de dados!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CarregarGrid();
            }
        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow LINHA = dgv_Busca.Rows[e.RowIndex];
                Codigo = LINHA.Cells[0].Value.ToString();
                Nome = LINHA.Cells[1].Value.ToString();
                Bairro = LINHA.Cells[6].Value.ToString();
                Endereco = LINHA.Cells[7].Value.ToString();
                Numero = LINHA.Cells[8].Value.ToString();
                Telefone = LINHA.Cells[11].Value.ToString();
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
