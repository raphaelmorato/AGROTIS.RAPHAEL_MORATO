using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Cadastro.Cliente
{
    public interface IClienteRepository : IRepository<ClienteDAL>
    {
        List<ClienteDAL> GetCliente(ClienteDAL objeto);
        bool ValidaRelacionamento(ClienteDAL objeto);
    }
}
