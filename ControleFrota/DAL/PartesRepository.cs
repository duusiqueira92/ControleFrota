using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PartesRepository : IParteRepository
    {
        DataBaseAcess db;
        DataTable dt;

        public DataTable RetornarID(int limite)
        {
            dt = new DataTable();
            db = new DataBaseAcess();
            try
            {
                string comando = "select * from parte_boletim order by id desc limit " + limite;
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

        public void CadastrarParte(List<Partes> partes)
        {
            db = new DataBaseAcess();
            try
            {
                for (int i = 0; i < partes.Count; i++)
                {
                    db.Conectar();
                    string comando = @"INSERT INTO parte_boletim(nome, nome_pai, nome_mae, telefone, celular, endereco, cidade, bairro,
                                numero, estado, cep, complemento, naturalidade, nacionalidade, local_trabalho, num_trabalho, bairro_trabalho,
                                cidade_trabalho, profissao, tel_comercial, data_nascimento, cpf, rg, expedicao_rg, org_emissor, uf, categoria,
                                reg_cnh, num_cnh, val_cnh, versao, conduzido, tipo_parte, boletim_ocorrencia) 
                    VALUES ('" + partes[i].Nome + "', '" + partes[i].Nome_Pai + "', '" + partes[i].Nome_Mae + "', '"
                   + partes[i].Telefone + "', '" + partes[i].Celular + "', '" + partes[i].Rua + "', '" + partes[i].Cidade + "', '"
                   + partes[i].Bairro + "', '" + partes[i].Numero + "', '" + partes[i].Estado + "', '" + partes[i].Cep + "', '"
                   + partes[i].Complemento + "', '" + partes[i].Naturalidade + "', '" + partes[i].Nacionalidade + "', '" + partes[i].Local_Trabalho + "', '"
                   + partes[i].Numero_Trabalho + "', '" + partes[i].Bairro_Trabalho + "', '" + partes[i].Cidade_Trabalho + "', '" + partes[i].Profissao + "', '"
                   + partes[i].Tel_Comercial + "', '" + partes[i].DataNascimento + "', '" + partes[i].Cpf + "', '" + partes[i].Rg + "', '"
                   + partes[i].Emissao_Rg + "', '" + partes[i].OrgaoEmissor + "', '" + partes[i].Rg_Uf + "', '" + partes[i].Categoria + "', '"
                   + partes[i].RegCnh + "', '" + partes[i].Cnh + "', '" + partes[i].Validade_cnh + "', '" + partes[i].VersaoParte + "', '"
                   + partes[i].Conduzido + "', '" + partes[i].TipoParte + "', '" + partes[i].Boletim_Ocorrencia + "')";

                    db.ExecutarComandoSql(comando);
                }
               
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

        public DataTable RetornarParteCpf(string cpf)
        {
            db = new DataBaseAcess();
            dt = new DataTable();
            try
            {
                db.Conectar();
                string comando = "SELECT * FROM parte_boletim WHERE cpf = " + cpf + " ORDER BY id DESC";
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
