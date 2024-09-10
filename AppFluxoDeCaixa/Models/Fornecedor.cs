using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Fornecedor
    {
        public Guid FornecedorID { get; set; }



        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do campo é de 100 Caracteres!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter, no mínimo, 3 Caracteres")]
        public string Nome { get; set; }


        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 18 Dígitos Numéricos!")]
        [MinLength(11, ErrorMessage = "O Campo CNPJ deve ter 18 Dígitos Numéricos")]
        public string CNPJ { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail é Obrigatório!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O Campo Telefone é Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 11 Dígitos Numéricos!")]
        [MinLength(11, ErrorMessage = "O Campo Telefone deve ter 10 Dígitos Numéricos")]
        public string Telefone { get; set; }


        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}