using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Armamento
    {

        public Armamento(string especie, string marca, string modelo, string num_arma, string calibre, string cap_tiros,
            string funcionamento, string acabamento, string qtd_canos, string cpm_canos, string tp_alma, string qtd_raias,
            string snt_raia, string pais_fab, string num_nf, string data_nf, string cidade_emissao, string data_emissao, string num_registro,
            string data_validade, string id_sinarm, int id_agente)
        {
            this.especie = especie;
            this.marca = marca;
            this.modelo = modelo;
            this.num_arma = num_arma;
            this.calibre = calibre;
            this.cap_tiros = cap_tiros;
            this.funcionamento = funcionamento;
            this.acabamento = acabamento;
            this.qtd_canos = qtd_canos;
            this.cpm_cano = cpm_canos;
            this.tp_alma = tp_alma;
            this.qtd_raias = qtd_raias;
            this.snt_raia = snt_raia;
            this.pais_fab = pais_fab;
            this.num_nf = num_nf;
            this.data_nf = data_nf;
            this.cidade_emissao = cidade_emissao;
            this.data_emissao = data_emissao;
            this.num_registro = num_registro;
            this.data_validade = data_validade;
            this.id_sinarm = id_sinarm;
            this.agente_resp = id_agente;
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string especie;
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string num_arma;
        public string Num_Arma
        {
            get { return num_arma; }
            set { num_arma = value; }
        }

        private string calibre;
        public string Calibre
        {
            get { return calibre; }
            set { calibre = value; }
        }

        private string cap_tiros;
        public string Cap_Tiros
        {
            get { return cap_tiros; }
            set { cap_tiros = value; }
        }

        private string funcionamento;
        public string Funcionamento
        {
            get { return funcionamento; }
            set { funcionamento = value; }
        }

        private string acabamento;
        public string Acabamento
        {
            get { return acabamento; }
            set { acabamento = value; }
        }

        private string qtd_canos;
        public string Qtd_Canos
        {
            get { return qtd_canos; }
            set { qtd_canos = value; }
        }

        private string cpm_cano;
        public string Cpm_Cano
        {
            get { return cpm_cano; }
            set { cpm_cano = value; }
        }

        private string tp_alma;
        public string Tp_Alma
        {
            get { return tp_alma; }
            set { tp_alma = value; }
        }

        private string qtd_raias;
        public string Qtd_Raias
        {
            get { return qtd_raias; }
            set { qtd_raias = value; }
        }

        private string snt_raia;
        public string Snt_Raia
        {
            get { return snt_raia; }
            set { snt_raia = value; }
        }

        private string pais_fab;
        public string Pais_Fab
        {
            get { return pais_fab; }
            set { pais_fab = value; }
        }

        private string num_nf;
        public string Num_Nf
        {
            get { return num_nf; }
            set { num_nf = value; }
        }

        private string data_nf;
        public string Data_Nf
        {
            get { return data_nf; }
            set { data_nf = value; }
        }

        private string cidade_emissao;
        public string Cidade_Emissao
        {
            get { return cidade_emissao; }
            set { cidade_emissao = value; }
        }

        private string data_emissao;
        public string Data_Emissao
        {
            get { return data_emissao; }
            set { data_emissao = value; }
        }

        private string num_registro;
        public string Num_Registro
        {
            get { return num_registro; }
            set { num_registro = value; }
        }

        private string data_validade;
        public string Data_Validade
        {
            get { return data_validade; }
            set { data_validade = value; }
        }

        private string id_sinarm;
        public string Id_Sinarm
        {
            get { return id_sinarm; }
            set { id_sinarm = value; }
        }

        private int agente_resp;
        public int Agente_Resp
        {
            get { return agente_resp; }
            set { agente_resp = value; }
        }
    }
}
