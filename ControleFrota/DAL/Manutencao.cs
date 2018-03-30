using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Manutencao
    {

        public Manutencao()
        {

        }
        public Manutencao(int veiculo)
        {
            this.veiculo = veiculo;
        }
        public Manutencao(int veiculo, DateTime data_manutencao)
        {
            this.veiculo = veiculo;
            this.data_manutencao = data_manutencao;
        }
        private int id_manutencao;
        public int Id_Manutencao
        {
            get { return id_manutencao; }
            set { id_manutencao = value; }
        }

        private int veiculo;
        public int Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        //data manutencao
        private DateTime data_manutencao;
        public DateTime Data_Manutencao
        {
            get { return data_manutencao; }
            set { data_manutencao = value; }
        }

        //km troca de oleo
        private string km_oleo;
        public string Km_Oleo
        {
            get { return km_oleo; }
            set { km_oleo = value; }
        }

        //km troca filtro oleo
        private string km_f_oleo;
        public string Km_F_Oleo
        {
            get { return km_f_oleo; }
            set { km_f_oleo = value; }
        }
        
        //km troca filtro combustivel
        private string km_f_combustivel;
        public string Km_F_Combustivel
        {
            get { return km_f_combustivel; }
            set { km_f_combustivel = value; }
        }

        //km pneu traseiro esquerdo
        private string km_pte;
        public string Km_Pte
        {
            get { return km_pte; }
            set { km_pte = value; }
        }

        //km troca pneu traseiro direito
        private string km_ptd;
        public string Km_Ptd
        {
            get { return km_ptd; }
            set { km_ptd = value; }
        }

        //km troca pneu dianteiro esquerdo
        private string km_pde;
        public string Km_Pde
        {
            get { return km_pde; }
            set { km_pde = value; }
        }

        //km troca pneu dianteiro direito
        private string km_pdd;
        public string Km_Pdd
        {
            get { return km_pdd; }
            set { km_pdd = value; }
        }

        //informaçoes lampadas
        private string lampadas;
        public string Lampadas
        {
            get { return lampadas; }
            set { lampadas = value; }
        }

        //informacoes lataria
        private string lataria;
        public string Lataria
        {
            get { return lataria; }
            set { lataria = value; }
        }

        //informacoes equipamento
        private string equipamento;
        public string Equipamento
        {
            get { return equipamento; }
            set { equipamento = value; }
        }

        //informacoes motor
        private string motor;
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }

        //viatura parada?
        private string parada;
        public string Parada
        {
            get { return parada; }
            set { parada = value; }
        }
    }
}
