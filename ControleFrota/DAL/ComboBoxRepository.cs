using DAL.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL
{
    public class ComboBoxRepository : IComboBoxRepository
    {
        DataBaseAcess db;
        DataTable dt;

        public DataTable CarregarCategoria()
        {
            dt = new DataTable();
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                dt = db.RetDataTable("SELECT id, categoria FROM categoria_cnh");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar Categoria_cnh" + ex);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarCombustivel()
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = "SELECT id, nome FROM combustivel";
                dt = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar Combustivel! " + ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarEquipe()
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = "SELECT * FROM equipe";
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

        public DataTable CarregarEstados()
        {
            dt = new DataTable();
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                dt = db.RetDataTable("SELECT id, sigla FROM estado");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar o Estado! " + ex.Message);
            }
            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarOrgaoEmissor()
        {
            dt = new DataTable();
            try
            {
                db = new DataBaseAcess();
                db.Conectar();
                dt = db.RetDataTable("SELECT id, sigla FROM orgao_emissor");
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao carregar Orgão Emissor! " + ex.Message);
            }

            finally
            {
                db = null;
            }
            return dt;
        }

        public DataTable CarregarPlantao()
        {
            try
            {
                db = new DataBaseAcess();
                dt = new DataTable();
                db.Conectar();
                string comando = "SELECT * FROM plantao";
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

        public DataTable CarregarViatura()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
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

        public DataTable CarregarNatOcorrencia()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT * FROM nat_ocorrencia";
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

        public DataTable CarregarMotorista(int plantao, int equipe)
        {

            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT id, nome, plantao, equipe, posicao, qra, reg_funcional FROM agentes
                                 WHERE plantao = '" + plantao + "' AND equipe = '" + equipe + "'  AND posicao = " + 1;
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

        public DataTable CarregarEncarregado(int plantao, int equipe)
        {

            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT id, nome, plantao, equipe, posicao, qra, reg_funcional FROM agentes
                                 WHERE plantao = '" + plantao + "' AND equipe = '" + equipe + "'  AND posicao = " + 2;
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

        public DataTable CarregarAuxiliar(int plantao, int equipe)
        {

            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT id, nome, plantao, equipe, posicao, qra, reg_funcional FROM agentes
                                 WHERE plantao = '" + plantao + "' AND equipe = '" + equipe + "'  AND posicao = " + 3;
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

        public DataTable CarregarViaturaDt()
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = @"SELECT pp.id, pp.data_plantao, v.prefixo as prefixo, pp.km_inicio, pp.km_termino,  p.nome_plantao, e.nome_equipe, mot.qra as Motorista, enc.qra as Encarregado
                                FROM plantao_producao pp
                                inner join plantao p on pp.plantao = p.id
                                inner join equipe e on pp.equipe = e.id
                                inner join veiculos v on pp.viatura = v.id_veiculo
                                inner join agentes mot on pp.motorista = mot.id
                                inner join agentes enc on pp.encarregado = enc.id";
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
