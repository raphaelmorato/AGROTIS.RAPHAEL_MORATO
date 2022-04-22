using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.BLL.Validacoes
{
    public class RetornoValidacao
    {
        public RetornoValidacao()
        {
            LstMensagem = new List<string>();
        }
        public List<string> LstMensagem { get; set; }
        public bool Sucesso
        {
            get
            {
                return !LstMensagem.Any();
            }
        }

        private string mensagem = string.Empty;
        public string Mensagem
        {
            get
            {
                if (LstMensagem.Any())
                {
                    mensagem = string.Join(Environment.NewLine, LstMensagem);
                }
                return mensagem;
            }
        }
    }
}
