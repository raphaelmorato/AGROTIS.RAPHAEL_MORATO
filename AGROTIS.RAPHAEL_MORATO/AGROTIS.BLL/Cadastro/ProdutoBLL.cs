using AGROTIS.BLL.Validacoes;
using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.DAL.Repository.Cadastro.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGROTIS.BLL.Mapper.Cadastro;
using System.Collections;

namespace AGROTIS.BLL.Cadastro
{
    public class ProdutoBLL
    {
        private readonly IProdutoRepository _IProdutoRepository;

        public ProdutoBLL()
        {
            _IProdutoRepository = new ProdutoRepository();
        }

        public RetornoValidacao Salvar(ProdutoCUL produtoCUL)
        {
            var validacao = ValidaSalvar(produtoCUL);
            if (validacao.Sucesso)
            {
                _IProdutoRepository.Salvar(produtoCUL.ToProdutoDAL());
            }
            return validacao;
        }

        public RetornoValidacao Excluir(ProdutoCUL produtoCUL)
        {
            var validacao = ValidaRelacionamentoExcluir(produtoCUL);
            if (validacao.Sucesso)
            {
                _IProdutoRepository.Remover(produtoCUL.ToProdutoDAL());
            }
            return validacao;
        }

        public List<ProdutoCUL> GetProduto(ProdutoCUL produtoCUL)
        {
            return _IProdutoRepository.GetProduto(produtoCUL.ToProdutoDAL()).ToProdutoCUL();
        }

        public RetornoValidacao ValidaSalvar(ProdutoCUL produtoCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var valDesc = Validacao.ValidaCampoBranco(produtoCUL.Descricao, "Informe a descrição.");
            if (valDesc != null) { rv.LstMensagem.AddRange(valDesc.LstMensagem); };

            var valPesoLiq = Validacao.ValidaCampoZerado(produtoCUL.PesoLiquido, "Informe o peso líquido.");
            if (valPesoLiq != null) { rv.LstMensagem.AddRange(valPesoLiq.LstMensagem); };

            var valPecoUni = Validacao.ValidaCampoZerado(produtoCUL.PrecoUnitario, "Informe o preço unitário.");
            if (valPecoUni != null) { rv.LstMensagem.AddRange(valPecoUni.LstMensagem); };

            return rv;
        }

        public RetornoValidacao ValidaProdutoExcluir(ProdutoCUL produtoCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var valCod = Validacao.ValidaCampoZerado(produtoCUL.Codigo, $"Informe o produto para a exclusão.{Environment.NewLine}Clica na aba \"Filtro\", pesquise o produto, dê um duplo clique nele e em seguida clica em \"Excluir\".");
            if (valCod != null) { rv.LstMensagem.AddRange(valCod.LstMensagem); };

            return rv;
        }

        private RetornoValidacao ValidaRelacionamentoExcluir(ProdutoCUL produtoCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var result = _IProdutoRepository.ValidaRelacionamento(produtoCUL.ToProdutoDAL());

            if (result)
            {
                rv = Validacao.ValidaGenerico("Este produto está relacionado com um ou mais pedidos, por isso não pode excluir.");
            }

            return rv;
        }
    }
}
