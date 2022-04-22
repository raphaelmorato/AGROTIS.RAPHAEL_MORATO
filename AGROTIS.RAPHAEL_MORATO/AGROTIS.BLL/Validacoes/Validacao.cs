using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.BLL.Validacoes
{
    public static class Validacao
    {
        public static RetornoValidacao ValidaCampoBranco(string valor, string mensagem)
        {
            RetornoValidacao validacao = null;

            if (string.IsNullOrEmpty(valor))
            {
                validacao = new RetornoValidacao();
                validacao.LstMensagem.Add(mensagem);
            }
            return validacao;
        }

        public static RetornoValidacao ValidaCampoZerado(decimal valor, string mensagem)
        {
            RetornoValidacao validacao = null;

            if (valor == 0)
            {
                validacao = new RetornoValidacao();
                validacao.LstMensagem.Add(mensagem);
            }
            return validacao;
        }

        public static RetornoValidacao ValidaGenerico(string mensagem)
        {
            RetornoValidacao validacao = new RetornoValidacao();
            validacao.LstMensagem.Add(mensagem);
            return validacao;
        }
    }
}
