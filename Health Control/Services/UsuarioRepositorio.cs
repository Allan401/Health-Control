    using Health_Control.Models;
using Microsoft.AspNetCore.Identity;
using MySqlConnector;
using System.Data;

    namespace Health_Control.Services

    {
        public class UsuarioRepositorio
        {
            private const string StringConexao = "Server=localhost;Port=3306;Database=health_inovation;User ID=Allan;Password=Allan#AZ401;";

            public Usuario? BuscarPorEmail(string email)
            {
                using var conexao = new MySqlConnection(StringConexao);
                conexao.Open();

                using var comando = new MySqlCommand("SELECT id, nome, email, funcao, senha_hash FROM usuarios WHERE email", conexao);
                comando.Parameters.AddWithValue("@email", email);

                using var leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    return new Usuario
                    {
                        Id = leitor.GetGuid("id"),
                        Nome = leitor.GetString("nome"),
                        Email = leitor.GetString("email"),
                        Funcao = leitor.GetString("funcao"),
                        SenhaHash = leitor.IsDBNull("senha_hash") ? "" : leitor.GetString("senha_hash")
                    };
                }

                return null;
            }

            public bool CriarConta(string nome, string email, string funcao, string senha)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(senha);

            using var conexao = new MySqlConnection(StringConexao);
            conexao.Open();

            using var comando = new MySqlCommand("INSERT INTO usuarios (nome, email, funcao, senha_hash) VALUES (@nome, @email, @funcao, @hash)", conexao);

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@funcao", funcao);
            comando.Parameters.AddWithValue("hash", hash);

            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                return false;
            }
        }
            public void DefinirSenha(string email, string senha)
            {
                string hash = BCrypt.Net.BCrypt.HashPassword(senha);

               using var conexao = new MySqlConnection(StringConexao);
               conexao.Open();

                using var comando = new MySqlCommand("UPDATE usuarios SET senha_hash = @hash WHERE email = @email", conexao);
                comando.Parameters.AddWithValue("@hash", hash);
                comando.Parameters.AddWithValue("@email", email);

                comando.ExecuteNonQuery();
            }
        }
    }
