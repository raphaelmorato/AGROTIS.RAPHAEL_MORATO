using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.CUL.Model.Cadastro
{
    public class ProdutoCUL
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal PesoLiquido { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
