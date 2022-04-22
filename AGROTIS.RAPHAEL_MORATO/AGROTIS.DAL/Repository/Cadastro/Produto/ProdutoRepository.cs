using AGROTIS.DAL.Repository.Cadastro.Cliente;
using AGROTIS.DAL.Repository.Conexao;
using Dapper;
using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Cadastro.Produto
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IConexaoBanco<ProdutoDAL> _conexaoBanco;
        public ProdutoRepository()
        {
            _conexaoBanco = new ConexaoMySQL<ProdutoDAL>();
        }

        public void Atualizar(ProdutoDAL objeto)
        {
            string cmd = "UPDATE produto SET descricao = @descricao,peso_liquido = @peso_liquido,preco_unitario = @preco_unitario WHERE id_produto = @id_produto";
            _conexaoBanco.ComandoTransaction(objeto, cmd);
        }

        public List<ProdutoDAL> GetProduto(ProdutoDAL objeto)
        {
            string sql = "SELECT id_produto,descricao,peso_liquido,preco_unitario FROM produto WHERE descricao LIKE CONCAT('%',@descricao,'%')";
            return _conexaoBanco.Consulta(sql, objeto).ToList();
        }

        public void Novo(ProdutoDAL objeto)
        {
            string cmd = "INSERT INTO produto (descricao,peso_liquido,preco_unitario) VALUE (@descricao,@peso_liquido,@preco_unitario)";
            _conexaoBanco.ComandoTransaction(objeto, cmd);            
        }

        public void Remover(ProdutoDAL objeto)
        {
            string cmd = "DELETE FROM produto WHERE id_produto = @id_produto";
            _conexaoBanco.ComandoTransaction(objeto, cmd);
        }

        public void Salvar(ProdutoDAL objeto)
        {
            if (objeto.Id_produto == 0)
            {
                Novo(objeto);
            }
            else
            {
                Atualizar(objeto);
            }
        }

        public bool ValidaRelacionamento(ProdutoDAL objeto)
        {
            string sql = "SELECT produto_id_produto FROM produto_pedido WHERE produto_id_produto = @id_produto  LIMIT 1 ";
            return _conexaoBanco.Consulta(sql, objeto).Any();
        }
    }
}
