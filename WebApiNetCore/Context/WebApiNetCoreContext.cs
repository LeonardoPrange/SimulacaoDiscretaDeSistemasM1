using Microsoft.EntityFrameworkCore;
using WebApiNetCore.Models;

namespace WebApiNetCore.Context
{
    public class WebApiNetCoreContext: DbContext
    {
        public WebApiNetCoreContext(DbContextOptions<WebApiNetCoreContext> options)
            :base(options)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
    }
}
