using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }


        [Display(Name = "ID do Cliente:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ClienteID { get; set; }


        [Display(Name = "ID do Colaborador:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int FuncionarioID { get; set; }
    }
}