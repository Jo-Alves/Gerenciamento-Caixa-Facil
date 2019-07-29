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
    public partial class FrmBuscarContasNaoContabilizadas : Form
    {
        public FrmBuscarContasNaoContabilizadas()
        {
            InitializeComponent();
        }

        public int codigo { get; set; }
        public string nome { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string valorConta { get; set; }
        public string DataConta { get; set; }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        int X = 0, Y = 0;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.DarkTurquoise;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.DarkTurquoise;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select * from ContasNaoContabilizadas where Nome_Cliente like '%" + txtNome.Text.Trim() + "%' and Valor_Conta > 0";
                try
                {
                    SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                    conexao.Open();
                    DataTable Tabela = new DataTable();
                    comando.Fill(Tabela);
                    dgvContas.DataSource = Tabela;
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
            else
            {
                CarregarGrid();
            }
        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow row = dgvContas.Rows[ContLinhas];
                codigo = int.Parse(row.Cells["ColId"].Value.ToString());
                nome = row.Cells["ColNome"].Value.ToString();
                bairro = row.Cells["ColBairro"].Value.ToString();
                endereco = row.Cells["ColEndereco"].Value.ToString();
                numero = row.Cells["ColNumero"].Value.ToString();
                valorConta = row.Cells["ColValorConta"].Value.ToString();
                DataConta = row.Cells["ColDataConta"].Value.ToString();
                this.Close();
            }
        }

        private void dgvContas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv.ClearSelection();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from ContasNaoContabilizadas where Valor_Conta > 0";
            try
            {                
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgvContas.DataSource = Tabela;
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
    }
}
