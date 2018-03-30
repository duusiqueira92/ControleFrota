using DAL.Interfaces;
using System;
using System.Data;

namespace DAL
{
    public class AcidenteRepository : IAcidenteRepository
    {
        DataBaseAcess db;
        DataTable dt;
        public void CadastrarAcidente(Acidente acidente)
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {

                string comando = @"INSERT INTO acidente (tipo_acidente, tipo_pista, marca, modelo, placa, uf, municipio, chassi, cor, ano, 
                                pontos_impacto, danos, frontal, lateral_direita, lateral_esquerda, frontal_direita, 
                                frontal_esquerda, lateral_tr_direita, lateral_tr_esquerda, traseira, traseira_esquerda, traseira_direita, boletim_ocorrencia)
                                VALUES ('" + acidente.TipoAcidente + "', '" + acidente.TipoPista + "', '" + acidente.Marca + "', '" + acidente.Modelo + "', '"
                                + acidente.Placa + "', '" + acidente.Uf + "', '" + acidente.Municipio + "', '" + acidente.Chassi + "', '"
                                + acidente.Cor + "', '" + acidente.Ano + "', '" + acidente.PontosImpacto + "', '" + acidente.Danos + "', '"
                                + acidente.ColisaoFrontal + "', '" + acidente.ColisaoLateralDireita + "', '" + acidente.ColisaoLateralEsquerda + "', '" + acidente.ColisaoFrontalDireita + "', '"
                                + acidente.ColisaoFrontalEsquerda + "', '" + acidente.ColisaoLateralTrasDireita + "', '" + acidente.ColisaoLateralTrasEsquerda + "', '" + acidente.ColisaoTraseira + "', '"
                                + acidente.ColisaoTraseiraDireita + "', '" + acidente.ColisaoTraseiraEsquerda + "', '" + acidente.IdBoletim + "')";
                db.Conectar();
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o banco de dados! " + ex.Message);
            }
            finally
            {
                db = null;
            }
        }
    }
}
