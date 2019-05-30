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
    public partial class FrmAdicionarQuantidade : Form
    {
        public FrmAdicionarQuantidade(string quantidade)
        {
            InitializeComponent();       
            lbl_Quantidade.Text = "Estoque atual: " + quantidade;
        }
        public int Quantidade { get; set; }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Quantidade = int.Parse(num_Quantidade.Value.ToString());
            this.Close();
        }

        private void num_Quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Adicionar_Click(sender, e);
            }
        }

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
            lbl_Fechar.ForeColor = Color.White;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = SystemColors.Control;
            lbl_Fechar.ForeColor = Color.Black;
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
