using DAL;
using System.Collections.Generic;
using System.Data;

namespace BLL.Interfaces
{
    public interface IApreensoesServices
    {
        string CadastrarApreensao(List<Apreensao> objetos);
        DataTable RetornarObjetos();
    }
}
