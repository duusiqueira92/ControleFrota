using System;
using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class BoletimOcorrenciaRepository : IBoletimOcorrenciaRepository
    {
        DataTable dt;
        DataBaseAcess db;
        string comando;


        public void CadastrarBoletimOcorrencia(BoletimOcorrencia boletimOcorrencia)
        {
            try
            {
                db = new DataBaseAcess();

                if (boletimOcorrencia.Viatura_Apoio > 0)
                {
                    comando = @"INSERT INTO boletim_ocorrencia(data_inicio, nat_ocorrencia, situacao, hora_inicio, 
                            hora_seg_inicio, hora_termino, hora_seg_termino, km_inicio, km_seg_inicio, km_termino,
                            km_seg_termino, bo_pc, plantao, equipe, motorista, encarregado, auxiliar,
                            viatura, motorista_apoio, encarregado_apoio, auxiliar_apoio, viatura_apoio,
                            instituicao_apoio, instituicao_motorista, 
                            instituicao_encarregado, endereco_ocorrencia) 
                            VALUES('" + boletimOcorrencia.Data_Ocorrencia + "', '" + boletimOcorrencia.TipoOcorrencia + "', '"
                                    + boletimOcorrencia.Situacao + "', '" + boletimOcorrencia.Hora_Inicio + "', '"
                                    + boletimOcorrencia.Seg_Hora_Inicio + "', '" + boletimOcorrencia.Hora_Termino + "', '"
                                    + boletimOcorrencia.Seg_Hora_Termino + "', '" + boletimOcorrencia.Km_Inicio + "', '"
                                    + boletimOcorrencia.Seg_Km_Inicio + "', '" + boletimOcorrencia.Km_Termino + "', '"
                                    + boletimOcorrencia.Seg_Km_Termino + "', '" + boletimOcorrencia.Bo_Pc + "', '"
                                    + boletimOcorrencia.Plantao + "', '" + boletimOcorrencia.Equipe + "', '"
                                    + boletimOcorrencia.Motorista + "', '" + boletimOcorrencia.Encarregado + "', '"
                                    + boletimOcorrencia.Auxiliar + "', '" + boletimOcorrencia.Viatura + "', '"
                                    + boletimOcorrencia.MotoristaApoio + "', '" + boletimOcorrencia.EncarregadoApoio + "', '"
                                    + boletimOcorrencia.AuxiliarApoio + "', '"
                                    + boletimOcorrencia.Viatura_Apoio + "', '" + boletimOcorrencia.InstituicaoApoio + "', '"
                                    + boletimOcorrencia.MotoristaInstituicao + "', '" + boletimOcorrencia.EncarregadoInstituicao + "', '" + boletimOcorrencia.Endereco + "')";
                }

                else
                {
                    comando = @"INSERT INTO boletim_ocorrencia(data_inicio, nat_ocorrencia, situacao, hora_inicio, 
                            hora_seg_inicio, hora_termino, hora_seg_termino, km_inicio, km_seg_inicio, km_termino,
                            km_seg_termino, bo_pc, plantao, equipe, motorista, encarregado, auxiliar, 
                            viatura, endereco_ocorrencia)
                            VALUES('" + boletimOcorrencia.Data_Ocorrencia + "', '" + boletimOcorrencia.TipoOcorrencia + "', '"
                                + boletimOcorrencia.Situacao + "', '" + boletimOcorrencia.Hora_Inicio + "', '"
                                + boletimOcorrencia.Seg_Hora_Inicio + "', '" + boletimOcorrencia.Hora_Termino + "', '"
                                + boletimOcorrencia.Seg_Hora_Termino + "', '" + boletimOcorrencia.Km_Inicio + "', '"
                                + boletimOcorrencia.Seg_Km_Inicio + "', '" + boletimOcorrencia.Km_Termino + "', '"
                                + boletimOcorrencia.Seg_Km_Termino + "', '" + boletimOcorrencia.Bo_Pc + "', '"
                                + boletimOcorrencia.Plantao + "', '" + boletimOcorrencia.Equipe + "', '"
                                + boletimOcorrencia.Motorista + "', '" + boletimOcorrencia.Encarregado + "', '"
                                + boletimOcorrencia.Auxiliar + "', '"
                                + boletimOcorrencia.Viatura + "', '" + boletimOcorrencia.Endereco + "')";
                }

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

        public DataTable RetornarIDBoletim()
        {
            dt = new DataTable();
            db = new DataBaseAcess();
            try
            {
                string comando = "select * from boletim_ocorrencia order by id desc limit " + 1;
                db.Conectar();
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
