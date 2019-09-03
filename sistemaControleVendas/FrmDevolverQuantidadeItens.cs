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
    public partial class FrmDevolverQuantidadeItens : Form
    {
        public int qtdItens { get; set; }

        public FrmDevolverQuantidadeItens(int qtdItens)
        {
            InitializeComponent();
            ndQtd.Maximum = qtdItens;
            ndQtd.Minimum = 1;
        }

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            qtdItens = int.Parse(ndQtd.Value.ToString());
            this.Close();
        }
    }
}
