using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaControleVendas.Properties;

namespace sistemaControleVendas
{
    public partial class FrmSetting : Form
    {
        string Disco = Settings.Default["Disco"].ToString(), TempoPrazo = Settings.Default["TempoPrazo"].ToString();

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SalvarConfiguracao() == true)
            {
                this.Close();
            }
        }

        private void btbAplicar_Click(object sender, EventArgs e)
        {
            SalvarConfiguracao();
            btnAplicar.Enabled = false;
        }

        private void HabilitarBotaoAplicar()
        {
            if (cbDisco.Text == Disco && cbTempoPagamentoPrazo.Text == TempoPrazo)
            {
                btnAplicar.Enabled = false;
            }
            else
            {
                btnAplicar.Enabled = true;
            }
        }

        private void cbDisco_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotaoAplicar();
        }

        private void cbTempoPagamentoPrazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBotaoAplicar();
        }

        private bool SalvarConfiguracao()
        {
            if (cbDisco.SelectedIndex >= 0 && cbTempoPagamentoPrazo.SelectedIndex >= 0)
            {
                Settings.Default["Disco"] = cbDisco.Text;
                Settings.Default["TempoPrazo"] = cbTempoPagamentoPrazo.Text;
                Settings.Default.Save();
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            cbDisco.Text = Disco;
            cbTempoPagamentoPrazo.Text = TempoPrazo;
        }
    }
}
