using System.Collections.Generic;
using System.Data;

namespace DAL.Interfaces
{
    public interface IApreensoesRepository
    {
        void CadastrarApreensao(List<Apreensao> objetos);
        DataTable RetornarObjetos();
    }
}
