using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Cadastro.Produto
{
    public class ProdutoDAL
    {
        public int Id_produto { get; set; }
        public string Descricao { get; set; }
        public decimal Peso_Liquido { get; set; }
        public decimal Preco_Unitario { get; set; }
    }
}
