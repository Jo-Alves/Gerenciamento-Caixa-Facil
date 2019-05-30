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
    public partial class FrmCarregamentoSistemaControleVenda : Form
    {
        public FrmCarregamentoSistemaControleVenda()
        {
            InitializeComponent();
        }

        private void timerCarregar_Tick(object sender, EventArgs e)
        {
            if (pB_Carregar.Value < 100)
            {
                pB_Carregar.Value += 2;
            }
            else
            {
                timerCarregar.Enabled = false;
                this.Visible = false;
                VerificarDataBase();
                if (Retorno == true)
                {
                    if (VerificarSerial() == false)
                    {
                        FrmSerial serial = new FrmSerial();
                        serial.ShowDialog();   
                        if(serial.serialAtivo != null)
                        {
                            VerificarSerial();
                            if (VerificarSerial() == true)
                            {
                                verificarSituacaoUsuarioClienteAutenticacao();
                            }                           
                        }
                        else
                        {
                            MessageBox.Show("Para prosseguir é necessário ativar o sistema! Entre contato com a LAS Technology", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        verificarSituacaoUsuarioClienteAutenticacao();
                    }
                }
                else
                {
                    MessageBox.Show("Não encontramos uma base de dados ativa! Verifique com a empresa LAS Technology para a realização do suporte!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void verificarSituacaoUsuarioClienteAutenticacao()
        {
            VerificarCadastroUsuario();
            if (Situacao == true)
            {
                VerificarCadastroEmpresa();
                if (Situacao == true)
                {
                    FrmAutenticacao autenticacao = new FrmAutenticacao();
                    autenticacao.ShowDialog();
                    this.Visible = false;
                }
                else
                {
                    FrmEmpresa empresa = new FrmEmpresa();
                    empresa.ShowDialog();
                    VerificarCadastroEmpresa();
                    if (Situacao == true)
                    {
                        FrmAutenticacao autenticacao = new FrmAutenticacao();
                        autenticacao.ShowDialog();
                        this.Visible = false;

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                FrmUsuario usuario = new FrmUsuario();
                usuario.ShowDialog();
                VerificarCadastroEmpresa();
                if (Situacao == true)
                {
                    VerificarCadastroEmpresa();
                    if (Situacao == true)
                    {
                        FrmAutenticacao autenticacao = new FrmAutenticacao();
                        autenticacao.ShowDialog();
                        this.Visible = false;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    FrmEmpresa empresa = new FrmEmpresa();
                    empresa.ShowDialog();
                    VerificarCadastroEmpresa();
                    if (Situacao == true)
                    {
                        FrmAutenticacao autenticacao = new FrmAutenticacao();
                        autenticacao.ShowDialog();
                        this.Visible = false;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        string  _sql;
        bool Retorno;
        private void VerificarDataBase()
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHJjGrOXTsH7YfMGR7bciVESTNxiggiQBDbnJJ0mwpG2P2NoQZI/N9NA=="));
            _sql = "Select * from Sys.Databases where name = 'dbControleVenda'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = true;
                }
                else
                {
                    Retorno = false;
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
        bool Situacao;
        private void VerificarCadastroEmpresa()
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"));
            SqlCommand comando = new SqlCommand("Select * from Empresa", conexao);
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                SqlDataReader reader = comando.ExecuteReader();
                 if (reader.Read())
                {
                    Situacao = true;
                }
                else
                {
                    Situacao = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void VerificarCadastroUsuario()
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4"));
            SqlCommand comando = new SqlCommand("Select * from Usuario", conexao);
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Situacao = true;
                }
                else
                {
                    Situacao = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
            }
        }

        private bool VerificarSerial()
        {
            SqlConnection conexao = new SqlConnection(ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdHJjGrOXTsH7YfMGR7bciVESTNxiggiQBDbnJJ0mwpG2P2NoQZI/N9NA=="));
            _sql = "select * from autentico";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            conexao.Open();
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                conexao.Close();
                return true;
                }
            else
            {
                conexao.Close();
                return false;
            }
            
        }
    }
}
