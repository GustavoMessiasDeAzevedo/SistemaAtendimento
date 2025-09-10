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
    internal class UsuarioRepository
    {
        public List<Usuarios> Listar() 
        {
            var usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao()) 
            { 
                string sql = "SELECT * FROM Usuarios";

                using (var comando = new SqlCommand(sql, conexao)) 
                { 
                    conexao.Open();

                    using(var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            usuarios.Add(new Usuarios()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Senha = linhas["senha"].ToString(),
                                Perfil = linhas["perfil"].ToString()
                            });
                        }
                    }
                }
            }
                return usuarios;
        }

        public void Inserir(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO usuarios (nome, email, senha, perfil) 
                               VALUES (@nome, @email, @senha, @perfil)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@perfil", usuario.Perfil);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
