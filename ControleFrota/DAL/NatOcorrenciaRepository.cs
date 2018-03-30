using DAL.Interfaces;
using System;

namespace DAL
{
    public class NatOcorrenciaRepository : INatOcorrenciaRepository
    {
        DataBaseAcess db;

        public void CadastrarNatOcorrencia(NatOcorrencia natOcorrencia)
        {
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = @"INSERT INTO nat_ocorrencia(id, nome, descricao) VALUES
                    ('" + natOcorrencia.Id + "' , '" + natOcorrencia.Nome + "', '" + natOcorrencia.Descricao + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Natureza de Ocorrência!" + ex.Message);
            }
        }
    }
}
