namespace SistemaControleVendasProjeto.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public int NivelAcessoID { get; set; }
    }
}
