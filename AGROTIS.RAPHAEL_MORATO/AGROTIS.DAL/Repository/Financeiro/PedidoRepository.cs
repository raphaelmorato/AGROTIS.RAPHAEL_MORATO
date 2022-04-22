using AGROTIS.DAL.Repository.Cadastro.Cliente;
using AGROTIS.DAL.Repository.Cadastro.Produto;
using AGROTIS.DAL.Repository.Conexao;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Financeiro
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConexaoBanco<PedidoDAL> _conexaoBancoPedido;
        public PedidoRepository()
        {
            _conexaoBancoPedido = new ConexaoMySQL<PedidoDAL>();
        }
        public void Atualizar(PedidoDAL objeto)
        {
            string cmd = "UPDATE pedido SET cliente_id_cliente = @cliente_id_cliente WHERE id_pedido = @id_pedido";
            _conexaoBancoPedido.ComandoTransaction(objeto, cmd);

            AtualizarProduto_Pedido(objeto);
        }

        private void AtualizarProduto_Pedido(PedidoDAL objeto)
        {
            string sql = string.Empty;
            foreach (var item in objeto.LstItem)
            {
                if (ExisteProduto_Pedido(item))
                {
                    sql = "UPDATE produto_pedido SET quantidade = @quantidade WHERE pedido_id_pedido = @pedido_id_pedido and produto_id_produto = @produto_id_produto";
                    _conexaoBancoPedido.ComandoTransaction(item, sql);
                }
                else
                {
                    //o usuário incluiu mais um produto depois que já tinha cadastrado o pedido
                    InsereProduto_Pedido(item);
                }
            }
            //quando o usuário exclui um produto que já estava salvo, então tem que remover do banco
            RemoverProduto_Pedido(objeto, GetListaProdutoPedidoRemovido(objeto));
        }
        private bool ExisteProduto_Pedido(Produto_pedidoDAL produto_PedidoDAL)
        {
            bool result = false;
            _conexaoBancoPedido.Conecta();
            string sql = "SELECT 1 FROM produto_pedido WHERE pedido_id_pedido = @pedido_id_pedido and produto_id_produto = @produto_id_produto";
            result = _conexaoBancoPedido.Connection.Query<bool>(sql, param: produto_PedidoDAL, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }

        private List<int> GetListaIDProdutoBanco(PedidoDAL objeto)
        {
            List<int> lstIdProdutoBanco = new List<int>();
            _conexaoBancoPedido.Conecta();
            string sql = "SELECT produto_id_produto FROM produto_pedido WHERE pedido_id_pedido = @id_pedido";
            lstIdProdutoBanco = _conexaoBancoPedido.Connection.Query<int>(sql, param: new { objeto.Id_pedido }, commandType: CommandType.Text).ToList();
            return lstIdProdutoBanco;
        }

        private List<int> GetListaProdutoPedidoRemovido(PedidoDAL objeto)
        {
            List<int> lstIdProdBanco = GetListaIDProdutoBanco(objeto);

            List<int> lstIdRemover = new List<int>();

            lstIdRemover = lstIdProdBanco.Except(objeto.LstItem.Select(i => i.Produto_id_produto).ToList()).ToList();

            return lstIdRemover;
        }


        public List<ClienteDAL> GetCliente()
        {
            _conexaoBancoPedido.Conecta();
            string sql = "SELECT id_cliente,nome FROM cliente";
            return _conexaoBancoPedido.Connection.Query<ClienteDAL>(sql, commandType: CommandType.Text).ToList();
        }

        public List<PedidoDAL> GetPedido(int idPedido)
        {
            string sql = @"SELECT 
	                            c.id_cliente,
                                c.nome,
                                p.id_pedido,
                                p.data_emissao,
                                p.cliente_id_cliente,
                                pp.pedido_id_pedido,
                                pp.produto_id_produto,
                                pp.Quantidade,
                                prod.id_produto,
                                prod.descricao,
                                prod.peso_liquido,
                                prod.preco_unitario
                            FROM
	                            pedido p 
                                INNER JOIN produto_pedido pp on p.id_pedido = pedido_id_pedido
                                INNER JOIN produto prod on prod.id_produto = pp.produto_id_produto
                                INNER JOIN cliente c on c.id_cliente = p.cliente_id_cliente
                            WHERE p.id_pedido = @idPedido";
            _conexaoBancoPedido.Conecta();
            List<PedidoDAL> lst = new List<PedidoDAL>();
            lst = _conexaoBancoPedido.Connection.Query(sql,
                                                    new[]
                                                    {
                                                        typeof(ClienteDAL),
                                                        typeof(PedidoDAL),
                                                        typeof(Produto_pedidoDAL),
                                                        typeof(ProdutoDAL)
                                                    },
                                                    objects =>
                                                    {
                                                        var clienteDAL = objects[0] as ClienteDAL;
                                                        var pedidoDAL = objects[1] as PedidoDAL;
                                                        var produto_pedidoDAL = objects[2] as Produto_pedidoDAL;
                                                        var produtoDAL = objects[3] as ProdutoDAL;

                                                        if (clienteDAL != null)
                                                        {
                                                            pedidoDAL.ClienteDAL = clienteDAL;
                                                        }
                                                        if (produto_pedidoDAL != null)
                                                        {
                                                            pedidoDAL.LstItem.Add(new Produto_pedidoDAL()
                                                            {
                                                                Pedido_id_pedido = produto_pedidoDAL.Pedido_id_pedido,
                                                                Produto_id_produto = produto_pedidoDAL.Produto_id_produto,
                                                                Quantidade = produto_pedidoDAL.Quantidade
                                                            });
                                                        }
                                                        if (produtoDAL != null)
                                                        {
                                                            pedidoDAL.ProdutoDAL = produtoDAL;
                                                        }
                                                        return pedidoDAL;
                                                    }, splitOn:
                                                                @"id_cliente,
                                                                  id_pedido,
                                                                  pedido_id_pedido,
                                                                  id_produto"
                                                   , param: new { idPedido }).ToList();
            return lst;
        }

        public List<PedidoDAL> GetPedidoFiltro(PedidoDAL pedido)
        {
            string sql = @"SELECT 
                            c.id_cliente,
                            c.nome,
                            p.id_pedido,
                            p.data_emissao
                        FROM
                            pedido p
                            INNER JOIN cliente c on c.id_cliente = p.cliente_id_cliente
                        WHERE
                            c.nome LIKE CONCAT('%',@nome,'%')
                        ";
            _conexaoBancoPedido.Conecta();
            List<PedidoDAL> lst = new List<PedidoDAL>();
            lst = _conexaoBancoPedido.Connection.Query(sql,
                                                    new[]
                                                    {
                                                        typeof(ClienteDAL),
                                                        typeof(PedidoDAL),
                                                    },
                                                    objects =>
                                                    {
                                                        var clienteDAL = objects[0] as ClienteDAL;
                                                        var pedidoDAL = objects[1] as PedidoDAL;

                                                        if (clienteDAL != null)
                                                        {
                                                            pedidoDAL.ClienteDAL = clienteDAL;
                                                        }
                                                        return pedidoDAL;
                                                    }, splitOn:
                                                                @"id_cliente,
                                                                  id_pedido"
                                                    , param: new { pedido.ClienteDAL.Nome }).ToList();
            return lst;
        }

        public List<ProdutoDAL> GetProduto()
        {
            _conexaoBancoPedido.Conecta();
            string sql = "SELECT id_produto,descricao,peso_liquido,preco_unitario FROM produto";
            return _conexaoBancoPedido.Connection.Query<ProdutoDAL>(sql, commandType: CommandType.Text).ToList();
        }

        public void Novo(PedidoDAL objeto)
        {
            int cod;
            string cmd = "INSERT INTO pedido (data_emissao,cliente_id_cliente) VALUE (@data_emissao,@cliente_id_cliente)";
            cod = _conexaoBancoPedido.ComandoTransactionID(objeto, cmd);
            objeto.Id_pedido = cod;
            NovoProduto_Pedido(objeto);
        }

        private void NovoProduto_Pedido(PedidoDAL objeto)
        {
            foreach (var item in objeto.LstItem)
            {
                item.Pedido_id_pedido = objeto.Id_pedido;
                InsereProduto_Pedido(item);
            }
        }

        private void InsereProduto_Pedido(Produto_pedidoDAL item)
        {
            string sql = string.Empty;
            sql = "INSERT INTO produto_pedido (pedido_id_pedido,produto_id_produto,quantidade) VALUE (@pedido_id_pedido,@produto_id_produto,@quantidade)";
            _conexaoBancoPedido.ComandoTransaction(item, sql);
        }

        public void Remover(PedidoDAL objeto)
        {
            RemoverProduto_Pedido(objeto);

            string cmd = "DELETE FROM pedido WHERE id_pedido = @id_pedido";
            _conexaoBancoPedido.ComandoTransaction(objeto, cmd);
        }

        private void RemoverProduto_Pedido(PedidoDAL objeto)
        {
            string sql = "DELETE FROM produto_pedido WHERE pedido_id_pedido = @id_pedido";
            _conexaoBancoPedido.ComandoTransaction(objeto, sql);
        }

        private void RemoverProduto_Pedido(PedidoDAL objeto, List<int> lstIdProduto)
        {
            string sql = $"DELETE FROM produto_pedido WHERE pedido_id_pedido = @pedido_id_pedido and produto_id_produto in ({string.Join(",", lstIdProduto)})";
            _conexaoBancoPedido.ComandoTransaction(objeto.LstItem.FirstOrDefault(), sql);
        }

        public void Salvar(PedidoDAL objeto)
        {
            if (objeto.Id_pedido == 0)
            {
                Novo(objeto);
            }
            else
            {
                Atualizar(objeto);
            }
        }
    }
}
