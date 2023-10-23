using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Proyecto_11_11.Models.Entities;

namespace Proyecto_11_11.Models
{
    public class Context : DbContext
    {
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NB601\\SQLEXPRESS01; Initial Catalog=DepositoDB; Integrated Security=true; Encrypt=true; Trustservercertificate=true");
        }
    }
}
