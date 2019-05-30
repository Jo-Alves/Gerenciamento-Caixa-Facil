using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaControleVendas
{
    public partial class frmNovoCadastro : Form
    {
        public frmNovoCadastro()
        {
            InitializeComponent();
        }

        private void btn_CadastroCliente_Click(object sender, EventArgs e)
        {           
            FrmClientes clientes = new FrmClientes(NovoCadastro);
            clientes.ShowDialog();
            
        }
        string NovoCadastro = "Sim";
        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            NovoCadastro = null;
            FrmProduto produto = new FrmProduto(NovoCadastro);
            produto.ShowDialog();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Sair_Click(sender, e);
            }
            else if (e.KeyCode == Keys.C)
            {
                btn_CadastroCliente_Click(sender, e);
            }
            else if (e.KeyCode == Keys.P)
            {
                btnCadastroProduto_Click(sender, e);
            }
        }
    }
}
