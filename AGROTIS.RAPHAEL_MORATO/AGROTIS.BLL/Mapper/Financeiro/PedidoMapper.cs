using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.CUL.Model.Financeiro;
using AGROTIS.DAL.Repository.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.BLL.Mapper.Financeiro
{
    public static class PedidoMapper
    {
        public static PedidoCUL ToPedidoCUL(this PedidoDAL pedidoDAL)
        {
            PedidoCUL pedidoCUL = new PedidoCUL();

            if (pedidoDAL != null)
            {
                pedidoCUL.DataEmissao = pedidoDAL.Data_Emissao;
                pedidoCUL.Codigo = pedidoDAL.Id_pedido;
                pedidoCUL.Cliente = new ClienteCUL()
                {
                    Codigo = pedidoDAL.Cliente_id_cliente,
                    Nome = pedidoDAL.ClienteDAL.Nome
                };
            }
            return pedidoCUL;
        }

        public static List<PedidoCUL> ToPedidoCUL(this List<PedidoDAL> lstPedidoDAL)
        {
            List<PedidoCUL> lst = new List<PedidoCUL>();

            foreach (var item in lstPedidoDAL)
            {
                if (!lst.Any(i => i.Codigo == item.Id_pedido))
                {
                    lst.Add(item.ToPedidoCUL());
                }
                int index = lst.FindIndex(i => i.Codigo == item.Id_pedido);

                lst[index].AdicionaItem(new PedidoItemCUL()
                {
                    Produto = new ProdutoCUL()
                    {
                        Codigo = item.ProdutoDAL.Id_produto,
                        Descricao = item.ProdutoDAL.Descricao,
                        PesoLiquido = item.ProdutoDAL.Peso_Liquido,
                        PrecoUnitario = item.ProdutoDAL.Preco_Unitario
                    },
                    Quantidade = item.LstItem.Select(i => i.Quantidade).FirstOrDefault()
                }); 
            }
            return lst;
        }

        public static PedidoDAL ToPedidoDAL(this PedidoCUL pedidoCUL)
        {
            PedidoDAL pedidoDAL = new PedidoDAL();

            if (pedidoCUL != null)
            {
                pedidoDAL.Data_Emissao = pedidoCUL.DataEmissao;
                pedidoDAL.Id_pedido = pedidoCUL.Codigo;
                pedidoDAL.Cliente_id_cliente = pedidoCUL.Cliente.Codigo;
                pedidoDAL.ClienteDAL.Nome = pedidoCUL.Cliente.Nome;
                pedidoDAL.LstItem = pedidoCUL.LstItem.ToProduto_pedidoDAL(pedidoCUL.Codigo);
            }
            return pedidoDAL;
        }

        public static Produto_pedidoDAL ToProduto_pedidoDAL(this PedidoItemCUL pedidoItemCUL, int codPedido)
        {
            Produto_pedidoDAL produto_pedidoDAL = new Produto_pedidoDAL();

            if (pedidoItemCUL != null)
            {
                produto_pedidoDAL.Produto_id_produto = pedidoItemCUL.Produto.Codigo;
                produto_pedidoDAL.Pedido_id_pedido = codPedido;
                produto_pedidoDAL.Quantidade = pedidoItemCUL.Quantidade;
            }
            return produto_pedidoDAL;
        }

        public static List<Produto_pedidoDAL> ToProduto_pedidoDAL(this List<PedidoItemCUL> lstPedidoItemCUL, int codPedido)
        {
            List<Produto_pedidoDAL> lstProduto_PedidoDAL = new List<Produto_pedidoDAL>();
            lstPedidoItemCUL.ForEach(i =>
            {
                lstProduto_PedidoDAL.Add(i.ToProduto_pedidoDAL(codPedido));
            });
            return lstProduto_PedidoDAL;
        }
    }
}
