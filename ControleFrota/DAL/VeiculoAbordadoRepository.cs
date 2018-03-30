using DAL.Interfaces;
using System;
using System.Data;

namespace DAL
{
    public class VeiculoAbordadoRepository : IVeiculoAbordadoRepository
    {
        DataBaseAcess db;
        DataTable dt;
        public void CadastrarVeiculoAbordado(VeiculoAbordado veiculoAbordado)
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = @"INSERT INTO veiculos_abordados(condutor, marca, modelo, placa, endereco, equipe) VALUES(
                                 '" + veiculoAbordado.Condutor + "', '" + veiculoAbordado.Marca + "', '" + veiculoAbordado.Modelo + "', '"
                                 + veiculoAbordado.Placa + "', '" + veiculoAbordado.Endereco + "', '" + veiculoAbordado.Equipe + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db = null;
            }
        }

        public DataTable CarregarVeiculoAbordado(int equipe)
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = "SELECT * FROM veiculos_abordados WHERE equipe = " + equipe;
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
