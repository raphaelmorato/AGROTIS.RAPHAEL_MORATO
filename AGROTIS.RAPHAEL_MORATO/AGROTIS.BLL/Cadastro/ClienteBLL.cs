using AGROTIS.BLL.Validacoes;
using AGROTIS.CUL.Model.Cadastro;
using AGROTIS.DAL.Repository.Cadastro.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AGROTIS.BLL.Mapper.Cadastro;
using AGROTIS.BLL.CEP;
using AGROTIS.Model;

namespace AGROTIS.BLL.Cadastro
{
    public class ClienteBLL
    {
        private readonly IClienteRepository _IClienteRepository;

        public ClienteBLL()
        {
            _IClienteRepository = new ClienteRepository();
        }

        public RetornoValidacao Salvar(ClienteCUL clienteCUL)
        {
            var validacao = ValidaSalvar(clienteCUL);
            if (validacao.Sucesso)
            {
                _IClienteRepository.Salvar(clienteCUL.ToClienteDAL());
            }
            return validacao;
        }

        public RetornoValidacao Excluir(ClienteCUL clienteCUL)
        {
            var validacao = ValidaRelacionamentoExcluir(clienteCUL);
            if (validacao.Sucesso)
            {
                _IClienteRepository.Remover(clienteCUL.ToClienteDAL());
            }
            return validacao;
        }

        public List<ClienteCUL> GetCliente(ClienteCUL clienteCUL)
        {
            return _IClienteRepository.GetCliente(clienteCUL.ToClienteDAL()).ToClienteCUL();
        }

        public RetornoValidacao ValidaSalvar(ClienteCUL clienteCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var valNome = Validacao.ValidaCampoBranco(clienteCUL.Nome, "Informe o nome.");
            if (valNome != null) { rv.LstMensagem.AddRange(valNome.LstMensagem); };

            var valCep = Validacao.ValidaCampoBranco(clienteCUL.Cep, "Informe o CEP.");
            if (valCep != null) { rv.LstMensagem.AddRange(valCep.LstMensagem); };

            var valComplemento = Validacao.ValidaCampoBranco(clienteCUL.Complemento, "Informe o complemento.");
            if (valComplemento != null) { rv.LstMensagem.AddRange(valComplemento.LstMensagem); };

            return rv;
        }

        public RetornoValidacao ValidaClienteExcluir(ClienteCUL clienteCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var valCod = Validacao.ValidaCampoZerado(clienteCUL.Codigo, $"Informe o cliente para a exclusão.{Environment.NewLine}Clica na aba \"Filtro\", pesquise o cliente, dê um duplo clique nele e em seguida clica em \"Excluir\".");
            if (valCod != null) { rv.LstMensagem.AddRange(valCod.LstMensagem); };

            return rv;
        }

        private RetornoValidacao ValidaRelacionamentoExcluir(ClienteCUL clienteCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            var result = _IClienteRepository.ValidaRelacionamento(clienteCUL.ToClienteDAL());

            if (result)
            {
                rv = Validacao.ValidaGenerico("Este cliente está relacionado com um ou mais pedidos, por isso não pode excluir.");
            }

            return rv;
        }

        public RetornoValidacao CarregaDadoViaCep(ref ClienteCUL clienteCUL)
        {
            RetornoValidacao rv = new RetornoValidacao();

            if (!string.IsNullOrEmpty(clienteCUL.Cep.Trim()))
            {
                var cepBLL = new CepBLL(clienteCUL.Cep);
                try
                {
                    CepCUL cepCUL = cepBLL.Get();
                    clienteCUL = cepCUL.ToClienteCUL(clienteCUL);
                }
                catch (Exception ex)
                {
                    rv.LstMensagem.Add(ex.Message);
                }
            }
            return rv;
        }
    }
}
