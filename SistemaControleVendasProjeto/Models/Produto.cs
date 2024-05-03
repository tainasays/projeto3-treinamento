using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class Produto
    {
        [Display(Name = "ID do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ProdutoID { get; set; }


        [Display(Name = "Item:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? NomeProduto { get; set; }


        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Descricao { get; set; }


        [Display(Name = "Categoria:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int CategoriaProdutoID { get; set; }


        [Display(Name = "Quantidade em Estoque:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int QuantidadeEstoque { get; set; }


        [Display(Name = "Preço:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Preco { get; set; }

        [Display(Name = "Data de Cadastro:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Insira uma data válida")]
        public DateTime? DataCadastro { get; set; }



    }
}
