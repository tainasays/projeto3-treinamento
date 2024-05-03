using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleVendas.Models
{
    public class Pedido
    {
        [Display(Name = "ID do Pedido:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]

        public int PedidoID { get; set; }


        [Display(Name = "ID do Cliente:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ClienteID { get; set; }


        [Display(Name = "ID do Produto:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ProdutoID { get; set; }

        [Display(Name = "ID do Colaborador:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int FuncionarioID { get; set; }


        [Display(Name = "Quantidade:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int Quantidade { get; set; }


        [Display(Name = "Valor:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Valor { get; set; }


        [Display(Name = "Forma de Pagamento:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int FormaPagamentoID { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? Data { get; set; }
    }
}
