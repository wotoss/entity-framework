using System;
using Microsoft.EntityFrameworkCore;
using entity_framework.Models;

namespace entity_framework.Servicos.Database
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }
        
        /*DbSet sempre no plural(Enderecos) pegando um classe no singular (Endereco)*/
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoProduto> PedidosProdutos { get; set; }
    }
}
