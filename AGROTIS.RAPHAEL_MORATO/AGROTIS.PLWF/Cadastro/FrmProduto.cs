using AGROTIS.BLL.Cadastro;
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
    public partial class FrmProduto : MetroForm
    {
        private ProdutoBLL _ProdutoBLL;
        private ProdutoCUL _ProdutoCUL;
        public FrmProduto()
        {
            InitializeComponent();
            _ProdutoBLL = new ProdutoBLL();
            _ProdutoCUL = new ProdutoCUL();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
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
            txtDescricao.Focus();
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

                rv = _ProdutoBLL.Salvar(_ProdutoCUL);

                if (rv.Sucesso)
                {
                    string msg = _ProdutoCUL.Codigo == 0 ? "Cadastro realizado com sucesso!" : "Cadastro atualizado com sucesso!";
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
                rv = _ProdutoBLL.ValidaProdutoExcluir(_ProdutoCUL);
                if (rv.Sucesso)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Deseja realmente excluir?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        GetDadosCadastro();

                        rv = _ProdutoBLL.Excluir(_ProdutoCUL);

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
            _ProdutoCUL = new ProdutoCUL
            {
                Codigo = txtId.Text.ToInt(),
                Descricao = txtDescricao.Text,
                PrecoUnitario = txtPrecoUnitario.Text.ToDecimal(),
                PesoLiquido = txtPesoLiquido.Text.ToDecimal()
            };
        }

        private void LimpaDados()
        {
            _ProdutoCUL = new ProdutoCUL();
            LimpaCamposCadastro();
        }
        private void LimpaCamposCadastro()
        {
            txtDescricao.Text =
            txtId.Text =
            txtPesoLiquido.Text =
            txtPrecoUnitario.Text =
            string.Empty;
        }

        private void CarregaCamposCadastro()
        {
            txtDescricao.Text = _ProdutoCUL.Descricao;
            txtId.Text = _ProdutoCUL.Codigo.ToString();
            txtPesoLiquido.Text = _ProdutoCUL.PesoLiquido.ToString();
            txtPrecoUnitario.Text = _ProdutoCUL.PrecoUnitario.ToString();
        }

        public void SoDecimal(object sender, KeyPressEventArgs e)
        {
            string valor = ((MetroTextBox)sender).Text;

            if ((valor.Count(i => i.Equals(',')) == 1 && e.KeyChar == (char)44) ||
                    (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region FILTRO
        private void GetDadosFiltro()
        {
            _ProdutoCUL = new ProdutoCUL
            {
                Descricao = txtDescFiltro.Text
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
                bsFiltro.DataSource = _ProdutoBLL.GetProduto(_ProdutoCUL);
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
                    var obj = bsFiltro.Current as ProdutoCUL;
                    if (obj != null)
                    {
                        _ProdutoCUL = obj;
                        CarregaCamposCadastro();
                        tbcPainel.SelectedTab = tbcPainel.TabPages[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o produto.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

    }

}

