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
    public partial class FrmPesquisarBoletos : Form
    {
        public FrmPesquisarBoletos()
        {
            InitializeComponent();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void FrmPesquisarBoletos_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Id, Beneficiario, NumeroDocumento, Vencimento, ValorDocumento, Referencia, Desconto FROM ContasPagar WHERE (Status = 'Não Pago')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Busca.DataSource = Tabela;
        }

        public string Codigo { get; set; }
        public string Beneficiario { get; set; }

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

        private void txt_Beneficiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Beneficiario_TextChanged(sender, e);
            }
        }

        private void txt_Beneficiario_TextChanged(object sender, EventArgs e)
        {
            string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "Select * from ContasPagar where Beneficiario like '" + txt_Beneficiario.Text.Trim() + "%'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_Busca.DataSource = Tabela;
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

        private void dataGridView_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if(Cont >= 0)
            {
                DataGridViewRow linhas = dgv_Busca.Rows[e.RowIndex];
                Codigo = linhas.Cells[0].Value.ToString();
                Beneficiario = linhas.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void dataGridView_Busca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            this.dgv_Busca.ClearSelection();
        }
    }
}
