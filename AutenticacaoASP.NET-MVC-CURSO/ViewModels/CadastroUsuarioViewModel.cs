using System.ComponentModel.DataAnnotations;
namespace AutenticacaoASP.NET_MVC_CURSO.ViewModels
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [MaxLength(ErrorMessage = "O nome deve ter até 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu login")]
        [MaxLength(ErrorMessage = "O login deve ter até 30 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ao menos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [MinLength(6, ErrorMessage = "A senha deve ao menos 6 caracteres")]
        [Compare(nameof(Senha), ErrorMessage = "As senhas digitadas não estão iguais")]
        public string ConfirmacaoSenha { get; set; }

    }
}