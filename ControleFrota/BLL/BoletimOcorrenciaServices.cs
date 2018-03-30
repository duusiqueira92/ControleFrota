using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BoletimOcorrenciaServices : IBoletimOcorrenciaServices
    {

        ComboBoxRepository comboBoxRepository;
        IParteServices _partesServices;
        IParteRepository _partesRepository;
        IBoletimOcorrenciaRepository _boletimOcorrenciaRepository;

        public DataTable RetornarID(int limite)
        {
            _partesServices = new PartesServices(_partesRepository);
            return _partesServices.RetornarID(limite);
        }

        public DataTable RetornarIDBoletim()
        {
            _boletimOcorrenciaRepository = new BoletimOcorrenciaRepository();
            return _boletimOcorrenciaRepository.RetornarIDBoletim();
        }

        public string CadastrarBoletimOcorrencia(BoletimOcorrencia boletimOcorrencia)
        {
            _boletimOcorrenciaRepository = new BoletimOcorrenciaRepository();
            _boletimOcorrenciaRepository.CadastrarBoletimOcorrencia(boletimOcorrencia);
            return "Boletim cadastrado com sucesso!";
        }

        public string CadastrarParte(List<Partes> parte)
        {
            _partesServices = new PartesServices(_partesRepository);
            return _partesServices.CadastrarPartes(parte);
        }

        public DataTable RetornarParteCpf(string cpf)
        {
            _partesServices = new PartesServices(_partesRepository);
            return _partesServices.RetornarParteCpf(cpf);

        }

        public DataTable CarregarEstado()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarEstados();
        }

        public DataTable CarregarOrgEmissor()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarOrgaoEmissor();
        }

        public DataTable CarregarCategoria()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarCategoria();
        }

        public DataTable CarregarNatOcorrencia()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarNatOcorrencia();
        }

        public DataTable CarregarViatura()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarViatura();
        }

        public DataTable CarregarEquipe()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarEquipe();
        }

        public DataTable CarregarPlantao()
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarPlantao();
        }

        public DataTable CarregarMotorista(int plantao, int equipe)
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarMotorista(plantao, equipe);
        }

        public DataTable CarregarEncarregado(int plantao, int equipe)
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarEncarregado(plantao, equipe);
        }

        public DataTable CarregarAuxiliar(int plantao, int equipe)
        {
            comboBoxRepository = new ComboBoxRepository();
            return comboBoxRepository.CarregarAuxiliar(plantao, equipe);
        }
    }
}
