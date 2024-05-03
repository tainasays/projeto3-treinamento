using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Funcionario
    {
        [Display(Name = "ID do Funcionário:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int ClienteID { get; set; }


        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Nome { get; set; }

        [Display(Name = "Cargo:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Cargo { get; set; }

        [Display(Name = "Nível de Acesso:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int NivelAcessoID { get; set; }


        [Display(Name = "Data de Nascimento:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? Data { get; set; }


        // ------- Endereço ---------

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Endereco { get; set; }

        [Display(Name = "Bairro:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Bairro { get; set; }

        [Display(Name = "Cidade:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Cidade { get; set; }

        [Display(Name = "Estado:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Estado { get; set; }

        [Display(Name = "Complemento:")]
        public string? Complemento { get; set; }

        // ---- Fim de endereço ------



        [Display(Name = "Data de Cadastro:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? DataCadastro{ get; set; }


        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "E-mail deve ser preenchido!")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Insira um e-mail válido")]
        public string? Email { get; set; }



        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha deve ser preenchida!")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Senha deve ter entre 4 e 15 caracteres")]
        public string? Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Compare("Senha", ErrorMessage = "Senhas informadas não conferem")]
        public string? ConfirmarSenha { get; set; }
    }
}
