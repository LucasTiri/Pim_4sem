//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace PIM_MVC.Models
{    
   

    public partial class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usu?rio", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Required(ErrorMessage = "Informe a senha do usu?rio", AllowEmptyStrings = false)]
        public string Senha { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Informe um email v?lido.")]
        [Required(ErrorMessage = "Informe o email do usu?rio", AllowEmptyStrings = false)]

        public string Email { get; set; }
    }
}
