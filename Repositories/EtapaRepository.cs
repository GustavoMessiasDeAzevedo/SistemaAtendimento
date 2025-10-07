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
        public List<Etapas> Listar(string termo = "")
        {
            var etapas = new List<Etapas>();

            using (var conexao = ConexaoDB.GetConexao()) 
            {
                string sql = "SELECT * FROM Etapas";
                if (!string.IsNullOrEmpty(termo))
                {
                    sql = $"SELECT * FROM Etapas WHERE nome LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao)) 
                {
                    
                    if(!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    }
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

        public void Inserir(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO etapas (nome, ordem, ativo) 
                               VALUES (@nome, @ordem, @ativo)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapa.nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE etapas SET nome=@nome, ordem=@ordem, ativo=@ativo WHERE id=@id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapa.Id);
                    comando.Parameters.AddWithValue("@nome", etapa.nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM etapas WHERE id=@id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", etapa.Id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }



    }
}
