//deber hecho por Alejandro Ortiz 
namespace Cliente.Models
{
    using Microsoft.EntityFrameworkCore;
    public class clientebd_context : DbContext
    {
        public clientebd_context (DbContextOptions<clientebd_context> options) : base(options)
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }
    }
}
