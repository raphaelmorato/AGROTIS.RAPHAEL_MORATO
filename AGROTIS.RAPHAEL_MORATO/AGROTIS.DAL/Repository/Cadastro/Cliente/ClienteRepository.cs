using AGROTIS.DAL.Repository.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Cadastro.Cliente
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConexaoBanco<ClienteDAL> _conexaoBanco;
        public ClienteRepository()
        {
            _conexaoBanco = new ConexaoMySQL<ClienteDAL>();
        }
        public void Atualizar(ClienteDAL objeto)
        {
            string cmd = @"UPDATE 
                                cliente 
                           SET
                                nome = @nome,
                                cep = @cep,
                                logradouro = @logradouro,
                                complemento = @complemento,
                                bairro = @bairro,
                                cidade = @cidade,
                                uf = @uf,
                                codigo_ibge = @codigo_ibge
                            WHERE 
                                id_cliente = @id_cliente";
            _conexaoBanco.ComandoTransaction(objeto, cmd);
        }

        public List<ClienteDAL> GetCliente(ClienteDAL objeto)
        {
            string sql = "SELECT id_cliente,nome,cep,logradouro,complemento,bairro,cidade,uf,codigo_ibge FROM cliente WHERE nome LIKE CONCAT('%',@nome,'%')";
            return _conexaoBanco.Consulta(sql, objeto).ToList();

        }

        public void Novo(ClienteDAL objeto)
        {
            string cmd = @"INSERT INTO cliente (nome,cep,logradouro,complemento,bairro,cidade,uf,codigo_ibge) VALUE (@nome,@cep,@logradouro,@complemento,@bairro,@cidade,@uf,@codigo_ibge)";
            _conexaoBanco.ComandoTransaction(objeto, cmd);
        }

        public void Remover(ClienteDAL objeto)
        {
            string cmd = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
            _conexaoBanco.ComandoTransaction(objeto, cmd);
        }

        public void Salvar(ClienteDAL objeto)
        {
            if (objeto.Id_cliente == 0)
            {
                Novo(objeto);
            }
            else
            {
                Atualizar(objeto);
            }
        }

        public bool ValidaRelacionamento(ClienteDAL objeto)
        {
            string sql = "SELECT 1 FROM pedido WHERE cliente_id_cliente = @id_cliente LIMIT 1 ";
            return _conexaoBanco.Consulta(sql, objeto).Any();
        }
    }
}
