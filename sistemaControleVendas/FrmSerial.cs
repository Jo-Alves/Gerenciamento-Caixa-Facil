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
    public partial class FrmSerial : Form
    {
        public FrmSerial()
        {
            InitializeComponent();
        }

        public string serialAtivo { get; set; }

        private void lblFechar_MouseEnter(object sender, EventArgs e)
        {
            lblFechar.BackColor = Color.Red;
        }

        private void lblFechar_MouseLeave(object sender, EventArgs e)
        {
            lblFechar.BackColor = Color.Transparent;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string serial = "MEWLA-RBTWR-FOUNR-JQPZV";
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHJjGrOXTsH7YfMGR7bciVESTNxiggiQBDbnJJ0mwpG2P2NoQZI/N9NA=="));
            string _sql = "insert into autentico values ('Ativo')";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
            serialAtivo = "ok";
            this.Close();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial.Text == serial)
            {
                btnConfirmar.Enabled = true; 
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }
    }
}
