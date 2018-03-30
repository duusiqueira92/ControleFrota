using DAL.Interfaces;
using System;
using System.Data;
namespace DAL
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        DataBaseAcess db;
        DataTable dt;
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                string comando = @"INSERT INTO agentes(nome, endereco, bairro, cidade, numero, cep, estado, complemento, telefone, celular,
                                num_cnh, reg_cnh, categoria, validade, tit_eleitor, cidade_tit, zona, estado_titulo, 
                                sessao, emissao_titulo, pis, rg, emissor, estado_rg, emissao_rg, cpf, data_nascimento,
                                estado_civil, filhos, escolaridade, ano_conclusao, instituicao, formacao,
                                conclusao_formacao, tipo_sanguineo, restricao, obs_restricao, pai, mae, naturalidade,
                                naturalidade_estado, reg_funcional, data_admissao, qra, graduacao)
                                VALUES ('" + funcionario.Nome + "', '" + funcionario.Rua + "', '" + funcionario.Bairro + "', '"
                                + funcionario.Cidade + "', '" + funcionario.Numero + "', '" + funcionario.Cep + "', '"
                                + funcionario.Estado + "', '" + funcionario.Complemento + "', '" + funcionario.Telefone + "', '"
                                + funcionario.Celular + "', '" + funcionario.Cnh + "', '" + funcionario.RegCnh + "', '"
                                + funcionario.Categoria + "', '" + funcionario.Validade_cnh + "', '" + funcionario.Titulo_Eleitor + "', '"
                                + funcionario.Cidade_Titulo + "', '" + funcionario.Zona + "', '" + funcionario.Estado_Titulo + "', '"
                                + funcionario.Sessao + "', '" + funcionario.Emissao_Titulo + "', '" + funcionario.Pis + "', '"
                                + funcionario.Rg + "', '" + funcionario.OrgaoEmissor + "', '" + funcionario.Rg_Uf + "', '"
                                + funcionario.Emissao_Rg + "', '" + funcionario.Cpf + "', '" + funcionario.DataNascimento + "', '"
                                + funcionario.Estado_Civil + "', '" + funcionario.Filhos + "', '" + funcionario.Escolaridade + "', '"
                                + funcionario.Conclusao_Escolar + "', '" + funcionario.Instituicao + "', '" + funcionario.Formacao + "', '"
                                + funcionario.Conclusao_Superior + "', '" + funcionario.Tipo_Sanguineo + "', '" + funcionario.Restricao + "', '"
                                + funcionario.Observacao + "', '" + funcionario.Nome_Pai + "', '" + funcionario.Nome_Mae + "', '"
                                + funcionario.Naturalidade + "', '" + funcionario.Uf_Naturalidade + "', '" + funcionario.Rf + "', '"
                                + funcionario.DataContratacao + "', '" + funcionario.Qra + "', '" + funcionario.Graduacao + "')";
                db.ExecutarComandoSql(comando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = @"UPDATE agentes SET nome = '" + funcionario.Nome + "', endereco = '" 
                                 + funcionario.Rua + "', bairro = '" + funcionario.Bairro + "', cidade = '" 
                                 + funcionario.Cidade + "', numero = '" + funcionario.Numero + "', cep = '"
                                 + funcionario.Cep + "', estado = '" + funcionario.Estado + "', complemento = '"
                                 + funcionario.Complemento + "', telefone = '" + funcionario.Telefone + "', celular = '"
                                 + funcionario.Celular + "', num_cnh = '" + funcionario.Cnh + "', reg_cnh = '"
                                 + funcionario.RegCnh + "', categoria = '" + funcionario.Categoria + "', validade = '"
                                 + funcionario.Validade_cnh + "', tit_eleitor = '" + funcionario.Titulo_Eleitor + "', cidade_tit = '"
                                 + funcionario.Cidade_Titulo + "', zona = '" + funcionario.Zona + "', estado_titulo = '"
                                 + funcionario.Estado_Titulo + "', sessao = '" + funcionario.Sessao + "', emissao_titulo = '"
                                 + funcionario.Emissao_Titulo + "', pis = '" + funcionario.Pis + "', rg = '"
                                 + funcionario.Rg + "', emissor = '" + funcionario.OrgaoEmissor + "', estado_rg = '"
                                 + funcionario.Rg_Uf + "', emissao_rg = '" + funcionario.Emissao_Rg + "', cpf = '"
                                 + funcionario.Cpf + "', data_nascimento = '" + funcionario.DataNascimento + "', estado_civil = '"
                                 + funcionario.Estado_Civil + "', filhos = '" + funcionario.Filhos + "', escolaridade = '"
                                 + funcionario.Escolaridade + "', ano_conclusao = '" + funcionario.Conclusao_Escolar + "', instituicao = '"
                                 + funcionario.Instituicao + "', formacao = '" + funcionario.Formacao + "', conclusao_formacao = '"
                                 + funcionario.Conclusao_Superior + "', tipo_sanguineo = '" + funcionario.Tipo_Sanguineo + "', restricao = '"
                                 + funcionario.Restricao + "', obs_restricao = '" + funcionario.Observacao + "', pai = '"
                                 + funcionario.Nome_Pai + "', mae = '" + funcionario.Nome_Mae + "', naturalidade = '"
                                 + funcionario.Naturalidade + "', naturalidade_estado = '" + funcionario.Uf_Naturalidade + "', reg_funcional = '"
                                 + funcionario.Rf + "', data_admissao = '" + funcionario.DataContratacao + "', qra = '"
                                 + funcionario.Qra + "', graduacao = '" + funcionario.Graduacao + "' WHERE id = '" + funcionario.Id + "'";
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

        public void AlterarPlantao(int plantao, int equipe, int id)
        {
            db = new DataBaseAcess();
            try
            {
                db.Conectar();
                string comando = "UPDATE agentes SET plantao = '" + plantao + "', equipe = '" + equipe + "' where id = " + id;
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

        public DataTable CarregarFuncionario()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM agentes";
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

        public DataTable CarregarEquipamentos(int agente)
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT ag.id AS 'Id', ag.qra AS 'QRA', ag.nome AS 'Nome', c.data_fab AS 'Col. Fabr.', 
                                a.modelo AS 'Modelo', a.data_emissao AS 'Reg. Emissão' 
                                FROM agentes ag
                                LEFT JOIN colete c on c.agente = ag.id
                                LEFT JOIN armas a on a.agente_resp = ag.id WHERE ag.id = " + agente;
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
