using System;
using Microsoft.EntityFrameworkCore;
using entity_framework.Models;

namespace entity_framework.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
