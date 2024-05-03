using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class CategoriaProduto
    {

        [Display(Name = "ID:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int CategoriaProdutoID { get; set; }


        [Display(Name = "Categoria:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? CategoriaNome { get; set; }


    }
}
