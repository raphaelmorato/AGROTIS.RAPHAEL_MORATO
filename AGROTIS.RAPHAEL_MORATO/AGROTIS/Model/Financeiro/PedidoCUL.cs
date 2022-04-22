using AGROTIS.CUL.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.CUL.Model.Financeiro
{
    public class PedidoCUL
    {
        public PedidoCUL()
        {
            Cliente = new ClienteCUL();
            LstItem = new List<PedidoItemCUL>();
        }
        public int Codigo { get; set; }
        public DateTime DataEmissao { get; set; }
        public ClienteCUL Cliente { get; set; }
        public List<PedidoItemCUL> LstItem { get; set; }
        public void AdicionaItem(PedidoItemCUL pedidoItem)
        {
            if (pedidoItem != null)
            {
                if (!LstItem.Any(i => i.Produto.Codigo == pedidoItem.Produto.Codigo))
                {
                    LstItem.Add(pedidoItem);
                }
                else
                {
                    int index = LstItem.FindIndex(i => i.Produto.Codigo == pedidoItem.Produto.Codigo);
                    LstItem[index].Quantidade += pedidoItem.Quantidade;
                }
            }
        }

    }
}
