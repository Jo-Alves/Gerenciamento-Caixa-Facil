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
    public partial class FrmContasPagar : Form
    {
        public FrmContasPagar()
        {
            InitializeComponent();
        }

        private void txt_ValorDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorDocumento.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Desconto.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_ValorDocumentoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorDocumentoQuitar.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_DescontoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_DescontoQuitar.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_Multa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Multa.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_ValorPago.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisarFornecedor pesquisarFornecedor = new FrmPesquisarFornecedor();
            pesquisarFornecedor.ShowDialog();
            if (pesquisarFornecedor.Fornecedor != null)
            {
                txt_Beneficiario.Text = pesquisarFornecedor.Fornecedor;
            }
        }

        private void txt_NumeroDocumentoQuitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txt_NumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }
        ErrorProvider errorProvider = new ErrorProvider();
        ClassContasPagar ContasPagar = new ClassContasPagar();
        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (txt_Beneficiario.Text == string.Empty)
            {                
                errorProvider.Clear();
                errorProvider.SetError(txt_Beneficiario, "Campo obrigatório!");
                txt_Beneficiario.Focus();
                return;
            }           
            else if (txt_Referente.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Referente, "Campo obrigatório!");
                txt_Referente.Focus();
                return;
            }
            else if (txt_NumeroDocumento.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_NumeroDocumento, "Campo obrigatório!");
                txt_NumeroDocumento.Focus();
                return;
            }
            else if (!mask_Vencimento.MaskCompleted)
            {
                errorProvider.Clear();
                errorProvider.SetError(mask_Vencimento, "Campo obrigatório!");
                mask_Vencimento.Focus();
                return;
            }
            else if (txt_ValorDocumento.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ValorDocumento, "Campo obrigatório!");
                txt_ValorDocumento.Focus();
                return;
            }
            else if (txt_Desconto.Text == string.Empty)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Desconto, "Campo obrigatório!");
                txt_Desconto.Focus();
                return;
            }
            else
            {
                string status = "Não Pago";
                try
                {
                    ContasPagar.beneficiario = txt_Beneficiario.Text.Trim();
                    ContasPagar.Referente = txt_Referente.Text.Trim();
                    ContasPagar.numeroDocumento = int.Parse(txt_NumeroDocumento.Text.Trim());
                    ContasPagar.vencimento = mask_Vencimento.Text;
                    ContasPagar.valorDocumento = double.Parse(txt_ValorDocumento.Text.Trim());
                    ContasPagar.desconto = double.Parse(txt_Desconto.Text.Trim());
                    ContasPagar.status = status;
                    ContasPagar.Cadastrar();
                    MessageBox.Show("Valores gravados no banco de dados com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Limpar_Click(sender, e);
                    CarregarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txt_Beneficiario.Clear();
            txt_Referente.Clear();
            txt_NumeroDocumento.Clear();
            mask_Vencimento.Clear();
            txt_ValorDocumento.Clear();
            txt_Desconto.Clear();
        }
        private void mask_Vencimento_Leave(object sender, EventArgs e)
        {
            if (mask_Vencimento.MaskCompleted)
            {
                DateTime resultado = DateTime.MinValue;
                if (!DateTime.TryParse(this.mask_Vencimento.Text.Trim(), out resultado))
                {
                    MessageBox.Show("Data Inválida!", "Informação do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mask_Vencimento.Clear();
                    mask_Vencimento.Focus();
                }
            }
        }
        int X = 0, Y = 0;

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void panelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }
        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Blue;
            btn_Minimizar.ForeColor = Color.White;
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Gold;
            btn_Minimizar.ForeColor = Color.Black;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Red;
            btn_Fechar.ForeColor = Color.White;
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Gold;
            btn_Fechar.ForeColor = Color.Black;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Referente_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_Vencimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumento_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Desconto_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_Beneficiario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_Referente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_NumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void mask_Vencimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_ValorDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void txt_Desconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Gravar_Click(sender, e);
            }
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        string codigo = "";
        private void btn_PesquisarQuitar_Click(object sender, EventArgs e)
        {
            FrmPesquisarBoletos pesquisarBoletos = new FrmPesquisarBoletos();
            pesquisarBoletos.ShowDialog();
            if (pesquisarBoletos.Codigo != null)
            {
                txt_Multa.Text = "0,00";
                codigo = pesquisarBoletos.Codigo;
                ContasPagar.id = int.Parse(pesquisarBoletos.Codigo);
                if (ContasPagar.Consultar() == true)
                {
                    ContasPagar.Consultar();
                    txt_BeneficiarioQuitar.Text = ContasPagar.beneficiario;
                    txt_ReferenteQuitar.Text = ContasPagar.Referente;
                    txt_NumeroDocumentoQuitar.Text = ContasPagar.numeroDocumento.ToString();
                    mask_VencimentoQuitar.Text = ContasPagar.vencimento;
                    txt_DescontoQuitar.Text = ContasPagar.desconto.ToString();
                    txt_ValorDocumentoQuitar.Text = ContasPagar.valorDocumento.ToString();
                    string Vencimento = mask_VencimentoQuitar.Text;
                    DateTime DataVencimento = Convert.ToDateTime(Vencimento);
                    string dataatual = DateTime.Now.ToShortDateString();
                    DateTime DataAtual = Convert.ToDateTime(dataatual);
                    if (DataVencimento < DataAtual)
                    {
                        txt_DescontoQuitar.Text = "0";
                    }
                    if ((txt_ValorPago.Text != "") && (txt_DescontoQuitar.Text != ""))
                    {
                        double desconto = double.Parse(txt_DescontoQuitar.Text);
                        double VP = double.Parse(txt_ValorPago.Text.Trim());
                        if (desconto > 0)
                        {
                            txt_ValorPago.Text = (VP - desconto).ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Não encontramos dados do boleto deste fornecedor!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            string Status = "Pago";
            try
            {
                if (txt_BeneficiarioQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_BeneficiarioQuitar, "Campo obrigatório");
                    txt_BeneficiarioQuitar.Focus();
                    return;
                }
                else if (txt_ReferenteQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ReferenteQuitar, "Campo obrigatório");
                    txt_ReferenteQuitar.Focus();
                    return;
                }
                else if (txt_NumeroDocumentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_NumeroDocumentoQuitar, "Campo obrigatório");
                    txt_NumeroDocumentoQuitar.Focus();
                    return;
                }
                else if (mask_VencimentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(mask_VencimentoQuitar, "Campo obrigatório");
                    mask_VencimentoQuitar.Focus();
                    return;
                }
                else if (txt_ValorDocumentoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ValorDocumentoQuitar, "Campo obrigatório");
                    txt_ValorDocumentoQuitar.Focus();
                    return;
                }
                else if (txt_DescontoQuitar.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_DescontoQuitar, "Campo obrigatório");
                    txt_DescontoQuitar.Focus();
                    return;
                }
                else if (txt_Multa.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_Multa, "Campo obrigatório");
                    txt_Multa.Focus();
                    return;
                }
                else if (txt_ValorPago.Text == string.Empty)
                {
                    errorProvider.Clear();
                    errorProvider.SetError(txt_ValorPago, "Campo obrigatório");
                    txt_ValorPago.Focus();
                    return;
                }
                else
                {
                    ContasPagar.id = int.Parse(codigo);
                    ContasPagar.multa = double.Parse(txt_Multa.Text.Trim());
                    ContasPagar.valorPago = double.Parse(txt_ValorPago.Text.Trim());
                    string DataPagamento = DateTime.Now.ToShortDateString();
                    ContasPagar.dataPagamento = DataPagamento;
                    ContasPagar.status = Status;
                    ContasPagar.QuitarPagamento();
                    MessageBox.Show("Boleto quitado com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_LimparQuitar_Click(sender, e);
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LimparQuitar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            txt_ValorDocumentoQuitar.Clear();
            txt_BeneficiarioQuitar.Clear();
            txt_DescontoQuitar.Clear();
            txt_NumeroDocumentoQuitar.Clear();
            txt_ReferenteQuitar.Clear();
            txt_ValorDocumentoQuitar.Clear();
            txt_ValorPago.Clear();
            txt_Multa.Clear();
            mask_VencimentoQuitar.Clear();
        }

        private void txt_Beneficiario_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumentoQuitar_TextChanged(object sender, EventArgs e)
        {
            txt_ValorPago.Text = txt_ValorDocumentoQuitar.Text;
        }

        private void txt_Multa_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if ((txt_Multa.Text != "") && (txt_ValorPago.Text != "") && (txt_ValorDocumentoQuitar.Text != ""))
            { double VD = double.Parse(txt_ValorDocumentoQuitar.Text), Multa = double.Parse(txt_Multa.Text);
                txt_ValorPago.Text = (VD + Multa).ToString();
            }
        }

        private void txt_ValorPago_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void mask_VencimentoQuitar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_BeneficiarioQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ReferenteQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_NumeroDocumentoQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_DescontoQuitar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txt_ValorDocumento_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorDocumento.Text != "")
                {
                    txt_ValorDocumento.Text = decimal.Parse(txt_ValorDocumento.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorDocumento.Clear();
            }
        }

        private void txt_Desconto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Desconto.Text != "")
                {
                    txt_Desconto.Text = decimal.Parse(txt_Desconto.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Desconto.Clear();
            }
}

        private void txt_Multa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Multa.Text != "")
                {
                    txt_Multa.Text = decimal.Parse(txt_Multa.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Desconto.Clear();
            }
        }

        private void txt_ValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_ValorPago.Text != "")
                {
                    txt_ValorPago.Text = decimal.Parse(txt_ValorPago.Text.Trim()).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorPago.Clear();
                txt_ValorPago.Clear();
            }
        }

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3"), _sql;

        private void CarregarGrid()
        {            
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Id, Beneficiario, NumeroDocumento, Vencimento, ValorDocumento, Referencia, Desconto FROM ContasPagar WHERE (Status = 'Não Pago')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dataGridView_Consulta.DataSource = Tabela;
        }
    }
}
