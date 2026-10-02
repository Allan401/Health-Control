namespace Health_Control.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Funcao { get; set; } = "";
        public string SenhaHash { get; set; } = "";
    }
}
