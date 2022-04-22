using AGROTIS.PLWF.Cadastro;
using AGROTIS.PLWF.Financeiro;
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

namespace AGROTIS.PLWF.Principal
{
    public partial class FrmPrincipal : MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mtlCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void mtlProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();   
            frmProduto.ShowDialog();
        }

        private void mtlPedido_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.ShowDialog();
        }
    }
}
