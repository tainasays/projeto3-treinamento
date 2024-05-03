using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Venda
    {
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID da Venda:")]
        public int VendaID { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "Valor da Venda:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Valor { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID do Colaborador:")]
        public int FuncionarioID { get; set; }


        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [Display(Name = "ID do Cliente:")]
        public int ClienteID { get; set; }


        [Display(Name = "Data da Venda:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? Data { get; set; }



    }
}
