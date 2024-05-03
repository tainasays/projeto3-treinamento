using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class FormaPagamento
    {
        [Display(Name = "ID:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int FormaPagamentoID { get; set; }


        [Display(Name = "Forma de Pagamento:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? NomeFormaPagamento { get; set; }

    }
}
