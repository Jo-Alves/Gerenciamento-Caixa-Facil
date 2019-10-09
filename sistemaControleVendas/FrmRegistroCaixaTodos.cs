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
    public partial class FrmRegistroCaixaTodos : Form
    {
        public FrmRegistroCaixaTodos()
        {
            InitializeComponent();
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;
        private void FrmRegistroCaixaTodos_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Usuario from Usuario where situacao <> 'BLOQUEADO' order by usuario asc";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            cb_Operador.DisplayMember = "Usuario";
            cb_Operador.DataSource = Tabela;
        }

        private void RegistroCaixa(string Data, string Usuario)
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select * from FluxoCaixa inner join Usuario on Usuario.Id_Usuario=FluxoCaixa.Id_Usuario where situacao = 'ATIVO' and Usuario.Usuario = @Usuario and FluxoCaixa.DataEntrada = @Data and FluxoCaixa.DataSaida<>''";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Usuario", Usuario);
            comando.SelectCommand.Parameters.AddWithValue("@Data", Data);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa(Data, Usuario, "");
                fechamentoCaixa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado. Tente outra opção!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            lbl_Fechar.BackColor = Color.Transparent;
        }

        int X = 0, Y = 0;
        private void panelTela_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panelTela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            RegistroCaixa(dt_Data.Text, cb_Operador.Text);
        }
      
    }
}
