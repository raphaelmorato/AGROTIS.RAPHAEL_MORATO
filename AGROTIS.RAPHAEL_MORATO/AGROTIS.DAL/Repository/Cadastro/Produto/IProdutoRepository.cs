using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Cadastro.Produto
{
    public interface IProdutoRepository : IRepository<ProdutoDAL>
    {
        List<ProdutoDAL> GetProduto(ProdutoDAL objeto);
        bool ValidaRelacionamento(ProdutoDAL objeto);
    }
}
