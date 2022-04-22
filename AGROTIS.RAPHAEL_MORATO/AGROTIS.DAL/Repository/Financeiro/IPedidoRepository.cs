using AGROTIS.CUL.Model.Financeiro;
using AGROTIS.DAL.Repository.Cadastro.Cliente;
using AGROTIS.DAL.Repository.Cadastro.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Financeiro
{
    public interface IPedidoRepository : IRepository<PedidoDAL>
    {
        List<ClienteDAL> GetCliente();
        List<ProdutoDAL> GetProduto();
        List<PedidoDAL> GetPedido(int idPedido);
        List<PedidoDAL> GetPedidoFiltro(PedidoDAL pedidoDAL);

    }
}
