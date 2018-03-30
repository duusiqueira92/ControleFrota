using DAL.Interfaces;
using System;

namespace DAL
{
    public class ObjetoRepository : IObjetoRepository
    {
        DataBaseAcess db;

        public void CadastrarObjeto(Objeto objeto)
        {
            try
            {
                db = new DataBaseAcess();
                string comando = "INSERT INTO categoria_objeto(nome) VALUES('" + objeto.NomeObjeto + "')";
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
