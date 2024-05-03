using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class NivelAcesso
    {

        [Display(Name = "ID:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int NivelAcessoID { get; set; }


        [Display(Name = "Tipo de Acesso:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? TipoAcesso { get; set; }


    }
}
