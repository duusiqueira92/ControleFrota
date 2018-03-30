using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
   
    public class ApreensaoServices : IApreensoesServices
    {
        IApreensoesRepository _apreensaoRepository;

        public string CadastrarApreensao(List<Apreensao> objetos)
        {
           _apreensaoRepository = new ApreensaoRepository();
           _apreensaoRepository.CadastrarApreensao(objetos);
            return "Apreensão cadastrada com sucesso!";
        }

        public DataTable RetornarObjetos()
        {
            _apreensaoRepository = new ApreensaoRepository();
            return _apreensaoRepository.RetornarObjetos();
        }
    }
}
