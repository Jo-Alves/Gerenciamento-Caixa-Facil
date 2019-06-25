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
    public partial class FrmValidadeProduto : Form
    {
        public FrmValidadeProduto(string Opcao)
        {
            InitializeComponent();
            if (Opcao == "TODAS AS DATAS")
            {
                lbl_Titulo.Text = "Registro da validade dos produtos cadastrados no sistema";
                ValidadeProdutos();
            }
            else if (Opcao == "HOJE")
            {
                lbl_Titulo.Text = "Registro da validade dos produtos do dia de hoje";
                this.Opcao = "convert(Date, DataValidade, 103) = ";
                VeirificarValidadeProdutosOpcao();
            }
            else if (Opcao =="A VENCER")
            {
                lbl_Titulo.Text = "Registro da validade dos produtos a vencer";
                this.Opcao = "convert(Date, DataValidade, 103) > ";
                VeirificarValidadeProdutosOpcao();
            }
            else
            {                
                lbl_Titulo.Text = "Registro da validade dos produtos vencidos";
                this.Opcao = "convert(Date, DataValidade, 103) < ";
                VeirificarValidadeProdutosOpcao();
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _Sql, Opcao;
        string DataValidade;
        private void ValidadeProdutos()
        {
            DataValidade=DateTime.Now.ToShortDateString();
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Id_Produto, Descricao, Convert(Date, DataValidade, 103) as DataValidade From Produto where dataValidade <> '00/00/0000' and unidade <> 'Serviço' order by Datavalidade";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.CommandText = _Sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_BuscaValidadeProduto.DataSource = Tabela;
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

        private void VeirificarValidadeProdutosOpcao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _Sql = "Select Id_Produto, Descricao, Convert(date, DataValidade, 103) as DataValidade From Produto where " + Opcao + " convert(Date, @DataValidade, 103) and dataValidade <> '00/00/0000' and unidade <> 'Serviço' order by DataValidade";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@DataValidade", DateTime.Now.ToShortDateString());
            comando.SelectCommand.CommandText = _Sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_BuscaValidadeProduto.DataSource = Tabela;
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

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
            btn_Fechar.ForeColor = Color.Black;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Aquamarine;
            btn_Fechar.ForeColor = Color.White;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int X = 0, Y = 0;

        private void dgv_BuscaValidadeProduto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgv_BuscaValidadeProduto.ClearSelection();
        }

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
    }
}
