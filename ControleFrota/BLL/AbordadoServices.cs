using DAL.Interfaces;
using System;
using DAL;
using System.Data;
using BLL.Interfaces;

namespace BLL
{
    public class AbordadoServices : IAbordadoServices
    {
        IAbordadoRepository _abordadoRepository;
        public string CadastrarAbordado(Abordado abordado)
        {
            _abordadoRepository = new AbordadoRepository();
            _abordadoRepository.CadastrarAbordado(abordado);
            return "Abordado cadastrado com sucesso!";
        }

        public DataTable CarregarAbordados(int equipe)
        {
            _abordadoRepository = new AbordadoRepository();
            return _abordadoRepository.CarregarAbordados(equipe);
        }
    }
}
