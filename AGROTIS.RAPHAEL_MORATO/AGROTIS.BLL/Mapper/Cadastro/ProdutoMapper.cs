using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.DAL.Repository.Cadastro.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.BLL.Mapper.Cadastro
{
    public static class ProdutoMapper
    {
        public static ProdutoCUL ToProdutoCUL(this ProdutoDAL produtoDAL)
        {
            ProdutoCUL produtoCUL = new ProdutoCUL();

            if (produtoDAL != null)
            {
                produtoCUL.PrecoUnitario = produtoDAL.Preco_Unitario;
                produtoCUL.Codigo = produtoDAL.Id_produto;
                produtoCUL.Descricao = produtoDAL.Descricao;
                produtoCUL.PrecoUnitario = produtoDAL.Preco_Unitario;
                produtoCUL.PesoLiquido = produtoDAL.Peso_Liquido;
            }
            return produtoCUL;
        }

        public static List<ProdutoCUL> ToProdutoCUL(this List<ProdutoDAL> lstProdutoDAL)
        {
            List<ProdutoCUL> lstProdutoCUL = new List<ProdutoCUL>();

            lstProdutoDAL.ForEach(i =>
            {
                lstProdutoCUL.Add(i.ToProdutoCUL());
            });
            return lstProdutoCUL;
        }

        public static ProdutoDAL ToProdutoDAL(this ProdutoCUL produtoCUL)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();

            if (produtoCUL != null)
            {
                produtoDAL.Preco_Unitario = produtoCUL.PrecoUnitario;
                produtoDAL.Id_produto = produtoCUL.Codigo;
                produtoDAL.Descricao = produtoCUL.Descricao;
                produtoDAL.Preco_Unitario = produtoCUL.PrecoUnitario;
                produtoDAL.Peso_Liquido = produtoCUL.PesoLiquido;
            }
            return produtoDAL;
        }

        public static List<ProdutoDAL> ToProdutoDAL(this List<ProdutoCUL> lstProdutoCUL)
        {
            List<ProdutoDAL> lstProdutoDAL = new List<ProdutoDAL>();

            lstProdutoCUL.ForEach(i =>
            {
                lstProdutoDAL.Add(i.ToProdutoDAL());
            });
            return lstProdutoDAL;
        }
    }
}
