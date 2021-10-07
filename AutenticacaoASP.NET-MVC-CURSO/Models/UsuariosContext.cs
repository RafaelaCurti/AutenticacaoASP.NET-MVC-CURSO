using System.Data.Entity;

namespace AutenticacaoASP.NET_MVC_CURSO.Models
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext():base("Usuarios")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}