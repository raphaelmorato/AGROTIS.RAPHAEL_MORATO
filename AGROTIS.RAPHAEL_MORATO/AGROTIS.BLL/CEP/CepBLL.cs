using AGROTIS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AGROTIS.BLL.CEP
{
    public class CepBLL
    {
        private string _url = "http://viacep.com.br/ws/CEP/json/";
        private string _cep;
        public CepBLL(string cep)
        {
            _cep = cep;
        }
        public CepCUL Get()
        {
            CepCUL cepCUL = new CepCUL();
            try
            {
                string result = string.Empty;
                IncluiCepUrl();
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(_url);
                httpWebRequest.Timeout = 5000; //5 segundos
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.GetEncoding("utf-8")))
                {
                    result = streamReader.ReadToEnd();
                    cepCUL = JsonConvert.DeserializeObject<CepCUL>(result);
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;

                if (response == null)
                {
                    throw new Exception("Sem acesso a API do CEP, tente mais tarde!");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    throw new Exception("Cep não encontrado!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cepCUL;
        }

        private void RemoveCaracterEspecial()
        {
            _cep = new String(_cep.Where(Char.IsDigit).ToArray());
        }

        private void IncluiCepUrl()
        {
            RemoveCaracterEspecial();
            _url = _url.Replace("CEP", _cep);
        }
    }
}
