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
    public class EtapaRepository
    {
        public List<Etapas> Listar()
        {
            var etapas = new List<Etapas>();

            using (var conexao = ConexaoDB.GetConexao()) 
            {
                string sql = "SELECT * FROM Etapas";

                using (var comando = new SqlCommand(sql, conexao)) 
                {
                    conexao.Open();

                    using (var Linhas = comando.ExecuteReader()) 
                    {
                        while (Linhas.Read()) 
                        {

                            etapas.Add(new Etapas() 
                            { 
                                Id = Convert.ToInt32(Linhas["id"]),
                                nome = Linhas["nome"].ToString(),
                                ordem = Convert.ToInt32(Linhas["ordem"]),
                                Ativo = Convert.ToBoolean(Linhas["ativo"])

                            });
                        }
                    }
                }
            }
            return etapas;
        }
    }
}
