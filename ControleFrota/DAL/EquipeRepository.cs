using DAL.Interfaces;
using System;

namespace DAL
{
    public class EquipeRepository : IEquipeRepository
    {
        public void CadastrarEquipe(Equipe equipe)
        {
            DataBaseAcess db;
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                string comando = @"INSERT INTO plantao_producao(plantao, equipe, viatura, km_inicio, km_termino, abastecido, litros,
                                 data_plantao, observacao, motorista, encarregado)
                                 VALUES ('" + equipe.Plantao +"', '" +equipe.Setor + "', '" + equipe.Viatura + "', '" + equipe.Km_Inicio + "', '" + equipe.Km_Fim + "', '"
                                 + equipe.Abastecido + "', '" + equipe.Litros.ToString("F2", System.Globalization.CultureInfo.InvariantCulture) + "', '" 
                                 + equipe.Data_Ocupacao + "', '" + equipe.Observacao + "', '" + equipe.Motorista + "', '" + equipe.Encarregado + "')";
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

        public void CadastrarAbordado(Abordado abordado)
        {
            DataBaseAcess db;
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                string comando = @"INSERT INTO abordados(nome, rg, endereco, passagem, artigo, equipe)
                                 VALUES ('" + abordado.Nome_Abordado + "', '" + abordado.Rg + "', '" + abordado.Endereco + "', '" + abordado.Passagem + "', '"
                                 + abordado.Artigo + "', '" +abordado.Equipe  + "')";
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
