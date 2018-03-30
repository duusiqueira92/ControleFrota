using DAL.Interfaces;
using System;

namespace DAL
{
    public class ColeteRepository : IColeteRepository
    {
        DataBaseAcess db;

        public void CadastrarColete(Colete colete)
        {
            db = new DataBaseAcess();
            try
            {
                string comando = @"INSERT INTO colete(num_serie, num_lote, data_fab, tamanho, num_ca, proprietario, nivel, agente)
                                VALUES('" + colete.NumSerie + "', '" +colete.NumLote+ "', '" + colete.DataFabricacao + "', '"
                                + colete.Tamanho + "', '" + colete.NumCA + "', '" + colete.Proprietario + "', '" + colete.Nivel + "', '" + colete.Agente + "')";
                db.Conectar();
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
    }
}
