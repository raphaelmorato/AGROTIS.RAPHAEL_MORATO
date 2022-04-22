using AGROTIS.BLL.Financeiro;
using AGROTIS.BLL.Validacoes;
using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.CUL.Model.Financeiro;
using AGROTIS.Model.Financeiro;
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

namespace AGROTIS.PLWF.Financeiro
{
    public partial class FrmPedido : MetroForm
    {
        private PedidoBLL _PedidoBLL;
        private PedidoCUL _PedidoCUL;

        public FrmPedido()
        {
            InitializeComponent();
            _PedidoBLL = new PedidoBLL();
            _PedidoCUL = new PedidoCUL();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            tbcPainel.SelectedTab = tbcPainel.TabPages[0];
            PreencheCboCliente();
            PreencheCboProduto();
            bsProd.DataSource = new List<PedidoItemGrid>();
        }

        private void tbcPainel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaFiltro();
        }


        #region CRUD
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaDados();
            cboCliente.Focus();
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

                rv = _PedidoBLL.Salvar(_PedidoCUL);

                if (rv.Sucesso)
                {
                    string msg = _PedidoCUL.Codigo == 0 ? "Cadastro realizado com sucesso!" : "Cadastro atualizado com sucesso!";
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
                if (MetroFramework.MetroMessageBox.Show(this, "Deseja realmente excluir?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    GetDadosCadastro();

                    _PedidoBLL.Excluir(_PedidoCUL);

                    MetroFramework.MetroMessageBox.Show(this, "Exclusão realizada com sucesso!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaDados();
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
            _PedidoCUL = new PedidoCUL
            {
                Codigo = txtId.Text.ToInt(),
                DataEmissao = dtpDtEmissao.Value,
                Cliente = new ClienteCUL() { Codigo = txtIdCliente.Text.ToInt() },
                LstItem = ((List<PedidoItemGrid>)bsProd.DataSource).ToPedidoItemCUL()
            };
        }

        private void LimpaDados()
        {
            _PedidoCUL = new PedidoCUL();
            bsProd.DataSource = new List<PedidoItemGrid>();
            LimpaCamposCadastro();
        }
        private void LimpaCamposCadastro()
        {
            dtpDtEmissao.Value = DateTime.Now;
            txtId.Text =
            txtIdCliente.Text =
            txtIdProduto.Text =
            txtQtd.Text =
            string.Empty;
        }

        private void LimpaCamposAdicionarProduto()
        {
            txtIdProduto.Text =
            txtQtd.Text =
            string.Empty;
        }

        private void CarregaCamposCadastro()
        {
            txtId.Text = _PedidoCUL.Codigo.ToString();
            txtIdCliente.Text = _PedidoCUL.Cliente.Codigo.ToString();
            bsProd.DataSource = _PedidoCUL.LstItem.ToGrid();

        }


        #endregion

        #region FILTRO
        private void GetDadosFiltro()
        {
            _PedidoCUL = new PedidoCUL
            {
                Cliente = new ClienteCUL()
                {
                    Nome = txtNomeF.Text
                }
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
                bsFiltro.DataSource = _PedidoBLL.GetPedidoFiltro(_PedidoCUL).ToPedidoFiltroGrid();
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
        #endregion

        #region Preenche Combo Cliente
        private void PreencheCboCliente()
        {
            cboCliente.DisplayMember = "Nome";
            cboCliente.ValueMember = "Codigo";
            var lst = _PedidoBLL.GetClienteCombo();
            lst.Insert(0, new ClienteCUL()
            {
                Codigo = 0,
                Nome = string.Empty
            });
            cboCliente.DataSource = lst;
        }



        private void cboCliente_Validating(object sender, CancelEventArgs e)
        {
            InformaIDClienteText();
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InformaIDClienteText();
        }

        private void InformaIDClienteText()
        {
            try
            {
                PreencheIdCliente();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o cliente.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheIdCliente()
        {
            if (cboCliente.Items != null)
            {
                if (cboCliente.Items.Count > 0)
                {
                    var cliente = (cboCliente.SelectedItem as ClienteCUL);
                    if (cliente != null)
                    {
                        if (cliente.Codigo > 0)
                        {
                            txtIdCliente.Text = cliente.Codigo.ToString();
                        }
                        else
                        {
                            txtIdCliente.Text = string.Empty;
                        }
                    }
                    else
                    {
                        txtIdCliente.Text = string.Empty;
                    }
                }
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            SelecionaNomeComboCliente();
        }

        private void txtIdCliente_Validating(object sender, CancelEventArgs e)
        {
            SelecionaNomeComboCliente();
        }

        private void SelecionaNomeComboCliente()
        {
            try
            {
                int id = 0;
                if (!string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    id = Convert.ToInt32(txtIdCliente.Text);
                }
                var valor = cboCliente.Items.Cast<ClienteCUL>().FirstOrDefault(i => i.Codigo == id);
                cboCliente.SelectedItem = valor;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o cliente.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Preenche Combo Produto
        private void PreencheCboProduto()
        {
            cboProduto.DisplayMember = "Descricao";
            cboProduto.ValueMember = "Codigo";
            var lst = _PedidoBLL.GetProdutoCombo();
            lst.Insert(0, new ProdutoCUL()
            {
                Codigo = 0,
                Descricao = string.Empty
            });
            cboProduto.DataSource = lst;
        }

        private void cboProduto_Validating(object sender, CancelEventArgs e)
        {
            InformaIDProdutoText();
        }

        private void cboProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            InformaIDProdutoText();
        }

        private void InformaIDProdutoText()
        {
            try
            {
                PreencheIdProduto();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o produto.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheIdProduto()
        {
            if (cboProduto.Items != null)
            {
                if (cboProduto.Items.Count > 0)
                {
                    var produto = (cboProduto.SelectedItem as ProdutoCUL);
                    if (produto != null)
                    {
                        if (produto.Codigo > 0)
                        {
                            txtIdProduto.Text = produto.Codigo.ToString();
                        }
                        else
                        {
                            txtIdProduto.Text = string.Empty;
                        }
                    }
                    else
                    {
                        txtIdProduto.Text = string.Empty;
                    }
                }
            }
        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            SelecionaNomeComboProduto();
        }

        private void txtIdProduto_Validating(object sender, CancelEventArgs e)
        {
            SelecionaNomeComboProduto();
        }

        private void SelecionaNomeComboProduto()
        {
            try
            {
                int id = 0;
                if (!string.IsNullOrEmpty(txtIdProduto.Text))
                {
                    id = Convert.ToInt32(txtIdProduto.Text);
                }
                var valor = cboProduto.Items.Cast<ProdutoCUL>().FirstOrDefault(i => i.Codigo == id);
                cboProduto.SelectedItem = valor;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, $"Erro ao selecionar o produto.{Environment.NewLine} {ex.Message}", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void SoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Adiciona produto
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            RetornoValidacao rv = new RetornoValidacao();
            try
            {
                var produto = CarregaProdutoAdcionarPedido();
                rv = _PedidoBLL.ValidaProdutoAdcionarPedido(produto);
                if (rv.Sucesso)
                {
                    _PedidoCUL.AdicionaItem(produto);
                    bsProd.DataSource = _PedidoCUL.LstItem.ToGrid();
                    LimpaCamposAdicionarProduto();
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

        private PedidoItemCUL CarregaProdutoAdcionarPedido()
        {
            PedidoItemCUL pedidoItemCUL = new PedidoItemCUL();
            var produto = (cboProduto.SelectedItem as ProdutoCUL);
            pedidoItemCUL.Produto = produto;
            pedidoItemCUL.Quantidade = txtQtd.Text.ToInt();
            return pedidoItemCUL;
        }
        #endregion

        private void dgvProd_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = bsProd.Current as PedidoItemGrid;
            if (obj != null)
            {
                _PedidoCUL.LstItem.RemoveAll(i => i.Produto.Codigo == obj.Codigo);
            }
        }

        private void dgvFiltro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.RowIndex != -1)
                {
                    bsFiltro.Position = e.RowIndex;
                    var obj = bsFiltro.Current as PedidoFiltroGrid;
                    if (obj != null)
                    {
                        var pedido = _PedidoBLL.GetPedido(obj.IdPedido);
                        _PedidoCUL = pedido.FirstOrDefault();
                        CarregaCamposCadastro();
                        tbcPainel.SelectedTab = tbcPainel.TabPages[0];
                        LimpaFiltro();
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
    }
}
