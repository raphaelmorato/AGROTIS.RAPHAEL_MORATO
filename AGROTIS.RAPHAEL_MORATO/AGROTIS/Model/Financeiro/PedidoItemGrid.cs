using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.Model.Financeiro
{
    //Classe feita apenas para popular a grid pelo datasource para facilitar, pois a grid não reconhece quando há uma classe dentro da outra.
    public class PedidoItemGrid
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal PesoLiquido { get; set; }
        public decimal PrecoTotal { get; set; }
        public decimal PesoTotal { get; set; }
    }
}
