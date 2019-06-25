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
    public partial class FrmPesquisarProdutos : Form
    {
        public FrmPesquisarProdutos()
        {
            InitializeComponent();
        }

        private void FrmPesquisarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbControleVendaDataSet.TabelaProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaProdutoTableAdapter.Fill(this.dbControleVendaDataSet.TabelaProduto);
        }
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql;
        
        public string ID { get; set; }
        public string CodBarra { get; set; }
        public string Fornecedor { get; set; }
        public string Descricao { get; set; }
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

        private void txt_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Nome_TextChanged(sender, e);
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Produto.Id_Produto, Produto.CodigoBarra, Produto.Descricao as DescricaoNome, Produto.Marca, Produto.DataValidade, Produto.ValorCusto, Produto.ValorVenda, Produto.EstoqueAtual, Produto.EstoqueMinimo, Produto.Unidade, Categoria.Descricao, Fornecedor.Nome, Produto.Lucro FROM Categoria INNER JOIN Produto ON Categoria.Id_Categoria = Produto.Id_Categoria INNER JOIN Fornecedor ON Produto.Id_Fornecedor = Fornecedor.Id_Fornecedor WHERE Produto.Descricao like '%" + txt_Nome.Text.Trim() + "%'";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgv_Busca.DataSource = Tabela;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgv_Busca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont >= 0)
            {
                DataGridViewRow LINHA = dgv_Busca.Rows[e.RowIndex];
                ID = LINHA.Cells[0].Value.ToString();
                CodBarra = LINHA.Cells[1].Value.ToString();
                Fornecedor = LINHA.Cells[12].Value.ToString();
                Descricao = LINHA.Cells[3].Value.ToString();
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
