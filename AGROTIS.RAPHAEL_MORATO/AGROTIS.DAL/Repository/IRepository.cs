using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGROTIS.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        void Salvar(T objeto);
        void Novo(T objeto);
        void Atualizar(T objeto);
        void Remover(T objeto);
    }
}
