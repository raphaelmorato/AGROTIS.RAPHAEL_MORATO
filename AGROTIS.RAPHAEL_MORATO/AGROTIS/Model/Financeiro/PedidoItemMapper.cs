using AGROTIS.CUL.Model.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.Model.Financeiro
{
    public static class PedidoItemMapper
    {
        public static PedidoItemGrid ToGrid(this PedidoItemCUL pedidoItemCUL)
        {
            PedidoItemGrid pedidoItemGrid = new PedidoItemGrid();   
            if (pedidoItemCUL != null)
            {
                pedidoItemGrid.Quantidade = pedidoItemCUL.Quantidade;
                pedidoItemGrid.Codigo = pedidoItemCUL.Produto.Codigo;
                pedidoItemGrid.Descricao = pedidoItemCUL.Produto.Descricao;
                pedidoItemGrid.PesoLiquido = pedidoItemCUL.Produto.PesoLiquido;
                pedidoItemGrid.PrecoUnitario = pedidoItemCUL.Produto.PrecoUnitario;
                pedidoItemGrid.PesoTotal = pedidoItemCUL.PesoTotal;
                pedidoItemGrid.PrecoTotal = pedidoItemCUL.PrecoTotal;
            }
            return pedidoItemGrid;
        }

        public static List<PedidoItemGrid> ToGrid(this List<PedidoItemCUL> lstPedidoItemCUL)
        {
            List<PedidoItemGrid> lstItemGrid = new List<PedidoItemGrid>();
            lstPedidoItemCUL.ForEach(i =>
            {
                lstItemGrid.Add(i.ToGrid());
            });
            return lstItemGrid;
        }

        public static PedidoItemCUL ToPedidoItemCUL(this PedidoItemGrid pedidoItemGrid)
        {
            PedidoItemCUL pedidoItemCUL = new PedidoItemCUL();
            if (pedidoItemCUL != null)
            {
                pedidoItemCUL.Produto.Codigo = pedidoItemGrid.Codigo;
                pedidoItemCUL.Produto.PesoLiquido = pedidoItemGrid.PesoLiquido;
                pedidoItemCUL.Produto.PrecoUnitario = pedidoItemGrid.PrecoUnitario;
                pedidoItemCUL.Produto.Descricao = pedidoItemGrid.Descricao;
                pedidoItemCUL.Quantidade = pedidoItemGrid.Quantidade;
            }
            return pedidoItemCUL;
        }
        public static List<PedidoItemCUL> ToPedidoItemCUL(this List<PedidoItemGrid> lstPedidoItemGrid)
        {
            List<PedidoItemCUL> lstPedidoItemCUL = new List<PedidoItemCUL>();
            lstPedidoItemGrid.ForEach(i =>
            {
                lstPedidoItemCUL.Add(i.ToPedidoItemCUL());
            });
            return lstPedidoItemCUL;
        }

        public static List<PedidoFiltroGrid> ToPedidoFiltroGrid(this List<PedidoCUL> lstPedido)
        {
            List<PedidoFiltroGrid> lstPedidoFiltroGrid = new List<PedidoFiltroGrid>();
            if (lstPedido != null)
            {
                lstPedido.ForEach(i =>
                {
                    lstPedidoFiltroGrid.Add(new PedidoFiltroGrid()
                    {
                        DataEmissao = i.DataEmissao,
                        IdPedido = i.Codigo,
                        Nome = i.Cliente.Nome
                    });
                });
            }
            return lstPedidoFiltroGrid;
        }

    }
}
