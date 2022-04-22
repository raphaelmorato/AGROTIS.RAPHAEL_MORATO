using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository.Conexao
{
    public interface IConexaoBanco<T>
    {
        void Conecta();
        void ComandoTransaction(object obj, string cmd);
        int ComandoTransactionID(object obj, string cmd);
        IEnumerable<T> Consulta(string consulta, object obj = null);
        DbConnection Connection { get; set; }
    }
}
