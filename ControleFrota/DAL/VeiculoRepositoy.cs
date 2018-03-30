using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeiculoRepositoy : IVeiculoRepository
    {
        DataBaseAcess db;
        DataTable dt;
        public void CadastrarVeiculo(Veiculo veiculo)
        {
            dt = new DataTable();
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = @"INSERT INTO veiculos(modelo, placa, prefixo, marca, ano_fab, ano_modelo, km, municipio, uf,
                                   combustivel, renavam, dpvat, licenciamento, chassi, observacao) 
                                   VALUES('" + veiculo.Modelo + "' , '" + veiculo.Placa + "', '" + veiculo.Prefixo +"', '"
                                   + veiculo.Marca + "' , '" + veiculo.AnoFabricacao + "', '" + veiculo.AnoModelo + "', '"
                                   + veiculo.Km + "' , '" + veiculo.Municipio + "', '" + veiculo.UF + "', '"
                                   + veiculo.Combustivel + "' , '" + veiculo.Renavam + "', '" + veiculo.Dpvat + "', '"
                                   + veiculo.Licenciamento + "' , '" + veiculo.Chassi + "', '" + veiculo.Observacao + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar Viatura! " + ex.Message);
            } 
        }

        public DataTable CarregarVeiculos()
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = @"SELECT * FROM veiculos";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }
        public DataTable CarregarManutencao(int veiculo)
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = @"SELECT * FROM manutencao where veiculo = " + veiculo;
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }
    }
}
