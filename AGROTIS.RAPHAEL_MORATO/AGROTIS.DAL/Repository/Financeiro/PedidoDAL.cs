using AGROTIS.DAL.Repository.Cadastro.Cliente;
using AGROTIS.DAL.Repository.Cadastro.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Financeiro
{
    public class PedidoDAL
    {
        public PedidoDAL()
        {
            LstItem = new List<Produto_pedidoDAL>();
            ClienteDAL = new ClienteDAL();
            ProdutoDAL = new ProdutoDAL();
        }
        public int Id_pedido { get; set; }
        public DateTime Data_Emissao { get; set; }
        public int Cliente_id_cliente { get; set; }
        public List<Produto_pedidoDAL> LstItem { get; set; }
        public ClienteDAL ClienteDAL { get; set; }
        //Coloquei por causa da pesquisa do dapper
        public ProdutoDAL ProdutoDAL{ get; set; }
    }
}
