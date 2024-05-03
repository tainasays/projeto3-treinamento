using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class ProdutoPedido
    {

        public int ProdutoPedidoID { get; set; }

        [Display(Name = "ID do Pedido:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int PedidoID { get; set; }

        [Display(Name = "ID do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ProdutoID { get; set; }

        [Display(Name = "Quantidade:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int Quantidade { get; set; }

        [Display(Name = "Valor:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Valor { get; set; }


        [Display(Name = "Data de Cadastro:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Insira uma data válida")]
        public DateTime? DataCadastro { get; set; }

    }
}
