using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.DAL.Repository.Cadastro.Cliente;
using AGROTIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.BLL.Mapper.Cadastro
{
    public static class ClienteMapper
    {
        public static ClienteCUL ToClienteCUL(this ClienteDAL clienteDAL)
        {
            ClienteCUL clienteCUL = new ClienteCUL();

            if (clienteDAL != null)
            {
                clienteCUL.Cep = clienteDAL.Cep;
                clienteCUL.Codigo = clienteDAL.Id_cliente;
                clienteCUL.Nome = clienteDAL.Nome;
                clienteCUL.UF = clienteDAL.UF;
                clienteCUL.Cidade = clienteDAL.Cidade;
                clienteCUL.Bairro = clienteDAL.Bairro;
                clienteCUL.CodigoIBGE = clienteDAL.Codigo_ibge;
                clienteCUL.Complemento = clienteDAL.Complemento;
                clienteCUL.Logradouro = clienteDAL.Logradouro;
            }
            return clienteCUL;
        }

        public static List<ClienteCUL> ToClienteCUL(this List<ClienteDAL> lstClienteDAL)
        {
            List<ClienteCUL> lstClienteCUL = new List<ClienteCUL>();

            lstClienteDAL.ForEach(i =>
            {
                lstClienteCUL.Add(i.ToClienteCUL());
            });
            return lstClienteCUL;
        }

        public static ClienteDAL ToClienteDAL(this ClienteCUL clienteCUL)
        {
            ClienteDAL clienteDAL = new ClienteDAL();

            if (clienteCUL != null)
            {
                clienteDAL.Cep = clienteCUL.Cep;
                clienteDAL.Id_cliente = clienteCUL.Codigo;
                clienteDAL.Nome = clienteCUL.Nome;
                clienteDAL.UF = clienteCUL.UF;
                clienteDAL.Cidade = clienteCUL.Cidade;
                clienteDAL.Bairro = clienteCUL.Bairro;
                clienteDAL.Codigo_ibge = clienteCUL.CodigoIBGE;
                clienteDAL.Complemento = clienteCUL.Complemento;
                clienteDAL.Logradouro = clienteCUL.Logradouro;
            }
            return clienteDAL;
        }

        public static List<ClienteDAL> ToClienteDAL(this List<ClienteCUL> lstClienteCUL)
        {
            List<ClienteDAL> lstClienteDAL = new List<ClienteDAL>();

            lstClienteCUL.ForEach(i =>
            {
                lstClienteDAL.Add(i.ToClienteDAL());
            });
            return lstClienteDAL;
        }

        public static ClienteCUL ToClienteCUL(this CepCUL cep)
        {
            ClienteCUL clienteCUL = new ClienteCUL()
            {
                Bairro = cep.Bairro,
                Cep = cep.Cep,
                Cidade = cep.Localidade,
                CodigoIBGE = cep.Ibge,
                Complemento = cep.Complemento,
                Logradouro = cep.Logradouro,
                UF = cep.Uf
            };

            return clienteCUL;
        }

        public static ClienteCUL ToClienteCUL(this CepCUL cep, ClienteCUL clienteCUL)
        {
            var clienteEnd = cep.ToClienteCUL();
            clienteEnd.Nome = clienteCUL.Nome;
            clienteEnd.Codigo = clienteCUL.Codigo;

            return clienteEnd;
        }
    }
}
