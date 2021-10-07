using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoASP.NET_MVC_CURSO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Int16 Id { get; set; }

        [Required]
        [MaxLength(100)]
        public String Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public String Login { get; set; }

        [Required]
        [MaxLength(100)]
        public String Senha { get; set; }
    }
}