using DAL.Interfaces;
using System;

namespace DAL
{
    public class ArmamentoRepository : IArmamentoRepository
    {
        DataBaseAcess db;

        public void CadastrarArmamento(Armamento armamento)
        {
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = @"INSERT INTO armas(especie, marca, modelo, numero_arma, calibre, cap_tiros, funcionamento,
                                 acabamento, qtd_canos, cpm_cano, tp_alma, qtd_raias, snt_raia, pais_fab, num_nf, data_nf, 
                                 cidade_emissao, data_emissao, num_registro, data_validade, id_sinarm, agente_resp)
                                 VALUES('" + armamento.Especie + "', '" + armamento.Marca + "', '" + armamento.Modelo + "', '"
                                 + armamento.Num_Arma + "', '" + armamento.Calibre + "', '" + armamento.Cap_Tiros + "', '"
                                 + armamento.Funcionamento + "', '" + armamento.Acabamento + "', '" + armamento.Qtd_Canos + "', '"
                                 + armamento.Cpm_Cano + "', '" + armamento.Tp_Alma + "', '" + armamento.Qtd_Raias + "', '"
                                 + armamento.Snt_Raia + "', '" + armamento.Pais_Fab + "', '" + armamento.Num_Nf + "', '"
                                 + armamento.Data_Nf + "', '" + armamento.Cidade_Emissao + "', '" + armamento.Data_Emissao + "', '"
                                 + armamento.Num_Registro + "', '" + armamento.Data_Validade + "', '" + armamento.Id_Sinarm + "', '"
                                 + armamento.Agente_Resp + "')";
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
