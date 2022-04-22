using AGROTIS.BLL.Validacoes;
using AGROTIS.DAL.Repository.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGROTIS.BLL.Mapper.Financeiro;
using AGROTIS.CUL.Model.Financeiro;
using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.BLL.Mapper.Cadastro;

namespace AGROTIS.BLL.Financeiro
{
    public class PedidoBLL
    {
        private readonly IPedidoRepository _IPedidoRepository;

        public PedidoBLL()
        {
            _IPedidoRepository = new PedidoRepository();
        }

        public RetornoValidacao Salvar(PedidoCUL pedidoCUL)
        {
            var validacao = ValidaSalvar(pedidoCUL);
            if (validacao.Sucesso)
            {
                _IPedidoRepository.Salvar(pedidoCUL.ToPedidoDAL());
            }
            return validacao;
        }

        public void Excluir(PedidoCUL pedidoCUL)
        {
            _IPedidoRepository.Remover(pedidoCUL.ToPedidoDAL());
        }

        public RetornoValidacao ValidaSalvar(PedidoCUL pedidoCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var valCliente = Validacao.ValidaCampoZerado(pedidoCUL.Cliente.Codigo, "Informe o cliente.");
            if (valCliente != null) { rv.LstMensagem.AddRange(valCliente.LstMensagem); };

            var valItem = Validacao.ValidaCampoZerado(pedidoCUL.LstItem.Count(), "Informe pelo menos um produto.");
            if (valItem != null) { rv.LstMensagem.AddRange(valItem.LstMensagem); };

            return rv;
        }

        public List<ClienteCUL> GetClienteCombo()
        {
            return _IPedidoRepository.GetCliente().ToClienteCUL();
        }

        public List<ProdutoCUL> GetProdutoCombo()
        {
            return _IPedidoRepository.GetProduto().ToProdutoCUL();
        }

        public List<PedidoCUL> GetPedido(int idPedido)
        {
            return _IPedidoRepository.GetPedido(idPedido).ToPedidoCUL();
        }
        public List<PedidoCUL> GetPedidoFiltro(PedidoCUL pedidoCUL)
        {
            return _IPedidoRepository.GetPedidoFiltro(pedidoCUL.ToPedidoDAL()).ToPedidoCUL();
        }

        public RetornoValidacao ValidaProdutoAdcionarPedido(PedidoItemCUL pedidoItemCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            if (pedidoItemCUL.Produto == null || pedidoItemCUL.Produto.Codigo == 0)
            {
                var valProd = Validacao.ValidaGenerico("Informe o produto.");
                if (valProd != null) { rv.LstMensagem.AddRange(valProd.LstMensagem); };
            }
            else
            {
                var valQtd = Validacao.ValidaCampoZerado(pedidoItemCUL.Quantidade, "Informe a quantidade.");
                if (valQtd != null) { rv.LstMensagem.AddRange(valQtd.LstMensagem); };
            }
            return rv;
        }
    }
}
