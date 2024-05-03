using System.ComponentModel.DataAnnotations;

namespace SistemaControleVendasProjeto.Models
{
    public class Funcionario
    {
        [Display(Name = "ID do Funcionário:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int FuncionarioID { get; set; }


        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Nome { get; set; }


        [Display(Name = "Cargo:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Cargo { get; set; }

        [Display(Name = "Setor:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Setor { get; set; }


        [Display(Name = "Salário:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        public double? Salario { get; set; }



        [Display(Name = "Nível de Acesso")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public int NivelAcessoID { get; set; }



        [Display(Name = "Data de Nascimento:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Uma data válida deve ser informada")]
        public DateTime? DataNascimento { get; set; }



        [Display(Name = "Telefone:")]
        [StringLength(14, MinimumLength = 8, ErrorMessage = "Insira um número válido")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        public string? Telefone { get; set; }



        // Endereço - INICIO 

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

        // Endereço - FIM



        [Display(Name = "Data de Cadastro:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Insira uma data válida")]
        public DateTime? DataCadastro { get; set; }


        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "E-mail deve ser preenchido!")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Insira um e-mail válido")]
        public string? Email { get; set; }


        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "A senha deve ter entre 4 e 10 caracteres")]
        public string? Senha { get; set; }

        [Display(Name = "Confirmar Senha:")]
        [Compare("Senha", ErrorMessage = "Senhas informadas não conferem")]
        public string? ConfirmarSenha { get; set; }


    }
}
