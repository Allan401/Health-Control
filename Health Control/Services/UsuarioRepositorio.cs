using Health_Control.Models;
using MySqlConnector;
<<<<<<< Updated upstream
=======
using System.Data;
using System.Globalization;

namespace Health_Control.Services
>>>>>>> Stashed changes

namespace Health_Control.Services
{
    public class UsuarioRepositorio
    {
        private const string StringConexao =
            "Server=localhost;Port=3306;Database=health_inovation;User ID=Allan;Password=Allan#AZ401;";

        public Usuario? BuscarPorEmail(string email)
        {
            using var conexao = new MySqlConnection(StringConexao);
            conexao.Open();

            using var comando = new MySqlCommand(
                "SELECT id, nome, email, funcao, senha_hash FROM usuarios WHERE email = @email",
                conexao);
            comando.Parameters.AddWithValue("@email", email);

            using var leitor = comando.ExecuteReader();

            if (leitor.Read())
            {
<<<<<<< Updated upstream
                return new Usuario
=======
                using var conexao = new MySqlConnection(StringConexao);
                conexao.Open();

                using var comando = new MySqlCommand("SELECT id, nome, email, funcao, senha_hash FROM usuarios WHERE email = @email", conexao);
                comando.Parameters.AddWithValue("@email", email);

                using var leitor = comando.ExecuteReader();

                if (leitor.Read())
>>>>>>> Stashed changes
                {
                    Id = leitor.GetGuid("id"),
                    Nome = leitor.GetString("nome"),
                    Email = leitor.GetString("email"),
                    Funcao = leitor.GetString("funcao"),
                    SenhaHash = leitor.IsDBNull("senha_hash") ? "" : leitor.GetString("senha_hash")
                };
            }

<<<<<<< Updated upstream
            return null;
        }

        private string GerarHash(string senha)
=======
        private String GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public bool CriarConta(string nome, string email, string funcao, string senha)
>>>>>>> Stashed changes
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public bool CriarConta(string nome, string email, string funcao, string senha)
        {
            string hash = GerarHash(senha);

            using var conexao = new MySqlConnection(StringConexao);
            conexao.Open();

            using var comando = new MySqlCommand(
                "INSERT INTO usuarios (nome, email, funcao, senha_hash) VALUES (@nome, @email, @funcao, @hash)",
                conexao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@funcao", funcao);
            comando.Parameters.AddWithValue("@hash", hash);

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
<<<<<<< Updated upstream
=======

            public void DefinirSenha(string email, string senha)
            {

            string hash = GerarHash(senha);
>>>>>>> Stashed changes

        public void DefinirSenha(string email, string senha)
        {
            string hash = GerarHash(senha);

            using var conexao = new MySqlConnection(StringConexao);
            conexao.Open();

            using var comando = new MySqlCommand(
                "UPDATE usuarios SET senha_hash = @hash WHERE email = @email",
                conexao);
            comando.Parameters.AddWithValue("@hash", hash);
            comando.Parameters.AddWithValue("@email", email);

            comando.ExecuteNonQuery();
        }
    }
}