using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Produto
    {
        [Display(Name = "ID do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ProdutoID { get; set; }


        [Display(Name = "Nome do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Nome { get; set; }


        [Display(Name = "Descrição do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Descricao { get; set; }


        [Display(Name = "Categoria:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? CategoriaProduto { get; set; }

        [Display(Name = "Quantidade em Estoque:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int QuantidadeEstoque {get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "Preço:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Preco { get; set; }

        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? DataCadastro { get; set; }


    }
}
