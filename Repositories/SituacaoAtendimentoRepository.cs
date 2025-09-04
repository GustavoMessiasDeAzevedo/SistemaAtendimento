using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class SituacaoAtendimentoRepository
    {

        public List<SituacaoAtendimento>Listar() 
        { 
        
            var SituacaoAtendimento = new List<SituacaoAtendimento>();

            using(var conexao = ConexaoDB.GetConexao()) 
            { 
                string sql = "SELECT * FROM situacao_atendimentos";

                using (var comando = new SqlCommand(sql, conexao)) 
                { 
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader()) 
                    {
                        while (linhas.Read()) 
                        {
                            SituacaoAtendimento.Add(new SituacaoAtendimento()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                nome = linhas["nome"].ToString(),
                                cor = linhas["cor"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    
                    }
                }
                return SituacaoAtendimento;
            }
        }
    }
}
