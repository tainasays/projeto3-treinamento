using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class FormaPagamento
    {

        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID da Forma de Pagamento:")]
        public int FormaPagamentoID { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "Forma de Pagamento:")]
        public string? NomeFormaPagamento { get; set; }

        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID do Pedido:")]
        public int PedidoID { get; set; }


    }
}
