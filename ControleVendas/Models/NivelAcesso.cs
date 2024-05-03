using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class NivelAcesso
    {
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "Nível de Acesso:")]
        public int NivelAcessoID { get; set; }

        [Display(Name = "Tipo de Acesso:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? TipoAcesso { get; set; }

    }
}
