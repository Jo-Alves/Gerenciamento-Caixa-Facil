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
using sistemaControleVendas.Properties;

namespace sistemaControleVendas
{
    public partial class FrmAutenticacao : Form
    {
        public FrmAutenticacao()
        {
            InitializeComponent();
        }
        int Id_Usuario;
        string NomeUsuario;
        double prazoFechamento;
        private void FrmAutenticacao_Load(object sender, EventArgs e)
        {
            txt_Senha.Focus();
            UsuarioSistema();
            CodigoCaixa();
        }

        private void UsuarioSistema()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                _sql = "Select Usuario From Usuario where Situacao <> 'BLOQUEADO'";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                cb_Usuario.DisplayMember = "Usuario";
                cb_Usuario.DataSource = Tabela;
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

        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRarR0A3RhJbiLUNDsVR7AWUv3GLXCm6nqT787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/keyP3k/xHE/swBoHi4WgOI3vX3aocmtwEi2KpDD1I0/s3");
        string _sql, DataEntrada, DataAtual;

        private void CodigoCaixa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Max(DataEntrada) from FluxoCaixa where DataSaida = '' and horaSaida = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                DataEntrada = comando.ExecuteScalar().ToString();
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ClassFluxoCaixa Caixa = new ClassFluxoCaixa();
        ClassAutenticacao autenticacao = new ClassAutenticacao();
        string Senha;
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            EntrarSistema();
        }
        string Funcao;
        private void EntrarSistema()
        {
            Senha = ClassSeguranca.Criptografar(txt_Senha.Text.Trim());
            autenticacao.usuario = cb_Usuario.Text;
            autenticacao.senha = Senha;
            if (autenticacao.Autenticar() == true)
            {
                if (string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
                {
                    FrmSetting setting = new FrmSetting();
                    setting.ShowDialog();
                    if (string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
                    {
                        Application.Exit();
                    }
                }
                if (!string.IsNullOrEmpty(Settings.Default["Disco"].ToString()))
                {
                    DataAtual = DateTime.Now.ToShortDateString();

                    Id_Usuario = autenticacao.id;
                    NomeUsuario = autenticacao.NomeUsuario;
                    Funcao = autenticacao.funcao;

                    this.Visible = false;
                    Caixa.SituacaoCaixa();
                    if (Caixa.dataEntrada != DataAtual)
                    {
                        if (MessageBox.Show("O caixa anterior está aberto.Feche o caixa para prosseguir.", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            this.Visible = false;
                            FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa("", "");
                            fechamentoCaixa.ShowDialog();
                            if (Caixa.SituacaoCaixa() == false)
                            {
                                FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa(Id_Usuario, NomeUsuario, Funcao);
                                aberturaCaixa.ShowDialog();
                            }
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        if (Caixa.SituacaoCaixa() == true)
                        {
                            string NomeUsuario = Caixa.nomeUsuario;
                            int CodigoUsuario = Caixa.id_Usuario;

                            if (CodigoUsuario == Id_Usuario)
                            {
                                if (MessageBox.Show("O Caixa está aberto! Deseja Continuar?", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    this.Visible = false;
                                    FrmPrincipal frmprincipal = new FrmPrincipal(Id_Usuario, NomeUsuario, Funcao);
                                    frmprincipal.ShowDialog();
                                }
                                else
                                {
                                    this.Visible = false;
                                    FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa("", "");
                                    fechamentoCaixa.ShowDialog();
                                    if (Caixa.SituacaoCaixa() == false)
                                    {
                                        FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa(Id_Usuario, NomeUsuario, Funcao);
                                        aberturaCaixa.ShowDialog();
                                    }
                                }
                            }
                            else if (CodigoUsuario != Id_Usuario && Funcao == "ADMINISTRADOR")
                            {
                                this.Visible = false;
                                FrmPrincipal frmprincipal = new FrmPrincipal(Id_Usuario, NomeUsuario, Funcao);
                                frmprincipal.ShowDialog();
                            }
                            else
                            {
                                if (MessageBox.Show("Feche o caixa para continuar.", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                                {
                                    this.Visible = false;
                                    FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa("", "");
                                    fechamentoCaixa.ShowDialog();
                                    if (Caixa.SituacaoCaixa() == false)
                                    {
                                        FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa(Id_Usuario, NomeUsuario, Funcao);
                                        aberturaCaixa.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa(Id_Usuario, NomeUsuario, Funcao);
                            aberturaCaixa.ShowDialog();
                        }
                    }
                }
            }
            else if (txt_Senha.Text == "")
            {
                MessageBox.Show("Digite a sua senha!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Senha.Focus();
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Senha.Clear();
                txt_Senha.Focus();
                InformarDicaSenha();
                linkRedefinicao.Visible = true;
            }
        }

        private double CalcularPeriodoDias()
        {
            DateTime PeriodoFechamento = Convert.ToDateTime(this.DataAtual);
            DateTime DataEntrada = Convert.ToDateTime(this.DataEntrada);
            TimeSpan timeSpan = PeriodoFechamento.Subtract(DataEntrada);
            return timeSpan.TotalDays;
        }

        private void InformarCaixaAberto()
        {
            MessageBox.Show("O Caixa anterior está aberto! Para prosseguir o caixa deverá ser fechado!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FrmFechamentoCaixa fechamentoCaixa = new FrmFechamentoCaixa("", "");
            fechamentoCaixa.ShowDialog();
            if (Caixa.SituacaoCaixa() == false)
            {
                FrmAberturaCaixa aberturaCaixa = new FrmAberturaCaixa(Id_Usuario, NomeUsuario, Funcao);
                aberturaCaixa.ShowDialog();
            }
        }

        string PerguntaSeguranca, RespostaSeguranca;
        private void InformarDicaSenha()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Usuario = @Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", cb_Usuario.Text.Trim());
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    lbl_DicaSenha.Text = "Dica de Senha: " + dr["DicaSenha"].ToString();
                    PerguntaSeguranca = dr["PerguntaSeguranca"].ToString();
                    RespostaSeguranca = dr["RespostaSeguranca"].ToString();
                }
                else
                {
                    Veriguacao = false;
                }
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

        string DicaSenha, AcaoFechar;
        bool Veriguacao;

        private void VerificarUsuario()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Usuario = @Usuario and RespostaSeguranca = @RespostaSeguranca";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", cb_Usuario.Text.Trim());
            comando.Parameters.AddWithValue("@RespostaSeguranca", rs);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    Veriguacao = true;
                }
                else
                {
                    Veriguacao = false;
                }
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
        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Senha.Clear();
            txt_Senha.Focus();
            lbl_DicaSenha.Text = "";
            linkRedefinicao.Visible = false;
        }

        int X = 0, Y = 0;

        string rs;
        private void linkRedefinicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Senha.Clear();
            txt_Senha.Focus();
            this.Visible = false;
            FrmInformarDicaSenha vnu = new FrmInformarDicaSenha(PerguntaSeguranca);
            vnu.ShowDialog();

            if (vnu.RespostaSeguranca != "")
            {
                rs = vnu.RespostaSeguranca;

                VerificarUsuario();
                if (Veriguacao == false)
                {

                    while (Veriguacao == false)
                    {
                        MessageBox.Show("A resposta de segurança não bate com a Resposta cadastrada no sistema!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        vnu.ShowDialog();
                        rs = vnu.RespostaSeguranca;
                        if (rs != "")
                        {
                            VerificarUsuario();

                            if (Veriguacao == true)
                            {
                                Veriguacao = true;
                            }
                        }
                        else
                        {
                            Veriguacao = true;
                            AcaoFechar = vnu.AcaoFechar;
                        }
                    }
                    if (AcaoFechar == "Fechar")
                    {
                        this.Visible = true;
                    }
                    else
                    {
                        FrmRedefinicaoSenha rs = new FrmRedefinicaoSenha(cb_Usuario.Text);

                        rs.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    FrmRedefinicaoSenha rs = new FrmRedefinicaoSenha(cb_Usuario.Text);
                    rs.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {

                this.Visible = true;
            }
        }

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

        private void lbl_Fechar_MouseEnter(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.Red;
        }

        private void lbl_Fechar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Fechar.BackColor = Color.MediumSlateBlue;
        }
    }
}
