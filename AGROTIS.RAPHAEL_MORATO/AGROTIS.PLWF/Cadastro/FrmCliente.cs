using AGROTIS.BLL.Cadastro;
using AGROTIS.BLL.CEP;
using AGROTIS.BLL.Validacoes;
using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.PLWF.Util;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROTIS.PLWF.Cadastro
{
    public partial class FrmCliente : MetroForm
    {
        private ClienteBLL _ClienteBLL;
        private ClienteCUL _ClienteCUL;
        public FrmCliente()
        {
            InitializeComponent();
            _ClienteBLL = new ClienteBLL();
            _ClienteCUL = new ClienteCUL();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            tbcPainel.SelectedTab = tbcPainel.TabPages[0];
        }
        private void tbcPainel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaFiltro();
        }

        #region CRUD
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaDados();
            txtNomeF.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            Cursor.Current = Cursors.WaitCursor;
            RetornoValidacao rv = new RetornoValidacao();
            try
            {
                GetDadosCadastro();

                rv = _ClienteBLL.Salvar(_ClienteCUL);

                if (rv.Sucesso)
                {
                    string msg = _ClienteCUL.Codigo == 0 ? "Cadastro realizado com sucesso!" : "Cadastro atualizado com sucesso!";
                    MetroFramework.MetroMessageBox.Show(this, msg, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaDados();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, rv.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao salvar.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Excluir()
        {
            Cursor.Current = Cursors.WaitCursor;
            RetornoValidacao rv = new RetornoValidacao();

            try
            {
                rv = _ClienteBLL.ValidaClienteExcluir(_ClienteCUL);
                if (rv.Sucesso)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Deseja realmente excluir?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        GetDadosCadastro();

                        rv = _ClienteBLL.Excluir(_ClienteCUL);

                        if (rv.Sucesso)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Exclusão realizada com sucesso!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaDados();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, rv.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, rv.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao excluir.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaDados();
        }


        #endregion

        #region Métodos gerais  
        private void GetDadosCadastro()
        {
            _ClienteCUL = new ClienteCUL
            {
                Codigo = txtId.Text.ToInt(),
                Bairro = txtBairro.Text,
                Cep = txtCep.Text,
                Cidade = txtCidade.Text,
                CodigoIBGE = txtCodIBGE.Text,
                Complemento = txtComp.Text,
                Logradouro = txtLogradouro.Text,
                Nome = txtNome.Text,
                UF = txtUf.Text
            };
        }

        private void LimpaDados()
        {
            _ClienteBLL = new ClienteBLL();
            LimpaCamposCadastro();
        }

        private void LimpaCamposCadastro()
        {
            txtId.Text =
            txtNome.Text =
            string.Empty;
            LimpaCamposEnderecoCadastro();
        }

        private void LimpaCamposEnderecoCadastro()
        {
            txtBairro.Text =
            txtCep.Text =
            txtCidade.Text =
            txtCodIBGE.Text =
            txtComp.Text =
            txtLogradouro.Text =
            txtUf.Text =
            string.Empty;
        }

        private void CarregaCamposCadastro()
        {
            txtId.Text = _ClienteCUL.Codigo != 0 ? _ClienteCUL.Codigo.ToString() : string.Empty;
            txtBairro.Text = _ClienteCUL.Bairro;
            txtCep.Text = _ClienteCUL.Cep;
            txtCidade.Text = _ClienteCUL.Cidade;
            txtCodIBGE.Text = _ClienteCUL.CodigoIBGE;
            txtComp.Text = _ClienteCUL.Complemento;
            txtLogradouro.Text = _ClienteCUL.Logradouro;
            txtNome.Text = _ClienteCUL.Nome;
            txtUf.Text = _ClienteCUL.UF;
        }

        public void RestrigirCaracterCEP(object sender, KeyPressEventArgs e)
        {
            string valor = ((MetroTextBox)sender).Text;

            if ((valor.Count(i => i.Equals('-')) == 1 && e.KeyChar == (char)45) ||
                    (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)45))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region FILTRO
        private void GetDadosFiltro()
        {
            _ClienteCUL = new ClienteCUL
            {
                Nome = txtNomeF.Text
            };
        }

        private void LimpaFiltro()
        {
            bsFiltro.DataSource = null;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                GetDadosFiltro();
                bsFiltro.DataSource = _ClienteBLL.GetCliente(_ClienteCUL);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao salvar.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void dgvFitro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.RowIndex != -1)
                {
                    bsFiltro.Position = e.RowIndex;
                    var obj = bsFiltro.Current as ClienteCUL;
                    if (obj != null)
                    {
                        _ClienteCUL = obj;
                        CarregaCamposCadastro();
                        tbcPainel.SelectedTab = tbcPainel.TabPages[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o cliente.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        private void txtCep_Validated(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            RetornoValidacao rv = new RetornoValidacao();

            try
            {
                GetDadosCadastro();
                if (!string.IsNullOrEmpty(_ClienteCUL.Cep))
                {
                    rv = _ClienteBLL.CarregaDadoViaCep(ref _ClienteCUL);
                    if (rv.Sucesso)
                    {
                        CarregaCamposCadastro();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, rv.Mensagem, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpaCamposEnderecoCadastro();
                    }
                }
                else
                {
                    LimpaCamposEnderecoCadastro();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o cliente.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCamposEnderecoCadastro();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
