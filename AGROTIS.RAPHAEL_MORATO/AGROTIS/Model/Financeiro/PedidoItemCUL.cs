using AGROTIS.CUL.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.CUL.Model.Financeiro
{
    public class PedidoItemCUL
    {
        public PedidoItemCUL()
        {
            Produto = new ProdutoCUL();
        }
        public ProdutoCUL Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoTotal
        {
            get
            {
                return Produto.PrecoUnitario * Quantidade;
            }
        }
        public decimal PesoTotal
        {
            get
            {
                return Produto.PesoLiquido * Quantidade;
            }
        }
    }
}
