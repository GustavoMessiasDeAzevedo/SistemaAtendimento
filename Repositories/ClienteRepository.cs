using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class ClienteRepository
    {
        public List<Clientes> Listar(string termo = "")
        {
            var clientes = new List<Clientes>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Clientes";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = $"SELECT * FROM Clientes where nome LIKE @termo OR email LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", "%"+termo+"%");
                    }
                    
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            clientes.Add(new Clientes()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                nome = linhas["nome"].ToString(),
                                email = linhas["email"].ToString(),
                                cpf_cnpj = linhas["cpf_cnpj"].ToString(),
                                tipo_pessoa = linhas["tipo_pessoa"].ToString(),
                                telefone = linhas["telefone"].ToString(),
                                celular = linhas["celular"].ToString(),
                                cep = linhas["cep"].ToString(),
                                endereco = linhas["endereco"].ToString(),
                                numero = linhas["numero"].ToString(),
                                complemento = linhas["complemento"].ToString(),
                                bairro = linhas["bairro"].ToString(),
                                cidade = linhas["cidade"].ToString(),
                                estado = linhas["estado"].ToString(),
                                ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }
            return clientes;
        }

        public void Inserir(Clientes cliente) 
        { 
            using(var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO clientes (nome, email, cpf_cnpj, tipo_pessoa, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado, ativo)
                                 VALUES (@nome, @email, @cpf_cnpj, @tipo_pessoa, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @ativo)";


                using (var comando = new SqlCommand(sql, conexao)) 
                {
                    comando.Parameters.AddWithValue("@nome", cliente.nome);
                    comando.Parameters.AddWithValue("@email", cliente.email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.tipo_pessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.celular);
                    comando.Parameters.AddWithValue("@cep", cliente.cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }

        }

        public void Atualizar(Clientes cliente)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE clientes SET nome=@nome, email=@email, cpf_cnpj=@cpf_cnpj, tipo_pessoa=@tipo_pessoa, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado, ativo=@ativo WHERE id=@Id";


                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", cliente.Id);
                    comando.Parameters.AddWithValue("@nome", cliente.nome);
                    comando.Parameters.AddWithValue("@email", cliente.email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.cpf_cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.tipo_pessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.celular);
                    comando.Parameters.AddWithValue("@cep", cliente.cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(Clientes cliente)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM clientes WHERE id=@Id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", cliente.Id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
