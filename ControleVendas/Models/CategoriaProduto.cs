using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class CategoriaProduto
    {
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID da Categoria:")]
        public int CategoriaProdutoID { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "Categoria:")]
        public string? NomeCategoria { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID do Produto:")]
        public int ProdutoID { get; set; }
    }
}
